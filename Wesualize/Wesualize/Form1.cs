using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;
using System.Linq;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;

namespace Wesualize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] lines = File.ReadAllLines(openFileDialog1.FileName);
                    dataEntries.Clear();

                    for (int i = 1; i < lines.Length; i++) // Start from 1 to skip header
                    {
                        string[] values = lines[i].Split(',');
                        dataEntries.Add(new DataEntry
                        {
                            Company = values[0].Trim(),
                            Date = values[1].Trim(),
                            Sales = int.Parse(values[2].Trim()),
                            Views = int.Parse(values[3].Trim())
                        });
                    }

                    MessageBox.Show($"Loaded {lines.Length - 1} rows from the CSV file.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading the file: " + ex.Message);
                }
            }
        }
        private List<DataEntry> dataEntries = new List<DataEntry>();

        private void btnShowGraph_Click(object sender, EventArgs e)
        {
        }

        private class DataEntry
        {
            public string Company { get; set; }
            public string Date { get; set; }
            public int Sales { get; set; }
            public int Views { get; set; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();

            var companies = dataEntries.Select(x => x.Company).Distinct();

            foreach (var company in companies)
            {
                Series series = new Series(company);
                series.ChartType = SeriesChartType.Line;

                var companyData = dataEntries.Where(x => x.Company == company).ToList();

                var salesData = new List<SalesData>();
                for (int i = 0; i < companyData.Count; i++)
                {
                    salesData.Add(new SalesData { MonthNumber = i + 1, Sales = companyData[i].Sales });
                    series.Points.AddXY(companyData[i].Date, companyData[i].Sales);
                }

                // Set up ML.NET
                var context = new MLContext();
                var trainData = context.Data.LoadFromEnumerable(salesData);
                var pipeline = context.Transforms.Concatenate("Features", "MonthNumber")
                    .Append(context.Regression.Trainers.Sdca(labelColumnName: "Sales", maximumNumberOfIterations: 100));

                var model = pipeline.Fit(trainData);

                // Predict next 3 months
                for (int i = 1; i <= 3; i++)
                {
                    var prediction = model.Transform(context.Data.LoadFromEnumerable(new List<SalesData> { new SalesData { MonthNumber = companyData.Count + i } }));
                    var salesPrediction = context.Model.CreatePredictionEngine<SalesData, SalesPrediction>(model).Predict(new SalesData { MonthNumber = companyData.Count + i });
                    series.Points.AddXY($"Month {companyData.Count + i}", salesPrediction.Score);
                }

                chart1.Series.Add(series);
            }
        }
        public class SalesData
        {
            public float MonthNumber { get; set; }
            public float Sales { get; set; }
        }

        public class SalesPrediction
        {
            public float Score { get; set; }
        }

    }
}


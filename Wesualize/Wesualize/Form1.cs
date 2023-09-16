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
        }

        private void button2_Click(object sender, EventArgs e)
        {

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

        private void label1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private float LimitChange(float originalValue, float newValue)
        {
            float maxAllowedValue = originalValue * 1.20f; // 20% increase
            float minAllowedValue = originalValue * 0.80f; // 20% decrease

            return Math.Max(minAllowedValue, Math.Min(maxAllowedValue, newValue));
        }
        private const float MAX_PERCENTAGE_CHANGE = 0.18f; // 20%
        private const float MIN_PERCENTAGE_CHANGE = -0.18f; // -20%
        private void siticoneButton1_Click(object sender, EventArgs e)
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
        public enum Bias
        {
            Positive,
            Neutral,
            Negative
        }
        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            // Call the overloaded method with default Bias.Neutral
            siticoneButton2_Click(sender, e, Bias.Negative);
        }
        private void siticoneButton2_Click(object sender, EventArgs e, Bias bias)
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

                // Set up ML.NET with a fixed seed for consistency
                var context = new MLContext(seed: 0);
                var trainData = context.Data.LoadFromEnumerable(salesData);
                var pipeline = context.Transforms.Concatenate("Features", "MonthNumber")
                    .Append(context.Regression.Trainers.Sdca(labelColumnName: "Sales", maximumNumberOfIterations: 100));

                var model = pipeline.Fit(trainData);
                float y;
                int num = int.Parse(siticoneTextBox1.Text);
                // Predict next 2 months
                for (int i = 1; i <= (num); i++)
                {
                    var prediction = model.Transform(context.Data.LoadFromEnumerable(new List<SalesData> { new SalesData { MonthNumber = companyData.Count + i } }));
                    var salesPrediction = context.Model.CreatePredictionEngine<SalesData, SalesPrediction>(model).Predict(new SalesData { MonthNumber = companyData.Count + i });
                    string before = siticoneSlider1.Value.ToString();
                    float xx = float.Parse(before);
                    y = xx / 10;
                    float amount = y / 10;
                    float rawPrediction = salesPrediction.Score;
                    switch (bias)
                    {
                        case Bias.Positive:
                            float amount3 = 1 + amount;
                            if (siticoneSlider1.Value == 0)
                            {
                                salesPrediction.Score = (float)(salesPrediction.Score * 1.05);  // Increase by 5%
                            }
                            else
                            {
                                salesPrediction.Score = (float)(salesPrediction.Score * amount3);  // Increase by bias percentage
                            }
                            break;

                        case Bias.Negative:
                            float amount2 = 1 - amount;
                            if (siticoneSlider1.Value == 0)
                            {
                                salesPrediction.Score = (float)(salesPrediction.Score * 0.95);  // Decrease by 5%
                            }
                            else
                            {
                                salesPrediction.Score = (float)(salesPrediction.Score * amount2);  // Decrease by bias percentage
                            }
                            break;
                            // Neutral does nothing
                    }
                    salesPrediction.Score = LimitChange(rawPrediction, salesPrediction.Score);
                    series.Points.AddXY($"Month {companyData.Count + i}", salesPrediction.Score);
                }

                chart1.Series.Add(series);
                chart1.Visible = true;
            }
        }

        private void siticoneSlider1_Scroll(object sender, EventArgs e)
        {
            string before = siticoneSlider1.Value.ToString();
            float x = float.Parse(before);
            float y = x / 10;
            label3.Text = y.ToString() + "%";
        }

        private void siticoneTextBox1_Click(object sender, EventArgs e)
        {
            siticoneTextBox1.Text = "";
        }

        private void siticoneTextBox1_Enter(object sender, EventArgs e)
        {
            siticoneTextBox1.Text = "";
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            if (chart1.Series.Count == 0)
            {
                MessageBox.Show("No predictions to export. Please generate predictions first.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<string> csvData = new List<string>
        {
            "Company,Date,SalesPrediction" // header
        };

                foreach (var series in chart1.Series)
                {
                    for (int i = 0; i < series.Points.Count; i++)
                    {
                        string company = series.Name;
                        string date = series.Points[i].AxisLabel;
                        string prediction = series.Points[i].YValues[0].ToString("F2");

                        csvData.Add($"{company},{date},{prediction}");
                    }
                }

                File.WriteAllLines(saveFileDialog.FileName, csvData);
                MessageBox.Show("Predictions exported successfully.");
            }
        }
    }
}


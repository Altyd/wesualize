# Wesualize

## Table of Contents
- [Overview](#overview)
- [Features](#features)
- [Program Overview](#program-overview)
  - [Initialization](#initialization)
  - [Loading Data](#loading-data)
- [Making Predictions](making-predictions)
  - [ML.NET Model](#ml.net-model)
  - [Bias Adjustment](#bias-adjustment)
  - [Ensuring Realistic Predictions](#ensuring-realistic-predictions)
- [Visualization](#visualization)
  - [Error Handling](#error-handling)
  - [Exporting Predictions](#exporting-predictions)
- [User Interaction](#user-interaction)
- [Conclusion](#conclusion)
- [Contributors](#contributors)

## Overview

Wesualize is a tool that is meant to visualize and predict company sales

## Features

1. Load csv files
2. Export predictions to a csv file
3. Show predictions csv file in the program
4. Custom amount of months to predict
5. Choose a bias (Negative, Positive, Neutral)
6. Choose amount of bias (multiplier)

## Program overview

### Initialization
Upon loading, the application's secondary panel (`panel2`) is initially hidden to ensure a streamlined user experience.
```csharp
private void Form1_Load(object sender, EventArgs e)
{
    panel2.Hide();
}
```

### Loading Data
Users can upload CSV data which is then parsed and stored in the dataEntries list.
```csharp
private void siticoneButton1_Click(object sender, EventArgs e)
{
    openFileDialog1.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
    if (openFileDialog1.ShowDialog() == DialogResult.OK)
    {
        try
        {
            // Read all lines from the selected file.
            string[] lines = File.ReadAllLines(openFileDialog1.FileName);
            
            // Clear the current entries for new data.
            dataEntries.Clear();

            // Start from the second line (index 1) to skip the header of the CSV file.
            for (int i = 1; i < lines.Length; i++)
            {
                // Split each line using the comma as a delimiter.
                string[] values = lines[i].Split(',');
                
                // Populate the dataEntries list using the parsed data.
                dataEntries.Add(new DataEntry
                {
                    Company = values[0].Trim(),
                    Date = values[1].Trim(),
                    Sales = int.Parse(values[2].Trim()),
                });
            }

            // Display a message showing the number of rows loaded.
            MessageBox.Show($"Loaded {lines.Length - 1} rows from the CSV file.");
        }
        catch (Exception ex)
        {
            // Gracefully handle any unexpected errors and inform the user.
            MessageBox.Show("Error reading the file: " + ex.Message);
        }
    }
}

```
## Making Predictions
### ML.NET Model
The core of the prediction lies in ML.NET, a robust machine learning library. We set up a regression model to predict sales.
```csharp
var context = new MLContext(seed: 0);
var pipeline = context.Transforms.Concatenate("Features", "MonthNumber")
    .Append(context.Regression.Trainers.Sdca(labelColumnName: "Sales", maximumNumberOfIterations: 100));
```
### Bias Adjustment
The bias adjustment is a unique feature allowing users to introduce a manual bias through a slider, adding flexibility to predictions.
```csharp
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
    // Neutral requires no change
}
```
### Ensuring Realistic Predictions
Predictions are post-processed to ensure they're in line with realistic expectations based on trends and historical data.
```csharp
        private float EnsureRealisticPrediction(float predictedValue, List<DataEntry> historicalData)
        {
            float lastHistoricalValue = historicalData.Last().Sales;
            float percentageChange = (predictedValue - lastHistoricalValue) / lastHistoricalValue;

            // If the change is within limits, directly return the predicted value
            if (percentageChange >= MIN_PERCENTAGE_CHANGE && percentageChange <= MAX_PERCENTAGE_CHANGE)
                return predictedValue;

            // Adjust based on the recent trend
            float trend = ComputeRecentTrend(historicalData);
            predictedValue += trend;

            // Re-compute the percentage change after applying the trend adjustment
            percentageChange = (predictedValue - lastHistoricalValue) / lastHistoricalValue;

            // Calculate a factor that's a smooth gradient between 1 to 1.2 (or 0.8 for decreases)
            float adjustmentFactor = 1 + (MAX_PERCENTAGE_CHANGE * (percentageChange / Math.Abs(percentageChange)));

            // Adjust the prediction with the factor, making it feel more "natural"
            float adjustedPrediction = lastHistoricalValue * adjustmentFactor;

            return adjustedPrediction;
        }
```
## Visualization
Data and predictions are visualized in a line chart (`chart1`) where data points represent sales for each month
### Error Handling
The application employs try-catch blocks to gracefully handle and inform the user of any unexpected errors during file reading or prediction.

### Exporting Predictions
Users can export the visualized predictions to a CSV file for further analysis or reporting.
```csharp
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
```

## User Interaction
Beyond file uploading and predictions, users can interact with the bias slider which updates a label reflecting the percentage of bias introduced.

## Conclusion
The Sales Predictions Application, powered by ML.NET, offers an intuitive platform for sales forecasting. Despite its underpinning in advanced machine learning, the user-friendly interface makes it accessible for both experts and novices. Features like bias adjustment ensure tailored and realistic forecasts, making it a valuable tool for data-driven decisions. It stands as a testament to making advanced analytics both accessible and practical for varied users, with potential for future enhancements.

## Contributors
- [Franco](https://github.com/Altyd)
import pandas as pd
import matplotlib.pyplot as plt
from fbprophet import Prophet

# Step 1: Load Data
data = pd.read_csv('sales_data.csv')

# Step 2: Data Visualization
def plot_sales(data, company_name):
    company_data = data[data['Company'] == company_name]
    plt.figure(figsize=(10, 6))
    
    # Plot historical sales data
    plt.plot(company_data['Date'], company_data['Sales'], marker='o', linestyle='-', color='b', label='Historical Sales')
    
    plt.xlabel('Date')
    plt.ylabel('Sales')
    plt.title(f'Monthly Sales for {company_name}')
    plt.legend()
    plt.grid(True)
    plt.show()

# Visualize sales for Company A
plot_sales(data, 'Company A')

# Step 3: Time Series Forecasting with Prophet
def predict_future_sales(data, company_name, future_month):
    company_data = data[data['Company'] == company_name]
    
    # Prepare data for Prophet
    df = company_data[['Date', 'Sales']]
    df.columns = ['ds', 'y']
    
    # Create and fit the Prophet model
    model = Prophet()
    model.fit(df)
    
    # Create a dataframe for future predictions
    future = model.make_future_dataframe(periods=1, freq='M')
    
    # Predict future sales
    forecast = model.predict(future)
    
    # Filter the forecast for the specified future_month
    predicted_sales = forecast[forecast['ds'] == future_month]['yhat'].values[0]
    
    # Plot the forecast
    plt.figure(figsize=(10, 6))
    model.plot(forecast, xlabel='Date', ylabel='Sales', ax=plt.gca())
    plt.title(f'Monthly Sales Forecast for {company_name}')
    plt.grid(True)
    plt.show()
    
    return predicted_sales

# Predict sales for a future month (e.g., 'April')
future_month = 'April'
predicted_sales = predict_future_sales(data, 'Company A', future_month)
print(f"Predicted sales for {future_month}: {predicted_sales:.2f}")

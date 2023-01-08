using System.Runtime.InteropServices;
using FinancialCalculator.Tools;

namespace FinancialCalculator {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e) {
            String province;
            double[] fedTaxRates = {0, 0.15, 0.21, 0.26, 0.29, 0.33};
            long[] fedTaxBrackets = {0, 13_808, 50_195, 100_392, 155_625, 221_708};
            double income;
            double tempIncome;
            double deductedIncome;
            double takehome;
            double fedTaxes = 0;
            double provTaxes = 0;
            

            // grabbing province and validating income
            province = provinceListBox.Text.Trim();
            if (double.TryParse(incomeTextBox.Text, out income)) {
            } else {
                //takeHomeResult.Text = "Income must be a numeric value";
                return;
            }

            // setting income to temporary variable
            tempIncome = income;

            // calculating federal taxes
            for (int i = fedTaxBrackets.Length - 1; i >= 0; i--) {
                if (tempIncome > fedTaxBrackets[i]) {
                    deductedIncome = tempIncome - fedTaxBrackets[i]; // grabbing amount over current bracket
                    fedTaxes += deductedIncome * fedTaxRates[i]; // grabbing tax amount for that group
                    tempIncome = fedTaxBrackets[i];              // setting income to top of next bracket
                }
            }

            // grabbing provincial tax rates/brackets
            double[] provTaxRates = getProvTaxRates(province);
            long[] provTaxBrackets = getProvTaxBrackets(province);
            tempIncome = income;

            // calculating provincial taxes
            for (int i = provTaxBrackets.Length - 1; i >= 0; i--) {
                if (tempIncome > provTaxBrackets[i]) {
                    deductedIncome = tempIncome - provTaxBrackets[i]; // grabbing amount over current bracket
                    provTaxes += deductedIncome * provTaxRates[i]; // grabbing tax amount for that group
                    tempIncome = provTaxBrackets[i];              // setting income to top of next bracket
                }
            }

            // calculating takehome pay
            takehome = income - fedTaxes - provTaxes;

            // setting display values rounded to two decimals
            //takeHomeResult.Text = String.Format("{0:0,0.00}",takehome);
            //fedTaxResult.Text = String.Format("{0:0,0.00}", fedTaxes);
            //provTaxResult.Text = String.Format("{0:0,0.00}", provTaxes);

            // populating chart with data
            //populateChart(takehome, fedTaxes, provTaxes);

        }

        // tax calculator to compare against 
        // https://www.wealthsimple.com/en-ca/tool/tax-calculator
        private long[] getProvTaxBrackets(String province) {
            long[]? brackets = null;

            switch (province) {
                case "Alberta":
                    brackets = new long[] {0, 131_220, 157_464, 209_952, 314_928}; // https://www.wealthsimple.com/en-ca/learn/alberta-tax-brackets
                    break;
                case "British Columbia":
                    brackets = new long[] {0, 42_184, 84_369, 96_866, 117_623, 159_483, 222_420}; // https://www.wealthsimple.com/en-ca/learn/bc-tax-brackets
                    break;
                case "Manitoba":
                    Array.Fill(brackets, 1, 2, 3); // not done yet
                    break;
                case "New Brunswick":
                    Array.Fill(brackets, 1, 2, 3); // not done yet
                    break;
                case "Newfoundland and Labrador":
                    Array.Fill(brackets, 1, 2, 3); // not done yet
                    break;
                case "Northwest Territories":
                    Array.Fill(brackets, 1, 2, 3); // not done yet
                    break;
                case "Nova Scotia":
                    Array.Fill(brackets, 1, 2, 3); // not done yet
                    break;
                case "Nunavut":
                    Array.Fill(brackets, 1, 2, 3); // not done yet
                    break;
                case "Ontario":
                    brackets = new long[] {0, 45_142, 90_287, 150_000, 220_000}; // https://www.wealthsimple.com/en-ca/learn/ontario-tax-brackets
                    break;
                case "Prince Edward Island":
                    Array.Fill(brackets, 1, 2, 3); // not done yet
                    break;
                case "Quebec":
                    Array.Fill(brackets, 1, 2, 3); // not done yet
                    break;
                case "Saskatchewan":
                    Array.Fill(brackets, 1, 2, 3); // not done yet
                    break;
                case "Yukon":
                    Array.Fill(brackets, 1, 2, 3); // not done yet
                    break;
                default:
                    Array.Fill(brackets, 0);
                    break;
            }

            return brackets;
        }

        private double[] getProvTaxRates(String province) {
            double[]? rates = null;

            switch (province) {
                case "Alberta":
                    rates = new double[] {0.1, 0.12, 0.13, 0.14, 0.15 }; // https://www.wealthsimple.com/en-ca/learn/alberta-tax-brackets
                    break;
                case "British Columbia":
                    rates = new double[] {0.0506, 0.077, 0.105, 0.1229, 0.1470, 0.1680, 0.205}; // https://www.wealthsimple.com/en-ca/learn/bc-tax-brackets
                    break;
                case "Manitoba":
                    Array.Fill(rates, 1, 2, 3); // not done yet
                    break;
                case "New Brunswick":
                    Array.Fill(rates, 1, 2, 3); // not done yet
                    break;
                case "Newfoundland and Labrador":
                    Array.Fill(rates, 1, 2, 3); // not done yet
                    break;
                case "Northwest Territories":
                    Array.Fill(rates, 1, 2, 3); // not done yet
                    break;
                case "Nova Scotia":
                    Array.Fill(rates, 1, 2, 3); // not done yet
                    break;
                case "Nunavut":
                    Array.Fill(rates, 1, 2, 3); // not done yet
                    break;
                case "Ontario":
                    rates = new double[] {0.0505, 0.0915, 0.1116, 0.1216, 0.1316}; // https://www.wealthsimple.com/en-ca/learn/ontario-tax-brackets
                    break;
                case "Prince Edward Island":
                    Array.Fill(rates, 1, 2, 3); // not done yet
                    break;
                case "Quebec":
                    Array.Fill(rates, 1, 2, 3); // not done yet
                    break;
                case "Saskatchewan":
                    Array.Fill(rates, 1, 2, 3); // not done yet
                    break;
                case "Yukon":
                    Array.Fill(rates, 1, 2, 3); // not done yet
                    break;
                default:
                    Array.Fill(rates, 0);
                    break;
            }
            return rates;
        }
   
        private void populateChart(double takeHome, double fedTaxes, double provTaxes) {
            double total = takeHome + fedTaxes + provTaxes;
            int takeHomePercent = (int)(takeHome / total * 100);
            int fedTaxesPercent = (int)(fedTaxes / total * 100);
            int provTaxesPercent = (int)(provTaxes / total * 100);

            

            barChart.progressBar1.Value = takeHomePercent;
            barChart.progressBar2.Value = fedTaxesPercent;
            barChart.progressBar3.Value = provTaxesPercent;

            barChart.progressBar1.SetState(1);
            barChart.progressBar2.SetState(2);
            barChart.progressBar3.SetState(3);

        }
    
    
    }
}
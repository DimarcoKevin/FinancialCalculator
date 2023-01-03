namespace FinancialCalculator {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e) {
            String province;
            double[] fedTaxRates = {0.15, 0.205, 0.26, 0.29, 0.33};
            long[] fedTaxBrackets = {0, 50_195, 100_392, 155_625, 221_708};
            double income;
            double tempIncome;
            double takehome;
            double fedTaxes = 0;
            double provTaxes = 0;
            

            // showing take home labels
            takeHomeLabel.Visible = true;
            takeHomeResult.Visible = true;
            fedTaxLabel.Visible = true;
            fedTaxResult.Visible = true;
            provTaxLabel.Visible = true;
            provTaxResult.Visible = true;

            // grabbing province and validating income
            province = provinceListBox.Text.Trim();
            if (double.TryParse(incomeTextBox.Text, out income)) {
            } else {
                takeHomeResult.Text = "Income must be a numeric value";
                return;
            }

            // calculating federal taxes
            for (int i = fedTaxBrackets.Length - 1; i >= 0; i++) {
                if (income > fedTaxBrackets[i]) {
                    tempIncome = income - fedTaxBrackets[i]; // grabbing amount over current bracket
                    fedTaxes += tempIncome * fedTaxRates[i]; // grabbing tax amount for that group
                    income = fedTaxBrackets[i];              // setting income to top of next bracket
                }
            }
            
            
        }

        private long[] getProvTaxBrackets(String province) {
            long[]? brackets = null;

            switch (province) {
                case "Alberta":
                    Array.Fill(brackets, 1, 2, 3); // not done yet
                    break;
                case "British Columbia":
                    brackets = new long[] {0, 43_070, 86_141, 98_901, 120_094, 162_832, 227_091}; // https://www2.gov.bc.ca/gov/content/taxes/income-taxes/personal/tax-rates
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
                    Array.Fill(brackets, 1, 2, 3); // not done yet
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
                    Array.Fill(rates, 1, 2, 3); // not done yet
                    break;
                case "British Columbia":
                    rates = new double[] {0.0506, 0.077, 0.105, 0.1229, 0.1470, 0.1680, 0.205}; // https://www2.gov.bc.ca/gov/content/taxes/income-taxes/personal/tax-rates
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
                    Array.Fill(rates, 1, 2, 3); // not done yet
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
    }
}
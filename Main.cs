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
                    Array.Fill(brackets, 1, 2, 3);
                    break;
                case "British Columbia":
                    Array.Fill(brackets, 1, 2, 3);
                    break;
                default:
                    Array.Fill(brackets, 0);
                    break;
            }

            return brackets;
        }
    }
}
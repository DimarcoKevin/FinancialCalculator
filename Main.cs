namespace FinancialCalculator {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e) {
            String province;
            double[] fedTaxRates = {15, 20.5, 26, 29, 33};
            long[] fedTaxBrackets = {0, 50_195, 100_392, 155_625, 221_708};
            double income;
            double takehome;
            double fedTaxes;
            double provTaxes;
            

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
            

            
            
            
        }
    }
}
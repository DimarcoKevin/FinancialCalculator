namespace FinancialCalculator {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e) {
            double[] fedTaxRates = {15, 20.5, 26, 29, 33};
            long[] fedTaxBrackets = {50_195, 100_392, 155_625, 221_708, 100_000_000};
            long income;
            String province;

            // showing take home labels
            takeHomeLabel.Visible = true;
            takeHomeResult.Visible = true;

            // grabbing province and validating income
            province = provinceListBox.Text.Trim();
            if (long.TryParse(incomeTextBox.Text, out income)) {
            } else {
                takeHomeResult.Text = "Income must be a numeric value";
                return;
            }
            

            
            
            
        }
    }
}
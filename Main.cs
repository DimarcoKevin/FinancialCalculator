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

            // grabbing variables
            if (long.TryParse(incomeTextBox.Text, out income));
            province = provinceListBox.Text.Trim();

            // showing take home labels
            takeHomeLabel.Visible = true;
            takeHomeResult.Visible = true;
            
            
        }
    }
}
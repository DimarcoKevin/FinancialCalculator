namespace FinancialCalculator {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e) {
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
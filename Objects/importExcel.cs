using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCalculator.Objects {
    public partial class importExcel : UserControl {

        public string defaultFilePath { get; set; }
        public string returnFilePath { get; set; }

        public importExcel() {
            InitializeComponent();
        }

        private void exploreBtn_Click(object sender, EventArgs e) {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = "C:\\Users\\kevin\\OneDrive\\Desktop";
                openFileDialog.Filter = "excel files (*.xls)|*.xls|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    fileTextBox.Text = openFileDialog.FileName;
                }
            }
        }

        private void importBtn_Click(object sender, EventArgs e) {

        }
    }
}

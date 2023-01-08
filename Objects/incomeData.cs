using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCalculator.Tools;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinancialCalculator.Objects {
    public partial class incomeData : UserControl {
        public incomeData() {
            InitializeComponent();
        }

        // creating props
        public double Income { get; set; }
        public double Takehome { get; set; }
        public double FedTax { get; set; }
        public double ProvTax { get; set; }


        // functions
        public void setValues(double income, double pay, double fedTax, double provTax) {
            Income = income;    
            Takehome = pay;
            FedTax = fedTax;
            ProvTax = provTax;

            takehomeResult.Text = String.Format("{0:0,0.00}", pay);
            fedTaxResult.Text = String.Format("{0:0,0.00}", fedTax);
            provTaxResult.Text = String.Format("{0:0,0.00}", provTax);
        }

        public void setChart() {
            // validating there is data populated first
            if (Income == 0 || Takehome == 0) return;

            progressBar1.Value = (int)(Takehome / Income * 100);
            progressBar2.Value = (int)(FedTax / Income * 100);
            progressBar3.Value = (int)(ProvTax / Income * 100);

            progressBar1.SetState(1);
            progressBar2.SetState(2);
            progressBar3.SetState(3);
        }

        public void makeVisible() {
            this.Visible = true;
        }

    }
}

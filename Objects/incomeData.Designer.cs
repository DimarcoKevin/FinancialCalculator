namespace FinancialCalculator.Objects {
    partial class incomeData {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.takehomeLabel = new System.Windows.Forms.Label();
            this.takehomeResult = new System.Windows.Forms.Label();
            this.fedTaxResult = new System.Windows.Forms.Label();
            this.fedTaxLabel = new System.Windows.Forms.Label();
            this.provTaxResult = new System.Windows.Forms.Label();
            this.provTaxLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(196, 26);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(514, 63);
            this.progressBar1.TabIndex = 0;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(196, 108);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(514, 63);
            this.progressBar2.TabIndex = 1;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(196, 189);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(514, 63);
            this.progressBar3.TabIndex = 2;
            // 
            // takehomeLabel
            // 
            this.takehomeLabel.AutoSize = true;
            this.takehomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.takehomeLabel.Location = new System.Drawing.Point(53, 31);
            this.takehomeLabel.Name = "takehomeLabel";
            this.takehomeLabel.Size = new System.Drawing.Size(108, 21);
            this.takehomeLabel.TabIndex = 3;
            this.takehomeLabel.Text = "Takehome Pay";
            // 
            // takehomeResult
            // 
            this.takehomeResult.AutoSize = true;
            this.takehomeResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.takehomeResult.Location = new System.Drawing.Point(112, 62);
            this.takehomeResult.Name = "takehomeResult";
            this.takehomeResult.Size = new System.Drawing.Size(49, 21);
            this.takehomeResult.TabIndex = 4;
            this.takehomeResult.Text = "7,600";
            // 
            // fedTaxResult
            // 
            this.fedTaxResult.AutoSize = true;
            this.fedTaxResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fedTaxResult.Location = new System.Drawing.Point(112, 144);
            this.fedTaxResult.Name = "fedTaxResult";
            this.fedTaxResult.Size = new System.Drawing.Size(49, 21);
            this.fedTaxResult.TabIndex = 6;
            this.fedTaxResult.Text = "7,600";
            // 
            // fedTaxLabel
            // 
            this.fedTaxLabel.AutoSize = true;
            this.fedTaxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fedTaxLabel.Location = new System.Drawing.Point(75, 113);
            this.fedTaxLabel.Name = "fedTaxLabel";
            this.fedTaxLabel.Size = new System.Drawing.Size(86, 21);
            this.fedTaxLabel.TabIndex = 5;
            this.fedTaxLabel.Text = "Federal Tax";
            // 
            // provTaxResult
            // 
            this.provTaxResult.AutoSize = true;
            this.provTaxResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.provTaxResult.Location = new System.Drawing.Point(112, 226);
            this.provTaxResult.Name = "provTaxResult";
            this.provTaxResult.Size = new System.Drawing.Size(49, 21);
            this.provTaxResult.TabIndex = 8;
            this.provTaxResult.Text = "7,600";
            // 
            // provTaxLabel
            // 
            this.provTaxLabel.AutoSize = true;
            this.provTaxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.provTaxLabel.Location = new System.Drawing.Point(58, 195);
            this.provTaxLabel.Name = "provTaxLabel";
            this.provTaxLabel.Size = new System.Drawing.Size(103, 21);
            this.provTaxLabel.TabIndex = 7;
            this.provTaxLabel.Text = "Provincial Tax";
            // 
            // incomeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.provTaxResult);
            this.Controls.Add(this.provTaxLabel);
            this.Controls.Add(this.fedTaxResult);
            this.Controls.Add(this.fedTaxLabel);
            this.Controls.Add(this.takehomeResult);
            this.Controls.Add(this.takehomeLabel);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Name = "incomeData";
            this.Size = new System.Drawing.Size(744, 273);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
        private Label takehomeLabel;
        private Label takehomeResult;
        private Label fedTaxResult;
        private Label fedTaxLabel;
        private Label provTaxResult;
        private Label provTaxLabel;
    }
}

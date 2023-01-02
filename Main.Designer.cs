namespace FinancialCalculator {
    partial class Main {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.incomeLabel = new System.Windows.Forms.Label();
            this.incomeTextBox = new System.Windows.Forms.TextBox();
            this.provinceLabel = new System.Windows.Forms.Label();
            this.provinceListBox = new System.Windows.Forms.ListBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.takeHomeLabel = new System.Windows.Forms.Label();
            this.takeHomeResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // incomeLabel
            // 
            this.incomeLabel.AutoSize = true;
            this.incomeLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.incomeLabel.Location = new System.Drawing.Point(31, 56);
            this.incomeLabel.Name = "incomeLabel";
            this.incomeLabel.Size = new System.Drawing.Size(169, 25);
            this.incomeLabel.TabIndex = 0;
            this.incomeLabel.Text = "Pre-Tax Income ($)";
            this.incomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // incomeTextBox
            // 
            this.incomeTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.incomeTextBox.Location = new System.Drawing.Point(31, 84);
            this.incomeTextBox.Name = "incomeTextBox";
            this.incomeTextBox.Size = new System.Drawing.Size(169, 32);
            this.incomeTextBox.TabIndex = 1;
            this.incomeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // provinceLabel
            // 
            this.provinceLabel.AutoSize = true;
            this.provinceLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.provinceLabel.Location = new System.Drawing.Point(31, 123);
            this.provinceLabel.Name = "provinceLabel";
            this.provinceLabel.Size = new System.Drawing.Size(85, 25);
            this.provinceLabel.TabIndex = 0;
            this.provinceLabel.Text = "Province";
            this.provinceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // provinceListBox
            // 
            this.provinceListBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.provinceListBox.FormattingEnabled = true;
            this.provinceListBox.ItemHeight = 25;
            this.provinceListBox.Items.AddRange(new object[] {
            "Alberta",
            "British Columbia",
            "Manitoba",
            "New Brunswick",
            "Newfoundland and Labrador",
            "Northwest Territories",
            "Nova Scotia",
            "Nunavut",
            "Ontario",
            "Prince Edward Island",
            "Quebec",
            "Saskatchewan",
            "Yukon"});
            this.provinceListBox.Location = new System.Drawing.Point(28, 151);
            this.provinceListBox.Name = "provinceListBox";
            this.provinceListBox.Size = new System.Drawing.Size(276, 329);
            this.provinceListBox.TabIndex = 3;
            // 
            // calcButton
            // 
            this.calcButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calcButton.Location = new System.Drawing.Point(113, 498);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(88, 29);
            this.calcButton.TabIndex = 4;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // takeHomeLabel
            // 
            this.takeHomeLabel.AutoSize = true;
            this.takeHomeLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.takeHomeLabel.Location = new System.Drawing.Point(88, 541);
            this.takeHomeLabel.Name = "takeHomeLabel";
            this.takeHomeLabel.Size = new System.Drawing.Size(138, 25);
            this.takeHomeLabel.TabIndex = 5;
            this.takeHomeLabel.Text = "Take Home Pay";
            this.takeHomeLabel.Visible = false;
            // 
            // takeHomeResult
            // 
            this.takeHomeResult.AutoSize = true;
            this.takeHomeResult.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.takeHomeResult.Location = new System.Drawing.Point(127, 579);
            this.takeHomeResult.Name = "takeHomeResult";
            this.takeHomeResult.Size = new System.Drawing.Size(60, 25);
            this.takeHomeResult.TabIndex = 6;
            this.takeHomeResult.Text = "TEMP";
            this.takeHomeResult.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 634);
            this.Controls.Add(this.takeHomeResult);
            this.Controls.Add(this.takeHomeLabel);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.provinceListBox);
            this.Controls.Add(this.provinceLabel);
            this.Controls.Add(this.incomeTextBox);
            this.Controls.Add(this.incomeLabel);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label incomeLabel;
        private TextBox incomeTextBox;
        private Label provinceLabel;
        private ListBox provinceListBox;
        private Button calcButton;
        private Label takeHomeLabel;
        private Label takeHomeResult;
    }
}
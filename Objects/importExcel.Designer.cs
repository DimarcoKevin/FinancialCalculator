namespace FinancialCalculator.Objects {
    partial class importExcel {
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
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.exploreBtn = new System.Windows.Forms.Button();
            this.importBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(16, 14);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(396, 23);
            this.fileTextBox.TabIndex = 0;
            // 
            // exploreBtn
            // 
            this.exploreBtn.Location = new System.Drawing.Point(418, 14);
            this.exploreBtn.Name = "exploreBtn";
            this.exploreBtn.Size = new System.Drawing.Size(28, 23);
            this.exploreBtn.TabIndex = 1;
            this.exploreBtn.Text = "...";
            this.exploreBtn.UseVisualStyleBackColor = true;
            this.exploreBtn.Click += new System.EventHandler(this.exploreBtn_Click);
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(465, 14);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(75, 23);
            this.importBtn.TabIndex = 2;
            this.importBtn.Text = "Import";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // importExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.exploreBtn);
            this.Controls.Add(this.fileTextBox);
            this.Name = "importExcel";
            this.Size = new System.Drawing.Size(555, 49);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox fileTextBox;
        private Button exploreBtn;
        private Button importBtn;
    }
}

namespace BitCoinCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currencyBox = new System.Windows.Forms.ComboBox();
            this.getRatesBTN = new System.Windows.Forms.Button();
            this.amountOfBtc = new System.Windows.Forms.TextBox();
            this.resultLbl = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // currencyBox
            // 
            this.currencyBox.FormattingEnabled = true;
            this.currencyBox.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.currencyBox.Location = new System.Drawing.Point(67, 97);
            this.currencyBox.Name = "currencyBox";
            this.currencyBox.Size = new System.Drawing.Size(128, 23);
            this.currencyBox.TabIndex = 0;
            this.currencyBox.Text = "Select Currency";
            // 
            // getRatesBTN
            // 
            this.getRatesBTN.Location = new System.Drawing.Point(226, 97);
            this.getRatesBTN.Name = "getRatesBTN";
            this.getRatesBTN.Size = new System.Drawing.Size(75, 23);
            this.getRatesBTN.TabIndex = 1;
            this.getRatesBTN.Text = "Get Rates";
            this.getRatesBTN.UseVisualStyleBackColor = true;
            this.getRatesBTN.Click += new System.EventHandler(this.getRatesBTN_Click);
            // 
            // amountOfBtc
            // 
            this.amountOfBtc.Location = new System.Drawing.Point(67, 163);
            this.amountOfBtc.Name = "amountOfBtc";
            this.amountOfBtc.PlaceholderText = "Amount of BitCoins";
            this.amountOfBtc.Size = new System.Drawing.Size(128, 23);
            this.amountOfBtc.TabIndex = 2;
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(67, 219);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(36, 15);
            this.resultLbl.TabIndex = 3;
            this.resultLbl.Text = "result";
            this.resultLbl.Visible = false;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(67, 262);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 23);
            this.result.TabIndex = 4;
            this.result.Text = "Result";
            this.result.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.amountOfBtc);
            this.Controls.Add(this.getRatesBTN);
            this.Controls.Add(this.currencyBox);
            this.Name = "Form1";
            this.Text = "Bitcoin Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyBox;
        private System.Windows.Forms.Button getRatesBTN;
        private System.Windows.Forms.TextBox amountOfBtc;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.TextBox result;
    }
}


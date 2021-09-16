namespace FastTicket
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fastCalculatorControl1 = new FastTicket.FastCalculatorControl();
            this.SuspendLayout();
            // 
            // fastCalculatorControl1
            // 
            this.fastCalculatorControl1.Location = new System.Drawing.Point(31, 41);
            this.fastCalculatorControl1.Name = "fastCalculatorControl1";
            this.fastCalculatorControl1.Size = new System.Drawing.Size(316, 194);
            this.fastCalculatorControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 269);
            this.Controls.Add(this.fastCalculatorControl1);
            this.Name = "MainForm";
            this.Text = "Fast Ticket Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private FastCalculatorControl fastCalculatorControl1;
    }
}


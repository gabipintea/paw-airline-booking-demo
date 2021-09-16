namespace FastTicket
{
    partial class FastCalculatorControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbChildPrice = new System.Windows.Forms.TextBox();
            this.tbFullPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbChildren = new System.Windows.Forms.TextBox();
            this.tbAdults = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFinalPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbChildPrice
            // 
            this.tbChildPrice.Location = new System.Drawing.Point(199, 63);
            this.tbChildPrice.Name = "tbChildPrice";
            this.tbChildPrice.Size = new System.Drawing.Size(100, 20);
            this.tbChildPrice.TabIndex = 19;
            // 
            // tbFullPrice
            // 
            this.tbFullPrice.Location = new System.Drawing.Point(199, 27);
            this.tbFullPrice.Name = "tbFullPrice";
            this.tbFullPrice.Size = new System.Drawing.Size(100, 20);
            this.tbFullPrice.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Child Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Full price";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(118, 110);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 15;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total ticket price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Children";
            // 
            // tbChildren
            // 
            this.tbChildren.Location = new System.Drawing.Point(62, 67);
            this.tbChildren.Name = "tbChildren";
            this.tbChildren.Size = new System.Drawing.Size(24, 20);
            this.tbChildren.TabIndex = 12;
            // 
            // tbAdults
            // 
            this.tbAdults.Location = new System.Drawing.Point(62, 26);
            this.tbAdults.Name = "tbAdults";
            this.tbAdults.Size = new System.Drawing.Size(24, 20);
            this.tbAdults.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Adults";
            // 
            // tbFinalPrice
            // 
            this.tbFinalPrice.Location = new System.Drawing.Point(118, 160);
            this.tbFinalPrice.Name = "tbFinalPrice";
            this.tbFinalPrice.Size = new System.Drawing.Size(75, 20);
            this.tbFinalPrice.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Fast Ticket Calculator";
            // 
            // FastCalculatorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbFinalPrice);
            this.Controls.Add(this.tbChildPrice);
            this.Controls.Add(this.tbFullPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbChildren);
            this.Controls.Add(this.tbAdults);
            this.Controls.Add(this.label1);
            this.Name = "FastCalculatorControl";
            this.Size = new System.Drawing.Size(316, 194);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbChildPrice;
        private System.Windows.Forms.TextBox tbFullPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbChildren;
        private System.Windows.Forms.TextBox tbAdults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFinalPrice;
        private System.Windows.Forms.Label label6;
    }
}

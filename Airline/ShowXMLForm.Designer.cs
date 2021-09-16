namespace Airline
{
    partial class ShowXMLForm
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
            this.lvXmlBookings = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXMLDone = new System.Windows.Forms.Button();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvXmlBookings
            // 
            this.lvXmlBookings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvXmlBookings.GridLines = true;
            this.lvXmlBookings.HideSelection = false;
            this.lvXmlBookings.Location = new System.Drawing.Point(125, 12);
            this.lvXmlBookings.Name = "lvXmlBookings";
            this.lvXmlBookings.Size = new System.Drawing.Size(549, 363);
            this.lvXmlBookings.TabIndex = 0;
            this.lvXmlBookings.UseCompatibleStateImageBehavior = false;
            this.lvXmlBookings.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Flight Date";
            this.columnHeader2.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Route ID";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Take-off";
            this.columnHeader4.Width = 97;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Landing";
            this.columnHeader5.Width = 104;
            // 
            // btnXMLDone
            // 
            this.btnXMLDone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnXMLDone.Location = new System.Drawing.Point(680, 191);
            this.btnXMLDone.Name = "btnXMLDone";
            this.btnXMLDone.Size = new System.Drawing.Size(98, 39);
            this.btnXMLDone.TabIndex = 1;
            this.btnXMLDone.Text = "Done";
            this.btnXMLDone.UseVisualStyleBackColor = true;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "No of passengers";
            this.columnHeader6.Width = 105;
            // 
            // ShowXMLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXMLDone);
            this.Controls.Add(this.lvXmlBookings);
            this.Name = "ShowXMLForm";
            this.Text = "ShowXMLForm";
            this.Load += new System.EventHandler(this.ShowXMLForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvXmlBookings;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnXMLDone;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}
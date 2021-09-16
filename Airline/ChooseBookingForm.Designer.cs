namespace Airline
{
    partial class ChooseBookingForm
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
            this.lvLatestBookings = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnDoneEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvLatestBookings
            // 
            this.lvLatestBookings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvLatestBookings.FullRowSelect = true;
            this.lvLatestBookings.GridLines = true;
            this.lvLatestBookings.HideSelection = false;
            this.lvLatestBookings.Location = new System.Drawing.Point(166, 23);
            this.lvLatestBookings.Name = "lvLatestBookings";
            this.lvLatestBookings.Size = new System.Drawing.Size(454, 181);
            this.lvLatestBookings.TabIndex = 0;
            this.lvLatestBookings.UseCompatibleStateImageBehavior = false;
            this.lvLatestBookings.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 38;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Flight Date";
            this.columnHeader2.Width = 92;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "No of passengers";
            this.columnHeader3.Width = 109;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "StartCity";
            this.columnHeader4.Width = 104;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Destination City";
            this.columnHeader5.Width = 106;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(319, 230);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(126, 23);
            this.btnChoose.TabIndex = 1;
            this.btnChoose.Text = "Choose and edit";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnDoneEdit
            // 
            this.btnDoneEdit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDoneEdit.Location = new System.Drawing.Point(545, 306);
            this.btnDoneEdit.Name = "btnDoneEdit";
            this.btnDoneEdit.Size = new System.Drawing.Size(75, 23);
            this.btnDoneEdit.TabIndex = 2;
            this.btnDoneEdit.Text = "Done";
            this.btnDoneEdit.UseVisualStyleBackColor = true;
            // 
            // ChooseBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDoneEdit);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.lvLatestBookings);
            this.Name = "ChooseBookingForm";
            this.Text = "Choose Booking";
            this.Load += new System.EventHandler(this.ChooseBookingForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvLatestBookings;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnDoneEdit;
    }
}
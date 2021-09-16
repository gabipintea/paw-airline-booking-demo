namespace Airline
{
    partial class EditRouteForm
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
            this.grpOfferedRoutes = new System.Windows.Forms.GroupBox();
            this.btnCoSave = new System.Windows.Forms.Button();
            this.lvCompanies = new System.Windows.Forms.ListView();
            this.columnHCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHContact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grpOfferedRoutes
            // 
            this.grpOfferedRoutes.Enabled = false;
            this.grpOfferedRoutes.Location = new System.Drawing.Point(22, 176);
            this.grpOfferedRoutes.Name = "grpOfferedRoutes";
            this.grpOfferedRoutes.Size = new System.Drawing.Size(756, 216);
            this.grpOfferedRoutes.TabIndex = 14;
            this.grpOfferedRoutes.TabStop = false;
            this.grpOfferedRoutes.Text = "Offered Routes";
            // 
            // btnCoSave
            // 
            this.btnCoSave.Location = new System.Drawing.Point(22, 412);
            this.btnCoSave.Name = "btnCoSave";
            this.btnCoSave.Size = new System.Drawing.Size(95, 25);
            this.btnCoSave.TabIndex = 1;
            this.btnCoSave.Text = "Save Company";
            this.btnCoSave.UseVisualStyleBackColor = true;
            this.btnCoSave.Click += new System.EventHandler(this.btnCoSave_Click);
            // 
            // lvCompanies
            // 
            this.lvCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvCompanies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHCode,
            this.columnHName,
            this.columnHAddress,
            this.columnHContact,
            this.columnHPhone});
            this.lvCompanies.FullRowSelect = true;
            this.lvCompanies.GridLines = true;
            this.lvCompanies.HideSelection = false;
            this.lvCompanies.Location = new System.Drawing.Point(52, 17);
            this.lvCompanies.Name = "lvCompanies";
            this.lvCompanies.Size = new System.Drawing.Size(685, 153);
            this.lvCompanies.TabIndex = 15;
            this.lvCompanies.UseCompatibleStateImageBehavior = false;
            this.lvCompanies.View = System.Windows.Forms.View.Details;
            this.lvCompanies.SelectedIndexChanged += new System.EventHandler(this.lvCompanies_SelectedIndexChanged);
            // 
            // columnHCode
            // 
            this.columnHCode.Text = "Code";
            this.columnHCode.Width = 111;
            // 
            // columnHName
            // 
            this.columnHName.Text = "Name";
            this.columnHName.Width = 116;
            // 
            // columnHAddress
            // 
            this.columnHAddress.Text = "Address";
            this.columnHAddress.Width = 161;
            // 
            // columnHContact
            // 
            this.columnHContact.Text = "Contact";
            this.columnHContact.Width = 129;
            // 
            // columnHPhone
            // 
            this.columnHPhone.Text = "Phone";
            this.columnHPhone.Width = 162;
            // 
            // btnDone
            // 
            this.btnDone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDone.Location = new System.Drawing.Point(664, 412);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(95, 25);
            this.btnDone.TabIndex = 16;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            // 
            // EditRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnCoSave);
            this.Controls.Add(this.grpOfferedRoutes);
            this.Controls.Add(this.lvCompanies);
            this.Name = "EditRouteForm";
            this.Text = "Edit Route";
            this.Load += new System.EventHandler(this.EditRouteForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOfferedRoutes;
        private System.Windows.Forms.Button btnCoSave;
        private System.Windows.Forms.ListView lvCompanies;
        private System.Windows.Forms.ColumnHeader columnHCode;
        private System.Windows.Forms.ColumnHeader columnHName;
        private System.Windows.Forms.ColumnHeader columnHAddress;
        private System.Windows.Forms.ColumnHeader columnHContact;
        private System.Windows.Forms.ColumnHeader columnHPhone;
        private System.Windows.Forms.Button btnDone;
    }
}
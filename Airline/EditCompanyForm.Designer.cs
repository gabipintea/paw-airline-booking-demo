namespace Airline
{
    partial class EditCompanyForm
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
            this.components = new System.ComponentModel.Container();
            this.grpCoDetails = new System.Windows.Forms.GroupBox();
            this.btnDoneEdit = new System.Windows.Forms.Button();
            this.btnDeleteCo = new System.Windows.Forms.Button();
            this.btnSaveCo = new System.Windows.Forms.Button();
            this.tbCoCode = new System.Windows.Forms.TextBox();
            this.tbCoPhone = new System.Windows.Forms.TextBox();
            this.lblCoCode = new System.Windows.Forms.Label();
            this.lblCoPhone = new System.Windows.Forms.Label();
            this.tbCoName = new System.Windows.Forms.TextBox();
            this.tbCoContact = new System.Windows.Forms.TextBox();
            this.lblCoName = new System.Windows.Forms.Label();
            this.lblContactPerson = new System.Windows.Forms.Label();
            this.lblCoAddress = new System.Windows.Forms.Label();
            this.tbCoAddress = new System.Windows.Forms.TextBox();
            this.lvCompanies = new System.Windows.Forms.ListView();
            this.columnHCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHContact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpCoDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCoDetails
            // 
            this.grpCoDetails.Controls.Add(this.btnDoneEdit);
            this.grpCoDetails.Controls.Add(this.btnDeleteCo);
            this.grpCoDetails.Controls.Add(this.btnSaveCo);
            this.grpCoDetails.Controls.Add(this.tbCoCode);
            this.grpCoDetails.Controls.Add(this.tbCoPhone);
            this.grpCoDetails.Controls.Add(this.lblCoCode);
            this.grpCoDetails.Controls.Add(this.lblCoPhone);
            this.grpCoDetails.Controls.Add(this.tbCoName);
            this.grpCoDetails.Controls.Add(this.tbCoContact);
            this.grpCoDetails.Controls.Add(this.lblCoName);
            this.grpCoDetails.Controls.Add(this.lblContactPerson);
            this.grpCoDetails.Controls.Add(this.lblCoAddress);
            this.grpCoDetails.Controls.Add(this.tbCoAddress);
            this.grpCoDetails.Enabled = false;
            this.grpCoDetails.Location = new System.Drawing.Point(12, 278);
            this.grpCoDetails.Name = "grpCoDetails";
            this.grpCoDetails.Size = new System.Drawing.Size(756, 118);
            this.grpCoDetails.TabIndex = 11;
            this.grpCoDetails.TabStop = false;
            this.grpCoDetails.Text = "Company Details";
            // 
            // btnDoneEdit
            // 
            this.btnDoneEdit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDoneEdit.Location = new System.Drawing.Point(679, 70);
            this.btnDoneEdit.Name = "btnDoneEdit";
            this.btnDoneEdit.Size = new System.Drawing.Size(49, 19);
            this.btnDoneEdit.TabIndex = 12;
            this.btnDoneEdit.Text = "Done";
            this.btnDoneEdit.UseVisualStyleBackColor = true;
            this.btnDoneEdit.Click += new System.EventHandler(this.btnDoneEdit_Click);
            // 
            // btnDeleteCo
            // 
            this.btnDeleteCo.Location = new System.Drawing.Point(591, 70);
            this.btnDeleteCo.Name = "btnDeleteCo";
            this.btnDeleteCo.Size = new System.Drawing.Size(49, 19);
            this.btnDeleteCo.TabIndex = 11;
            this.btnDeleteCo.Text = "Delete";
            this.btnDeleteCo.UseVisualStyleBackColor = true;
            this.btnDeleteCo.Click += new System.EventHandler(this.btnDeleteCo_Click);
            // 
            // btnSaveCo
            // 
            this.btnSaveCo.Location = new System.Drawing.Point(503, 70);
            this.btnSaveCo.Name = "btnSaveCo";
            this.btnSaveCo.Size = new System.Drawing.Size(49, 19);
            this.btnSaveCo.TabIndex = 10;
            this.btnSaveCo.Text = "Save";
            this.btnSaveCo.UseVisualStyleBackColor = true;
            this.btnSaveCo.Click += new System.EventHandler(this.btnSaveCo_Click);
            // 
            // tbCoCode
            // 
            this.tbCoCode.Location = new System.Drawing.Point(353, 17);
            this.tbCoCode.Name = "tbCoCode";
            this.tbCoCode.Size = new System.Drawing.Size(100, 20);
            this.tbCoCode.TabIndex = 5;
            this.tbCoCode.Validating += new System.ComponentModel.CancelEventHandler(this.tbCoCode_Validating);
            this.tbCoCode.Validated += new System.EventHandler(this.tbCoCode_Validated);
            // 
            // tbCoPhone
            // 
            this.tbCoPhone.Location = new System.Drawing.Point(353, 70);
            this.tbCoPhone.Name = "tbCoPhone";
            this.tbCoPhone.Size = new System.Drawing.Size(100, 20);
            this.tbCoPhone.TabIndex = 9;
            this.tbCoPhone.Validating += new System.ComponentModel.CancelEventHandler(this.tbCoPhone_Validating);
            this.tbCoPhone.Validated += new System.EventHandler(this.tbCoPhone_Validated);
            // 
            // lblCoCode
            // 
            this.lblCoCode.AutoSize = true;
            this.lblCoCode.Location = new System.Drawing.Point(257, 21);
            this.lblCoCode.Name = "lblCoCode";
            this.lblCoCode.Size = new System.Drawing.Size(79, 13);
            this.lblCoCode.TabIndex = 4;
            this.lblCoCode.Text = "Company Code";
            // 
            // lblCoPhone
            // 
            this.lblCoPhone.AutoSize = true;
            this.lblCoPhone.Location = new System.Drawing.Point(256, 74);
            this.lblCoPhone.Name = "lblCoPhone";
            this.lblCoPhone.Size = new System.Drawing.Size(78, 13);
            this.lblCoPhone.TabIndex = 8;
            this.lblCoPhone.Text = "Phone Number";
            // 
            // tbCoName
            // 
            this.tbCoName.Location = new System.Drawing.Point(140, 17);
            this.tbCoName.Name = "tbCoName";
            this.tbCoName.Size = new System.Drawing.Size(100, 20);
            this.tbCoName.TabIndex = 1;
            this.tbCoName.Validating += new System.ComponentModel.CancelEventHandler(this.tbCoName_Validating);
            this.tbCoName.Validated += new System.EventHandler(this.tbCoName_Validated);
            // 
            // tbCoContact
            // 
            this.tbCoContact.Location = new System.Drawing.Point(137, 70);
            this.tbCoContact.Name = "tbCoContact";
            this.tbCoContact.Size = new System.Drawing.Size(100, 20);
            this.tbCoContact.TabIndex = 7;
            this.tbCoContact.Validating += new System.ComponentModel.CancelEventHandler(this.tbCoContact_Validating);
            this.tbCoContact.Validated += new System.EventHandler(this.tbCoContact_Validated);
            // 
            // lblCoName
            // 
            this.lblCoName.AutoSize = true;
            this.lblCoName.Location = new System.Drawing.Point(41, 21);
            this.lblCoName.Name = "lblCoName";
            this.lblCoName.Size = new System.Drawing.Size(82, 13);
            this.lblCoName.TabIndex = 0;
            this.lblCoName.Text = "Company Name";
            // 
            // lblContactPerson
            // 
            this.lblContactPerson.AutoSize = true;
            this.lblContactPerson.Location = new System.Drawing.Point(39, 74);
            this.lblContactPerson.Name = "lblContactPerson";
            this.lblContactPerson.Size = new System.Drawing.Size(79, 13);
            this.lblContactPerson.TabIndex = 6;
            this.lblContactPerson.Text = "Contact person";
            // 
            // lblCoAddress
            // 
            this.lblCoAddress.AutoSize = true;
            this.lblCoAddress.Location = new System.Drawing.Point(470, 21);
            this.lblCoAddress.Name = "lblCoAddress";
            this.lblCoAddress.Size = new System.Drawing.Size(92, 13);
            this.lblCoAddress.TabIndex = 2;
            this.lblCoAddress.Text = "Company Address";
            // 
            // tbCoAddress
            // 
            this.tbCoAddress.Location = new System.Drawing.Point(579, 17);
            this.tbCoAddress.Name = "tbCoAddress";
            this.tbCoAddress.Size = new System.Drawing.Size(171, 20);
            this.tbCoAddress.TabIndex = 3;
            this.tbCoAddress.Validating += new System.ComponentModel.CancelEventHandler(this.tbCoAddress_Validating);
            this.tbCoAddress.Validated += new System.EventHandler(this.tbCoAddress_Validated);
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
            this.lvCompanies.Location = new System.Drawing.Point(56, 12);
            this.lvCompanies.Name = "lvCompanies";
            this.lvCompanies.Size = new System.Drawing.Size(685, 238);
            this.lvCompanies.TabIndex = 12;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvCompanies);
            this.Controls.Add(this.grpCoDetails);
            this.Name = "EditCompanyForm";
            this.Text = "Edit Company";
            this.Load += new System.EventHandler(this.EditCompanyForm_Load);
            this.grpCoDetails.ResumeLayout(false);
            this.grpCoDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCoDetails;
        private System.Windows.Forms.Button btnSaveCo;
        private System.Windows.Forms.TextBox tbCoCode;
        private System.Windows.Forms.TextBox tbCoPhone;
        private System.Windows.Forms.Label lblCoCode;
        private System.Windows.Forms.Label lblCoPhone;
        private System.Windows.Forms.TextBox tbCoName;
        private System.Windows.Forms.TextBox tbCoContact;
        private System.Windows.Forms.Label lblCoName;
        private System.Windows.Forms.Label lblContactPerson;
        private System.Windows.Forms.Label lblCoAddress;
        private System.Windows.Forms.TextBox tbCoAddress;
        private System.Windows.Forms.ListView lvCompanies;
        private System.Windows.Forms.ColumnHeader columnHCode;
        private System.Windows.Forms.ColumnHeader columnHName;
        private System.Windows.Forms.ColumnHeader columnHAddress;
        private System.Windows.Forms.ColumnHeader columnHContact;
        private System.Windows.Forms.ColumnHeader columnHPhone;
        private System.Windows.Forms.Button btnDeleteCo;
        private System.Windows.Forms.Button btnDoneEdit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
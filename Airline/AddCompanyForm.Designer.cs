namespace Airline
{
    partial class AddCompanyForm
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
            this.lblCoName = new System.Windows.Forms.Label();
            this.tbCoName = new System.Windows.Forms.TextBox();
            this.lblCoAddress = new System.Windows.Forms.Label();
            this.tbCoAddress = new System.Windows.Forms.TextBox();
            this.lblCoCode = new System.Windows.Forms.Label();
            this.tbCoCode = new System.Windows.Forms.TextBox();
            this.lblContactPerson = new System.Windows.Forms.Label();
            this.tbCoContact = new System.Windows.Forms.TextBox();
            this.lblCoPhone = new System.Windows.Forms.Label();
            this.tbCoPhone = new System.Windows.Forms.TextBox();
            this.grpCoDetails = new System.Windows.Forms.GroupBox();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.grpOfferedRoutes = new System.Windows.Forms.GroupBox();
            this.btnCoSave = new System.Windows.Forms.Button();
            this.btnAddOffers = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpCoDetails.SuspendLayout();
            this.grpOfferedRoutes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
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
            // tbCoName
            // 
            this.tbCoName.Location = new System.Drawing.Point(140, 17);
            this.tbCoName.Name = "tbCoName";
            this.tbCoName.Size = new System.Drawing.Size(100, 20);
            this.tbCoName.TabIndex = 1;
            this.tbCoName.Validating += new System.ComponentModel.CancelEventHandler(this.tbCoName_Validating);
            this.tbCoName.Validated += new System.EventHandler(this.tbCoName_Validated);
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
            // lblCoCode
            // 
            this.lblCoCode.AutoSize = true;
            this.lblCoCode.Location = new System.Drawing.Point(257, 21);
            this.lblCoCode.Name = "lblCoCode";
            this.lblCoCode.Size = new System.Drawing.Size(79, 13);
            this.lblCoCode.TabIndex = 4;
            this.lblCoCode.Text = "Company Code";
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
            // lblContactPerson
            // 
            this.lblContactPerson.AutoSize = true;
            this.lblContactPerson.Location = new System.Drawing.Point(39, 74);
            this.lblContactPerson.Name = "lblContactPerson";
            this.lblContactPerson.Size = new System.Drawing.Size(79, 13);
            this.lblContactPerson.TabIndex = 6;
            this.lblContactPerson.Text = "Contact person";
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
            // lblCoPhone
            // 
            this.lblCoPhone.AutoSize = true;
            this.lblCoPhone.Location = new System.Drawing.Point(256, 74);
            this.lblCoPhone.Name = "lblCoPhone";
            this.lblCoPhone.Size = new System.Drawing.Size(78, 13);
            this.lblCoPhone.TabIndex = 8;
            this.lblCoPhone.Text = "Phone Number";
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
            // grpCoDetails
            // 
            this.grpCoDetails.Controls.Add(this.btnAddCompany);
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
            this.grpCoDetails.Location = new System.Drawing.Point(14, 15);
            this.grpCoDetails.Name = "grpCoDetails";
            this.grpCoDetails.Size = new System.Drawing.Size(756, 118);
            this.grpCoDetails.TabIndex = 10;
            this.grpCoDetails.TabStop = false;
            this.grpCoDetails.Text = "Company Details";
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddCompany.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddCompany.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddCompany.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddCompany.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCompany.Location = new System.Drawing.Point(642, 74);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(102, 24);
            this.btnAddCompany.TabIndex = 10;
            this.btnAddCompany.Text = "Add Company";
            this.btnAddCompany.UseVisualStyleBackColor = false;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
            // 
            // grpOfferedRoutes
            // 
            this.grpOfferedRoutes.Controls.Add(this.btnCoSave);
            this.grpOfferedRoutes.Controls.Add(this.btnAddOffers);
            this.grpOfferedRoutes.Enabled = false;
            this.grpOfferedRoutes.Location = new System.Drawing.Point(14, 161);
            this.grpOfferedRoutes.Name = "grpOfferedRoutes";
            this.grpOfferedRoutes.Size = new System.Drawing.Size(756, 258);
            this.grpOfferedRoutes.TabIndex = 11;
            this.grpOfferedRoutes.TabStop = false;
            this.grpOfferedRoutes.Text = "Offered Routes";
            // 
            // btnCoSave
            // 
            this.btnCoSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCoSave.Location = new System.Drawing.Point(654, 218);
            this.btnCoSave.Name = "btnCoSave";
            this.btnCoSave.Size = new System.Drawing.Size(90, 34);
            this.btnCoSave.TabIndex = 1;
            this.btnCoSave.Text = "Save Company";
            this.btnCoSave.UseVisualStyleBackColor = true;
            this.btnCoSave.Click += new System.EventHandler(this.btnCoSave_Click);
            // 
            // btnAddOffers
            // 
            this.btnAddOffers.Location = new System.Drawing.Point(654, 19);
            this.btnAddOffers.Name = "btnAddOffers";
            this.btnAddOffers.Size = new System.Drawing.Size(96, 27);
            this.btnAddOffers.TabIndex = 0;
            this.btnAddOffers.Text = "Add Route";
            this.btnAddOffers.UseVisualStyleBackColor = true;
            this.btnAddOffers.Click += new System.EventHandler(this.addOfferRoute);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpOfferedRoutes);
            this.Controls.Add(this.grpCoDetails);
            this.Name = "AddCompanyForm";
            this.Text = "AddCompanyForm";
            this.Load += new System.EventHandler(this.AddCompanyForm_Load);
            this.grpCoDetails.ResumeLayout(false);
            this.grpCoDetails.PerformLayout();
            this.grpOfferedRoutes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCoName;
        private System.Windows.Forms.TextBox tbCoName;
        private System.Windows.Forms.Label lblCoAddress;
        private System.Windows.Forms.TextBox tbCoAddress;
        private System.Windows.Forms.Label lblCoCode;
        private System.Windows.Forms.TextBox tbCoCode;
        private System.Windows.Forms.Label lblContactPerson;
        private System.Windows.Forms.TextBox tbCoContact;
        private System.Windows.Forms.Label lblCoPhone;
        private System.Windows.Forms.TextBox tbCoPhone;
        private System.Windows.Forms.GroupBox grpCoDetails;
        private System.Windows.Forms.GroupBox grpOfferedRoutes;
        private System.Windows.Forms.Button btnAddOffers;
        private System.Windows.Forms.Button btnCoSave;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
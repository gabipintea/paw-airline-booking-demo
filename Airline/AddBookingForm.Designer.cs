namespace Airline
{
    partial class AddBookingForm
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
            this.grpFlightDetails = new System.Windows.Forms.GroupBox();
            this.tbNoPers = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblNoPersons = new System.Windows.Forms.Label();
            this.tbLanding = new System.Windows.Forms.TextBox();
            this.lblLanding = new System.Windows.Forms.Label();
            this.tbTakeOff = new System.Windows.Forms.TextBox();
            this.lblTakeOff = new System.Windows.Forms.Label();
            this.dateTimeFlight = new System.Windows.Forms.DateTimePicker();
            this.lblFlightDate = new System.Windows.Forms.Label();
            this.grpPassenger = new System.Windows.Forms.GroupBox();
            this.btnSaveBooking = new System.Windows.Forms.Button();
            this.dgvPassengers = new System.Windows.Forms.DataGridView();
            this.grpPassDetails = new System.Windows.Forms.GroupBox();
            this.tbSSN = new System.Windows.Forms.TextBox();
            this.lblSSN = new System.Windows.Forms.Label();
            this.btnAddPassenger = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lvCompanies = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblAvailCo = new System.Windows.Forms.Label();
            this.errorProviderBookingAdd = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpFlightDetails.SuspendLayout();
            this.grpPassenger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengers)).BeginInit();
            this.grpPassDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBookingAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFlightDetails
            // 
            this.grpFlightDetails.Controls.Add(this.tbNoPers);
            this.grpFlightDetails.Controls.Add(this.btnSearch);
            this.grpFlightDetails.Controls.Add(this.lblNoPersons);
            this.grpFlightDetails.Controls.Add(this.tbLanding);
            this.grpFlightDetails.Controls.Add(this.lblLanding);
            this.grpFlightDetails.Controls.Add(this.tbTakeOff);
            this.grpFlightDetails.Controls.Add(this.lblTakeOff);
            this.grpFlightDetails.Controls.Add(this.dateTimeFlight);
            this.grpFlightDetails.Controls.Add(this.lblFlightDate);
            this.grpFlightDetails.Location = new System.Drawing.Point(14, 15);
            this.grpFlightDetails.Name = "grpFlightDetails";
            this.grpFlightDetails.Size = new System.Drawing.Size(769, 98);
            this.grpFlightDetails.TabIndex = 0;
            this.grpFlightDetails.TabStop = false;
            this.grpFlightDetails.Text = "Flight Details";
            // 
            // tbNoPers
            // 
            this.tbNoPers.Location = new System.Drawing.Point(711, 26);
            this.tbNoPers.Name = "tbNoPers";
            this.tbNoPers.Size = new System.Drawing.Size(31, 20);
            this.tbNoPers.TabIndex = 9;
            this.tbNoPers.Validating += new System.ComponentModel.CancelEventHandler(this.tbNoPers_Validating);
            this.tbNoPers.Validated += new System.EventHandler(this.tbNoPers_Validated);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(640, 67);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 25);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search Company";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblNoPersons
            // 
            this.lblNoPersons.AutoSize = true;
            this.lblNoPersons.Location = new System.Drawing.Point(615, 30);
            this.lblNoPersons.Name = "lblNoPersons";
            this.lblNoPersons.Size = new System.Drawing.Size(76, 13);
            this.lblNoPersons.TabIndex = 6;
            this.lblNoPersons.Text = "No. of persons";
            // 
            // tbLanding
            // 
            this.tbLanding.Location = new System.Drawing.Point(533, 26);
            this.tbLanding.Name = "tbLanding";
            this.tbLanding.Size = new System.Drawing.Size(67, 20);
            this.tbLanding.TabIndex = 5;
            this.tbLanding.Validating += new System.ComponentModel.CancelEventHandler(this.tbLanding_Validating);
            this.tbLanding.Validated += new System.EventHandler(this.tbLanding_Validated);
            // 
            // lblLanding
            // 
            this.lblLanding.AutoSize = true;
            this.lblLanding.Location = new System.Drawing.Point(454, 30);
            this.lblLanding.Name = "lblLanding";
            this.lblLanding.Size = new System.Drawing.Size(64, 13);
            this.lblLanding.TabIndex = 4;
            this.lblLanding.Text = "Landing city";
            // 
            // tbTakeOff
            // 
            this.tbTakeOff.Location = new System.Drawing.Point(364, 26);
            this.tbTakeOff.Name = "tbTakeOff";
            this.tbTakeOff.Size = new System.Drawing.Size(75, 20);
            this.tbTakeOff.TabIndex = 3;
            this.tbTakeOff.Validating += new System.ComponentModel.CancelEventHandler(this.tbTakeOff_Validating);
            this.tbTakeOff.Validated += new System.EventHandler(this.tbTakeOff_Validated);
            // 
            // lblTakeOff
            // 
            this.lblTakeOff.AutoSize = true;
            this.lblTakeOff.Location = new System.Drawing.Point(283, 30);
            this.lblTakeOff.Name = "lblTakeOff";
            this.lblTakeOff.Size = new System.Drawing.Size(66, 13);
            this.lblTakeOff.TabIndex = 2;
            this.lblTakeOff.Text = "Take-off city";
            // 
            // dateTimeFlight
            // 
            this.dateTimeFlight.Location = new System.Drawing.Point(84, 26);
            this.dateTimeFlight.Name = "dateTimeFlight";
            this.dateTimeFlight.Size = new System.Drawing.Size(184, 20);
            this.dateTimeFlight.TabIndex = 1;
            // 
            // lblFlightDate
            // 
            this.lblFlightDate.AutoSize = true;
            this.lblFlightDate.Location = new System.Drawing.Point(13, 30);
            this.lblFlightDate.Name = "lblFlightDate";
            this.lblFlightDate.Size = new System.Drawing.Size(56, 13);
            this.lblFlightDate.TabIndex = 0;
            this.lblFlightDate.Text = "Flight date";
            // 
            // grpPassenger
            // 
            this.grpPassenger.Controls.Add(this.btnSaveBooking);
            this.grpPassenger.Controls.Add(this.dgvPassengers);
            this.grpPassenger.Controls.Add(this.grpPassDetails);
            this.grpPassenger.Controls.Add(this.lvCompanies);
            this.grpPassenger.Controls.Add(this.lblAvailCo);
            this.grpPassenger.Location = new System.Drawing.Point(14, 119);
            this.grpPassenger.Name = "grpPassenger";
            this.grpPassenger.Size = new System.Drawing.Size(769, 319);
            this.grpPassenger.TabIndex = 1;
            this.grpPassenger.TabStop = false;
            this.grpPassenger.Text = "Travel Details";
            // 
            // btnSaveBooking
            // 
            this.btnSaveBooking.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveBooking.Location = new System.Drawing.Point(665, 229);
            this.btnSaveBooking.Name = "btnSaveBooking";
            this.btnSaveBooking.Size = new System.Drawing.Size(87, 28);
            this.btnSaveBooking.TabIndex = 64;
            this.btnSaveBooking.Text = "Save Booking";
            this.btnSaveBooking.UseVisualStyleBackColor = true;
            this.btnSaveBooking.Click += new System.EventHandler(this.btnSaveBooking_Click);
            // 
            // dgvPassengers
            // 
            this.dgvPassengers.AllowUserToAddRows = false;
            this.dgvPassengers.AllowUserToOrderColumns = true;
            this.dgvPassengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPassengers.Location = new System.Drawing.Point(117, 153);
            this.dgvPassengers.Name = "dgvPassengers";
            this.dgvPassengers.Size = new System.Drawing.Size(542, 166);
            this.dgvPassengers.TabIndex = 63;
            // 
            // grpPassDetails
            // 
            this.grpPassDetails.Controls.Add(this.tbSSN);
            this.grpPassDetails.Controls.Add(this.lblSSN);
            this.grpPassDetails.Controls.Add(this.btnAddPassenger);
            this.grpPassDetails.Controls.Add(this.label1);
            this.grpPassDetails.Controls.Add(this.tbLastName);
            this.grpPassDetails.Controls.Add(this.tbFirstName);
            this.grpPassDetails.Controls.Add(this.label2);
            this.grpPassDetails.Controls.Add(this.label3);
            this.grpPassDetails.Controls.Add(this.dtpBirthDate);
            this.grpPassDetails.Location = new System.Drawing.Point(117, 19);
            this.grpPassDetails.Name = "grpPassDetails";
            this.grpPassDetails.Size = new System.Drawing.Size(646, 119);
            this.grpPassDetails.TabIndex = 62;
            this.grpPassDetails.TabStop = false;
            this.grpPassDetails.Text = "Add Passenger";
            // 
            // tbSSN
            // 
            this.tbSSN.Location = new System.Drawing.Point(411, 72);
            this.tbSSN.Name = "tbSSN";
            this.tbSSN.Size = new System.Drawing.Size(120, 20);
            this.tbSSN.TabIndex = 54;
            this.tbSSN.Validating += new System.ComponentModel.CancelEventHandler(this.tbSSN_Validating);
            this.tbSSN.Validated += new System.EventHandler(this.tbSSN_Validated);
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(350, 77);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(29, 13);
            this.lblSSN.TabIndex = 53;
            this.lblSSN.Text = "SSN";
            // 
            // btnAddPassenger
            // 
            this.btnAddPassenger.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddPassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPassenger.ForeColor = System.Drawing.Color.White;
            this.btnAddPassenger.Location = new System.Drawing.Point(567, 69);
            this.btnAddPassenger.Name = "btnAddPassenger";
            this.btnAddPassenger.Size = new System.Drawing.Size(58, 23);
            this.btnAddPassenger.TabIndex = 52;
            this.btnAddPassenger.Text = "Add";
            this.btnAddPassenger.UseVisualStyleBackColor = false;
            this.btnAddPassenger.Click += new System.EventHandler(this.btnAddPassenger_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Last Name";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(102, 31);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(178, 20);
            this.tbLastName.TabIndex = 0;
            this.tbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.tbLastName_Validating);
            this.tbLastName.Validated += new System.EventHandler(this.tbLastName_Validated);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(102, 72);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(178, 20);
            this.tbFirstName.TabIndex = 2;
            this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tbFirstName_Validating);
            this.tbFirstName.Validated += new System.EventHandler(this.tbFirstName_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Birth Date";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(411, 29);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthDate.TabIndex = 5;
            // 
            // lvCompanies
            // 
            this.lvCompanies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvCompanies.FullRowSelect = true;
            this.lvCompanies.HideSelection = false;
            this.lvCompanies.Location = new System.Drawing.Point(4, 45);
            this.lvCompanies.Name = "lvCompanies";
            this.lvCompanies.Size = new System.Drawing.Size(107, 273);
            this.lvCompanies.TabIndex = 1;
            this.lvCompanies.UseCompatibleStateImageBehavior = false;
            this.lvCompanies.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Company";
            this.columnHeader1.Width = 102;
            // 
            // lblAvailCo
            // 
            this.lblAvailCo.AutoSize = true;
            this.lblAvailCo.Location = new System.Drawing.Point(6, 16);
            this.lblAvailCo.Name = "lblAvailCo";
            this.lblAvailCo.Size = new System.Drawing.Size(105, 13);
            this.lblAvailCo.TabIndex = 0;
            this.lblAvailCo.Text = "Available Companies";
            // 
            // errorProviderBookingAdd
            // 
            this.errorProviderBookingAdd.ContainerControl = this;
            // 
            // AddBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpPassenger);
            this.Controls.Add(this.grpFlightDetails);
            this.Name = "AddBookingForm";
            this.Text = "Add a Booking";
            this.Load += new System.EventHandler(this.AddBookingForm_Load);
            this.grpFlightDetails.ResumeLayout(false);
            this.grpFlightDetails.PerformLayout();
            this.grpPassenger.ResumeLayout(false);
            this.grpPassenger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengers)).EndInit();
            this.grpPassDetails.ResumeLayout(false);
            this.grpPassDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBookingAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFlightDetails;
        private System.Windows.Forms.TextBox tbLanding;
        private System.Windows.Forms.Label lblLanding;
        private System.Windows.Forms.TextBox tbTakeOff;
        private System.Windows.Forms.Label lblTakeOff;
        private System.Windows.Forms.DateTimePicker dateTimeFlight;
        private System.Windows.Forms.Label lblFlightDate;
        private System.Windows.Forms.Label lblNoPersons;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpPassenger;
        private System.Windows.Forms.Label lblAvailCo;
        private System.Windows.Forms.ListView lvCompanies;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.DataGridView dgvPassengers;
        private System.Windows.Forms.GroupBox grpPassDetails;
        private System.Windows.Forms.Button btnAddPassenger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.TextBox tbSSN;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.Button btnSaveBooking;
        private System.Windows.Forms.TextBox tbNoPers;
        private System.Windows.Forms.ErrorProvider errorProviderBookingAdd;
    }
}
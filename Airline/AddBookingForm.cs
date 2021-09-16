using Airline.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class AddBookingForm : Form
    {
        #region Attributes
        private const string ConnectionString = "Data Source=database.db";
        private Booking _booking;
        private readonly List<Route> _routes;
        private readonly BindingList<Passenger> _passengers;
        private readonly List<Company> _companies;
        private Company _company;
        private int GroupNo = 0;
        private long currId = 0;
        #endregion

        public AddBookingForm()
        {
            InitializeComponent();
            _companies = new List<Company>();
            _routes = new List<Route>();
            _passengers = new BindingList<Passenger>();
            _booking = new Booking();
        }

        #region Methods
        private void SearchRoutes(string startCity, string destCity)
        {
            const string stringSql = "SELECT * FROM Routes WHERE StartCity=@startCity AND DestCity=@destCity";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(stringSql, connection);
                command.Parameters.AddWithValue("@startCity", startCity);
                command.Parameters.AddWithValue("@destCity", destCity);

                using (SQLiteDataReader sqlReader = command.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        long id = (long)sqlReader["ID"];
                        string start = (string)sqlReader["StartCity"];
                        string dest = (string)sqlReader["DestCity"];
                        long coId = (long)sqlReader["CompanyID"];


                        Route route = new Route(id, start, dest, coId);
                        _routes.Add(route);
                    }
                }
            }
        }

        private void LoadCompanies(Route route)
        {
            const string stringSql = "SELECT * FROM Company WHERE ID = @coId";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(stringSql, connection);
                command.Parameters.AddWithValue("@coId", route.companyId);

                using (SQLiteDataReader sqlReader = command.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        long id = (long)sqlReader["ID"];
                        string code = (string)sqlReader["Code"];
                        string name = (string)sqlReader["Name"];
                        string addr = (string)sqlReader["Address"];
                        string contact = (string)sqlReader["Contact"];
                        string phone = (string)sqlReader["Phone"];


                        Company company = new Company(id, code, name, addr, contact, phone);
                        _companies.Add(company);
                    }
                }
            }
        }

        private void DisplayCompanies()
        {
            lvCompanies.Items.Clear();

            foreach (Company company in _companies)
            {
                var listViewItem = new ListViewItem(company.CompanyCode);
                listViewItem.SubItems.Add(company.Name);
                listViewItem.SubItems.Add(company.Address);
                listViewItem.SubItems.Add(company.ContactPerson);
                listViewItem.SubItems.Add(company.ContactPhone);

                listViewItem.Tag = company;

                lvCompanies.Items.Add(listViewItem);
            }
        }

        private void AddPassenger(Passenger passenger)
        {
            var query = "INSERT INTO Passenger(LastName, FirstName, BirthDate, SSN, GroupID) " +
               " VALUES (@LastName, @FirstName, @BirthDate, @SSN, @GroupID);" +
               " SELECT last_insert_rowid();";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@LastName", passenger.LastName);
                command.Parameters.AddWithValue("@FirstName", passenger.FirstName);
                command.Parameters.AddWithValue("@BirthDate", passenger.BirthDate.ToShortDateString());
                command.Parameters.AddWithValue("@SSN", passenger.SSN);
                command.Parameters.AddWithValue("@GroupID", GroupNo);


                connection.Open();

                long id = (long)command.ExecuteScalar();
                passenger.Id = id;
                //_booking._passengers.Add(passenger);

            }
        }

        private void AddBooking(Booking booking)
        {
            var query = "INSERT INTO Booking(RouteID, PassGroupID, NoPassengers, FlightDate) " +
               " VALUES (@RouteID, @GroupID, @NoPass, @FlightDate);" +
               " SELECT last_insert_rowid();";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@RouteID", booking.BookedRoute.Id);
                command.Parameters.AddWithValue("@GroupID", GroupNo);
                command.Parameters.AddWithValue("@NoPass", booking.NoOfPassengers);
                command.Parameters.AddWithValue("@FlightDate", booking.FlightDate.ToShortDateString());
               
                connection.Open();

                long id = (long)command.ExecuteScalar();
                booking.Id = id;
                

            }
        }

        private void LoadLatestGroupNo()
        {
            const string stringSql = "SELECT PassGroupID FROM Booking ORDER BY ID DESC LIMIT 1;";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(stringSql, connection);                

                using (SQLiteDataReader sqlReader = command.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        int id = int.Parse(sqlReader["PassGroupID"].ToString());

                        GroupNo = id;
                    }
                }
            }
        }

        private bool IsFieldValid(TextBox tb)
        {
            return !string.IsNullOrWhiteSpace(tb.Text.Trim());
        }


        #endregion

        #region Events
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                _booking.FlightDate = dateTimeFlight.Value;
            }
            catch(InvalidDateException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
            string startCity = tbTakeOff.Text;
            string destCity = tbLanding.Text;
            try
            {
                SearchRoutes(startCity, destCity);
            }
            catch(SQLiteException ex)
            {
                MessageBox.Show("No available route!" + ex.Message);
            }
            
            if(_routes.Count() > 0)
            {
                if (grpPassenger.Enabled == false)
                    grpPassenger.Enabled = true;
                foreach (Route route in _routes)
                    LoadCompanies(route);
                DisplayCompanies();
            }
            else
            {
                MessageBox.Show("No available route!");
                return;
            }
            
        }

        private void AddBookingForm_Load(object sender, EventArgs e)
        {
            if (grpPassenger.Enabled == true)
                grpPassenger.Enabled = false;

            LoadLatestGroupNo();

            dgvPassengers.DataSource = _passengers;
        }

        private void btnAddPassenger_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("The form contains errors!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;
            string ssn = tbSSN.Text;
            DateTime birthDate = dtpBirthDate.Value;

            try
            {
                var passenger = new Passenger(lastName, firstName, birthDate, ssn);
                _passengers.Add(passenger);
            }
            catch(InvalidDateException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception exe)
            {
                MessageBox.Show("Exception encountered:" + exe.Message);
            }
            

            tbFirstName.Text = tbLastName.Text = tbSSN.Text = string.Empty;
            dtpBirthDate.Value = DateTime.Today;
        }

        private void btnSaveBooking_Click(object sender, EventArgs e)
        {
            if (lvCompanies.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose an available company!");
                this.DialogResult = DialogResult.None;
                return;
            }            

            try
            {
                _booking.FlightDate = dateTimeFlight.Value;
            }
            catch(InvalidDateException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception exe)
            {
                MessageBox.Show("Exception encountered:" + exe.Message);
            }
            
            _booking.NoOfPassengers = int.Parse(tbNoPers.Text);
            GroupNo = GroupNo + 1;

            

            var last = lvCompanies.SelectedItems.Count;
            if (last >= 1)
            {
                _company = (Company)lvCompanies.SelectedItems[0].Tag;
                currId = _company.Id;                
            }

            foreach (Route route in _routes)
                if(route.companyId == currId)
                {
                    _booking.BookedRoute = route;
                    break;
                }
            foreach (Passenger passenger in _passengers)
            {
                AddPassenger(passenger);
            }

            AddBooking(_booking);            
        }

        #region ErrorHandling
        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            if (!IsFieldValid(tbLastName))
            {
                e.Cancel = true;
                errorProviderBookingAdd.SetError((Control)sender, "Last Name is empty!");
            }
        }

        private void tbLastName_Validated(object sender, EventArgs e)
        {
            errorProviderBookingAdd.SetError((Control)sender, string.Empty);
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (!IsFieldValid(tbFirstName))
            {
                e.Cancel = true;
                errorProviderBookingAdd.SetError((Control)sender, "First Name is empty!");
            }
        }
        private void tbFirstName_Validated(object sender, EventArgs e)
        {
            errorProviderBookingAdd.SetError((Control)sender, string.Empty);

        }
        private void tbSSN_Validating(object sender, CancelEventArgs e)
        {
            if (!IsFieldValid(tbSSN))
            {
                e.Cancel = true;
                errorProviderBookingAdd.SetError((Control)sender, "SSN is empty!");
            }
        }
        private void tbSSN_Validated(object sender, EventArgs e)
        {
            errorProviderBookingAdd.SetError((Control)sender, string.Empty);
        }
        private void tbTakeOff_Validating(object sender, CancelEventArgs e)
        {
            if (!IsFieldValid(tbTakeOff))
            {
                e.Cancel = true;
                errorProviderBookingAdd.SetError((Control)sender, "Start City is empty!");
            }
        }

        private void tbTakeOff_Validated(object sender, EventArgs e)
        {
            errorProviderBookingAdd.SetError((Control)sender, string.Empty);
        }

        private void tbLanding_Validating(object sender, CancelEventArgs e)
        {
            if (!IsFieldValid(tbLanding))
            {
                e.Cancel = true;
                errorProviderBookingAdd.SetError((Control)sender, "Destination is empty!");
            }
        }
        private void tbLanding_Validated(object sender, EventArgs e)
        {
            errorProviderBookingAdd.SetError((Control)sender, string.Empty);
        }
        private void tbNoPers_Validating(object sender, CancelEventArgs e)
        {
            if (!IsFieldValid(tbNoPers))
            {
                e.Cancel = true;
                errorProviderBookingAdd.SetError((Control)sender, "Number of passengers is empty!");
            }
        }

        private void tbNoPers_Validated(object sender, EventArgs e)
        {
            errorProviderBookingAdd.SetError((Control)sender, string.Empty);
        }
        #endregion

        #endregion


    }
}

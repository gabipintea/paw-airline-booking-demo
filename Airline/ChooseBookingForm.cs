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
    public partial class ChooseBookingForm : Form
    {

        #region Attributes
        private const string ConnectionString = "Data Source=database.db";
        private readonly List<Booking> _bookings;
        #endregion

        public ChooseBookingForm()
        {
            InitializeComponent();
            _bookings = new List<Booking>();
        }

        #region Methods
        private void DisplayBookings()
        {
            lvLatestBookings.Items.Clear();

            foreach (Booking booking in _bookings)
            {
                var listViewItem = new ListViewItem(booking.Id.ToString());
                listViewItem.SubItems.Add(booking.FlightDate.ToShortDateString());
                listViewItem.SubItems.Add(booking.NoOfPassengers.ToString());
                listViewItem.SubItems.Add(booking.BookedRoute.StartCity.ToString());
                listViewItem.SubItems.Add(booking.BookedRoute.DestinationCity.ToString());
                listViewItem.Tag = booking;

                lvLatestBookings.Items.Add(listViewItem);
            }
        }

        private List<Passenger> LoadPassengers(int groupId)
        {
            const string stringSql = "SELECT * FROM Passenger WHERE GroupID = @groupId";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(stringSql, connection);
                command.Parameters.AddWithValue("@groupId", groupId);

                using (SQLiteDataReader sqlReader = command.ExecuteReader())
                {
                    List<Passenger> passengers = new List<Passenger>();
                    while (sqlReader.Read())
                    {
                        long id = (long)sqlReader["ID"];
                        string lastName = (string)sqlReader["LastName"];
                        string firstName = (string)sqlReader["FirstName"];
                        DateTime birthDate = DateTime.Parse((string)sqlReader["BirthDate"]);
                        string SSN = (string)sqlReader["SSN"];
                        int group = int.Parse(sqlReader["GroupID"].ToString());

                        Passenger currPassenger = new Passenger(id, lastName, firstName, birthDate, SSN);
                        passengers.Add(currPassenger);
                    }

                    return passengers;
                }
            }
        }

        private Route LoadRoute(int routeId)
        {
            const string stringSql = "SELECT * FROM Routes WHERE ID = @routeId";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(stringSql, connection);
                command.Parameters.AddWithValue("@routeId", routeId);

                using (SQLiteDataReader sqlReader = command.ExecuteReader())
                {
                    Route route = new Route();
                    while (sqlReader.Read())
                    {
                        long id = (long)sqlReader["ID"];
                        string startCity = (string)sqlReader["StartCity"];
                        string endCity = (string)sqlReader["DestCity"];
                        long coId = (long)sqlReader["CompanyID"];

                        route.Id = id;
                        route.StartCity = startCity;
                        route.DestinationCity = endCity;
                        route.companyId = coId;

                    }
                    return route;
                }


            }
        }

        private void LoadLatestBookings()
        {
            _bookings.Clear();
            const string stringSql = "SELECT * FROM Booking";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(stringSql, connection);

                using (SQLiteDataReader sqlReader = command.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        long id = (long)sqlReader["ID"];
                        int routeId = int.Parse(sqlReader["RouteID"].ToString());
                        int groupId = int.Parse(sqlReader["PassGroupID"].ToString());
                        int noPass = int.Parse(sqlReader["NoPassengers"].ToString());
                        string flight = (string)sqlReader["FlightDate"];

                        DateTime flightDate = DateTime.Parse(flight);

                        List<Passenger> _passengers = new List<Passenger>();
                        _passengers = LoadPassengers(groupId);

                        Route route = LoadRoute(routeId);

                        Booking booking = new Booking(id, flightDate, route, noPass, _passengers);

                        _bookings.Add(booking);
                    }
                }
            }
        }
        #endregion

        private void ChooseBookingForm_Load(object sender, EventArgs e)
        {
            LoadLatestBookings();
            DisplayBookings();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (lvLatestBookings.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose an existing booking!");
                return;
            }

            var last = lvLatestBookings.SelectedItems.Count;
            if (last >= 1)
            {
                Booking booking = (Booking)lvLatestBookings.SelectedItems[0].Tag;
                EditBookingForm editBooking = new EditBookingForm(booking);
                if (editBooking.ShowDialog() == DialogResult.OK)
                {
                    LoadLatestBookings();
                    DisplayBookings();
                }

            }
        }
    }
}

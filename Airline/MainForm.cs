using Airline.Entities;
using FastTicket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Airline
{
    public partial class MainForm : Form
    {
        #region Attributes
        private const string ConnectionString = "Data Source=database.db";
        private readonly List<Booking> _bookings;
        #endregion

        public MainForm()
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
                var listViewItem = new ListViewItem(booking.FlightDate.ToShortDateString());                
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

        private void ShowXML(List<Booking> bookings)
        {
            ShowXMLForm xMLForm = new ShowXMLForm(bookings);
            xMLForm.ShowDialog();
        }

        private void generateStatistics()
        {
            LineChartValues[] values = new LineChartValues[_bookings.Count];

            for (int i = 0; i < _bookings.Count; i++)
            {
                values[i] = new LineChartValues(_bookings[i].Id.ToString(), _bookings[i].NoOfPassengers);
            }
            LineChartControl line = new LineChartControl(values);
            Label lblNoPass = new Label();
            
            grpStats.Controls.Add(line);
            grpStats.Controls.Add(lblNoPass);
            line.Size = new Size(326, 229);
            line.Location = new Point(17, 70);
            line.Name = "myFirstLine";
            line.Hide();

            lblNoPass.Name = "lblNoPass";
            lblNoPass.Text = "Persons/booking";
            lblNoPass.Size = new Size(100, 13);
            lblNoPass.Location = new Point(124, 41);
            lblNoPass.Hide();

        }

        private void generateCalculator()
        {
            FastCalculatorControl calc = new FastCalculatorControl();
            grpStats.Controls.Add(calc);
            calc.Name = "fastCalculator";
            calc.Size = new Size(326, 229);
            calc.Location = new Point(17, 70);
            calc.Hide();
        }

        private void refreshStatistics()
        {
            LineChartValues[] values = new LineChartValues[_bookings.Count];

            for (int i = 0; i < _bookings.Count; i++)
            {
                values[i] = new LineChartValues(_bookings[i].Id.ToString(), _bookings[i].NoOfPassengers);
            }           

            LineChartControl line = (LineChartControl)grpStats.Controls["myFirstLine"];
            line.Data = values;
            line.Invalidate();            
        }

        private void refreshAll()
        {
            LoadLatestBookings();
            DisplayBookings();
            refreshStatistics();
        }
        #endregion

        #region Events
        private void miAddBooking(object sender, EventArgs e)
        {
            AddBookingForm addBooking = new AddBookingForm();
            if(addBooking.ShowDialog() == DialogResult.OK)
            {
                LoadLatestBookings();
                DisplayBookings();
            }
        }

        private void miAddCompany(object sender, EventArgs e)
        {
            AddCompanyForm addCompany = new AddCompanyForm();
            addCompany.ShowDialog();
        }

        private void editCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCompanyForm editCompany = new EditCompanyForm();
            editCompany.ShowDialog();
        }

        private void addRouteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRouteForm addRoute = new AddRouteForm();
            addRoute.ShowDialog();
        }

        private void editRouteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditRouteForm editRoute = new EditRouteForm();
            editRoute.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadLatestBookings();
            DisplayBookings();
            generateStatistics();
            generateCalculator();
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Booking>));
            using (FileStream s = File.Create("SerializedXML.xml"))
            {
                serializer.Serialize(s, _bookings);
                MessageBox.Show("XML File Created!");
            }

        }

        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Booking> bookings = new List<Booking>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Booking>));
            using (FileStream s = File.OpenRead("SerializedXML.xml"))
            {
                bookings = (List<Booking>)serializer.Deserialize(s);
                ShowXML(bookings);
            }
        }

        private void exportReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File | *.txt";
            saveFileDialog.Title = "Save as text file";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine("Booking ID, No of passengers, FlightDate, From, To");

                    foreach (var booking in _bookings)
                    {
                        sw.WriteLine("{0}, {1}, {2}, {3}, {4}"
                            , booking.Id.ToString()
                            , booking.NoOfPassengers.ToString()
                            , booking.FlightDate.ToShortDateString()
                            , booking.BookedRoute.StartCity.ToString()
                            , booking.BookedRoute.DestinationCity.ToString());
                    }
                    MessageBox.Show("Text report exported!");
                }
            }
        }

        private void lvLatestBookings_SelectedIndexChanged(object sender, EventArgs e)
        {

            var last = lvLatestBookings.SelectedItems.Count;
            if (last >= 1)
            {
                tlStatus.Text = lvLatestBookings.SelectedItems[0].SubItems[0].Text;
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            LoadLatestBookings();

            Control ctn = grpStats.Controls["fastCalculator"];
            ctn.Hide();

            if (_bookings.Count >= 0)
            {
                ctn = grpStats.Controls["myFirstLine"];
                ctn.Show();
                ctn = grpStats.Controls["lblNoPass"];
                ctn.Show();
            }
            else
            {
                MessageBox.Show("No statistics for the moment");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Control ctn = grpStats.Controls["myFirstLine"];
            ctn.Hide();
            ctn = grpStats.Controls["lblNoPass"];
            ctn.Hide();
            ctn = grpStats.Controls["fastCalculator"];
            ctn.Show();  

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.B || e.Control && e.KeyCode == Keys.B)
            {
                AddBookingForm bookingForm = new AddBookingForm();
                bookingForm.Show();
            }
            if (e.Alt && e.KeyCode == Keys.R || e.Control && e.KeyCode == Keys.R)
            {
                AddRouteForm routeForm = new AddRouteForm();
                routeForm.Show();
            }
            if (e.Alt && e.KeyCode == Keys.C || e.Control && e.KeyCode == Keys.C)
            {
                AddCompanyForm companyForm = new AddCompanyForm();
                companyForm.Show();
            }
        }

        private void editBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseBookingForm chooseBooking = new ChooseBookingForm();
            if(chooseBooking.ShowDialog() == DialogResult.OK)
            {
                LoadLatestBookings();
                DisplayBookings();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshAll();
        }
    }
    #endregion


}

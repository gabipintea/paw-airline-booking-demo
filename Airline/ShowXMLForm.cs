using Airline.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class ShowXMLForm : Form
    {
        private readonly List<Booking> _bookings;
        public ShowXMLForm(List<Booking> bookings)
        {
            _bookings = new List<Booking>();
            foreach (Booking booking in bookings)
            {
                _bookings.Add(booking);
            }

            InitializeComponent();
        }

        private void DisplayBookings()
        {
            lvXmlBookings.Items.Clear();

            foreach (Booking booking in _bookings)
            {
                var listViewItem = new ListViewItem(booking.Id.ToString());
                listViewItem.SubItems.Add(booking.FlightDate.ToShortDateString());
                listViewItem.SubItems.Add(booking.BookedRoute.Id.ToString());                
                listViewItem.SubItems.Add(booking.BookedRoute.StartCity.ToString());
                listViewItem.SubItems.Add(booking.BookedRoute.DestinationCity.ToString());
                listViewItem.SubItems.Add(booking.NoOfPassengers.ToString());


                lvXmlBookings.Items.Add(listViewItem);
            }
        }

        private void ShowXMLForm_Load(object sender, EventArgs e)
        {
            DisplayBookings();
        }
    }
}

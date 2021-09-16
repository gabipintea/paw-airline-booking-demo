using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline.Entities
{
    public class Booking
    {
        public long Id { get; set; }
        #region FlightDate
        private DateTime _flightDate;
        public DateTime FlightDate
        {
            get { return _flightDate; }
            set
            {
                if (value < DateTime.Today)
                    throw new InvalidDateException(value);
                _flightDate = value;
            }
        }
        #endregion
        public Route BookedRoute { get; set; }
        public int NoOfPassengers { get; set; }
        public List<Passenger> _passengers;

        public Booking(DateTime flightDate, Route bookedRoute, int noOfPassengers, List<Passenger> passengers)
        {
            FlightDate = flightDate;
            BookedRoute = bookedRoute;
            NoOfPassengers = noOfPassengers;

            _passengers = new List<Passenger>();
            foreach (Passenger passenger in passengers)
            {
                _passengers.Add(passenger);
            }
        }

        public Booking(long id, DateTime flightDate, Route bookedRoute, int noOfPassengers, List<Passenger> passengers)
            :this(flightDate,  bookedRoute,  noOfPassengers, passengers)
        {
            Id = id;
        }

        public Booking()
        {
        }
    }
}

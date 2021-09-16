using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airline.Entities;

namespace Airline.Entities
{
    public class Passenger
    {
        public long Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        #region BirthDate
        private DateTime _birthDate;
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set
            {
                if (value >= DateTime.Today)
                    throw new InvalidDateException(value);
                _birthDate = value;
            }
        }
        #endregion

        public string SSN { get; set; }

        public Passenger(string lastName, string firstName, DateTime birthDate,string ssn)
        {
            LastName = lastName;
            FirstName = firstName;
            BirthDate = birthDate;            
            SSN = ssn;
        }

        public Passenger(long id, string lastName, string firstName, DateTime birthDate, string ssn)
            :this( lastName,  firstName,  birthDate,  ssn)
        {
            Id = id;
        }

        public Passenger()
        {

        }
    }
}

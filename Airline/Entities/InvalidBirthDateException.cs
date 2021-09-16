using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline.Entities
{
    class InvalidDateException : Exception
    {
        public DateTime Date { get; set; }

        public InvalidDateException(DateTime Day)
        {
            Date = Day;
        }

        public override string Message
        {
            get
            {
                return "The Date " + Date + " is invalid";
            }
        }
    }
}

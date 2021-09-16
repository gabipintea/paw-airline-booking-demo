using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline.Entities
{
    public class Route
    {
        public long Id { get; set; }
        public string StartCity { get; set; }
        public string DestinationCity { get; set; }
        public long companyId { get; set; }

        public Route(string startCity, string destinationCity, long coId)
        {
            StartCity = startCity;
            DestinationCity = destinationCity;
            companyId = coId;
        }

        public Route(long id, string startcity, string destcity, long coId)
            : this(startcity,destcity, coId)
        {
            Id = id;
        }

        public Route()
        {
        }
    }
}

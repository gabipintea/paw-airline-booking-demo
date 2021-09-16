using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline.Entities
{
    internal class Company
    {
        public long Id { get; set; }
        public string CompanyCode { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPhone { get; set; }

        public Company(string companyCode, string name, string address, string contactPerson, string contactPhone)
        {
            CompanyCode = companyCode;
            Name = name;
            Address = address;
            ContactPerson = contactPerson;
            ContactPhone = contactPhone;
            
           
        }
        public Company(long id, string companyCode, string name, string address, string contactPerson, string contactPhone)
            : this( companyCode,  name,  address,  contactPerson,  contactPhone)
        {
            Id = id;
        }



    }
}

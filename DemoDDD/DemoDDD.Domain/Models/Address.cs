using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDDD.Domain.Models
{
    public class Address
    {
        public string Province { get; set; }

        public string City { get; set; }

        public string County { get; set; }

        public string Street { get; set; }

        public Address()
        {

        }

        public Address(string province, string city,
            string county, string street)
        {
            this.Province = province;
            this.City = city;
            this.County = county;
            this.Street = street;
        }



    }
}

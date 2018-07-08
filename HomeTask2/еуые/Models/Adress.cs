using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace еуые.Models
{
    public class Adress
    {
        private int id;
        private string country;
        private string city;
        private string street;
        private int userId;
        private string zip;

        public int Id { get { return id; } }
        public string Country { get { return country; } }
        public string City { get { return city; } }
        public string Street { get { return street; } }
        public int UserId { get { return userId; } }

        public string Zip { get { return zip; } }

        public Adress(int id, string country, string city, string street, int userId, string zip)
        {
            this.id = id;
            this.city = city;
            this.country = country;
            this.street = street;
            this.userId = userId;
            this.zip = zip;
        }
     
    }
}
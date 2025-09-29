using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace App.School.v3.Entities
{
    public class SchoolData : AuditedEntity<int>
    {
        public SchoolData(string name, string address, int idCity, string postalCode, string directorName, string phone)
        {
            Name = name;
            Address = address;
            IdCity = idCity;
            PostalCode = postalCode;
            DirectorName = directorName;
            Phone = phone;
        }

        public SchoolData Create(string name, string address, int idCity, string postalCode, string directorName, string phone)
        {
          
            return new SchoolData(name,address,idCity,postalCode,directorName,phone);
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public int IdCity { get; set; }
        public City? City { get; set; }
        public string PostalCode { get; set; }
        public string DirectorName { get; set; }
        public string Phone { get; set; }
    }
}

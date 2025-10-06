using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;

namespace App.School.v3.Students.DTOs
{
    public class StudentDto : EntityDto<int>
    {
        public string Name { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        #region Tax info
        public string TaxCode { get; set; } 
        public string TaxAddress { get; set; }
        public string TaxEmailAdress { get; set; }
        public string TaxFullName { get; set; }
        #endregion

        public DateTime Bithday { get; set; }
        public int Age { get; set; } = 0;
        public int GroupId { get; set; }

        public int SchoolDataId { get; set; }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.School.v3.Common.Dtos
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime Bithday { get; set; }
        public int Age { get; set; } = 0;
        public string GroupName { get; set; }=string.Empty;
    }

    public class StudentRequestDto
    {
      
        public string Name { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime Bithday { get; set; }
        public int Age { get; set; } = 0;
        public int GroupId { get; set; } = 0;
    }
}

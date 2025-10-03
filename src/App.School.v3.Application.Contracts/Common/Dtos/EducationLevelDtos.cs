using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.School.v3.Common.Dtos
{
    public class EducationLevelDtos
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class AddEducationLevelDto {
       
        public string Name { get; set; }
    }
}

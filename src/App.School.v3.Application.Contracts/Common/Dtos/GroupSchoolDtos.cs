using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.School.v3.Common.Dtos
{
    public class GroupSchoolDtos
    {
        public int Id { get; set; }
        public string Name { get; set; } =string.Empty;
       
    }

    public class AddUpdateGroupSchool {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int GradeId { get; set; }
    }
}

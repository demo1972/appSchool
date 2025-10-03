using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.School.v3.Common.Dtos
{
    public class GradesDto
    {
        public int Id { get; set; }
        public string Name { get; set; }= string.Empty;
        public string EductationLevel { get; set; } =string.Empty;
    }
    public class AddUpdateGradeDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int EducationLevelId { get; set; }
    }
}

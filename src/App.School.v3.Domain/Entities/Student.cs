

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace App.School.v3.Entities
{
    public class Student :AuditedEntity <int>
    {
        public string Name { get; set; } = string.Empty;



        public string MiddleName { get; set; } = string.Empty;


        public string LastName { get; set; } = string.Empty;

        public DateTime Bithday { get; set; }

        public int Age { get; set; } = 0;

        public List<DocumentStudent>? Documents { get; set; } = new List<DocumentStudent>();
        public List<Tutor>? Tutors { get; set; } = new List<Tutor>();
        public int GroupId { get; set; }
        public GroupSchool? Group { get; set; }
        public List<StudentNote>? Notes { get; set; }



    }
}

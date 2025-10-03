
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace App.School.v3.Entities
{
    public class EducationLevel : FullAuditedEntity<int>
    {
        public string Name { get; set; }
        public List<Grade> Grades { get; set; } = new();

        public EducationLevel(string name) {
            Name=name;
        }

        public static EducationLevel Create(string name) {
            return new EducationLevel(name);
        }
        public EducationLevel Update(string name) { Name = name; return this; }


    }
}

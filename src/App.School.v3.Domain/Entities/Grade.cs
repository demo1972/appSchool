
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace App.School.v3.Entities
{
    public class Grade : AuditedEntity<int>
    {
        public Grade(string name, int educationLevelId)
        {
            Name = name;
            EducationLevelId = educationLevelId;
        }

        public string Name { get; set; }
        public int EducationLevelId { get; set; }

        public Grade Create(string name, int educationLevelId)
        {
            return new Grade(name, educationLevelId);
        }
        public Grade Update(string name, int educationLevelId)
        {
            Name = name;
            EducationLevelId = educationLevelId;
            return this;
        }
        public EducationLevel? EducationLevel { get; set; }

        public List<GroupSchool> Groups { get; set; } = new();
    }
}

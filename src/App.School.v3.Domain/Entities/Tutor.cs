

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace App.School.v3.Entities
{

    public class Tutor : FullAuditedEntity<int>
    {
        public string CompleteName { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;
        public List<Student> Students { get; set; } = new List<Student>();
    }
}

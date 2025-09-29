

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace App.School.v3.Entities
{
    public class Teacher : AuditedEntity<int>
    {
        public string CompleteName { get; set; } = string.Empty;
        public List<StudentNote> Notes { get; set; } = new();
    }
}

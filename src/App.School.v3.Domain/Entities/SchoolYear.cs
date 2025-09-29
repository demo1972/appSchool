

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace App.School.v3.Entities
{
    public class SchoolYear : AuditedEntity<int>
    {
        public string Name { get; set; }   = string.Empty;

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public List<StudentPayment> StudentPayments { get; set; } = new();

    }
}

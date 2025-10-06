

using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace App.School.v3.Entities
{
    public class SchoolYear : FullAuditedEntity<int>
    {
        public string Name { get; set; }   = string.Empty;

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public List<Payment> StudentPayments { get; set; } = new();

        public int SchoolDataId { get; set; }
        public SchoolData SchoolData { get; set; }

    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace App.School.v3.Entities
{
    public class StudentPayment :AuditedEntity<Guid>
    {
     

        public int StudentId { get; set; }
        public Student? Student { get; set; }

        public int PaymentConceptId { get; set; }
        public PaymentConcept? PaymentConcept { get; set; }

        public DateTime PaymentDate { get; set; } = DateTime.Now;

        public decimal AmountPaid { get; set; }

        public int? SchoolYearId { get; set; }
        public SchoolYear? SchoolYear { get; set; }

        public string Month { get; set; }  = string.Empty;

        public string Notes { get; set; } = string.Empty;

        public PaymentStatus Status { get; set; } = PaymentStatus.Paid;
    }

    public enum PaymentStatus
    {
        Pending,
        Paid,
        Partial
    }
}

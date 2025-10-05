using Volo.Abp.Domain.Entities.Auditing;

namespace App.School.v3.Entities
{
    public class PaymentConcept : FullAuditedEntity<int>
    {
        public string? Name { get; set; } 

        public decimal DefaultAmount { get; set; }

        public bool IsRecurring { get; set; }

        public int SchoolDataId { get; set; }
        public SchoolData SchoolData { get; set; }
    }
}

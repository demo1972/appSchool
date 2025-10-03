

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace App.School.v3.Entities
{
    public class PaymentConcept : FullAuditedEntity<int>
    {
        public string? Name { get; set; } // Ej: "Colegiatura", "Libros", "Uniformes"

        public decimal DefaultAmount { get; set; }

        public bool IsRecurring { get; set; } // true si es mensual
    }
}

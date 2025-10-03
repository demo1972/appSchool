
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace App.School.v3.Entities
{
    public class Country : FullAuditedEntity<int>
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<State> States { get; set; } = new List<State>();
    }
}

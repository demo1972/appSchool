

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace App.School.v3.Entities
{
    public class State : FullAuditedEntity<int>
    {
        public string Name { get; set; } = string.Empty;

        public int IdCountry { get; set; }
        public Country? Country { get; set; }

        public ICollection<City> Cities { get; set; } = new List<City>();
    }
}

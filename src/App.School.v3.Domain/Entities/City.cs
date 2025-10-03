
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace App.School.v3.Entities
{
    public class City :FullAuditedEntity<int>
    {
        public City()
        {
        }

        public City(string name, int idState)
        {
            Name = name;
            IdState = idState;
        }

        public string Name { get; set; } = string.Empty;
        public int IdState { get; set; } = 1;
        public State? State { get; set; }
        public ICollection<SchoolData> Schools { get; set; } = new List<SchoolData>();
    }
}

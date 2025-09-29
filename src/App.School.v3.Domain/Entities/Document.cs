
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace App.School.v3.Entities
{
    public class DocumentStudent : AuditedEntity<int>
    {
        public DocumentStudent(string typeDocument, string url, int studentId)
        {
            TypeDocument = typeDocument;
            Url = url;
            StudentId = studentId;
        }

        public string TypeDocument { get; set; }
        public string Url { get; set; }

        public int StudentId { get; set; }
        public Student? Student { get; set; }
    }
}

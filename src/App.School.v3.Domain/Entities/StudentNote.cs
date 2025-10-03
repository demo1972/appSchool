

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace App.School.v3.Entities
{

    public class StudentNote :FullAuditedEntity<int>
    {
        public int StudentId { get; set; }
        public Student? Student { get; set; }

        public string Title { get; set; }  = string.Empty;
        public string Content { get; set; } = string.Empty;

        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public NoteType Type { get; set; } = NoteType.General;
    }
    public enum NoteType
    {
        General,
        Comportamiento,
        Académico,
        Asistencia
    }
}

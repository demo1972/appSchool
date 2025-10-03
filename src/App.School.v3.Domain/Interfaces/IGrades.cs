using App.School.v3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.School.v3.Interfaces
{
    public interface IGrades
    {
        Task<List<Grade>> GetPaginated(int skipCount, int MaxResultCount, string? sorted);
    }
}

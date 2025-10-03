using App.School.v3.DTLs;
using App.School.v3.Entities;
using App.School.v3.EntityFrameworkCore;
using App.School.v3.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace App.School.v3.Repositories
{
    public class EFCoreGradesRepository :EfCoreRepository<v3DbContext, GradeDTL>, IGrades
    {
        private readonly IRepository<Grade> _repository;
        private readonly ILogger<EFCoreGradesRepository> _logger;

        public EFCoreGradesRepository(IDbContextProvider<v3DbContext> dbContextProvider, IRepository<Grade> repository, ILogger<EFCoreGradesRepository> logger) : base(dbContextProvider)
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task<List<Grade>> GetPaginated(int skipCount, int MaxResultCount, string? sorted) {
            var queryable = await _repository.WithDetailsAsync();
            queryable = queryable.Include(x=>x.EducationLevel).Skip(skipCount).Take(MaxResultCount);
            var listGrade = await queryable.ToListAsync();
            return listGrade;
        }
    }
}

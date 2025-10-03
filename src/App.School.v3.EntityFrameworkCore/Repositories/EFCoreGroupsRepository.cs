using App.School.v3.DTLs;
using App.School.v3.Entities;
using App.School.v3.EntityFrameworkCore;
using App.School.v3.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace App.School.v3.Repositories
{
    public class EFCoreGroupsRepository : EfCoreRepository<v3DbContext, GroupsDTL>, IGroups
    {
        private readonly IRepository<GroupSchool> _groupRepository;
        private readonly ILogger<EFCoreGroupsRepository> _logger;
        public EFCoreGroupsRepository(IDbContextProvider<v3DbContext> dbContextProvider, IRepository<GroupSchool> groupRepository, ILogger<EFCoreGroupsRepository> logger) : base(dbContextProvider)
        {
            _groupRepository = groupRepository;
            _logger = logger;
        }

        public async Task<List<GroupSchool>> GetPaginated(int skipCount, int MaxResultCount, string? sorted)
        {
            var queryable = await _groupRepository.WithDetailsAsync();
            queryable = queryable.Include(x => x.Grade).ThenInclude(x=>x.EducationLevel).Skip(skipCount).Take(MaxResultCount);
            var listGroups = await queryable.ToListAsync();
            return listGroups;
        }
    }
}

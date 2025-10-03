using App.School.v3.Common.Dtos;
using App.School.v3.Entities;
using App.School.v3.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace App.School.v3.Groups
{
    public class GroupsService :ApplicationService
    {
        public readonly IRepository<GroupSchool> _repositroryGroup;
        public readonly IGroups _groupsInterface;
        public readonly ILogger<GroupsService> _logger;

        public GroupsService(IRepository<GroupSchool> repositroryGroup, ILogger<GroupsService> logger, IGroups groupsInterface)
        {
            _repositroryGroup = repositroryGroup;
            _logger = logger;
            _groupsInterface = groupsInterface;
        }
        public async Task<AddUpdateGroupSchool> CreateAsync(AddUpdateGroupSchool request)
        {
            var group = new GroupSchool(request.Name, request.GradeId);
            var newGRade = await _repositroryGroup.InsertAsync(group);

            var resultMapped = ObjectMapper.Map<GroupSchool, AddUpdateGroupSchool>(newGRade);

            return resultMapped;

        }

        public async Task<List<GroupSchoolDtos>> GetPaginatedAsync(PagedAndSortedResultRequestDto pagination, CancellationToken token)
        {

            var listGrades = await _groupsInterface.GetPaginated(pagination.SkipCount, pagination.MaxResultCount, pagination.Sorting);

            var resultMapped = ObjectMapper.Map<List<GroupSchool>, List<GroupSchoolDtos>>(listGrades);

            return resultMapped;
        }

        public async Task<AddUpdateGroupSchool> UpdateAsync(AddUpdateGroupSchool request)
        {
            var groupUpdated = await _repositroryGroup.GetAsync(x => x.Id == request.Id);
            groupUpdated.Upadate(request.Name,request.GradeId);
            await _repositroryGroup.UpdateAsync(groupUpdated);

            var resultMapped = ObjectMapper.Map<GroupSchool, AddUpdateGroupSchool>(groupUpdated);

            return resultMapped;

        }

    }
}

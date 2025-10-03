using App.School.v3.Common.Dtos;
using App.School.v3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace App.School.v3.EducationLevels
{
    public class EducationLevelService :ApplicationService
    { 
        private readonly IRepository<EducationLevel> _educationLevelRepository;

        public EducationLevelService(IRepository<EducationLevel> educationLevelRepository)
        {
            _educationLevelRepository = educationLevelRepository;
        }

        public async Task<EducationLevelDtos> CreateAsync(AddEducationLevelDto request) {
            var educationLeve = new EducationLevel(request.Name);
            var newEdu= await _educationLevelRepository.InsertAsync(educationLeve);

            var resultMapped = ObjectMapper.Map<EducationLevel,EducationLevelDtos>(newEdu);

            return resultMapped;
        
        }

        public async Task<List<EducationLevelDtos>> GetPaginatedAsync(PagedAndSortedResultRequestDto pagination,CancellationToken token) {

            var listEducation =await  _educationLevelRepository.GetPagedListAsync(pagination.SkipCount, pagination.MaxResultCount, pagination.Sorting,false, token);

            var resultMapped = ObjectMapper.Map<List<EducationLevel>, List<EducationLevelDtos>>(listEducation);

            return resultMapped;
        }

        public async Task<EducationLevelDtos> UpdateAsync(EducationLevelDtos request)
        {
            var educationLeve = await _educationLevelRepository.GetAsync(x => x.Id == request.Id);
            educationLeve.Update(request.Name);
            await _educationLevelRepository.UpdateAsync(educationLeve);

            var resultMapped = ObjectMapper.Map<EducationLevel, EducationLevelDtos>(educationLeve);

            return resultMapped;

        }

    }
}

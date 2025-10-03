using App.School.v3.Common.Dtos;
using App.School.v3.Entities;
using App.School.v3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace App.School.v3.Grades
{
    public class GradesService :ApplicationService
    {
        private readonly IRepository<Grade> _gradesRepository;
        private readonly IGrades _gradeInterface;
        public GradesService(IRepository<Grade> gradesRepository, IGrades gradeInterface)
        {
            _gradesRepository = gradesRepository;
            _gradeInterface = gradeInterface;
        }


        public async Task<AddUpdateGradeDto> CreateAsync(AddUpdateGradeDto request)
        {
            var grade = new Grade(request.Name,request.EducationLevelId);
            var newGRade = await _gradesRepository.InsertAsync(grade);

            var resultMapped = ObjectMapper.Map<Grade, AddUpdateGradeDto>(newGRade);

            return resultMapped;

        }

        public async Task<List<GradesDto>> GetPaginatedAsync(PagedAndSortedResultRequestDto pagination, CancellationToken token)
        {

            var listGrades = await _gradeInterface.GetPaginated(pagination.SkipCount, pagination.MaxResultCount, pagination.Sorting);

            var resultMapped = ObjectMapper.Map<List<Grade>, List<GradesDto>>(listGrades);

            return resultMapped;
        }

        public async Task<AddUpdateGradeDto> UpdateAsync(AddUpdateGradeDto request)
        {
            var grade = await _gradesRepository.GetAsync(x => x.Id == request.Id);
            grade.Update(request.Name,request.EducationLevelId);
            await _gradesRepository.UpdateAsync(grade);

            var resultMapped = ObjectMapper.Map<Grade, AddUpdateGradeDto>(grade);

            return resultMapped;

        }

    }
}

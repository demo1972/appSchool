
using App.School.v3.Students.DTOs;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace App.School.v3.Students
{
    public interface IStudentAppService : ICrudAppService<StudentDto, int, PagedAndSortedResultRequestDto, CreateStudentDto, UpdateStudentDto>
    {
    }
}

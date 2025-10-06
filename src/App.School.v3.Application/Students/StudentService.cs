using App.School.v3.Entities;
using App.School.v3.Students.DTOs;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace App.School.v3.Students
{
    public class StudentService : CrudAppService<Student, StudentDto, int, PagedAndSortedResultRequestDto, CreateStudentDto, UpdateStudentDto>, IStudentAppService
    {


        //public StudentService(IRepository<Student> studentRepository)
        //{
        //    _studentRepository = studentRepository;
        //}

        //public async Task<StudentDto> CreateAsync(StudentRequestDto request) {

        //        var result = ObjectMapper.Map<StudentRequestDto, Student>(request);
        //        var newStudent =await _studentRepository.InsertAsync(result);
        //        var resultMapped = ObjectMapper.Map<Student, StudentDto>(newStudent);
        //        return resultMapped; 

        //}
        public StudentService(IRepository<Student, int> repository) : base(repository)
        {
        }
    }
}

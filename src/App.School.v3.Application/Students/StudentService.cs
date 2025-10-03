using App.School.v3.Common.Dtos;
using App.School.v3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace App.School.v3.Students
{
    public class StudentService :ApplicationService
    {
        private readonly IRepository<Student> _studentRepository;

        public StudentService(IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<StudentDto> CreateAsync(StudentRequestDto request) {
           
                var result = ObjectMapper.Map<StudentRequestDto, Student>(request);
                var newStudent =await _studentRepository.InsertAsync(result);
                var resultMapped = ObjectMapper.Map<Student, StudentDto>(newStudent);
                return resultMapped; 
          
        }
    }
}

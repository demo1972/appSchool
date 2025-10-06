using App.School.v3.Entities;
using App.School.v3.Students.DTOs;
using AutoMapper;

namespace App.School.v3.AutoMapper
{
    public class StudentAutoMapperProfile : Profile
    {
        public StudentAutoMapperProfile() {
            CreateMap<CreateStudentDto, Student>();

            CreateMap<Student, StudentDto>();

            CreateMap<UpdateStudentDto, Student>();
        }
    }
}

using App.School.v3.Common.Dtos;
using App.School.v3.Entities;
using AutoMapper;

namespace App.School.v3;

public class v3ApplicationAutoMapperProfile : Profile
{
    public v3ApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Student, StudentDto>().ForMember(x=>x.GroupName, opt=>opt.MapFrom(src=>src.Group.Name));

        CreateMap<StudentRequestDto, Student>();
        CreateMap<EducationLevel, EducationLevelDtos>();
        CreateMap<Grade, GradesDto>().ForMember(x => x.EductationLevel, opt => opt.MapFrom(src => src.EducationLevel.Name));
        CreateMap<Grade, AddUpdateGradeDto>();
        CreateMap<GroupSchool, AddUpdateGroupSchool>();
        CreateMap<GroupSchool, GroupSchoolDtos>()
            .ForMember(x=>x.Name,opt=>opt.MapFrom(src=>src.Grade.Name+" "+src.Grade.EducationLevel.Name+" "+ src.Name));
    }
}

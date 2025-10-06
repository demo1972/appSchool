using App.School.v3.Entities;
using App.School.v3.Payments.DTOs;
using AutoMapper;

namespace App.School.v3.AutoMapper
{
    public class PaymentAutoMapperProfile : Profile
    {
        public PaymentAutoMapperProfile()
        {
            CreateMap<CreatePaymentDto, Payment>()
                .ForMember(
                    dest => dest.Status,
                    opt => opt.MapFrom(src => (PaymentStatus)src.Status)
                )

                .ForMember(dest => dest.Student, opt => opt.Ignore())
                .ForMember(dest => dest.PaymentConcept, opt => opt.Ignore())
                .ForMember(dest => dest.SchoolYear, opt => opt.Ignore())
                .ForMember(dest => dest.SchoolData, opt => opt.Ignore());


            CreateMap<Payment, PaymentDto>()
                .ForMember(
                    dest => dest.Status,
                    opt => opt.MapFrom(src => (int)src.Status)
                );


            CreateMap<UpdatePaymentDto, Payment>()
                .ForMember(
                    dest => dest.Status,
                    opt => opt.MapFrom(src => (PaymentStatus)src.Status)
                )
                .ForMember(dest => dest.Student, opt => opt.Ignore())
                .ForMember(dest => dest.PaymentConcept, opt => opt.Ignore())
                .ForMember(dest => dest.SchoolYear, opt => opt.Ignore())
                .ForMember(dest => dest.SchoolData, opt => opt.Ignore());
        }
    }
}
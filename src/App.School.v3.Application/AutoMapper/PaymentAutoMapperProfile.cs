using App.School.v3.Entities;
using App.School.v3.Payments.DTOs;
using AutoMapper;

namespace App.School.v3.AutoMapper
{
    public class PaymentAutoMapperProfile : Profile
    {
        public PaymentAutoMapperProfile()
        {
            // Mapeo de DTO de Creación a Entidad
            CreateMap<CreatePaymentDto, Payment>()
                // Instrucción especial para la propiedad 'Status'
                .ForMember(
                    dest => dest.Status, // Para el miembro de destino 'Status' en la entidad Payment...
                    opt => opt.MapFrom(src => (PaymentStatus)src.Status) // ...mapea desde la fuente 'Status' del DTO, convirtiendo el int a la enum.
                )
                // Ignorar el mapeo de propiedades de navegación complejas
                // AutoMapper no debe encargarse de esto, lo hará el AppService
                .ForMember(dest => dest.Student, opt => opt.Ignore())
                .ForMember(dest => dest.PaymentConcept, opt => opt.Ignore())
                .ForMember(dest => dest.SchoolYear, opt => opt.Ignore())
                .ForMember(dest => dest.SchoolData, opt => opt.Ignore());


            // Mapeo de Entidad a DTO de Lectura
            CreateMap<Payment, PaymentDto>()
                // Si tu PaymentDto también tiene un Status como int
                .ForMember(
                    dest => dest.Status,
                    opt => opt.MapFrom(src => (int)src.Status)
                );

            // Mapeo de DTO de Actualización a Entidad
            CreateMap<UpdatePaymentDto, Payment>()
                .ForMember(
                    dest => dest.Status,
                    opt => opt.MapFrom(src => (PaymentStatus)src.Status)
                )
                // Ignorar también aquí las propiedades de navegación
                .ForMember(dest => dest.Student, opt => opt.Ignore())
                .ForMember(dest => dest.PaymentConcept, opt => opt.Ignore())
                .ForMember(dest => dest.SchoolYear, opt => opt.Ignore())
                .ForMember(dest => dest.SchoolData, opt => opt.Ignore());
        }
    }
}
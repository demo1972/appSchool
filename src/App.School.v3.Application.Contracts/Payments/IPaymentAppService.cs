using App.School.v3.Payments.DTOs;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace App.School.v3.Payments
{
    public interface IPaymentAppService : ICrudAppService<PaymentDto, Guid, PagedAndSortedResultRequestDto, CreatePaymentDto, UpdatePaymentDto>
    {
    }
}

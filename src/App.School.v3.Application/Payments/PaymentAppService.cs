
using App.School.v3.Entities;
using App.School.v3.Payments.DTOs;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace App.School.v3.Payments
{
    public class PaymentAppService : CrudAppService<Payment, PaymentDto, Guid, PagedAndSortedResultRequestDto, CreatePaymentDto, UpdatePaymentDto>, IPaymentAppService
    {
        public PaymentAppService(IRepository<Payment, Guid> repository) : base(repository)
        {
        }
    }
}

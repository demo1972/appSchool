using System;

namespace App.School.v3.Payments.DTOs
{
    public class CreatePaymentDto
    {
        public int StudentId { get; set; }
        public int PaymentConceptId { get; set; }

        public DateTime PaymentDate { get; set; }

        public decimal AmountPaid { get; set; }

        public int? SchoolYearId { get; set; }

        public string Month { get; set; } = string.Empty;

        public string Notes { get; set; } = string.Empty;

        public int? Status { get; set; }

        public int SchoolDataId { get; set; }
    }
}

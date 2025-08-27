// Clinic.Web/ViewModels/RecordPaymentViewModel.cs

using System.ComponentModel.DataAnnotations;

namespace Clinic.Web.ViewModels;

public class RecordPaymentViewModel
{
    [Required]
    [Range(0.01, double.MaxValue, ErrorMessage = "Payment amount must be positive.")]
    public decimal Amount { get; set; }
}
using FluentValidation.Results;

namespace EnterpriseToDo.Models.InvoiceViewModels
{
  public class VoidInvoiceViewModel
  {
    public int InvoiceID { get; set; }
    public string? VoidReason { get; set; }
    public string? InvoiceNumber { get; set; }

    public ValidationResult? ValidationResult { get; set; }
  }
}
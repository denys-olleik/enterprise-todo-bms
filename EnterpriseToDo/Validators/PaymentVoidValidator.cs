using EnterpriseToDo.Models.PaymentViewModels;
using FluentValidation;

namespace EnterpriseToDo.Validators
{
  public class PaymentVoidValidator 
    : AbstractValidator<PaymentVoidViewModel>
  {
    public PaymentVoidValidator()
    {
      RuleFor(x => x.VoidReason)
        .NotEmpty()
        .WithMessage("Void reason is required.");
    }
  }
}
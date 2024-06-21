using EnterpriseToDo.Models.InvoiceViewModels;
using FluentValidation;

namespace EnterpriseToDo.Validators
{
    public class InvoiceLineViewModelValidator : AbstractValidator<InvoiceLineViewModel>
    {
        public InvoiceLineViewModelValidator()
        {
            RuleFor(x => x.ID)
                .NotEmpty()
                .WithMessage("Id is required.");

            RuleFor(x => x.Title)
                .NotEmpty()
                .WithMessage("Title is required.");

            RuleFor(x => x.Quantity)
                .NotEmpty()
                .WithMessage("Quantity is required.");

            RuleFor(x => x.Price)
                .NotEmpty()
                .WithMessage("Price is required.");
        }
    }
}
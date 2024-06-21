using EnterpriseToDo.Models.LocationViewModels;
using FluentValidation;

namespace EnterpriseToDo.Validators
{
  public class CreateLocationViewModelValidator : AbstractValidator<CreateLocationViewModel>
  {
    public CreateLocationViewModelValidator()
    {
      RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
    }
  }
}
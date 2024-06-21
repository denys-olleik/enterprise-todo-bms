using EnterpriseToDo.Models.OrganizationViewModels;
using FluentValidation;
using static EnterpriseToDo.Business.Organization;

namespace EnterpriseToDo.Validators
{
  public class UpdateOrganizationViewModelValidator : AbstractValidator<UpdateOrganizationViewModel>
  {
    public UpdateOrganizationViewModelValidator()
    {
      RuleFor(x => x.Name).NotEmpty().WithMessage("Organization Name is required.");
    }
  }
}
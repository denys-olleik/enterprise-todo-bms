using EnterpriseToDo.Models.ToDoViewModels;
using FluentValidation;

namespace EnterpriseToDo.Validators
{
  public class CreateTaskViewModelValidator : AbstractValidator<CreateToDoViewModel>
  {
    public CreateTaskViewModelValidator()
    {
      RuleFor(x => x.Title).NotEmpty().WithMessage("'Title' is required.");
    }
  }
}
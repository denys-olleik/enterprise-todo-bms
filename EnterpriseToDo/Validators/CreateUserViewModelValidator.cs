using EnterpriseToDo.Business;
using EnterpriseToDo.Models.UserViewModels;
using EnterpriseToDo.Service;
using FluentValidation;

namespace EnterpriseToDo.Validators
{
    public class CreateUserViewModelValidator : AbstractValidator<CreateUserViewModel>
    {
        public CreateUserViewModelValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress();

            RuleFor(x => x.Email).MustAsync(UserDoesNotExistAsync).WithMessage(x => $"The '{x.Email}' is already exists.");
        }

        private async Task<bool> UserDoesNotExistAsync(string email, CancellationToken token)
        {
            UserService userService = new UserService();
            User user = await userService.GetByEmailAsync(email);
            return user == null;
        }
    }
}
using EnterpriseToDo.Models.InvitationViewModels;
using EnterpriseToDo.Service;
using FluentValidation;

namespace EnterpriseToDo.Validators
{
    public class InvitationViewModelValidator : AbstractValidator<InvitationViewModel>
    {
        private readonly InvitationService _invitationService;

        public InvitationViewModelValidator()
        {
            _invitationService = new InvitationService();

            RuleFor(i => i.Password)
                .Equal(i => i.ConfirmPassword)
                .WithMessage("Passwords do not match");
        }
    }
}
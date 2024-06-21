﻿using FluentValidation.Results;

namespace EnterpriseToDo.Models.AccountViewModels
{
    public class LoginViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public ValidationResult ValidationResult { get; set; }
    }
}
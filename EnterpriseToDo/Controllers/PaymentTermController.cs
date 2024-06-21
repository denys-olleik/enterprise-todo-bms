﻿using EnterpriseToDo.Business;
using EnterpriseToDo.CustomAttributes;
using EnterpriseToDo.Models.PaymentTermViewModels;
using EnterpriseToDo.Service;
using EnterpriseToDo.Validators;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EnterpriseToDo.Controllers
{
  [AuthorizeWithOrganizationId]
  [Route("pt")]
  public class PaymentTermController : BaseController
  {
    [Route("payment-terms")]
    [HttpGet]
    public async Task<IActionResult> PaymentTerms()
    {
      PaymentTermsViewModel paymentTermsViewModel = new PaymentTermsViewModel();

      PaymentTermsService paymentTermsService = new PaymentTermsService();
      List<PaymentTerm> paymentTerms = await paymentTermsService.GetAllAsync();

      paymentTermsViewModel.PaymentTerms = paymentTerms.Select(paymentTerm => new PaymentTermViewModel
      {
        ID = paymentTerm.PaymentTermID,
        Description = paymentTerm.Description,
        DaysUntilDue = paymentTerm.DaysUntilDue
      }).ToList();

      return View(paymentTermsViewModel);
    }

    [Route("create")]
    [HttpGet]
    public async Task<IActionResult> Create()
    {
      return View();
    }

    [Route("create")]
    [HttpPost]
    public async Task<IActionResult> Create(CreatePaymentTermsViewModel model)
    {
      CreatePaymentTermsViewModelValidator validator = new CreatePaymentTermsViewModelValidator();
      ValidationResult validationResult = await validator.ValidateAsync(model);

      if (!validationResult.IsValid)
      {
        model.ValidationResult = validationResult;
        return View(model);
      }

      PaymentTermsService paymentTermsService = new PaymentTermsService();
      await paymentTermsService.CreatePaymentTermAsync(new PaymentTerm()
      {
        Description = model.Description,
        DaysUntilDue = model.DaysUntilDue,
        CreatedById = GetUserId(),
        OrganizationId = GetOrganizationId()
      });

      return RedirectToAction("PaymentTerms");
    }
  }
}
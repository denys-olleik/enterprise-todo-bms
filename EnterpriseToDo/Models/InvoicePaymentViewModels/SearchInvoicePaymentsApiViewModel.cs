namespace EnterpriseToDo.Models.InvoicePaymentViewModels
{
    public class SearchInvoicePaymentsApiViewModel : PaginatedViewModel
  {
        public List<InvoicePaymentViewModel>? InvoicePayments { get; set; }
    }
}
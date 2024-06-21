namespace EnterpriseToDo.Models.InvoicePaymentViewModels
{
    public class GetInvoicePaymentsApiViewModel : PaginatedViewModel
    {
        public List<InvoicePaymentViewModel>? InvoicePayments { get; set; }
    }
}
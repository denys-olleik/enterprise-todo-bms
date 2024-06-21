using EnterpriseToDo.Business;
using EnterpriseToDo.Models.InvoiceViewModels;
using EnterpriseToDo.Models.PaymentViewModels;

namespace EnterpriseToDo.Models.InvoicePaymentViewModels
{
    public class InvoicePaymentViewModel
    {
        public int ID { get; set; }
        public InvoiceViewModel? Invoice { get; set; }
        public PaymentViewModel? Payment { get; set; }
        public decimal Amount { get; set; }
        public DateTime Created { get; set; }

        public int? RowNumber { get; set; }
    }
}
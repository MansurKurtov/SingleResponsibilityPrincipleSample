using SingleResponsibilityPrincipleSample.Models;
namespace SingleResponsibilityPrincipleSample.Services.Invoice
{
    public interface IInvoiceService
    {
        void AddInvoice(InvoiceModel invoice);
    }
}

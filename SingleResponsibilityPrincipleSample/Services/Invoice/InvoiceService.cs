using SingleResponsibilityPrincipleSample.Models;
using SingleResponsibilityPrincipleSample.Services.Email;
using SingleResponsibilityPrincipleSample.Services.Logger;
using System;

namespace SingleResponsibilityPrincipleSample.Services.Invoice
{
    public class InvoiceService : IInvoiceService
    {
        private ILoggerService _loggerService;
        private IEmailService _emailService;
        
        public InvoiceService()
        {
            _loggerService = new LoggerService();
            _emailService = new EmailService();
        }

        public void AddInvoice(InvoiceModel invoice)
        {
            try
            {
                //here goes Add Invoice logis

                var email = new EmailModel();
                email.FromEmail = "support@invoice.com";
                email.ToEmail = invoice.OwnerEmail;
                email.Subject = "Invoice added!";
                email.Body = "Thanks";
                _emailService.SendEmail(email);
                _loggerService.Log("Invoice succesfully added");
            }
            catch(Exception ex)
            {
                _loggerService.Log("Error:"+ex.Message);
            }
        }
    }
}

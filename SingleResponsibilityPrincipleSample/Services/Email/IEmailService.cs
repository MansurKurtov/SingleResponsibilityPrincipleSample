using SingleResponsibilityPrincipleSample.Models;

namespace SingleResponsibilityPrincipleSample.Services.Email
{
    interface IEmailService
    {
        void SendEmail(EmailModel email);
    }
}

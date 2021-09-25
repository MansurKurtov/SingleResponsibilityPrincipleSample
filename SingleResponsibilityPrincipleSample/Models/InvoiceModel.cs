using System;

namespace SingleResponsibilityPrincipleSample.Models
{
    public class InvoiceModel
    {
        public string OwnerId { get; set; }
        public string OwnerEmail { get; set; }
        public double InvoiceAmount { get; set; }
        public DateTime InvoiceDate { get; set; }
    }
}

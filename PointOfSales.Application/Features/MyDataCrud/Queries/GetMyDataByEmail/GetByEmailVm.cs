namespace PointOfSales.Application.Features.MyDataCrud.Queries.GetMyDataByEmail
{
    public class GetByEmailVm
    {
        public Guid Id { get; set; }
        public string CompanyRegistrationNumber { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyEmail { get; set; }
        public string InvoicePrefix { get; set; }
        public int InvoiceSecuence { get; set; }
        public string OrderPrefix { get; set; }
        public int OrderSecuence { get; set; }
        public string Currency { get; set; }
        public string InvoiceTextFooter { get; set; }
    }
}

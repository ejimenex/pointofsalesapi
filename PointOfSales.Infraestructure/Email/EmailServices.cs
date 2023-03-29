using PointOfSales.Application.Infraestructure;
using PointOfSales.Application.Model;

namespace PointOfSales.Infraestructure.Email
{
    public class EmailServices : IEmailService
    {
        public Task<bool> SendMail(Mail email)
        {
            //here the logic to send email
            return Task.FromResult(true);
        }
    }
}

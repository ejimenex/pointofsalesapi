using PointOfSales.Application.Model;

namespace PointOfSales.Application.Infraestructure
{
    public interface IEmailService
    {
        Task<bool> SendMail(Mail email);
    }
}

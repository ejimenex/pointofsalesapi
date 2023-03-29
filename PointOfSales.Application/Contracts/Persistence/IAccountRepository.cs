using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Application.Contracts.Persistence
{
    public interface IAccountRepository : IAsyncRepository<UserRegistrered>
    {
        Task<UserRegistrered> GetAvaliable(string email);
        Task<bool> ExistEmail(string email);
    }
}

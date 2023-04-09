using Microsoft.EntityFrameworkCore;
using PointOfSales.Application.Contracts.Persistence;
using PointOfSales.Domain.Entities;
using PointOfSales.Persistence.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Persistence.Repositories
{
    public class ProviderRepository:BaseRepository<Supplier>, IProviderRepository
    {
         private readonly ITokenRepository tokenRepository;
        public ProviderRepository(PointOfSalesDbContext context,ITokenRepository tokenRepository):base(context)
        {
            this.tokenRepository = tokenRepository;
        }
        public Task<bool> ExistPhoneNumber(string phoneNumber)
        {
            
                var matches = _dbContext.Supplier.Any(c => c.Phone.Equals(phoneNumber));
                return Task.FromResult(matches);
            
        }

        public async Task<List<Supplier>> GetPaged(string filter, int page, int size)
        {
            var user = tokenRepository.GetTokenData().Result.Email;
            var result= await _dbContext.Supplier
                .Where(x => !x.IsDeleted && x.UserEmail == user &&( x.Name.Contains(filter) || x.Phone.Contains(filter)))
                .Skip((page - 1) * size)
                .OrderBy(c=> c.CreatedDate)
                .Take(size)
                .AsNoTracking()
                .ToListAsync();
            return result;
        }

        public async Task<int> GetTotalCount(string filter)
        {
           return await _dbContext.Supplier.CountAsync(x =>!x.IsDeleted && (x.Name.Contains(filter) || x.Phone.Contains(filter)));
        }

      
    }
}

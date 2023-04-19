using PointOfSales.Domain.Entities;
using PointOfSales.Persistence.Contract;

namespace PointOfSales.Persistence.Repositories
{
    public class MyDataRepository : BaseRepository<MyData>, IMyDataRepository
    {
        private readonly ITokenRepository tokenRepository;

        public MyDataRepository(PointOfSalesDbContext dbContext, ITokenRepository tokenRepository) : base(dbContext)
        {
            this.tokenRepository= tokenRepository;
        }

        public async Task<string> GetInvoiceSecuence()
        {
            var myData = await GetMyData();
            return string.Concat(myData.InvoicePrefix, myData.InvoiceSecuence);
        }

        public async Task<MyData> GetOne()=> await GetMyData(); 
        
        public async Task<string> GetOrderSecuence()
        {
             var myData = await GetMyData();
            return string.Concat(myData.OrderPrefix, myData.OrderSecuence);
        }

        public async Task UpdateInvoiceSecuence()
        {
            var myData = await GetMyData();
            myData.InvoiceSecuence ++;
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateOrderSecuence()
        {
            var myData = await GetMyData();
            myData.OrderSecuence++;
            await _dbContext.SaveChangesAsync();
        }
        private async Task<MyData> GetMyData() {
            var email = tokenRepository.GetEmail();
            var result = await _dbContext.MyData.FirstOrDefaultAsync(c => c.UserEmail == email);
            return result;
        }
    }
}

using PointOfSales.Persistence.Contract;

namespace PointOfSales.Persistence.Repositories
{

    public class ProductRepository : BaseRepository<Product>, IServiceRepository
    {
        private readonly ITokenRepository tokenRepository;
        public ProductRepository(PointOfSalesDbContext context, ITokenRepository tokenRepository) : base(context)
        {
            this.tokenRepository = tokenRepository;
        }
        public Task<bool> ExistProduct(string phoneNumber)
        {

            var matches = _dbContext.Product.Any(c => c.Name.Equals(phoneNumber) && c.UserEmail== tokenRepository.GetEmail());
            return Task.FromResult(matches);
        }
        public async Task<List<Product>> GetPaged(string filter, int page, int size)
        {
            var email= tokenRepository.GetEmail();
            var result = await _dbContext.Product
                .Where(x => !x.IsDeleted && x.UserEmail == email && (x.Name.Contains(filter) || x.Name.Contains(filter))).Skip((page - 1) * size)
                .OrderBy(c => c.CreatedDate)
                .Take(size)
                .AsNoTracking()
                .ToListAsync();
            return result;
        }

        public async Task<int> GetTotalCount(string filter)
        {
            var email= tokenRepository.GetEmail();
            return await _dbContext.Product.CountAsync(x => !x.IsDeleted && x.UserEmail == email &&  (x.Name.Contains(filter) || x.Name.Contains(filter)));
        }
    }
}

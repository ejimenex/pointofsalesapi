using PointOfSales.Persistence.Contract;

namespace PointOfSales.Persistence.Repositories
{

    public class ClientRepository : BaseRepository<Client>, IClientRepository
    {
        private readonly ITokenRepository tokenRepository;
        public ClientRepository(PointOfSalesDbContext context, ITokenRepository tokenRepository) : base(context)
        {
            this.tokenRepository = tokenRepository;
        }
        public Task<bool> ExistPhoneNumber(string phoneNumber)
        {

            var matches = _dbContext.Client.Any(c => c.Phone.Equals(phoneNumber));
            return Task.FromResult(matches);

        }

        public async Task<List<Client>> GetPaged(string filter, int page, int size)
        {
            var email= tokenRepository.GetEmail();
            var result = await _dbContext.Client
                .Where(x => !x.IsDeleted && x.UserEmail == email && (x.Name.Contains(filter) || x.Phone.Contains(filter))).Skip((page - 1) * size)
                .OrderBy(c => c.CreatedDate)
                .Take(size)
                .AsNoTracking()
                .ToListAsync();
            return result;
        }

        public async Task<int> GetTotalCount(string filter)
        {
            var email= tokenRepository.GetEmail();
            return await _dbContext.Client.CountAsync(x => !x.IsDeleted && x.UserEmail == email &&  (x.Name.Contains(filter) || x.Phone.Contains(filter)));
        }
    }
}

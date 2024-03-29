﻿namespace PointOfSales.Persistence.Repositories
{
    public class UserAccountRepository : BaseRepository<UserRegistrered>, IAccountRepository
    {
        public UserAccountRepository(PointOfSalesDbContext context) : base(context)
        {

        }
        public override Task<UserRegistrered> AddAsync(UserRegistrered entity)
        {
            entity.CreatedDate=DateTime.Now;
            entity.IsDeleted=false;
            entity.IsLocked=false;
            entity.UserEmail="register@mail.com";
            return base.AddAsync(entity);
        }
        public async Task<UserRegistrered> GetAvaliable(string email)
        {
            var result = await _dbContext.UserRegistrered.Where(c => !c.IsDeleted && c.Email == email).FirstOrDefaultAsync();
            return result;
        }
        public async Task<bool> ExistEmail(string email)
        {
            return await _dbContext.UserRegistrered.AnyAsync(c => !c.IsDeleted && c.UserEmail == email);
        }
    }
}

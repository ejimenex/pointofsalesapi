﻿using Microsoft.EntityFrameworkCore;
using PointOfSales.Application.Contracts.Persistence;
using PointOfSales.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Persistence.Repositories
{
    public class ClientRepository:BaseRepository<Client>, IClientRepository
    {
        public ClientRepository(PointOfSalesDbContext context):base(context)
        {

        }
        public Task<bool> ExistPhoneNumber(string phoneNumber)
        {
            
                var matches = _dbContext.Client.Any(c => c.Phone.Equals(phoneNumber));
                return Task.FromResult(matches);
            
        }

        public async Task<List<Client>> GetPaged(string filter, int page, int size,string user)
        {
            var result= await _dbContext.Client
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
           return await _dbContext.Client.CountAsync(x =>!x.IsDeleted && (x.Name.Contains(filter) || x.Phone.Contains(filter)));
        }
    }
}

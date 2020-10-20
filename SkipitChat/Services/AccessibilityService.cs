using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SkipitChat.Data;
using SkipitChat.Domain;

namespace SkipitChat.Services
{
    public class AccessibilityService:IAccessibilityService
    {
        private readonly ApplicationDbContext _dbContext;

        public AccessibilityService(ApplicationDbContext dbContex)
        {
            _dbContext = dbContex;
        }

        public async Task<List<Accessibility>> GetAccessibilitesAsync()
        {
            return await _dbContext.Accessiblities.ToListAsync();
        }

        public async Task<Accessibility> GetAccessibilityByNameAsync(string name)
        {
            return await _dbContext.Accessiblities.SingleOrDefaultAsync(x => x.StationName == name);
        }
    }
}

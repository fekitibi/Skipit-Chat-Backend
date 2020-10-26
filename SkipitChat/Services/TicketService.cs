using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SkipitChat.Data;
using SkipitChat.Domain;

namespace SkipitChat.Services
{
    public class TicketService:ITicketService
    {
        private readonly ApplicationDbContext _dbContext;

        public TicketService(ApplicationDbContext dbContex)
        {
            _dbContext = dbContex;
        }

        public async Task<List<CityPass>> GetAllCityPass()
        {
            return await _dbContext.CityPasses.ToListAsync();
        }

        public async Task<List<Zone>> GetAllZones()
        {
            return await _dbContext.Zones.ToListAsync();
        }

        // The given duration should be in hours
        public async Task<CityPass> GetCityPassByDuration(int duration)
        {
            return await _dbContext.CityPasses.SingleOrDefaultAsync(x => x.DurationInHour == duration);
        }

        public async Task<Zone> GetZoneByZoneNumber(int zoneNumber)
        {
            return await _dbContext.Zones.SingleOrDefaultAsync(x => x.Id == zoneNumber);
        }
    }
}

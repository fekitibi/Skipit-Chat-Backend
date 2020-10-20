using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SkipitChat.Domain;

namespace SkipitChat.Services
{
    public interface ITicketService
    {
        Task<List<CityPass>> GetAllCityPass();
        Task<CityPass> GetCityPassByDuration(int duration);
        Task<Zone> GetZoneByZoneNumber(int zoneNumber);
    }
}

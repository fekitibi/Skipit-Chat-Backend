using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SkipitChat.Domain;

namespace SkipitChat.Services
{
    public interface IAccessibilityService
    {
        Task<List<Accessibility>> GetAccessibilitesAsync();
        Task<Accessibility> GetAccessibilityByNameAsync(string name);
    }
}

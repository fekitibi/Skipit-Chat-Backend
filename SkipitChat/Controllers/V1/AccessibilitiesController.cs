using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SkipitChat.Contracts;
using SkipitChat.Services;

namespace SkipitChat.Controllers.V1
{
    public class AccessibilitiesController:Controller
    {
        private readonly IAccessibilityService _accService;

        public AccessibilitiesController(IAccessibilityService accService)
        {
            _accService = accService;
        }

        [HttpGet(ApiRoutes.Accessibilities.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _accService.GetAccessibilitesAsync());
        }

        [HttpGet(ApiRoutes.Accessibilities.Get)]
        public async Task<IActionResult> Get([FromRoute] string name)
        {
            var access = await _accService.GetAccessibilityByNameAsync(name);

            if (access == null)
                return NotFound();

            return Ok(access);
        }
    }
}

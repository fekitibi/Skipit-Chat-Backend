using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SkipitChat.Contracts;
using SkipitChat.Contracts.V1.Response;
using SkipitChat.Services;

namespace SkipitChat.Controllers.V1
{
    public class TicketsController : Controller
    {
        private readonly ITicketService _ticketService;

        public TicketsController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpGet(ApiRoutes.Tickets.GetCityPass)]
        public async Task<IActionResult> GetCityPass([FromRoute] int duration, bool ticket99)
        {
            int dur = 0;

            if (duration <= 24)
            {
                dur = 24;
            }
            else if (duration > 24 && duration <= 48)
            {
                dur = 48;
            }
            else if (duration > 48 && duration <= 72)
            {
                dur = 72;
            }
            else if (duration > 72 && duration <= 96)
            {
                dur = 96;
            }
            else if (duration > 96 && duration <= 120)
            {
                dur = 120;
            }
            else
            {
                return NotFound();
            }


            var cityPass = await _ticketService.GetCityPassByDuration(dur);

            if (cityPass == null)
                return NotFound();

            if (ticket99)
            {
                return Ok(new CityPassResponse { Price = cityPass.CityPass99Price });
                //return Ok(cityPass);
            }
            else
            {
                //return Ok(cityPass);
                return Ok(new CityPassResponse { Price = cityPass.CityPass4Price });
            }
        }

        [HttpGet(ApiRoutes.Tickets.GetAllCityPass)]
        public async Task<IActionResult> GetAllCityPass()
        {
            return Ok(await _ticketService.GetAllCityPass());
        }

        [HttpGet(ApiRoutes.Tickets.GetZoneByZoneNumber)]
        public async Task<IActionResult> GetZoneByZoneNumber([FromRoute] int zoneNumber, int age, bool disabled, bool animal, bool bycicle)
        {
            int zNum = 0;
            float price = 0;

            if (zoneNumber < 2)
            {
                zNum = 2;
            }
            else if (zoneNumber > 30)
            {
                zNum = 30;
            }
            else
            {
                zNum = zoneNumber;
            }

            var zone = await _ticketService.GetZoneByZoneNumber(zNum);


            if (!disabled)
            {
                if (age >= 10 && age <= 15)
                {
                    price += zone.PriceChildren;
                }
                else if (age >= 16 && age <= 64)
                {
                    price += zone.PriceAdult;
                }
                else if (age >= 65)
                {
                    price += zone.PriceElderly;
                }
            }
            else
            {
                price += zone.PriceDisabled;
            }

            if (animal)
            {
                price += zone.Animal;
            }

            if (bycicle)
            {
                price += zone.Bycicle;
            }

            return Ok(new ZoneResponse { Duration = zone.DurationInMinute, Price = price });
        }
    }
}

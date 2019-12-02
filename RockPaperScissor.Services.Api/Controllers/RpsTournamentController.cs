using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using RockPaperScissor.Domain.Interfaces;
using RockPaperScissor.Domain.Tournament;

namespace RockPaperScissor.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RpsTournamentController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get([FromBody] JArray array)
        {
            try
            {
                Tournament tournament = RpsTournament.Build();
                IPlayer player = tournament.FindWinner(array);

                return $"[\"{player.Name}\", \"{player.Command}\"]";
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}

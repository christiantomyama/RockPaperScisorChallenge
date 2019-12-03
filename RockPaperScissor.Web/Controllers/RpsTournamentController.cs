using System;
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
        [HttpPost]
        public ActionResult<string> Post([FromBody] JArray array)
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

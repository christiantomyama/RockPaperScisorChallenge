using System;
using System.Collections;
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
        public ActionResult<string> Post([FromBody] IList list)
        {
            try
            {
                Tournament tournament = RpsTournament.Build();
                IPlayer player = tournament.FindWinner(list);

                return $"[\"{player.Name}\", \"{player.Command}\"]";
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}

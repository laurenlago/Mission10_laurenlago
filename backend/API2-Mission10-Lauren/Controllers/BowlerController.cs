using API2_Mission10_Lauren.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API2_Mission10_Lauren.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;

        public BowlerController(IBowlerRepository temp)
        {
            _bowlerRepository = temp;
        }

        public IEnumerable<Bowler> Get()
        {
            //Get data method and pass in which teams you want to see
            var bowlersWithTeams = _bowlerRepository.GetBowlersWithTeams(["Marlins", "Sharks"]);

            return bowlersWithTeams;
        }


    }
}

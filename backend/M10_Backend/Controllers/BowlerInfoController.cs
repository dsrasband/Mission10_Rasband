using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using M10_Backend.Data;

namespace M10_Backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerInfoController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;
        public BowlerInfoController(IBowlerRepository temp)
        {
            _bowlerRepository = temp;
        }

        [HttpGet]
        public IEnumerable<BowlerInfo> Get()
        {
            var BowlerData = _bowlerRepository.Bowlers
                .Where(bowler => bowler.TeamID == 1 || bowler.TeamID == 2)
                .ToArray();

            return BowlerData;
        }
    }
}

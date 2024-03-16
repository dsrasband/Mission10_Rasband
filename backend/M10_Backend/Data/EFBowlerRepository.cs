using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace M10_Backend.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlerContext _bowlerContext;
        public EFBowlerRepository(BowlerContext temp)
        {
            _bowlerContext = temp;
        }

        public IEnumerable<BowlerInfo> Bowlers => _bowlerContext.Bowlers;
    }
}

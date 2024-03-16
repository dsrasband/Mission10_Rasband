namespace M10_Backend.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<BowlerInfo> Bowlers { get; }
    }
}

namespace MineCraft.ApplicationLayer.Queries
{
    public interface IQuery<TResultType>
    {
        TResultType Execute();
    }
}

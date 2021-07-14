namespace Store
{
    public interface IReadOnlyCell
    {
        Good Good { get; }
        int Count { get; }
    }
}
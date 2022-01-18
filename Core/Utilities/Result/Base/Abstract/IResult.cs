namespace Core.Utilities.Result.Base.Abstract
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}

namespace Core.Utilities.Result.Base.Abstract
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}

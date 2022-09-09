namespace Core.Utilities.Results
{
    // Temek voidler içim başlangıç 
    public interface IResult
    {
        bool IsSuccess { get; }
        string Message { get; }


    }
}

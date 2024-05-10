namespace Domain.Helpers;

public class Result<T>
{
    public T Value { get; }
    public bool IsSuccess { get; }
    public string ErrorMessage { get; }
    public int? ErrorCode { get; }

    protected Result(T value, bool isSuccess, string errorMessage, int? errorCode)
    {
        Value = value;
        IsSuccess = isSuccess;
        ErrorMessage = errorMessage;
        ErrorCode = errorCode;
    }

    public static Result<T> Success(T value) => new Result<T>(value, true, null, null);
    public static Result<T> Failure(string message, int? errorCode = null) => new Result<T>(default, false, message, errorCode);
}

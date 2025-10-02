namespace Pokedex_Backend.APIs;

public class BaseResponse<T> where T : class
{
    public string ErrorMessage { get; private set; }
    public bool DidReceiveResponse { get; private set; }
    public bool IsSuccessful { get; private set; }
    public T Data { get; private set; }

    public static BaseResponse<T> Success(T data)
    {
        var response = new BaseResponse<T>
        {
            DidReceiveResponse = true,
            IsSuccessful = true,
            Data = data
        };

        return response;
    }
    
    public static BaseResponse<T> FailedResponse(string errorMessage)
    {
        var response = new BaseResponse<T>
        {
            DidReceiveResponse = true,
            IsSuccessful = false,
            ErrorMessage = errorMessage
        }; 

        return response;
    }

    public static BaseResponse<T> NoResponse(string errorMessage)
    {
        var response = new BaseResponse<T>
        {
            DidReceiveResponse = false,
            IsSuccessful = false,
            ErrorMessage = errorMessage
        };
        
        return response;
    }
}
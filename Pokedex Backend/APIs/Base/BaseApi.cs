using System.Text.Json;

namespace Pokedex_Backend.APIs;

public class BaseApi : IBaseApi
{
    private readonly ILogger _logger;
    private readonly HttpClient _client = new();

    public BaseApi(ILogger logger)
    {
        _logger = logger;
    }

    protected void SetBaseAddress(string baseAddress)
    {
        _client.BaseAddress = new Uri(baseAddress);
    }

    protected async Task<BaseResponse<T>> Get<T>(string endpoint) where T : class
    {
        try
        {
            BaseResponse<T> baseApiResponse;
            var response = await _client.GetAsync(endpoint);
            var parsedData = await GetDataFromHttpResponse<T>(response);
            if (parsedData is not null)
            {
                baseApiResponse = BaseResponse<T>.Success(parsedData);
            }
            else
            {
                if (response.IsSuccessStatusCode)
                {
                    baseApiResponse = BaseResponse<T>.FailedResponse("BASE API - Failed to parse data.");
                }
                else
                {
                    baseApiResponse = BaseResponse<T>.NoResponse($"BASE API - Call to {_client.BaseAddress} failed.");
                }
            }

            return baseApiResponse;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "BASE API - Error while calling API");
        }
        
        return BaseResponse<T>.NoResponse($"BASE API - Call to {_client.BaseAddress} failed.");
    }


    private async Task<T?> GetDataFromHttpResponse<T>(HttpResponseMessage response) where T : class
    {
        T? result = default;
        try
        {
            var dataString = await response.Content.ReadAsStreamAsync();
            result = await JsonSerializer.DeserializeAsync<T>(dataString);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "BASE API - Error while deserializing response");
        }

        return result;
    }
}
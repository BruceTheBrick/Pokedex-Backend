using Pokedex_Backend.APIs.Pokemon_List;

namespace Pokedex_Backend.APIs;

public class PokeApi : BaseApi, IPokeApi
{
    private readonly IConfiguration _configuration;

    public PokeApi(
        IConfiguration configuration,
        ILogger logger)
        : base(logger)
    {
        _configuration = configuration;
        
        SetBaseAddress(_configuration.GetValue<string>("PokeApi:BaseAddress")!);
    }

    public async Task<BaseResponse<PokemonListResponse>> GetList()
    {
        var result = await Get<PokemonListResponse>(_configuration.GetValue<string>("PokeApi:Endpoints:PokemonList"));
        return result;
    }
}
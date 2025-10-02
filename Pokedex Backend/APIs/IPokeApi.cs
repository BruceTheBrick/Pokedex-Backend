using Pokedex_Backend.APIs.Pokemon_List;

namespace Pokedex_Backend.APIs;

public interface IPokeApi
{
    public Task<BaseResponse<PokemonListResponse>> GetList();
}
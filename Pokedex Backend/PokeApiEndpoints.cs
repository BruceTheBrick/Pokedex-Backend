using Pokedex_Backend.APIs;

namespace Pokedex_Backend;

public static class PokeApiEndpoints
{
    public static IApplicationBuilder RegisterPokeApiEndpoints(this WebApplication app)
    {
        app.MapGet("/pokemon", GetPokemonList).WithName("GetPokemonList");

        return app;
    }

    private static async Task GetPokemonList(HttpContext context)
    {
        var api = context.RequestServices.GetRequiredService<IPokeApi>();
        var t = await api.GetList();
    }
}
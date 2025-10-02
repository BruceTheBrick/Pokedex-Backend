using System.Text.Json.Serialization;

namespace Pokedex_Backend.APIs.Pokemon_List;

public sealed class PokemonListResponse
{
    [JsonPropertyName("count")]
    public int Count { get; init; }

    [JsonPropertyName("next")]
    public string? Next { get; init; }

    [JsonPropertyName("previous")]
    public string? Previous { get; init; }

    [JsonPropertyName("results")]
    public IReadOnlyList<PokemonListItem> Results { get; init; } = Array.Empty<PokemonListItem>();
}

public sealed class PokemonListItem
{
    [JsonPropertyName("name")]
    public string Name { get; init; } = string.Empty;

    [JsonPropertyName("url")]
    public string Url { get; init; } = string.Empty;
}

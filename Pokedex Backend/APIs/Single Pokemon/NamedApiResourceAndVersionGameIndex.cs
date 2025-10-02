using System.Text.Json.Serialization;

namespace Pokedex_Backend.APIs.Pokemon_List_Models;

public sealed class NamedApiResource
{
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("url")]
    public required string Url { get; init; }
}

public sealed class VersionGameIndex
{
    [JsonPropertyName("game_index")]
    public int GameIndex { get; init; }

    [JsonPropertyName("version")]
    public required NamedApiResource Version { get; init; }
}

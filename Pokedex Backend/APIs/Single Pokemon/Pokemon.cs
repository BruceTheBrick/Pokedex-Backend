using System.Text.Json.Serialization;

namespace Pokedex_Backend.APIs.Pokemon_List_Models;

public sealed class Pokemon
{
    [JsonPropertyName("id")]
    public int Id { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("base_experience")]
    public int BaseExperience { get; init; }

    [JsonPropertyName("height")]
    public int Height { get; init; }

    [JsonPropertyName("is_default")]
    public bool IsDefault { get; init; }

    [JsonPropertyName("order")]
    public int Order { get; init; }

    [JsonPropertyName("weight")]
    public int Weight { get; init; }

    [JsonPropertyName("abilities")]
    public List<PokemonAbility> Abilities { get; init; } = new();

    [JsonPropertyName("forms")]
    public List<NamedApiResource> Forms { get; init; } = new();

    [JsonPropertyName("game_indices")]
    public List<VersionGameIndex> GameIndices { get; init; } = new();

    [JsonPropertyName("held_items")]
    public List<PokemonHeldItem> HeldItems { get; init; } = new();

    [JsonPropertyName("location_area_encounters")]
    public required string LocationAreaEncounters { get; init; }

    [JsonPropertyName("moves")]
    public List<PokemonMove> Moves { get; init; } = new();

    [JsonPropertyName("species")]
    public required NamedApiResource Species { get; init; }

    [JsonPropertyName("sprites")]
    public required PokemonSprites Sprites { get; init; }

    [JsonPropertyName("cries")]
    public required PokemonCries Cries { get; init; }

    [JsonPropertyName("stats")]
    public List<PokemonStat> Stats { get; init; } = new();

    [JsonPropertyName("types")]
    public List<PokemonType> Types { get; init; } = new();

    [JsonPropertyName("past_types")]
    public List<PokemonPastType> PastTypes { get; init; } = new();

    [JsonPropertyName("past_abilities")]
    public List<PokemonPastAbilities> PastAbilities { get; init; } = new();
}

public sealed class PokemonAbility
{
    [JsonPropertyName("is_hidden")]
    public bool IsHidden { get; init; }

    [JsonPropertyName("slot")]
    public int Slot { get; init; }

    [JsonPropertyName("ability")]
    public required NamedApiResource Ability { get; init; }
}

public sealed class PokemonHeldItem
{
    [JsonPropertyName("item")]
    public required NamedApiResource Item { get; init; }

    [JsonPropertyName("version_details")]
    public List<PokemonHeldItemVersion> VersionDetails { get; init; } = new();
}

public sealed class PokemonHeldItemVersion
{
    [JsonPropertyName("rarity")]
    public int Rarity { get; init; }

    [JsonPropertyName("version")]
    public required NamedApiResource Version { get; init; }
}

public sealed class PokemonMove
{
    [JsonPropertyName("move")]
    public required NamedApiResource Move { get; init; }

    [JsonPropertyName("version_group_details")]
    public List<PokemonMoveVersion> VersionGroupDetails { get; init; } = new();
}

public sealed class PokemonMoveVersion
{
    [JsonPropertyName("level_learned_at")]
    public int LevelLearnedAt { get; init; }

    [JsonPropertyName("version_group")]
    public required NamedApiResource VersionGroup { get; init; }

    [JsonPropertyName("move_learn_method")]
    public required NamedApiResource MoveLearnMethod { get; init; }

    // Some APIs include an optional "order" here
    [JsonPropertyName("order")]
    public int? Order { get; init; }
}

public sealed class PokemonCries
{
    [JsonPropertyName("latest")]
    public required string Latest { get; init; }

    [JsonPropertyName("legacy")]
    public required string Legacy { get; init; }
}

public sealed class PokemonStat
{
    [JsonPropertyName("base_stat")]
    public int BaseStat { get; init; }

    [JsonPropertyName("effort")]
    public int Effort { get; init; }

    [JsonPropertyName("stat")]
    public required NamedApiResource Stat { get; init; }
}

public sealed class PokemonType
{
    [JsonPropertyName("slot")]
    public int Slot { get; init; }

    [JsonPropertyName("type")]
    public required NamedApiResource Type { get; init; }
}

public sealed class PokemonPastType
{
    [JsonPropertyName("generation")]
    public required NamedApiResource Generation { get; init; }

    [JsonPropertyName("types")]
    public List<PokemonType> Types { get; init; } = new();
}

public sealed class PokemonPastAbilities
{
    [JsonPropertyName("generation")]
    public required NamedApiResource Generation { get; init; }

    [JsonPropertyName("abilities")]
    public List<PastAbilityEntry> Abilities { get; init; } = new();
}

public sealed class PastAbilityEntry
{
    // Past abilities can be null in the dataset
    [JsonPropertyName("ability")]
    public NamedApiResource? Ability { get; init; }

    [JsonPropertyName("is_hidden")]
    public bool IsHidden { get; init; }

    [JsonPropertyName("slot")]
    public int Slot { get; init; }
}

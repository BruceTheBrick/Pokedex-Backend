using System.Text.Json.Serialization;

namespace Pokedex_Backend.APIs.Pokemon_List_Models;

public sealed class PokemonSprites
{
    [JsonPropertyName("back_default")]
    public string? BackDefault { get; init; }

    [JsonPropertyName("back_female")]
    public string? BackFemale { get; init; }

    [JsonPropertyName("back_shiny")]
    public string? BackShiny { get; init; }

    [JsonPropertyName("back_shiny_female")]
    public string? BackShinyFemale { get; init; }

    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; init; }

    [JsonPropertyName("front_female")]
    public string? FrontFemale { get; init; }

    [JsonPropertyName("front_shiny")]
    public string? FrontShiny { get; init; }

    [JsonPropertyName("front_shiny_female")]
    public string? FrontShinyFemale { get; init; }

    [JsonPropertyName("other")]
    public required PokemonOtherSprites Other { get; init; }

    [JsonPropertyName("versions")]
    public required PokemonVersionSprites Versions { get; init; }
}

public sealed class PokemonOtherSprites
{
    [JsonPropertyName("dream_world")]
    public required DreamWorldSprites DreamWorld { get; init; }

    [JsonPropertyName("home")]
    public required HomeSprites Home { get; init; }

    [JsonPropertyName("official-artwork")]
    public required OfficialArtworkSprites OfficialArtwork { get; init; }

    [JsonPropertyName("showdown")]
    public required ShowdownSprites Showdown { get; init; }
}

public sealed class DreamWorldSprites
{
    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; init; }

    [JsonPropertyName("front_female")]
    public string? FrontFemale { get; init; }
}

public sealed class HomeSprites
{
    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; init; }

    [JsonPropertyName("front_female")]
    public string? FrontFemale { get; init; }

    [JsonPropertyName("front_shiny")]
    public string? FrontShiny { get; init; }

    [JsonPropertyName("front_shiny_female")]
    public string? FrontShinyFemale { get; init; }
}

public sealed class OfficialArtworkSprites
{
    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; init; }

    [JsonPropertyName("front_shiny")]
    public string? FrontShiny { get; init; }
}

public sealed class ShowdownSprites
{
    [JsonPropertyName("back_default")]
    public string? BackDefault { get; init; }

    [JsonPropertyName("back_female")]
    public string? BackFemale { get; init; }

    [JsonPropertyName("back_shiny")]
    public string? BackShiny { get; init; }

    [JsonPropertyName("back_shiny_female")]
    public string? BackShinyFemale { get; init; }

    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; init; }

    [JsonPropertyName("front_female")]
    public string? FrontFemale { get; init; }

    [JsonPropertyName("front_shiny")]
    public string? FrontShiny { get; init; }

    [JsonPropertyName("front_shiny_female")]
    public string? FrontShinyFemale { get; init; }
}

public sealed class PokemonVersionSprites
{
    [JsonPropertyName("generation-i")]
    public required GenerationISprites GenerationI { get; init; }

    [JsonPropertyName("generation-ii")]
    public required GenerationIISprites GenerationII { get; init; }

    [JsonPropertyName("generation-iii")]
    public required GenerationIIISprites GenerationIII { get; init; }

    [JsonPropertyName("generation-iv")]
    public required GenerationIVSprites GenerationIV { get; init; }

    [JsonPropertyName("generation-v")]
    public required GenerationVSprites GenerationV { get; init; }

    [JsonPropertyName("generation-vi")]
    public required GenerationVISprites GenerationVI { get; init; }

    [JsonPropertyName("generation-vii")]
    public required GenerationVIISprites GenerationVII { get; init; }

    [JsonPropertyName("generation-viii")]
    public required GenerationVIIISprites GenerationVIII { get; init; }
}

// Generation I
public sealed class GenerationISprites
{
    [JsonPropertyName("red-blue")]
    public required RedBlueSprites RedBlue { get; init; }

    [JsonPropertyName("yellow")]
    public required YellowSprites Yellow { get; init; }
}

public sealed class RedBlueSprites
{
    [JsonPropertyName("back_default")]
    public string? BackDefault { get; init; }

    [JsonPropertyName("back_gray")]
    public string? BackGray { get; init; }

    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; init; }

    [JsonPropertyName("front_gray")]
    public string? FrontGray { get; init; }
}

public sealed class YellowSprites
{
    [JsonPropertyName("back_default")]
    public string? BackDefault { get; init; }

    [JsonPropertyName("back_gray")]
    public string? BackGray { get; init; }

    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; init; }

    [JsonPropertyName("front_gray")]
    public string? FrontGray { get; init; }
}

// Generation II
public sealed class GenerationIISprites
{
    [JsonPropertyName("crystal")]
    public required CrystalSprites Crystal { get; init; }

    [JsonPropertyName("gold")]
    public required GoldSprites Gold { get; init; }

    [JsonPropertyName("silver")]
    public required SilverSprites Silver { get; init; }
}

public sealed class CrystalSprites
{
    [JsonPropertyName("back_default")]
    public string? BackDefault { get; init; }

    [JsonPropertyName("back_shiny")]
    public string? BackShiny { get; init; }

    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; init; }

    [JsonPropertyName("front_shiny")]
    public string? FrontShiny { get; init; }
}

public sealed class GoldSprites
{
    [JsonPropertyName("back_default")]
    public string? BackDefault { get; init; }

    [JsonPropertyName("back_shiny")]
    public string? BackShiny { get; init; }

    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; init; }

    [JsonPropertyName("front_shiny")]
    public string? FrontShiny { get; init; }
}

public sealed class SilverSprites
{
    [JsonPropertyName("back_default")]
    public string? BackDefault { get; init; }

    [JsonPropertyName("back_shiny")]
    public string? BackShiny { get; init; }

    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; init; }

    [JsonPropertyName("front_shiny")]
    public string? FrontShiny { get; init; }
}

// Generation III
public sealed class GenerationIIISprites
{
    [JsonPropertyName("emerald")]
    public required EmeraldSprites Emerald { get; init; }

    [JsonPropertyName("firered-leafgreen")]
    public required FireRedLeafGreenSprites FireRedLeafGreen { get; init; }

    [JsonPropertyName("ruby-sapphire")]
    public required RubySapphireSprites RubySapphire { get; init; }
}

public sealed class EmeraldSprites
{
    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; init; }

    [JsonPropertyName("front_shiny")]
    public string? FrontShiny { get; init; }
}

public sealed class FireRedLeafGreenSprites
{
    [JsonPropertyName("back_default")]
    public string? BackDefault { get; init; }

    [JsonPropertyName("back_shiny")]
    public string? BackShiny { get; init; }

    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; init; }

    [JsonPropertyName("front_shiny")]
    public string? FrontShiny { get; init; }
}

public sealed class RubySapphireSprites
{
    [JsonPropertyName("back_default")]
    public string? BackDefault { get; init; }

    [JsonPropertyName("back_shiny")]
    public string? BackShiny { get; init; }

    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; init; }

    [JsonPropertyName("front_shiny")]
    public string? FrontShiny { get; init; }
}

// Generation IV
public sealed class GenerationIVSprites
{
    [JsonPropertyName("diamond-pearl")]
    public required DiamondPearlSprites DiamondPearl { get; init; }

    [JsonPropertyName("heartgold-soulsilver")]
    public required HeartGoldSoulSilverSprites HeartGoldSoulSilver { get; init; }

    [JsonPropertyName("platinum")]
    public required PlatinumSprites Platinum { get; init; }
}

public sealed class DiamondPearlSprites
{
    [JsonPropertyName("back_default")]
    public string? BackDefault { get; init; }

    [JsonPropertyName("back_female")]
    public string? BackFemale { get; init; }

    [JsonPropertyName("back_shiny")]
    public string? BackShiny { get; init; }

    [JsonPropertyName("back_shiny_female")]
    public string? BackShinyFemale { get; init; }

    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; init; }

    [JsonPropertyName("front_female")]
    public string? FrontFemale { get; init; }

    [JsonPropertyName("front_shiny")]
    public string? FrontShiny { get; init; }

    [JsonPropertyName("front_shiny_female")]
    public string? FrontShinyFemale { get; init; }
}

public sealed class HeartGoldSoulSilverSprites
{
    [JsonPropertyName("back_default")]
    public string? BackDefault { get; init; }

    [JsonPropertyName("back_female")]
    public string? BackFemale { get; init; }

    [JsonPropertyName("back_shiny")]
    public string? BackShiny { get; init; }

    [JsonPropertyName("back_shiny_female")]
    public string? BackShinyFemale { get; init; }

    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; init; }

    [JsonPropertyName("front_female")]
    public string? FrontFemale { get; init; }

    [JsonPropertyName("front_shiny")]
    public string? FrontShiny { get; init; }

    [JsonPropertyName("front_shiny_female")]
    public string? FrontShinyFemale { get; init; }
}

public sealed class PlatinumSprites
{
    [JsonPropertyName("back_default")]
    public string? BackDefault { get; init; }

    [JsonPropertyName("back_female")]
    public string? BackFemale { get; init; }

    [JsonPropertyName("back_shiny")]
    public string? BackShiny { get; init; }

    [JsonPropertyName("back_shiny_female")]
    public string? BackShinyFemale { get; init; }

    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; init; }

    [JsonPropertyName("front_female")]
    public string? FrontFemale { get; init; }

    [JsonPropertyName("front_shiny")]
    public string? FrontShiny { get; init; }

    [JsonPropertyName("front_shiny_female")]
    public string? FrontShinyFemale { get; init; }
}

// Generation V
public sealed class GenerationVSprites
{
    [JsonPropertyName("black-white")]
    public required BlackWhiteSprites BlackWhite { get; init; }
}

public sealed class BlackWhiteSprites
{
    [JsonPropertyName("animated")]
    public required AnimatedSprites Animated { get; init; }

    [JsonPropertyName("back_default")]
    public string? BackDefault { get; init; }

    [JsonPropertyName("back_female")]
    public string? BackFemale { get; init; }

    [JsonPropertyName("back_shiny")]
    public string? BackShiny { get; init; }

    [JsonPropertyName("back_shiny_female")]
    public string? BackShinyFemale { get; init; }

    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; init; }

    [JsonPropertyName("front_female")]
    public string? FrontFemale { get; init; }

    [JsonPropertyName("front_shiny")]
    public string? FrontShiny { get; init; }

    [JsonPropertyName("front_shiny_female")]
    public string? FrontShinyFemale { get; init; }
}

public sealed class AnimatedSprites
{
    [JsonPropertyName("back_default")]
    public string? BackDefault { get; init; }

    [JsonPropertyName("back_female")]
    public string? BackFemale { get; init; }

    [JsonPropertyName("back_shiny")]
    public string? BackShiny { get; init; }

    [JsonPropertyName("back_shiny_female")]
    public string? BackShinyFemale { get; init; }

    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; init; }

    [JsonPropertyName("front_female")]
    public string? FrontFemale { get; init; }

    [JsonPropertyName("front_shiny")]
    public string? FrontShiny { get; init; }

    [JsonPropertyName("front_shiny_female")]
    public string? FrontShinyFemale { get; init; }
}

// Generation VI
public sealed class GenerationVISprites
{
    [JsonPropertyName("omegaruby-alphasapphire")]
    public required OmegaRubyAlphaSapphireSprites OmegaRubyAlphaSapphire { get; init; }

    [JsonPropertyName("x-y")]
    public required XYSprites XY { get; init; }
}

public sealed class OmegaRubyAlphaSapphireSprites
{
    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; init; }

    [JsonPropertyName("front_female")]
    public string? FrontFemale { get; init; }

    [JsonPropertyName("front_shiny")]
    public string? FrontShiny { get; init; }

    [JsonPropertyName("front_shiny_female")]
    public string? FrontShinyFemale { get; init; }
}

public sealed class XYSprites
{
    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; init; }

    [JsonPropertyName("front_female")]
    public string? FrontFemale { get; init; }

    [JsonPropertyName("front_shiny")]
    public string? FrontShiny { get; init; }

    [JsonPropertyName("front_shiny_female")]
    public string? FrontShinyFemale { get; init; }
}

// Generation VII
public sealed class GenerationVIISprites
{
    [JsonPropertyName("icons")]
    public required IconsSprites Icons { get; init; }

    [JsonPropertyName("ultra-sun-ultra-moon")]
    public required UltraSunUltraMoonSprites UltraSunUltraMoon { get; init; }
}

public sealed class IconsSprites
{
    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; init; }

    [JsonPropertyName("front_female")]
    public string? FrontFemale { get; init; }
}

public sealed class UltraSunUltraMoonSprites
{
    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; init; }

    [JsonPropertyName("front_female")]
    public string? FrontFemale { get; init; }

    [JsonPropertyName("front_shiny")]
    public string? FrontShiny { get; init; }

    [JsonPropertyName("front_shiny_female")]
    public string? FrontShinyFemale { get; init; }
}

// Generation VIII
public sealed class GenerationVIIISprites
{
    [JsonPropertyName("icons")]
    public required IconsSprites Icons { get; init; }
}

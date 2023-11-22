namespace Domain.Models;

public record Company(
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("is_state")] bool IsState,
    [property: JsonPropertyName("distance")] int Distance
) { }

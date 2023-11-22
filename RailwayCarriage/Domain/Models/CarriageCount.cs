namespace Domain.Models;

public record CarriageCount(
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("company_id")] int CompanyId,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("count")] int Count,
    [property: JsonPropertyName("broken_percent")] int BrokenPercent
) { }

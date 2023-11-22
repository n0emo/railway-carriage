using System.Text.Json;
using Domain.Models;

var companies = JsonSerializer.Deserialize<List<Company>>(
    File.ReadAllText("../Domain/companies.json")
)!;

Console.WriteLine(string.Join('\n', companies));

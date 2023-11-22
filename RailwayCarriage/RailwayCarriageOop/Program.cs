using System.Text.Json;
using Domain.Models;
using RailwayCarriage.Utils;

var companies = JsonSerializer.Deserialize<List<Company>>(
    File.ReadAllText("../Domain/companies.json")
)!;

var radiuses = Enumerable.Range(1, 100).Select(n => n * 100).ToArray();

foreach(var radius in radiuses)
{

}



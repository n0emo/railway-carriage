namespace RailwayCarriage.Utils;

using Newtonsoft.Json;

public static class Dumper
{    
    private static JsonSerializerSettings _settings = new JsonSerializerSettings()
    {
        Formatting = Formatting.Indented,
    };
    public static void Dump<T>(this T obj, string? name = null)
    {
        var json = JsonConvert.SerializeObject(obj, settings:_settings);
        
        if(name is not null)
        {
            Console.Write($"{name} = ");
        }
        Console.WriteLine(json);
    }
}

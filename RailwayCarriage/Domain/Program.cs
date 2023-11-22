
using System.Text;
using Domain.Models;

void CreateSampleData()
{
    var companies = new List<Company>
    {
        new(1, "Federal XD", true, 400),
        new(2, "Federal XD Pushkin", true, 15600),
        new(3, "From Ivanych", false, 2350),
        new(4, "State Podzol Goverment Company", true, 460),
        new(5, "State Maneken", true, 780),
        new(6, "Hard Metal Inc.", false, 2500),
        new(7, "Ivan Ivanych Corp", false, 1400),
        new(8, "Federal Municipal Goverment Russian Railway Russian Carriage Factory", true, 250),
        new(9, "OAO RJD Carriages", true, 4500),
        new(10, "Vladimir Medvedev's State Company", true, 4400),
        new(11, "Medved Vladimirov's Company", false, 3000),
        new(12, "International Carriage Courier", false, 13000),
        new(13, "American-Belorussian Factory", false, 3680),
        new(14, "Nord Steel", true, 2800),
    };

    var carriageCounts = new List<CarriageCount>
    { 
        new(1, 1, "BoxMotor", 354, 10),
        new(2, 1, "CargoSprinter", 286, 16),
        new(3, 1, "Conflat", 339, 23),
        new(4, 1, "Double-stack car", 394, 18),
        new(5, 1, "Megafret", 438, 32),

        new(6, 2, "BoxMotor", 135, 1),
        new(7, 2, "CargoSprinter", 177, 19),
        new(8, 2, "Conflat", 139, 10),
        new(9, 2, "Double-stack car", 115, 16),
        new(10, 2, "Megafret", 480, 23),

        new(11, 3, "BoxMotor", 221, 0),
        new(12, 3, "CargoSprinter", 382, 1),
        new(13, 3, "Conflat", 256, 4),
        new(14, 3, "Megafret", 332, 25),

        new(15, 4, "BoxMotor", 95, 23),
        new(16, 4, "CargoSprinter", 141, 11),
        new(17, 4, "Conflat", 258, 16),
        new(18, 4, "Double-stack car", 127, 19),
        new(19, 4, "Megafret", 445, 18),

        new(20, 5, "CargoSprinter", 175, 24),
        new(21, 5, "Conflat", 86, 10),
        new(22, 5, "Double-stack car", 123, 9),
        new(23, 5, "Megafret", 126, 17),

        new(24, 6, "BoxMotor", 292, 15),
        new(25, 6, "CargoSprinter", 253, 32),
        new(26, 6, "Double-stack car", 470, 9),
        new(27, 6, "Megafret", 7, 1),

        new(28, 7, "BoxMotor", 26, 0),
        new(29, 7, "CargoSprinter", 140, 4),
        new(30, 7, "Double-stack car", 110, 21),

        new(31, 8, "BoxMotor", 447, 33),
        new(32, 8, "CargoSprinter", 225, 26),
        new(33, 8, "Conflat", 34, 14),
        new(34, 8, "Double-stack car", 341, 3),
        new(35, 8, "Megafret", 14, 15),

        new(36, 9, "CargoSprinter", 341, 12),
        new(37, 9, "Conflat", 265, 30),
        new(38, 9, "Megafret", 108, 32),

        new(39, 10, "BoxMotor", 147, 6),
        new(40, 10, "CargoSprinter", 90, 12),
        new(41, 10, "Conflat", 55, 16),
        new(42, 10, "Double-stack car", 206, 23),
        new(43, 10, "Megafret", 0, 9),

        new(44, 11, "CargoSprinter", 421, 23),
        new(45, 11, "Conflat", 273, 18),
        new(46, 11, "Double-stack car", 200, 21),
        new(47, 11, "Megafret", 271, 6),

        new(48, 12, "BoxMotor", 209, 29),
        new(49, 12, "Double-stack car", 358, 2),
        new(50, 12, "Megafret", 32, 2),

        new(51, 13, "BoxMotor", 476, 20),
        new(52, 13, "CargoSprinter", 340, 20),
        new(53, 13, "Conflat", 332, 23),
        new(54, 13, "Double-stack car", 462, 13),
        new(55, 13, "Megafret", 475, 25),

        new(56, 14, "BoxMotor", 408, 7),
        new(57, 14, "CargoSprinter", 60, 26),
        new(58, 14, "Conflat", 428, 33),
        new(59, 14, "Megafret", 227, 5),
    };

    File.WriteAllText("companies.json", JsonSerializer.Serialize(companies));
    File.WriteAllText("carriage_counts.json", JsonSerializer.Serialize(carriageCounts));
}

string CreateRandomCarriagesCsharp(int count, int indentLevel)
{
    string[] types = new string[] { "BoxMotor", "CargoSprinter", "Conflat", "Double-stack car", "Megafret" };
    string indent = new string(' ', indentLevel * 4);

    int currentCarriage = 1;

    var sb = new StringBuilder();

    for (var currentCompany = 1; currentCompany <= count; currentCompany++)
    {
        foreach (var type in types)
        {
            int include = Random.Shared.Next(100);
            if (include < 20)
            {
                continue;
            }

            int carriageCount = Random.Shared.Next(500);
            int brokenPercent = Random.Shared.Next(35);

            sb
                .Append(indent)
                .Append("new")
                .Append("(")
                .Append(currentCarriage)
                .Append(", ")
                .Append(currentCompany)
                .Append(", ")
                .Append('\"')
                .Append(type)
                .Append('\"')
                .Append(", ")
                .Append(carriageCount)
                .Append(", ")
                .Append(brokenPercent)
                .Append("),\n");

            currentCarriage++;

        }
        sb.Append("\n");
    }


    return sb.ToString();
}

CreateSampleData();

// Console.WriteLine(CreateRandomCarriagesCsharp(14, 2));

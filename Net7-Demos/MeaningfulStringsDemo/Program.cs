
using System.Diagnostics.CodeAnalysis;

// >= .NET 6

PrintRegexLegacy(@"/^\\w+([\\.-]?\\w+)*@\\w+([\\.-]?\\w+)*(\\.\\w{2,3})+$/");


// .NET 7

//PrintJson(@"{""id"": 2, ""name"": ""Deyvid""}");
//PrintRegex(@"/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/");
//PrintDateTimeNowInSpecificFormat("dddd M yyyyy");


static void PrintRegexLegacy(string regex)
{
    Console.WriteLine(regex);
}


static void PrintJson([StringSyntax(StringSyntaxAttribute.Json)]string json)
{
    Console.WriteLine(json);
}

static void PrintRegex([StringSyntax(StringSyntaxAttribute.Regex)] string regex)
{
    Console.WriteLine(regex);
}

static void PrintDateTimeNowInSpecificFormat([StringSyntax(StringSyntaxAttribute.DateTimeFormat)] string format)
{
    Console.WriteLine(DateTime.UtcNow.ToString(format));
}


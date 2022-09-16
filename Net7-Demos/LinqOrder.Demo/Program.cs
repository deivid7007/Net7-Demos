#pragma warning disable

var data = new[] { 2, 1, 3, 6, 5 };
IEnumerable<int> sorted = null;
IEnumerable<int> sortedDesc = null;

// NET 6 syntax
sorted = data.OrderBy(e => e);
sortedDesc = data.OrderByDescending(e => e);

// NET 7 syntax
//sorted = data.Order();
//sortedDesc = data.OrderDescending();

// Printing sorted values
Console.WriteLine("ASC:");
foreach (var item in sorted)
{
    Console.WriteLine(item);
}

Console.WriteLine("DESC:");
foreach (var item in sortedDesc)
{
    Console.WriteLine(item);
}
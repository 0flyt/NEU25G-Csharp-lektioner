

var objectList = new List<object>();

objectList.Add("Hello world!");
objectList.Add("This is a text");
objectList.Add(5.3);
objectList.Add("Hej");
objectList.Add(true);
objectList.Add(94);
objectList.Add('a');
objectList.Add("Bye!");

//var stringList = new List<string>();

//foreach (var o in objectList)
//{
//    if (o is string s) stringList.Add(s);
//}

Console.WriteLine("\nobjectList:");
Console.WriteLine(string.Join('\n', objectList));

var stringList = objectList.OfType<string>().ToList();

Console.WriteLine("\n*** OfType - Filters the elements based on a specified type - E.g. OfType<string> ***");
Console.WriteLine("\nstringList:");
Console.WriteLine(string.Join('\n', stringList));

Console.WriteLine("\n*** Any, All ***\n");

Console.WriteLine($"stringList.Any() => {stringList.Any()}");
Console.WriteLine($"stringList.Any(s => s.Length == 4) => {stringList.Any(s => s.Length == 4)}");
Console.WriteLine($"stringList.All(s => s.Length >= 4) => {stringList.All(s => s.Length >= 4)}");
Console.WriteLine($"stringList.All(s => == \"Hej\") => {stringList.Any(s => s == "Hej")}");
Console.WriteLine($"stringList.All(s => s.Contains(\"ye\")) => {stringList.Any(s => s.Contains("ye"))}");
Console.WriteLine($"stringList.All(s => s.ToLower() == \"hej\")) => {stringList.Any(s => s.ToLower() == "hej")}");
Console.WriteLine($"stringList.All(s => s.Split(' ').Length == 3)) => {stringList.Any(s => s.Split(' ').Length == 3)}");
Console.WriteLine($"stringList.All(s => s.StartsWith('B')) => {stringList.All(s => s.StartsWith('B'))}");

// List<Enemy> enemies = levelElements.OfType<Enemy>().ToList();
// if (enemies.Any(e => e.HP < 5) ...


Console.WriteLine("\n*** Where ***\n");

var filteredStrings = stringList.Where(s => s.Length <= 12).ToList();
Console.WriteLine("\nstringList.Where(s => s.Length <= 12).ToList() =>");
Console.WriteLine(string.Join('\n', filteredStrings));

//foreach (var enemy in enemies.Where(e => e.HP < 5))
//{
//    Console.WriteLine(enemy.Name);
//}

Console.WriteLine("\n*** Select ***\n");

var people = new[]
{
    new { FirstName = "Anders", LastName = "Svensson", Age = 34 },
    new { FirstName = "Maria", LastName = "Bengtsoon", Age = 24 },
    new { FirstName = "Pelle", LastName = "Andersson", Age = 73 },
    new { FirstName = "Frida", LastName = "Palm", Age = 47 },
    new { FirstName = "Kalle", LastName = "Kvist", Age = 35},
    new { FirstName = "Gudrun", LastName = "Öberg", Age = 14 }
}.ToList();

var people2 = people
    .Where(p => p.Age < 30)
    .Select(p => new {
        FullName = $"{p.FirstName} {p.LastName}",
        Age = p.Age,
        FirstNameLength = p.FirstName.Length 
    })
    .Where(p => p.FirstNameLength == 4)
    .ToList();

Console.WriteLine();

Console.WriteLine("\n*** OrderBy ***\n");

Console.WriteLine("people.OrderBy(p => p.Age) => ");
foreach (var p in people.OrderBy(p => p.Age))
{
    Console.WriteLine(p);
}

Console.WriteLine("\npeople.OrderByDescending(p => p.FirstName) => ");
foreach (var p in people.OrderByDescending(p => p.FirstName))
{
    Console.WriteLine(p);
}

var querySyntax = from p in people where p.Age > 30 select p.Age;

var methodSyntax = people.Where(p => p.Age > 30).Select(p => p.Age);

Console.WriteLine();


foreach (var age in querySyntax)
{
    Console.WriteLine(age);
}

Console.WriteLine();
people.Add(new { FirstName = "Olof", LastName = "Kalm", Age = 51 });

foreach (var age in querySyntax)
{
    Console.WriteLine(age);
}





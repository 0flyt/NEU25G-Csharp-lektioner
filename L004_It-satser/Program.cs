Console.WriteLine("Start");

Random rnd = new Random();

if (rnd.Next(2) == 1)
    Console.WriteLine("Kanske");
else
    Console.WriteLine("Kanske inte");

Console.WriteLine("Slut");

Console.WriteLine("Skriv ditt namn: ");
string name = Console.ReadLine().ToLower();

switch (name)
{
    case "fredrik":
        Console.WriteLine("Du heter Fredrik");
        break;
    default:
        Console.WriteLine("Du heter inte Fredrik");
        break;
            
}

Console.WriteLine(name == "fredrik" ? $"Hej {name}" : $"Inte hej, {name}");


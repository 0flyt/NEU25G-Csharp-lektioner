

var person = new { FirstName = "Anders", LastName = "Svensson", Age = 34 };

Console.WriteLine(person.FirstName);
Console.WriteLine(person.Age);

var typeExamples = new { Float = 3.2f, Double = 5.4, Decimal = 102.3m, Bool = true  };

Console.WriteLine();

var countries = new string[] { "Sweden", "Denmark", "Norway" };

var people = new[]
{
    new { FirstName = "Anders", LastName = "Svensson", Age = 34 },
    new { FirstName = "Maria", LastName = "Bengtsoon", Age = 24 },
    new { FirstName = "Pelle", LastName = "Andersson", Age = 73 },
    new { FirstName = "Frida", LastName = "Palm", Age = 47 },
    new { FirstName = "Kalle", LastName = "Kvist", Age = 35},
    new { FirstName = "Gudrun", LastName = "Öberg", Age = 14 }
};

foreach (var p in people)
{
    Console.WriteLine($"{p.FirstName} {p.LastName} är {p.Age} år gammal.");
}
Console.WriteLine();

var user = new
{
    name = "Anders Eriksson",
    age = 45,
    contactInfo = new { eMail = "anders@gmail.com", phone = "0707123123" }
};

Console.WriteLine(user.contactInfo.eMail);
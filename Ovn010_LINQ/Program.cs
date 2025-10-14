//1.Anonyma datatyper
//Skapa en array "people" med anonyma datatyper. Varje objekt i arrayen ska ha följande properties:
//FirstName, LastName, Age, Height, Weight.

//Lägg till minst 8 sådana objekt i arrayen.

var people = new[]
{
    new { FirstName = "Anders", LastName = "Andersson", Age = 34, Height = 1.93, Weight = 90 },
    new { FirstName = "Maria", LastName = "Bengtsoon", Age = 24, Height = 1.73, Weight = 75 },
    new { FirstName = "Pelle", LastName = "Andersson", Age = 73, Height = 1.68, Weight = 60 },
    new { FirstName = "Frida", LastName = "Palm", Age = 47, Height = 1.76, Weight = 81 },
    new { FirstName = "Kalle", LastName = "Kvist", Age = 35, Height = 1.75, Weight = 78 },
    new { FirstName = "Gudrun", LastName = "Öberg", Age = 14, Height = 1.50, Weight = 67 },
    new { FirstName = "Robin", LastName = "Treman", Age = 17, Height = 1.58, Weight = 65 },
    new { FirstName = "Mio", LastName = "Kvibergsson", Age = 46, Height = 1.79, Weight = 89 }
};

//Använd dig sedan av LINQ för att lösa följande uppgifter:

//2.Filtrera på ålder
//Filtrera arrayen (uppgift 1) så du får en ny lista med endast de användare som är mellan 20 och 40 år gamla.

Console.WriteLine("Method syntax:");
var ageBetween20and40 = people.Where(p => p.Age > 20 && p.Age < 40).ToList();
foreach (var p in ageBetween20and40)
{
    Console.WriteLine(p);
}
Console.WriteLine();
Console.WriteLine("Query syntax:");
var qAgeBetween20and40 = (from p in people where p.Age > 20 && p.Age < 40 select p).ToList();
foreach (var p in qAgeBetween20and40)
{
    Console.WriteLine(p);
}
Console.WriteLine();

//3. Är någon längre än 190 cm?
//Är någon av personerna mellan 20 och 40 år längre än 190 cm lång?

Console.WriteLine("Method syntax:");
var longerThan190 = ageBetween20and40.Where(p => p.Height > 1.90);
foreach (var p in longerThan190)
{
    Console.WriteLine(p);
}
Console.WriteLine();

Console.WriteLine("Query syntax:");
var qLongerThan190 = from p in qAgeBetween20and40 where p.Height > 1.90 select p;
foreach (var p in qLongerThan190)
{
    Console.WriteLine(p);
}
Console.WriteLine();

//4. Filtrera på namn
//Filtrera arrayen från uppgift 1 så att du får en ny lista med endast de användare vars förnamn är längre än efternamnet
//(d.v.s större antal bokstäver). I den nya listan vill vi att objekten ska ha endast properties FirstName och LastName.

Console.WriteLine("Method syntax:");
var longerFirstThanLastName = people
    .Where(p => p.FirstName.Length > p.LastName.Length)
    .Select(p => new
        {
            p.FirstName,
            p.LastName
        })
    .ToList();
foreach (var p in longerFirstThanLastName)
{
    Console.WriteLine(p);
}
Console.WriteLine();

Console.WriteLine("Query syntax:");
var qLongerFirstThanLastName = (from p in people where p.FirstName.Length > p.LastName.Length select new { p.FirstName, p.LastName }).ToList();
foreach (var p in qLongerFirstThanLastName)
{
    Console.WriteLine(p);
}
Console.WriteLine();

//5. Hela namnet tillsammans med BMI
//Skapa en ny lista från arrayen (från uppgift 1) som innehåller objekt med properties Name (hela namnet),
//samt BMI (uträknat från längd och vikt) för alla personer.

Console.WriteLine("Method syntax:");
var fullNameAndBMI = people
    .Select(p => new
    {
        Name = $"{p.FirstName} {p.LastName}",
        BMI = p.Weight / (p.Height * p.Height)
    })
    .ToList();
foreach (var p in fullNameAndBMI)
{
    Console.WriteLine(p);
}
Console.WriteLine();

Console.WriteLine("Query syntax:");
var qFullNameAndBMI = (from p in people select new { Name = $"{p.FirstName} {p.LastName}", BMI = p.Weight / (p.Height * p.Height) }).ToList();
foreach (var p in qFullNameAndBMI)
{
    Console.WriteLine(p);
}
Console.WriteLine();

//6. Filtrera listan ovan på BMI
//Filtrera listan (från uppgift 5) så att du endast får med personer med BMI under 20 eller BMI över 25.

Console.WriteLine("Method syntax:");
var lowOrHighBMI = fullNameAndBMI.Where(p => p.BMI < 20 || p.BMI > 25);
foreach (var p in lowOrHighBMI)
{
    Console.WriteLine(p);
}
Console.WriteLine();

Console.WriteLine("Query syntax:");
var qLowOrHighBMI = from p in qFullNameAndBMI where p.BMI < 20 || p.BMI > 25 select p;
foreach (var p in qLowOrHighBMI)
{
    Console.WriteLine(p);
}
Console.WriteLine();

//7. Filtrera orginallistan på BMI
//Filtrera arrayen (från uppgift 1) så att du endast får med personer med BMI under 20 eller BMI över 25.

Console.WriteLine("Method syntax:");
var filterBMI = people.Where(p => p.Weight / (p.Height * p.Height) < 20 || p.Weight / (p.Height * p.Height) > 25);
foreach (var p in filterBMI)
{
    Console.WriteLine(p);
}
Console.WriteLine();

Console.WriteLine("Query syntax:");
var qFilterBMI = from p in people where p.Weight / (p.Height * p.Height) < 20 || p.Weight / (p.Height * p.Height) > 25 select p;
foreach (var p in qFilterBMI)
{
    Console.WriteLine(p);
}
Console.WriteLine();

//8. Username tillsammans med Category
//Skapa en ny lista från arrayen (i uppgift 1) som innehåller objekt med properties Username (förnamnet + åldern, ex. “Kalle23”),
//samt Category (som har värdet “Child” eller “Adult” beroende på om personen är under 18 eller inte).

Console.WriteLine("Method syntax:");
var userList = people
    .Select(p => new
        {
            Username = $"{p.FirstName}{p.Age}",
            Category = p.Age >= 18 ? "Adult" : "Child"
        })
    .ToList();
foreach (var p in userList)
{
    Console.WriteLine(p);
}
Console.WriteLine();

Console.WriteLine("Query syntax:");
var qUserList = (from p in people select new { Username = $"{p.FirstName}{p.Age}", Category = p.Age >= 18 ? "Adult" : "Child" }).ToList();
foreach (var p in qUserList)
{
    Console.WriteLine(p);
}
Console.WriteLine();

//9. Query syntax
//Lös alla uppgifter 2 - 8 med query-syntax (om du använt method-syntax, annars tvärtom).

//10. Sortera efter längd
//LINQ använder metoderna .OrderBy() och .OrderByDescending() för att sortera data.

//Skriv ut alla personer (från uppgift 1) i längdordning (kortast först).

var orderHeight = people.OrderBy(p => p.Height);
foreach (var p in orderHeight)
{
    Console.WriteLine(p);
}
Console.WriteLine();

//11. Sortera äldst till yngst
//Skriv ut alla personer (från uppgift 1) sortera efter ålder; från äldst till yngst.

var orderAge = people.OrderByDescending(p => p.Age);
foreach (var p in orderAge)
{
    Console.WriteLine(p);
}
Console.WriteLine();

//12. Sortering i första och andra hand
//Efter .OrderBy eller .OrderByDescending() kan man använda .ThenBy() och .ThenByDescending()
//för att sortera på något annat i andra hand (om flera objekt har samma värden i första sorteringen).

//Skriv ut alla personer (från uppgift 1) sorterade på efternamn i stigande ordning (A → Z).
//Om flera personer har samma efternamn, sortera dessa på förnamn i fallande ordning (Z → A).

var orderName = people.OrderBy(p => p.LastName).ThenByDescending(p => p.FirstName);
foreach (var p in orderName)
{
    Console.WriteLine(p);
}
Console.WriteLine();
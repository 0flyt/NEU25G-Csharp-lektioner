

var countries = new List<string>() { "Sweden", "Denmark", "Norway" };

// removes all elements
//countries.Clear();

countries.Add("Finland");
countries.Add("Germany");


//countries.Remove("Norway");
//countries.RemoveAt(2);
//countries.RemoveRange(0, 2);

Console.WriteLine($"Number of countries in list: {countries.Count}");

countries.Sort();

foreach (var country in countries)
{
    Console.WriteLine(country);
}

var myCountry = "Sweden";
Console.WriteLine($"countries.Contains(\"{myCountry}\") => {countries.Contains(myCountry)}");

Console.WriteLine();
var numbers = new List<int>();
for (int i = 0; i < 40; i++)
{
    Console.WriteLine($"numbers.Count => {numbers.Count}, numbers.Capacity => {numbers.Capacity}");
    numbers.Add(234);
}

//numbers.Capacity = numbers.Count;
numbers.TrimExcess(); // <-- Gör samma som raden ovan.
Console.WriteLine();
Console.WriteLine($"numbers.Count => {numbers.Count}, numbers.Capacity => {numbers.Capacity}");

var myArray = new int[50];
Array.Resize(ref myArray, 25);
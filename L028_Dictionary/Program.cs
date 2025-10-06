
var myDictionary = new Dictionary<string, string>();

myDictionary.Add("boy", "pojke");
myDictionary.Add("girl", "flicka");
myDictionary.Add("man", "man");
myDictionary.Add("woman", "kvinna");

Console.WriteLine("Keys:");

foreach (var key in myDictionary.Keys)
{
    Console.WriteLine(key);
}
Console.WriteLine("\nValues:");

foreach (var value in myDictionary.Values)
{
    Console.WriteLine(value);
}

Console.WriteLine("\nKeys with values:");

foreach (var keyValuePair in myDictionary)
{
    Console.WriteLine($"The key {keyValuePair.Key} holds the value {keyValuePair.Value}");
}

Console.WriteLine($"\nmyDictionary[\"girl\"] => {myDictionary["girl"]}");

string input;
do
{

    input = Console.ReadLine();

    if (myDictionary.ContainsKey(input))
    {
        Console.WriteLine($"{myDictionary[input]}");
    }
    else
    {
        Console.WriteLine("Nyckeln saknas.");
    }
} while (input != string.Empty);

using System.Net.NetworkInformation;
using System.Runtime.ExceptionServices;

//static void FunctionA() // <-- signatur. static är ett keyword.
//{
//    Console.WriteLine("Start of FunctionA.");
//    FunctionB();
//    Console.WriteLine("End of functionA.");
//}

//static void FunctionB()
//{
//    Console.WriteLine("Start of FunctionB.");
//    FunctionC();
//    Console.WriteLine("End of functionB.");
//}

//static void FunctionC()
//{
//    Console.WriteLine("This is FunctionC.");
//}

//FunctionA();
//Console.WriteLine();

// En funktion kan ta 0, 1, eller flera inparametrar.
// Parametrar skrivs kommaseparerade i parantesen efter funktionsnamnet.
// Varje parameter har en datatyp (Datatypen anges alltså per parameter).

// Man kan ange att en parameter är "optional" genom att ge den ett defaultvärde (t.ex int count = 1).
//static void MyFunction(string text, int count = 1, int numberOfExclemationMarks = 3) // Parametrar
//{
//    for (int i = 0; i < count; i++)   
//    {
//        Console.Write(text);
//        for (int j = 0; j < numberOfExclemationMarks; j++)
//            Console.Write("!");
//        Console.WriteLine();
//    }
    
//}

//MyFunction("Min text", 5); // Argument

//Console.Write("Skriv en text: ");
//string text = Console.ReadLine();
//MyFunction(text, 10);
//MyFunction(text); // Här anger jag ingen andra parameter då det finns en default.
//MyFunction("Sju utropstecken", numberOfExclemationMarks: 7);

// Uppgift: Skriv en funktion som tar två heltal in och skriver ut summan av dessa på skärmen.

//static void Adding(int first, int second)
//{
//    Console.WriteLine(first + second);
//}

//Console.Write("Skriv ett heltal: ");
//int first = Int32.Parse(Console.ReadLine());

//Console.Write("Skriv ett till heltal: ");
//int second = Int32.Parse(Console.ReadLine());

//Adding(first, second);

// Uppgift 2: Skriv en funktion som tar två heltal t.ex 2 & 4 och skriver ut en sträng "2 * 4 = 8"

//Console.Write("Skriv ett heltal: ");
//int myFirst = Int32.Parse(Console.ReadLine());

//Console.Write("Skriv ett till heltal: ");
//int mySecond = Int32.Parse(Console.ReadLine());

//static void MyMultiple(int myFirst, int mySecond)
//{
//    Console.Write($"{myFirst} * {mySecond} = {myFirst * mySecond}");
//}

//MyMultiple(myFirst, mySecond);

//Console.WriteLine();

// En funktion kan returnera 0 eller 1 objekt.
// Man anger datatypen på objektet som returneras före funktionsnamnet.
// Alternativt använd "void" om funktionen inte returnerar ett värde.
// Koden (i funktionen) måste ALLTID returnera en matchande datatyp.
//static int AddNumbers(int a, int b)
//{
//    return a + b;
//}

//int x = AddNumbers(3, 5);
//Console.WriteLine(x);

// Uppgift 3: Skriv en funktion som tar en Char och en Int och returnerar en string med bokstaven upprepat x antal gånger.

//static string repeatLetter(int times, char letter)
//{
//    string result = "";
//    for (int i = 0; i < times; i++)
//    {
//        result += letter;
//    }
//    return result;
//}
//Console.WriteLine(repeatLetter(5, 'g'));



// Uppgift 4: Skriv en funktion som tar två heltal 'multiple' och 'length' och returnerar en int[] med längden 'length'
// där varje element är multiplar av multiple i tur och ordning:
// Ex. GetMultiples(3, 5); => int[5] {3, 6, 9, 12, 15 }
// Spara värdet som funktionen returnerar i en variabel, och skriv sedan ut alla värden på skärmen.

//Console.WriteLine();
//static int[] Multiplicera(int multiple, int length)
//{
//    int[] intArray = new int[length];
//    for (int i = 0; i < length; i++)
//    {
//        intArray[i] = (i + 1) * multiple;
//    }
//    return intArray;
//}

//int[] myMulti = Multiplicera(3, 5);

//foreach (var m in myMulti)
//{
//    Console.WriteLine(m);
//}

//Console.WriteLine();

// Keyword 'params' kan användas för att ta in ett okänt antal parametrar av samma datatyp.

static int AddMultipleNumbers(params int[] numbers)
{
    int result = 0;
    foreach (var i in numbers)
    {
        result += i;
    }
    return result;
}

int[] myNumbers = new int[] { 1, 3, 7, 5 };
Console.WriteLine(AddMultipleNumbers( 1, 3, 7 ,5, 10, 100));

// Exempel på hur man kan använda string.Join() för att skriva ut alla element i en array.
Console.WriteLine(string.Join(", ", myNumbers));

Console.WriteLine();

int count = 3;

// Funktioner märkta med 'static' har inte åtkomst till objekt utanför funktionen.
// Tillsvidare använd static på alla funktioner, så ni får inte tänket att funktioner fungerar isolerat/fristående från annan kod.
static void ExampleWithStatic(int count)
{
    Console.WriteLine(count); // <-- count kan inte läsas här.
}

void ExampleWithoutStatic()
{
    Console.WriteLine(count); // <-- count utanför funktionen kan användas här.
}

ExampleWithStatic(5);
ExampleWithoutStatic();

//// sista i <> är output, int i detta fallet
//Func<string, int> myDelegate = CountWords;

//// action<> har void som output, så allt i <> är vad den tar in.

//Console.WriteLine(myDelegate.Invoke("hello world"));

//myDelegate = CountChars;

//Console.WriteLine(myDelegate("hello world"));

//myDelegate = null;

//Console.WriteLine(myDelegate?.Invoke("hello world"));

//if (myDelegate is not null)
//{
//    Console.WriteLine(myDelegate("hello world"));
//}

//var strings = new string[] { "Hello world", "Good morning everyone", "Hej" };

//ProcessArray(strings, CountChars);
//Console.WriteLine();
//ProcessArray(strings, CountWords);
//Console.WriteLine();

//static void ProcessArray(string[] strings, MyDelegate myDelegate)
//{
//    foreach (var item in strings)
//    {
//        Console.WriteLine(myDelegate(item));
//    }
//}
//static int CountChars(string text)
//{
//    return text.Length;
//}

//static int CountWords(string text)
//{
//    return text.Split(' ').Length;
//}


//// Multicast delegate

//MyOtherDelegate funcDelegate = FuncC;

//funcDelegate += FuncB;

//funcDelegate.Invoke("Hello");

//static void FuncA(string text)
//{
//    Console.WriteLine($"FuncA {text}");
//}

//static void FuncB(string text)
//{
//    Console.WriteLine($"FuncB {text}");
//}

//static void FuncC(string text)
//{
//    Console.WriteLine($"FuncC {text}");
//}

//public delegate int MyDelegate(string s);

//public delegate void MyOtherDelegate(string s);

//public delegate TResult MyGenericDelegate<T, TResult>(T s);

// Använd generiska delegat (Func (om man har ett returvärde) Action (inget returvärde) för att lösa följande uppgifter:
// Func<in T1, in T2 (...osv), out TResult>
// Action<in T1, in T2, (... osv med in)>

// Uppgift 1:
// Skapa en funktion som tar två heltal in, plussar ihop dem och skriver ut resultatet.
// Skapa ett generiskt delegat som pekar på metoden och använd detta för att anropa metoden.

static void Adding(int x, int y)
{
    Console.WriteLine(x+y);
}

Action<int, int> myAdd = Adding;

myAdd.Invoke(4,5);

// Uppgift 2:
// Skapa en funktion som tar en char och en int in, samt returnerar en string som innehåller
// bokstaven upprepad antal gånger som man angett i heltalet. Använd ett generiskt delegat
// för att anropa metoden. Skriv ut resultatet.

//Console.WriteLine(NumberOfChars('f', 5));

static string NumberOfChars(char c, int i)
{
    string result = "";
    for (int j = 0; j < i; j++)
    {
        result += c;
    }
    return result;
}

Func<char, int, string> repeatChar = NumberOfChars;

Console.WriteLine(repeatChar.Invoke('t', 10));

// Uppgift 3:
// Skriv en funktion som tar två heltal in, multiplicerar dem och skriver ut resultatet.
// Skriv sedan ytterliggare en funktion som tar in ett heltal tillsammans med ett delegat till
// en metod som tar två heltal in. Om man skickar in t.ex 3 till metoden så ska den ha en loop
// i från 1 till 10, som varje gång anropar delegatmetoden med (3, i).
// Prova att anropa metoden dels med funktionen i uppgift 1, dels med funktionen som multiplicerar.

static void Multiplying(int x, int y)
{
    Console.WriteLine(x*y);
}

Action<int, int> myMultiplier = Multiplying;

myMultiplier(5,5);
Console.WriteLine();

static void loopMultiple(int x, Action<int, int> enFunc)
{
    for (int i = 1; i <= 10; i++)
    {
        enFunc(x, i);
    }
}

loopMultiple(3, myMultiplier);
Console.WriteLine();

loopMultiple(3, Adding);

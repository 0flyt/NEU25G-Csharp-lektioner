// Key word new används för att skapa ett nytt objekt (en instans av en klass):
// 1 - Allokerar minne för att lagra objektet.
// 2 - Skapar objektet på den platsen i minnet, med default värden.
// 3 - Kör konstruktorn.
// 4 - Returnerar en referens till det nya objektet.

Person myPerson = new("Fredrik", 44); // <-- Fungerar även om name och age är private.
Person myOtherPerson = new() { name = "Anders", age = 35 }; // <-- Fungerar inte nmed endast en konstruktor med parametrar eller till private fields.
// Men fungerar om jag skapar en konstruktor till som inte tar emot argument. 
Console.WriteLine(myOtherPerson.name);

class Person
{
    public string name = string.Empty;
    public int age = 0;

    public Person()
    {

    }

    public Person(string name, int age) // Samma namn som klassen och returnerar inget (void, string int osv)
    {
        Console.WriteLine("Konstruktorn körs!");
        this.name = name;
        this.age = age;
    }
}
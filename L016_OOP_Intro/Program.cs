
Cat myCat = new Cat() { name = "Pelle" };
Cat myOtherCat = new Cat() { name = "Måns" };

myCat.Greet();
myOtherCat.Greet("Fredik");

myCat.Greet(myOtherCat);
myOtherCat.Greet(myCat);

//Console.WriteLine(myCat.GetDoubleAge(); <-- Fungerar inte utanför classen om den är private.

class Cat
{
    public string name = "default name";
    private int age = 5;
    public static int numberOfLives = 9;

    public void Greet()
    {
        Console.WriteLine($"Hej, jag heter {name} och jag är {age} år gammal!");
    }
    public void Greet(string name)
    {
        Console.WriteLine($"Hej {name}, jag heter {this.name}!");
    }

    public void Greet(Cat cat)
    {
        Console.WriteLine($"Hej {cat.name}, jag heter {this.name}!");
    }

    private int GetDoubleAge()
    {
        return 2 * age;
    }
}
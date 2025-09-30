
//var animal = new Animal() { Name = "Orvar" };
//animal.Run();

using System.Xml.Linq;

Console.WriteLine();

var cat = new Cat() { Name = "Pelle" };
cat.Run();
cat.Mjau();
cat.Walk();

Console.WriteLine();

var dog = new Dog() { Name = "Fido" };
dog.Run();
dog.Bark();
dog.Walk();

Console.WriteLine();

dog.ScaredAway(cat);

Console.WriteLine();

cat.ScaredAway(dog);

Console.WriteLine();

Animal[] myAnimals = new Animal[] 
{
    new Cat() {Name="Måns"},
    new Dog() {Name="Pluto"},
    new Dog() {Name="Karo"},
    new Cat() {Name="Maja"}
};

Console.WriteLine();

foreach (var animal in myAnimals)
{
    animal.Walk();

    // Cast kommer kasta en exception om animal inte kan castas till Cat.
    Cat myCat = (animal as Cat);

    myCat?.Mjau(); // <-- Null conditional operator. Om den är null händer inget, om den inte är null så körs metoden.

    //(animal as Cat).Mjau(); // <-- Ger null och error om datatypen Cat inte stämmer (t.ex på alla Dog)
    // ((Cat)animal).Mjau(); // <-- Ger error


    // is-operatorn används för att se om animal är datatypen Cat. 
    // auto cast (kortversion)
    //if (animal is Cat myCat) // <-- is [datatyp] [ge variabel namn] 
    //{
    //myCat.Mjau();
    //}

    //if (animal is Dog) // <-- is [datatyp] (longversion)
    //{
    //    Dog myDog = (Dog)animal; // <-- Behöver skapa variabel med Cast (Dog)
    //    myDog.Bark();
    //}
}

Console.WriteLine();

//// Implicit konvertering
//int myInt = 100;
//long myLong = myInt;
//Console.WriteLine("Implicit konvertering: int => long");
//Console.WriteLine($"myInt = {myInt}");
//Console.WriteLine($"myLong = {myLong}");

//// Explicit konvertering (Cast)
//myLong = 10000000000;
//myInt = (int)myLong;
//Console.WriteLine("\nExplicit konvertering: long => int (Här krävs en Cast)");
//Console.WriteLine($"myInt = {myInt}");
//Console.WriteLine($"myLong = {myLong}");

foreach (Animal animal in myAnimals)
{
    animal.Walk(); // <-- Eftersom alla animals är tvingade att skapa en walk (abstract i animal) så kommer cat och dog göra sin walk.
}

// Skulle man skapa olika typer av objekt kan bara objekt-props användas och inte specifika props som t.ex Animal har.
//object[] myObjects = new object[]
//{
//    new Cat() {Name="Måns"},
//    new Dog() {Name="Pluto"},
//    new Dog() {Name="Karo"},
//    new Cat() {Name="Maja"}
//    true,
//    "Hello World!",
//    5.4
//};

abstract class Animal // <-- Abstract på klass gör att denna inte kan instanseras.
{
    public string Name { get; set; }

    public virtual void Run() // <-- Virtual tillåter alla som ärver att ändra (override) denna.
    {
        Console.WriteLine($"{Name} is running.");
    }

    public abstract void Walk(); // <-- Abstract tvingar alla som ärver att implementera (override) denna.

    public void ScaredAway(Animal animal)
    {
        Console.WriteLine($"{this.Name}: Im going to eat you {animal.Name}!");
        animal.Run();
    }
}

abstract class Mammal : Animal
{
    public override void Run()
    {
        Console.WriteLine($"{Name} is running like a mammal.");
    }
}

class Cat : Mammal
{
    public void Mjau()
    {
        Console.WriteLine($"{Name}: Mjau!");
    }

    public override void Walk()
    {
        Console.WriteLine($"{Name} is walking like a cat.");
    }
}

class Dog : Mammal
{
    public void Bark()
    {
        Console.WriteLine($"{Name}: Woof!");
    }

    public override void Run()
    {
        base.Run(); // <-- base anropar den som implementerade metoden med virtual.
        Console.WriteLine("Bark bark!"); // <-- Kan använda originalet och lägga till mer, eller skapa något nytt.
    }

    public override void Walk()
    {
        Console.WriteLine($"{Name} is walking like a dog.");
    }
}


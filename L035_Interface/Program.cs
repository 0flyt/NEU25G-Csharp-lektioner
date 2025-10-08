
var numbers = new int[] { 4, 6, 97, -15, 13 };

Array.Sort(numbers);
foreach (var number in numbers)
{
    Console.WriteLine(number);
}

var cats = new Cat[]
{
    new Cat("Pelle", 4),
    new Cat("Måns", 5),
    new Cat("Tiger", 2),
    new Cat("Bill", 2),
    new Cat("Bull", 3),

};

Array.Sort(cats);

foreach (var cat in cats)
{
    Console.WriteLine(cat.Name);
}

//Console.WriteLine();

//static void BadSort(IComparable[] comparables)
//{
//    if (comparables[0].CompareTo(comparables[1]) < 0)
//    {
//        IComparable temp = comparables[0];
//        comparables[0] = comparables[1];
//        comparables[1] = temp;
//    }
//}


//using (var reader = new StreamReader("myFile.txt"))
//{
//    // ... 

//}

//using (var cat = new Cat())
//{
//    Console.WriteLine("Cat");
//}

//Console.WriteLine("The end!");

var myCat = new Cat("Pelle", 5);
//myCat.Collect();

ICollectable collectable = myCat;
myCat = (Cat)collectable;

var collectibles = new List<ICollectable>();
collectibles.Add(myCat);
collectibles.Add(new PokemonCard());

var myInventory = new Inventory();

if (!myInventory.TryCollect(5))
{
    Console.WriteLine("Could not collect item!");
}

myInventory.Collect(myCat);

class Inventory
{
    public List<ICollectable> Items { get; set; }

    public Inventory()
    {
        Items = new List<ICollectable>();
    }

    public bool TryCollect(object a)
    {
        if (a is ICollectable item)
        {
            Items.Add(item);
            item.Collect();
            return true;
        }
        return false;
    }
    public void Collect(ICollectable collectable)
    {
        Items.Add(collectable);
    }
}

class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Cat : Animal, IDisposable, ICollectable, IComparable<Cat>
{
    public Cat(string name, int age) : base(name, age) { }

    public void Collect()
    {
        Console.WriteLine($"{Name} was collected!");
    }

    public int CompareTo(Cat? other)
    {
        return this.Name.CompareTo(other.Name);
    }

    public void Dispose()
    {
        Console.WriteLine("Disposed!");
    }

    public bool IsCollected()
    {
        throw new NotImplementedException();
    }
}

class PokemonCard : ICollectable
{
    public string Name { get; set; }

    public void Collect()
    {
        throw new NotImplementedException();
    }

    public bool IsCollected()
    {
        throw new NotImplementedException();
    }
}

interface ICollectable
{

    public void Collect();
    public bool IsCollected();
}
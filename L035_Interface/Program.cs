

//using (var reader = new StreamReader("myFile.txt"))
//{
//    // ... 

//}

//using (var cat = new Cat())
//{
//    Console.WriteLine("Cat");
//}

//Console.WriteLine("The end!");

var myCat = new Cat("Pelle");
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

    public Animal(string name)
    {
        Name = name;
    }
}

class Cat : Animal, IDisposable, ICollectable
{
    public Cat(string name) : base(name) { }

    public void Collect()
    {
        Console.WriteLine($"{Name} was collected!");
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
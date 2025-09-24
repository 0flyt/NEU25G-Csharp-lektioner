
Person myPerson = new("Fredrik") { FirstName = "Anders"}; // <-- FirstName har init och kan därför sättas när den skapas eller i konstruktorn..
//myPerson.FirstName = "Bertil"; // <-- Går inte sättas efteråt om den har init.
myPerson.Name = "Andres";
Console.WriteLine(myPerson.Name);

//Console.WriteLine(myPerson.name);
//myPerson.SetName("Anders");
//Console.WriteLine(myPerson.GetName());
//myPerson.Name = "Kalle";

myPerson.Age = 25;

class Person
{
    private string _name = string.Empty; // <-- Field

    public string Name // <-- Property. Vanligt är att ha fields som private och properties som public.
    {
        get { return _name; }
        set { this._name = value; }
    }

    // Backing field till Age, private och börjar med _
    private int _age = 0;

    public int Age
    {
        get { return _age; }
        set { this._age = value; }
    }

    public double Length { get; set; } // <-- Auto-property. Skapar en dold field som inte går att referera till.
    //public double Length { get; set; } = 1.85; // <-- Om man vill sätta ett värde direkt.
    // Snippet: 'prop' sedan tab för auto-property, eller 'propfull' sedan tab för att få en private field samt property. 
    public string LastName { get; private set; } // <-- Publikt/externt är den read-only, men internt i klassen är den read/write.

    public string FirstName { get; init; } // Kan bara sättas i konstruktorn eller i samband med new(), sedan är den read-only.

    public Person(string name) // <-- Konstruktor.
    {
        this._name = name;
    }

    // Exempel på hur vanliga metoder kan sätta/läsa värden på private fields.
    //public string GetName() // <-- Behöver inte skapa dessa metoder (GetName() & SetName()) om jag använder properties.
    //{
    //    return this.name.ToUpper();
    //}

    //public void SetName(string name)
    //{
    //    if (name.Length > 10)
    //    {
    //        throw new ArgumentException();
    //    }
    //    this.name = name;
    //}
}

Size mySize = Size.Medium;

Color myColor = Color.Black;

Console.WriteLine($"mySize = {(byte)mySize}"); //<-- Med (byte) får man ut siffran, utan (byte) får man "Medium".
Console.WriteLine($"myColor = {(int)myColor}");

Identification id = Identification.Passport | Identification.BankId;
Console.WriteLine($"id = {(byte)id}");

//Console.WriteLine(4 | 1);
////0001
////0010
////0100
////1000


enum Size : byte { Small, Medium, Large }; // Lagras som en byte, då vi angett det.

enum Color // Default är att det lagras som en Int32
{
    White, // 0
    Black, // 1
    Red = 10, // 10
    Green, // 11
    Blue, // 12
    Yellow // 13
}

[Flags] // <-- Ger Passport, BankId istället för 9 (1 & 8).
enum Identification : byte
{
    Passport = 1,
    DriverLicence = 2,
    NationalId = 4,
    BankId = 8
}


//Point p1 = new(3.0, 5.0);
//Point p2 = new(3.0, 5.0);

//Console.WriteLine($"p1 == p2 => {p1.Equals(p2)}"); // <-- med struct är dessa lika då den kollar värderna, med class är de inte lika då de pekar på två olika objekt.


//Point p3 = p1;
//p1.X = 8;


//Console.WriteLine($"p1 = ({p1.X}; {p1.Y})");
//Console.WriteLine($"p2 = ({p2.X}; {p2.Y})");
//Console.WriteLine($"p3 = ({p3.X}; {p3.Y})");
struct Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y)
    {
        this.X = x;
        this.Y = y;
    }
}


using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;

Func<int, int> square = x => x * x;
Action<int> printInt = i => Console.WriteLine(i);

//Console.WriteLine(square?.Invoke(5));
printInt(square(5));

//static int Square(int x)
//{
//    return x * x;
//}

PrintResult(x => x * 2);
Console.WriteLine();

PrintResult(x => x % 2);
Console.WriteLine();

PrintResult(i =>
{
    int sum = 0;
    for (int j = 0; j < i; j++)
    {
        sum += j;
    }
    return sum;
});

static void PrintResult(Func<int,int> func)
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{i}: {func(i)}");
    }
}

Func<Person, int, bool> isLegal = (person, legalAge) => person.Age >= legalAge;

Person kalle = new() { Age = 16};

Console.WriteLine(isLegal(kalle,15));
Console.WriteLine(isLegal(new Person() { Age = 18}, 21));

Action<int, int, int> Adding = (a, b, c) => Console.WriteLine($"{a}, {b}, {c} = {a + b + c}");

Adding(1, 2, 3);

Func<int, int, double> Cylinder = (r, h) => r * r * Math.PI * h;
Console.WriteLine(Cylinder(5, 10));

class Person
{
    public int Age { get; set; }
}

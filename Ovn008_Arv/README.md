# �vningsuppgifter med arv och polymorfism

## 1. Skapa en klass f�r fordon
Skapa en enum Brand med 5 bilm�rken, och en enum Color med 5 f�rger. Skriv sedan en klass Vehicle som har publika properties Brand och Color. Klassen ska ha en konstruktor som man kan anv�nda f�r att s�tta Brand och Color, och en konstruktor som endast tar Brand och s�tter en default f�rg.

## 2. L�gg till override f�r ToString()
ToString() �r en metod som alla klasser �rver fr�n System.Object. Denna metod anropas implicit n�r man skickar in ett objekt till Console.WriteLine, eller anv�nder ett objekt i en konkatenering (t.ex en interpolation string). Implementationen i System.Object �r s�dan att den bara skriver ut objektets datatyp, men din klass kan g�ra en override p� ToString() och returnera en str�ng i vilket format du vill.

G�r en override p� ToString() i Vehicle-klassen, s� att "A white Toyota" skrivs ut om man k�r f�ljande kod:

```cs
Console.WriteLine(new Vehicle(Brand.Toyota, Color.White));
```

## 3. Skapa en subklass f�r bilar
Skapa en klass Car som �rver av Vehicle. L�gg till en publik property Model, och skapa en konstruktor som initierar Brand, Model och Color.

"A white Yaris from Toyota" ska skrivas ut om man k�r f�ljande kod:

```cs
Console.WriteLine(new Car(Brand.Toyota, "Yaris", Color.White));
```

## 4. Skapa en struct f�r att spara l�ngd, bredd och h�jd.

Skapa en struct Size med properties Length, Width och Height; samt en konstruktor som tar 3 argument f�r att initiera dessa.

## 5. Initiera i Vehicle, skriv ut i Car.

Uppdatera Vehicle-klassen s� den s�tter slumpm�ssiga (men rimliga) v�rden f�r l�ngd, bredd och h�jd.

Uppdatera Car-klassen s� att �ven l�ngden skrivs ut n�r samma kod som i uppgift 3 k�rs.

Ex: "A white 4.1 meter long Yaris from Toyota".

## 6. Circle som �rver fr�n Shape

Utg� fr�n f�ljande kod:

```cs
public abstract class Shape
{
    public abstract double Area { get; }
    public abstract double Circumference { get; }
}
```

Skapa en klass Circle som �rver fr�n klassen ovan.

Implementera Circle p� s� vis att koden nedan ...

```cs
var circle = new Circle(5);
Console.WriteLine(circle);
Console.WriteLine($"Area: {circle.Area:f2}");
Console.WriteLine($"Circumference: {circle.Circumference:f2}");
```

... ger f�ljande utskrift:

```
A circle with radius 5
Area: 78,54
Circumference: 31,42
```

## 7. Square �rver ocks� fr�n Shape

Skapa �ven en klass Square som �rver fr�n Shape.

Implementera Square p� s� vis att koden nedan ...

```cs
var square = new Square(5);
Console.WriteLine(square);
Console.WriteLine($"Area: {square.Area:f2}");
Console.WriteLine($"Circumference: {square.Circumference:f2}");
```

... ger f�ljande utskrift:

```
A square with side 5
Area: 25,00
Circumference: 20,00
```

## 8. L�gg till Print() i Shape

Uppdatera (endast) den abstrakta basklassen med en Print() method.

N�r detta �r gjort ska koden nedan ...

```cs
var square = new Square(3.2);
square.Print();

var circle = new Circle(4.5);
circle.Print();
```
... ge f�ljande utskrift:

```
A square with side 3,2 has an area of 10,24 and a circumference of 12,80.
A circle with radius 4,5 has an area of 63,62 and a circumference of 28,27.
```

## 9. En array av cirklar och kvadrater
```cs
Shape[] shapes = new Shape[10];
```

Skriv en loop som slumpm�ssigt initerar alla element i arrayen med antingen cirklar med 0 < radie < 10, eller kvadrater med 0 < sida < 10.

S�tt en breakpoint efter loopen och inspektera arrayen i Visual Studios debugger.

## 10. Statiska printmetoder
L�gg till en statisk metod PrintAll() i Shape som anropar Print() p� alla shapes i en array.

L�gg �ven till en statisk metod PrintCircles() som endast anropar Print() p� alla cirklar i en array.

Prova sedan att k�ra f�ljande kod:
```cs
Shape.PrintAll(shapes);
Console.WriteLine();
Shape.PrintCircles(shapes);
```
(d�r shapes �r arrayen fr�n uppgift 9)

Ovanst�ende ska skriva ut f�rst alla shapes i arrayen, f�ljt av blankrad, f�ljt av alla circles i arrayen.

## 11. L�gg till f�rger i PrintAll()
Uppdatera PrintAll() i uppgift 10, s� att alla rader med cirklar skrivs med r�d f�rg och alla rader med kvadrater skrivs med gr�n f�rg.

## 12. Random f�rger
L�gg till f�ljande i Shape

```cs
protected ConsoleColor color;
```

Uppdatera sedan subklasserna med en variant (overload) av konstruktorn som �ven tar en f�rg. Anv�nd dig av constructor chaining.

Uppdatera PrintAll() s� att raden skrivs ut i den f�rg som angavs n�r vardera shape skapades.

Uppdatera loopen som initierar arrayen s� att varje shape som skapas f�r en random f�rg.
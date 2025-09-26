//using System;

//1.Person med property FirstName

//Skapa en klass "Person" som har en private field _firstName,
//och en public property FirstName.När man sätter värdet på FirstName ska detta sparas i _firstName,
//och när man läser värdet på FirstName ska den returnera det som finns lagrat i _firstName.

//2. Autoproperty LastName

//Lägg till en publik auto-property LastName som går att både läsa och skriva.

//3. Read-only property FullName

//Lägg sedan till en publik property FullName som är read only (bara get;)
//När man läser av propertyn så ska den returnera hela namnet.
//Testa koden genom att skapa ett objekt, tilldela värden på både FirstName och LastName, och sedan skriva ut FullName.

//Person myPerson = new();
//myPerson.FirstName = "Kalle";
//Console.WriteLine(myPerson.FirstName);
//myPerson.LastName = "Svensson";
//Console.WriteLine(myPerson.LastName);
//Console.WriteLine(myPerson.FullName);

//class Person
//{
//    private string _firstName = string.Empty;

//	public string FirstName
//	{
//		get { return _firstName; }
//		set { _firstName = value; }
//	}

//    public string LastName { get; set; }

//	public string FullName
//	{
//		get { return $"{FirstName} {LastName}"; }
//	}

//}

//4. Stegräknare

//Skapa en klass som kan användas som stegräknare.
//Den ska ha en property "Steps" som bara går att läsa; en metod Step() som räknar upp Steps med 1 varje gång man anropar den;
//och en metod Reset() som nollställer räknaren.

//Instantiera klassen och skriv en loop som motsvarar att man går 1000 steg. Skriv ut värdet på Steps.


//StepsCount mySteps = new();

//Console.WriteLine(mySteps.Steps);
//mySteps.Reset();
//Console.WriteLine(mySteps.Steps);

//class StepsCount
//{
//	private int steps = 0;

//	public StepsCount()
//	{
//		for (int i = 0; i < 100; i++)
//		{
//			Step();
//		}
//	}

//	public int Steps
//	{
//		get { return steps; }
//	}

//	public void Step()
//	{
//		steps++;
//	}

//	public void Reset()
//	{
//		steps = 0;
//	}
//}


//5. Bil

//Skriv en ny klass som motsvarar en bil. Den ska ha privata fields för modell, pris och färg.
//Skapa publika properties för att hämta eller ändra värdet på varje field.

//Skriv en konstruktor till bilklassen som inte tar några parametrar.
//Skriv en till konstruktor som tar en parameter för varje property som klassen har och initierar dessa.
//Hur kan man styra vilken konstruktor som anropas när man skapar ett objekt av klassen?

//Skriv en metod till bilklassen med namnet HalfPrice(). När den anropas ska priset på bilen sänkas till hälften.

//Car myCar = new();
//Car myOtherCar = new("Volvo", 120000, "Gray");
//Console.WriteLine(myOtherCar.Price);
//myOtherCar.HalfPrice();
//Console.WriteLine(myOtherCar.Price);

//class Car
//{
//    private string _model = string.Empty;
//    private int _price;
//    private string _color = string.Empty;

//    public Car()
//    {
//        Console.WriteLine("Car!");
//    }
//    public Car(string _model, int _price, string _color)
//    {
//        this._model = _model;
//        this._price = _price;
//        this._color = _color;
//    }
//    public void HalfPrice()
//    {
//        this._price = _price / 2;
//    }

//	public string Model
//	{
//		get { return _model; }
//		set { _model = value; }
//	}
//    public int Price
//    {
//        get { return _price; }
//        set { _price = value; }
//    }
//    public string Color
//    {
//        get { return _color; }
//        set { _color = value; }
//    }
//}


//6. Vattenglas

//Skriv en klass som representerar ett vattenglas. Den ska ha en metod för att fylla glaset, och en metod för att tömma glaset.
//Dessutom ska den ha en private field som håller reda på om glaset är tomt eller fullt.
//Beroende på tillståndet (tomt/fullt) så ska metoden som fyller glaset skriva ut antingen “Fyller glaset” eller
//“Glaset är redan fullt”. Den andra metoden ska skriva ut “Tömmer glaset” eller “Glaset är redan tomt”.

//Extra övning: Lägg till ytterligare en metod för att slå sönder glaset.
//Varje glas (instans) ska hålla reda på sitt tillstånd, och skriva ut vad som händer när man kör de olika metoderna.
//(t.ex “Glaset går sönder, och vattnet rinner ut på golvet”, eller “Glaset kan inte fyllas, eftersom det är trasigt” osv.)



//GlassOfWater myGlassOfWater = new();
//myGlassOfWater.Empty();
//myGlassOfWater.Fill();
//myGlassOfWater.Fill();
//myGlassOfWater.DestroyGlass();
//myGlassOfWater.Empty();
//myGlassOfWater.Fill();
//myGlassOfWater.DestroyGlass();
//class GlassOfWater
//{
//    private bool _glassFull = false;
//    private bool _glassBroken = false;
//    public void Fill()
//    {
//        if (_glassBroken)
//        {
//            Console.WriteLine("Glaset är trasigt och kan därför inte fyllas med vatten.");
//            return;
//        }
//        Console.WriteLine($"{(!_glassFull ? "Fyller glaset" : "Glaset är redan fullt")}");  
//        _glassFull = true;
//    }
//    public void Empty()
//    {
//        if (_glassBroken)
//        {
//            Console.WriteLine("Glaset är trasigt och är redan tömt på vatten.");
//            return;
//        }
//        Console.WriteLine($"{(_glassFull ? "Tömmer glaset" : "Glaset är redan tomt")}");
//        _glassFull = false;
//    }
//    public void DestroyGlass()
//    {
//        if (_glassBroken)
//        {
//            Console.WriteLine("Glaset är redan trasigt.");
//            return;
//        }
//        Console.WriteLine(_glassFull ? "Glaset går sönder, och vattnet rinner ut på golvet" : "Glaset gick sönder.");
//        _glassBroken = true;
//    }
//}


//7. Blå & Röd

//Skapa en en klass som har en property “Red” och en property “Blue”.
//Båda ska vara en double och kunna ha ett värde mellan 0.0 och 100.0 men de ska vara “sammankopplade”
//på så vis att värdena tillsammans alltid är 100.0 d.v.s om man t.ex. sätter “Blue” till 8.5 och sedan läser av “Red”
//så ska den returnera 91.5

//class RedAndBlue
//{

//}

//8. Temperatur

//Implementera klassen Temperature så att nedanstående kod fungerar, och korrekt omvandlar mellan enheterna.

//Temperature t = new() { Celcius = 0 };

//Console.WriteLine($"Kelvin:   {t.Kelvin,10:f2}");
//Console.WriteLine($"Celcius:  {t.Celcius,10:f2}");
//Console.WriteLine($"Farenheit:{t.Farenheit,10:f2}");

//Det ska såklart fungera oavsett vilken enhet och värde man väljer på första raden, när instansen skapas.

//Tips: Omräkningsformler

//Bonus: Om man sätter en ogiltig temperatur, kasta en ArgumentOutOfRangeException.
//9. Bil 2

//Skriv en ny klass som representerar en bil. Varje bil ska kunna ha en färg som representeras av en ConsoleColor, samt en längd. När man instansierar en bil så ska den få en random färg, och en random längd (mellan 3 och 5 meter). Instansiera 1000 bilar och spara i en array. Skapa en funktion som tar en array av bilar och returnerar den sammanlagda längden av alla gröna bilar.
//10. Lägg till statisk metod

//Lägg till en statisk metod på klassen i uppgift 9. Metoden ska ta en bil som inparameter och returnera en array med 10 bilar i samma färg som bilen man skickat in, men med olika längd.
//11. Simulering

//Uppdatera konstruktorn på klassen i uppgift 9 (och 10) så att bilen även får en random hastighet (mellan 60 och 240 km/h). Skriv en metod DriveForOneHour() som uppdaterar en property Distance med total körsträcka. Distance ska alltså initieras på 0, och sedan ökar för varje gång man anropar DriveForOneHour(). Lägg sedan till en metod GetGraph() som returnerar en string på 20 tecken som representerar en körsträcka på 1000 mil och visar bilens position enligt exempel: “| ------x---------- -|”. (‘x’ är alltså bilens position mellan start och mål (1000 mil).

//Skriv sedan ett program som simulerar att 10 bilar åker 1000 mil i olika hastighet där varje bils position, samt dess exakta körda distans (i text) uppdateras en gång i sekunden. (En sekund i simuleringen motsvarar alltså en timma i verkligheten).

//hint: Thread.Sleep(1000);

//Exempel:
//Bil A: | ------x---------- -| 3420 km
//Bil B: | -------------x---- | 8293 km..etc..Extra utmaning: Lägg till så varje ‘x’ ritas ut i respektive bils färg; och så man ser hur lång tid som gått sedan start; samt eventuella andra förbättringar du kan komma på.
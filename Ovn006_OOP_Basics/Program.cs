//1.Skriva ut namn på personer
//Skriv en klass som representerar en person. Klassen ska ha två publika fält (fields): firstName, lastName.
//Skapa två instanser av personer med olika för och efternamn, och använd sedan dessa för att printa ut (hela) namnen på de olika personerna.

//Person personOne = new Person() { firstName = "Pelle", lastName = "Svensson" };
//Person personTwo = new Person() { firstName = "Sven", lastName = "Pellesson" };

//personOne.GetFullName();
//personTwo.GetFullName();

//class Person
//{
//    public string firstName = "Anon";
//    public string lastName = "Anon";

//    public void GetFullName()
//    {
//        Console.WriteLine($"{firstName} {lastName}");
//    }
//}

//2. Lägg till en metod som returnerar hela namnet
//Uppdatera klassen i uppgift 1 med en metod: public string GetFullName(), som returnerar en sträng med hela namnet.

//3. Lägg till en metod som returnerar namnet baklänges
//Uppdatera klassen med en ny metod: public string GetFullNameReversed() som returnerar en sträng med hela namnet baklänges.
//Låt denna metoden använda sig av metoden i uppgift 2.

//4. Overload av GetFullName med titel.
//GetFullName ska finnas i två versioner: en utan parametrar som i uppgift 2;
//och en där man kan skicka in en titel, t.ex. "Dr." eller "Mr." som returnerar namnet på personen med titeln framför.

//5. Lägg till så personer kan ha föräldrar.
//Uppdatera person-klassen så att varje person kan ha en mamma och en pappa.
//Dessa representeras som publika fält(fields) av typen Person (eller vad du kallade klassen i uppgift 1).

//6. Skapa ett objekt som representerar dig och dina föräldrar
//Gör en instans av en person och ge den ditt för- och efternamn.
//Lägg även in dina föräldrars namn, kopplade till dig.
//Så t.ex myself.GetFullName() returnerar ditt namn, och myself.mother.GetFullName() returnerar din mammas namn.

//7. Hämta information om dig och dina föräldrar.
//Lägg till en public string GetSelfAndParents() som returnerar en sträng på formatet "Ditt Namn - Mamma: Mammans Namn - Pappa: Pappans namn".
//Om mammans eller pappans namn saknas (null) markera det med "okänd" i strängen.
//Exempel: "Fredrik Johansson - Mamma: okänd - Pappa: Göran Johansson"

//8.Privat fält, med metoder för att sätta och hämta värdet.
//Uppdatera klassen med ett fält, private double length, som kan lagra längden på personen.
//Eftersom denna är markerad som private kommer man inte kunna läsa/skriva denna utanför klassen.
//Lägg därför till en metod void SetLength(double length) som sätter värdet på det privat fältet length,
//samt en double GetLength() som returnerar värdet på fältet length.

//När du är klar ska följande kod ge utskriften 1.82

//Person myPerson = new Person();
//myPerson.SetLength(1.82);
//Console.Write(myPerson.GetLength());

//9.Vikt och BMI
//Gör motsvarande för Vikt, alltså ett privat fält med publika metoder: double GetWeight() och void SetWeight(double weight).
//Gör sedan även en publik metod double GetBMI() som returnerar personens BMI. Detta ska dock inte finnas representerat som en private field.

Person personOne = new Person() { firstName = "Pelle", lastName = "Svensson" };
Person personTwo = new Person() { firstName = "Sven", lastName = "Pellesson" };

Person mother = new Person() { firstName = "Carina", lastName = "Rydberg" };
Person father = new Person() { firstName = "Leif", lastName = "Lengstrand" };
Person myself = new Person() { firstName = "Christopher", lastName = "Rydberg", mother = mother, father = null };

Console.WriteLine(personOne.GetFullName("Mr."));
Console.WriteLine(personTwo.GetFullName("Dr."));
Console.WriteLine(myself.GetSelfAndParent());
myself.SetLength(1.75);
Console.WriteLine(myself.GetLength());

myself.SetWeigth(85.5);
Console.WriteLine(myself.GetWeigth());
Console.WriteLine(myself.GetBMI());


class Person
{
    public string firstName = string.Empty;
    public string lastName = string.Empty;
    public Person? mother;
    public Person? father;
    private double length;
    private double weigth;

    public string GetFullName()
    {
        return $"{firstName} {lastName}";
    }

    public string GetFullName(string title)
    {
        return $"{title} {firstName} {lastName}";
    }

    public string GetFullNameReversed()
    {
        string fullName = GetFullName();
        return new string(fullName.Reverse().ToArray());
    }

    public string GetSelfAndParent()
    {
        string motherName = mother?.GetFullName() ?? "okänd";
        string fatherName = father?.GetFullName() ?? "okänd";
        return $"{firstName} {lastName} - Mamma: {motherName} - Pappa: {fatherName}";
    }

    public void SetLength(double length)
    {
        this.length = length;
    }

    public double GetLength()
    {
        return length;
    }

    public void SetWeigth(double weigth)
    {
        this.weigth = weigth;
    }

    public double GetWeigth()
    {
        return weigth;
    }

    public double GetBMI()
    {
        return this.weigth / (this.length * this.length);
    }
}
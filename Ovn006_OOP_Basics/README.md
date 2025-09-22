# �vningsuppgifter med klasser och objekt

## 1. Skriva ut namn p� personer
Skriv en klass som representerar en person. Klassen ska ha tv� publika f�lt (fields): firstName, lastName. Skapa tv� instanser av personer med olika f�r och efternamn, och anv�nd sedan dessa f�r att printa ut (hela) namnen p� de olika personerna.

## 2. L�gg till en metod som returnerar hela namnet
Uppdatera klassen i uppgift 1 med en metod: public string GetFullName(), som returnerar en str�ng med hela namnet.

## 3. L�gg till en metod som returnerar namnet bakl�nges
Uppdatera klassen med en ny metod: public string GetFullNameReversed() som returnerar en str�ng med hela namnet bakl�nges. L�t denna metoden anv�nda sig av metoden i uppgift 2.

## 4. Overload av GetFullName med titel.
GetFullName ska finnas i tv� versioner: en utan parametrar som i uppgift 2; och en d�r man kan skicka in en titel, t.ex. "Dr." eller "Mr." som returnerar namnet p� personen med titeln framf�r.

## 5. L�gg till s� personer kan ha f�r�ldrar.
Uppdatera person-klassen s� att varje person kan ha en mamma och en pappa. Dessa representeras som publika f�lt(fields) av typen Person (eller vad du kallade klassen i uppgift 1).

## 6. Skapa ett objekt som representerar dig och dina f�r�ldrar
G�r en instans av en person och ge den ditt f�r- och efternamn. L�gg �ven in dina f�r�ldrars namn, kopplade till dig. S� t.ex myself.GetFullName() returnerar ditt namn, och myself.mother.GetFullName() returnerar din mammas namn.

## 7. H�mta information om dig och dina f�r�ldrar.
L�gg till en public string GetSelfAndParents() som returnerar en str�ng p� formatet "Ditt Namn - Mamma: Mammans Namn - Pappa: Pappans namn". Om mammans eller pappans namn saknas (null) markera det med "ok�nd" i str�ngen. Exempel: "Fredrik Johansson - Mamma: ok�nd - Pappa: G�ran Johansson" 

## 8. Privat f�lt, med metoder f�r att s�tta och h�mta v�rdet.
Uppdatera klassen med ett f�lt, *private* double length, som kan lagra l�ngden p� personen. Eftersom denna �r markerad som private kommer man inte kunna l�sa/skriva denna utanf�r klassen. L�gg d�rf�r till en metod void SetLength(double length) som s�tter v�rdet p� det privat f�ltet length, samt en double GetLength() som returnerar v�rdet p� f�ltet length.

N�r du �r klar ska f�ljande kod ge utskriften 1.82
```cs
Person myPerson = new Person();
myPerson.SetLength(1.82);
Console.Write(myPerson.GetLength());
```
## 9. Vikt och BMI
G�r motsvarande f�r Vikt, allts� ett privat f�lt med publika metoder: double GetWeight() och void SetWeight(double weight). G�r sedan �ven en publik metod double GetBMI() som returnerar personens [BMI](https://sv.wikipedia.org/wiki/BMI_(kroppsmasseindex)). Detta ska dock *inte* finnas representerat som en private field.
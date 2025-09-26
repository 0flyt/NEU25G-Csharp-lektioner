# �vningsuppgifter med properties

## 1. Person med property FirstName
Skapa en klass "Person" som har en private field _firstName, och en public property FirstName. N�r man s�tter v�rdet p� FirstName ska detta sparas i _firstName, och n�r man l�ser v�rdet p� FirstName ska den returnera det som finns lagrat i _firstName.

## 2. Autoproperty LastName
L�gg till en publik auto-property LastName som g�r att b�de l�sa och skriva.

## 3. Read-only property FullName
L�gg sedan till en publik property FullName som �r read only (bara get;) N�r man l�ser av propertyn s� ska den returnera hela namnet. Testa koden genom att skapa ett objekt, tilldela v�rden p� b�de FirstName och LastName, och sedan skriva ut FullName.

## 4. Stegr�knare
Skapa en klass som kan anv�ndas som stegr�knare. Den ska ha en property "Steps" som bara g�r att l�sa; en metod Step() som r�knar upp Steps med 1 varje g�ng man anropar den; och en metod Reset() som nollst�ller r�knaren.

Instantiera klassen och skriv en loop som motsvarar att man g�r 1000 steg. Skriv ut v�rdet p� Steps.

## 5. Bil
Skriv en ny klass som motsvarar en bil. Den ska ha privata fields f�r modell, pris och f�rg. Skapa publika properties f�r att h�mta eller �ndra v�rdet p� varje field.

Skriv en konstruktor till bilklassen som inte tar n�gra parametrar. Skriv en till konstruktor som tar en parameter f�r varje property som klassen har och initierar dessa. Hur kan man styra vilken konstruktor som anropas n�r man skapar ett objekt av klassen?

Skriv en metod till bilklassen med namnet HalfPrice(). N�r den anropas ska priset p� bilen s�nkas till h�lften.

## 6. Vattenglas
Skriv en klass som representerar ett vattenglas. Den ska ha en metod f�r att fylla glaset, och en metod f�r att t�mma glaset. Dessutom ska den ha en private field som h�ller reda p� om glaset �r tomt eller fullt. Beroende p� tillst�ndet (tomt/fullt) s� ska metoden som fyller glaset skriva ut antingen �Fyller glaset� eller �Glaset �r redan fullt�. Den andra metoden ska skriva ut �T�mmer glaset� eller �Glaset �r redan tomt�.

**Extra �vning:** L�gg till ytterligare en metod f�r att sl� s�nder glaset. Varje glas (instans) ska h�lla reda p� sitt tillst�nd, och skriva ut vad som h�nder n�r man k�r de olika metoderna. (t.ex �Glaset g�r s�nder, och vattnet rinner ut p� golvet�, eller �Glaset kan inte fyllas, eftersom det �r trasigt� osv.)

## 7. Bl� & R�d 
Skapa en en klass som har en property �Red� och en property �Blue�. B�da ska vara en double och kunna ha ett v�rde mellan 0.0 och 100.0  men de ska vara �sammankopplade� p� s� vis att v�rdena tillsammans alltid �r 100.0 d.v.s om man t.ex. s�tter �Blue� till 8.5 och sedan l�ser av �Red� s� ska den returnera 91.5

## 8. Temperatur
Implementera klassen Temperature s� att nedanst�ende kod fungerar, och korrekt omvandlar mellan enheterna.
```cs
Temperature t = new() { Celcius = 0 };

Console.WriteLine($"Kelvin:   {t.Kelvin,10:f2}");
Console.WriteLine($"Celcius:  {t.Celcius,10:f2}");
Console.WriteLine($"Farenheit:{t.Farenheit,10:f2}");
```
Det ska s�klart fungera oavsett vilken enhet och v�rde man v�ljer p� f�rsta raden, n�r instansen skapas.

**Tips:** [Omr�kningsformler](https://www.cuemath.com/temperature-conversion-formulas/)

**Bonus:** Om man s�tter en ogiltig temperatur, kasta en ArgumentOutOfRangeException.

## 9. Bil 2
Skriv en ny klass som representerar en bil. Varje bil ska kunna ha en f�rg som representeras av en ConsoleColor, samt en l�ngd. N�r man instansierar en bil s� ska den f� en random f�rg, och en random l�ngd (mellan 3 och 5 meter). Instansiera 1000 bilar och spara i en array. Skapa en funktion som tar en array av bilar och returnerar den sammanlagda l�ngden av alla gr�na bilar.

## 10. L�gg till statisk metod
L�gg till en statisk metod p� klassen i uppgift 9. Metoden ska ta en bil som inparameter och returnera en array med 10 bilar i samma f�rg som bilen man skickat in, men med olika l�ngd.

## 11. Simulering
Uppdatera konstruktorn p� klassen i uppgift 9 (och 10) s� att bilen �ven f�r en random hastighet (mellan 60 och 240 km/h). Skriv en metod DriveForOneHour() som uppdaterar en property Distance med total k�rstr�cka. Distance ska allts� initieras p� 0, och sedan �kar f�r varje g�ng man anropar DriveForOneHour(). L�gg sedan till en metod GetGraph() som returnerar en string p� 20 tecken som representerar en k�rstr�cka p� 1000 mil och visar bilens position enligt exempel: �|------x-----------|�. 
(�x� �r allts� bilens position mellan start och m�l (1000 mil).

Skriv sedan ett program som simulerar att 10 bilar �ker 1000 mil i olika hastighet d�r varje bils position, samt dess exakta k�rda distans (i text) uppdateras en g�ng i sekunden. (En sekund i simuleringen motsvarar allts� en timma i verkligheten).

*hint:* Thread.Sleep(1000);

**Exempel:**   
Bil A: |------x-----------|   3420 km  
Bil B: |-------------x----|   8293 km  
	.. etc ..

**Extra utmaning:** L�gg till s� varje �x� ritas ut i respektive bils f�rg; och s� man ser hur l�ng tid som g�tt sedan start; samt eventuella andra f�rb�ttringar du kan komma p�.
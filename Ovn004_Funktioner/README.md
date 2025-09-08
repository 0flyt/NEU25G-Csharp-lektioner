# �vningsuppgifter med funktioner

## 1. Sl� ihop f�r- och efternamn - skriv ut
Skriv en funktion som tar tv� parametrar: firstName och lastName. Funktionen ska skriva ut hela namnet p� sk�rmen. Testa genom att anropa funktionen med ditt namn.

**Exempel:**
```
PrintName("Fredrik", "Johansson");
```
*Skriver ut:* Fredrik Johansson

## 2. Sl� ihop f�r- och efternamn - returnera
Skriv om funktionen ovan s� att den ist�llet f�r att skriva ut namnet returnerar en string med hela namnet. Anropa funktionen och skriv ut returv�rdet.

## 3. Kolla om st�ngen �r l�ngre �n ett givet antal tecken.
Skriv en funktion som tar in en str�ng och ett heltal. Om l�ngden p� str�ngen �r st�rre �n heltalet returnera true, annars false.

## 4. Omvandla Celsius till Fahrenheit
Skriv en funktion som �vers�tter ett v�rde fr�n Celsius till Fahrenheit. B�de in-parameter och returv�rde ska vara av datatyp double.

## 5. L�gg in bindestr�ck mellan tecken i en str�ng

Skriv en funktion som tar in en str�ng och returnerar en str�ng med ett bindestreck mellan varje tecken. T.ex om man skickar in �Fredrik� , s� returnerar den �F-r-e-d-r-i-k�

## 6. Egen version av String.Join();

Skriv en egen funktion som fungerar p� samma s�tt som String.Join();

**Exempel:**
```
MyJoin("->", "Sverige", "Norge", "Finland");
```
*Returv�rde:* "Sverige->Norge->Finland"

## 7. Ber�kna medelv�rde av int-array
Skriv en funktion som tar en int[] in, och returnerar medelv�rdet som en double.

## 8. Siffror till text
Skriv en funktion som tar ett heltal in, och returnerar en string[] d�r varje element inneh�ller ordet f�r varje siffra i talet.

**Exempel:**
```
NumberToWords(6543);
```
*Returv�rde:* {"sex", "fem", "fyra", "tre"}

## 9. Heltal till text
Skriv en funktion som tar en *ushort* som parameter, och returnerar en str�ng med numret utskrivet i ord.

**Exempel:**
```
IntegerToText(6543);
```
*Returv�rde:* "six thousand five hundred forty three"

## 10. Hitta index f�r alla f�rekomster av ett givet tecken.
Skapa funktionen int[] IndexesOf(string text, char c) som s�ker igenom str�ngen text och returnerar en int[] med index till alla f�rekomster av *c* i *text*.

**Exempel:**
```
IndexesOf("Hello World!", 'o');
```
*Returv�rde:* {4, 7}

## 11. Kasta t�rning
Skriv en funktion ThrowDice() som returnerar ett slumpm�ssigt heltal 1-6. Skriv en annan funktion ThrowMultipleDice(int n) som returnerar resultatet av att man slagit *n* t�rningar.

***Extra utmaning:*** *L�gg till en frivillig(optional) int p� b�da funktionerna, d�r man kan ange antal sidor p� t�rningen (default 6).*

***Tips:*** Kolla exempelkoden f�r [Random.Next()](https://learn.microsoft.com/en-us/dotnet/api/system.random.next?view=net-8.0) f�r att f� ut slumpm�ssiga heltal. 

## 12. Rita en box
Skriv en funktion *DrawBox(int width, int height)*.
N�r man anropar funktionen ska den skriva ut en rektangel d�r de yttre tecknen best�r av �#� och de inre av �-�.

**Exempel:** DrawBox(7, 4);
```
#######
#-----#
#-----#
#######
```

***Extrauppgift:*** *Uppdatera funktionen och l�gg till parametrar left och top (f�r positionen p� �versta v�nstra h�rnet av boxen. Skriv en loop som printar ut rektanglar med random storlek och position p� sk�rmen.* 

***Tips:*** *Anv�nd [Console.SetCursorPosition();](https://learn.microsoft.com/en-us/dotnet/api/system.console.setcursorposition?view=net-8.0) f�r att flytta Cursorn, d.v.s var n�sta tecken ska skrivas. Om du vill kan du �ven d�lja cursorn genom att s�tta [Console.CursorVisible = false;](https://learn.microsoft.com/en-us/dotnet/api/system.console.cursorvisible?view=net-8.0)*

***Tips:*** *Anv�nd [Thread.Sleep(n);](https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.sleep?view=net-8.0) f�r att l�gga in en f�rdr�jning p� n millisekunder innan n�sta rektangel ritas ut.*

## 13. Flytta runt ett @ med piltangenterna.
L�t oss skriva b�rjan till ett enkelt spel:

Anv�nd DrawBox-funktionen i f�reg�ende uppgift f�r att rita en box p� sk�rmen. Placera sedan ett @ i mitten av boxen. Om man anv�nder piltangenterna ska man kunna flytta runt @. 
N�r den kommer till kanten av boxen s� ska den inte kunna g� l�ngre �t det h�llet.

***Tips:*** *F�r att flytta @ beh�ver du skriva �-� p� dess tidigare position och �@� p� den nya positionen. Spara bredd och h�jd p� boxen s� du vet n�r den ska stanna.*

***Tips:*** *Kolla upp [Console.ReadKey();](https://learn.microsoft.com/en-us/dotnet/api/system.console.readkey?view=net-8.0) och [Console.KeyAvailable;](https://learn.microsoft.com/en-us/dotnet/api/system.console.keyavailable?view=net-8.0)*

## 14. Masken
Skriv om DrawBox() s� den ist�llet returnerar en 2D-array av char med tecknen som den tidigare skrev ut p� displayen. Man ska ocks� kunna mata in en tredje parameter f�r antal slumpade �#�. Om man anger t.ex 5 s� ska 5 stycken extra �#� slumpas ut p� random st�llen inne i boxen. 

Skriv sedan en annan funktion som tar och ritar ut arrayen p� sk�rmen. Fixa s� man kan flytta runt @ med piltangenterna. J�mf�r positionen mot arrayen och g�r s� man inte kan g� p� n�gon '#'.

***Extra utmaning:*** *G�r en "orm" av '@'. N�r man flyttar positionen p� @ s� f�ljer (t.ex) 5 andra @ efter i samma sp�r som man f�rflyttat sig.*

***Extra utmaning 2:*** *I det klassiska spelet "masken" (snake) f�rflyttar sig en mask i j�mna tidsintervall i den riktning spelaren senast angav med piltangenterna. N�gonstans p� banan finns ett �pple masken ska �ta. Det g�ller f�r spelaren att ta sig dit utan att krocka med n�got hinder, eller sin egen svans. N�r man tar �pplet blir masken l�ngre och ett nytt �pple dyker upp p� slumpvis vald plats p� banan.*

*Implementera din egen version av spelet. F�rs�k dela in koden i l�mpliga funktioner.*

***F�rslag:*** *N�r du f�tt en f�rsta version av spelet att fungera, l�gg till flera banor genom att h�rdkoda in olika banlayout i olika 2D-arrayer. N�r man tagit ett visst antal �pplen p� en bana s� kommer man vidare till n�sta.*
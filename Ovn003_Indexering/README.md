# �vningsuppgifter med indexering av str�ngar och arrayer

## 1. En bokstav p� varje rad

Be anv�ndaren mata in en str�ng. Skriv ut varje tecken i str�ngen p� en egen rad.

**Exempel:**
```
Skriv n�got: Hej
H
e
j
```

## 2. Siffror till text

Skapa ett program med en array som inneh�ller str�ngarna �noll�, �ett�, �tv�, �tre�, �fyra�, �fem�, �sex�, �sju�, ��tta�, �nio�. Be sedan anv�ndaren att mata in en siffra. Anv�nd arrayen f�r att skriva ut siffrans ord. Ex. Inmatning �3� => �tre�.

**Exempel:**
```
Skriv en siffra: 3
tre
```

***Extra utmaning:*** *Anv�ndaren kan mata in en str�ng med fritt antal siffror, om man skriver in t.ex 432 s� svarar programmet: �fyra-tre-tv�.*

## 3. Bakl�nges

Be anv�ndaren mata in en text. Skriv sedan ut texten bakl�nges.

**Exempel:**
```
Skriv n�got: Hello there!
!ereht olleH
```

## 4. D�lj vokaler

Be anv�ndaren mata in en text. Skriv ut texten med alla vokaler ersatta med *

**Exempel:**
```
Skriv n�got: Hejsan, jag heter Fredrik!
H*js*n, j*g h*t*r Fr*dr*k!
```
***Extra utmaning:*** *Skriv ut texten �versatt till [r�varspr�ket](https://sv.wikipedia.org/wiki/R%C3%B6varspr%C3%A5ket).*

## 5. Palindrom

Ett palindrom �r ett ord som blir samma framl�nges som bakl�nges. Be anv�ndaren skriva in ett ord och ange sedan om det �r ett palindrom eller inte.

**Exempel:**
```
Skriv ett ord: Kajak
Kajak �r ett palindrom.
```

## 6. Minir�knare

Skapa en enkel minir�knare som kan hantera de fyra r�knes�tten med tv� operander. Till skillnad fr�n [uppgift 6 i �vningsuppgifter med variabler](https://github.com/everyloop/NET24-Csharp/blob/master/Exercises/Variabler.md), s� ska inmatningen nu ske p� en rad (f�rsta talet, operator, andra talet). Ignorera inmatade mellanslag i str�ngen. Om man t.ex. matar in str�ngen "34 - 14", s� ska programmet skriva ut "= 20".

**Exempel:**
```
Vad vill du r�kna ut? 15 * 4
= 60
```

## 7. Omv�nd ordning

Be anv�ndaren skriva in ett ord, sedan ett till, och ett till; tills man skrivit in 7 ord. Skriv sedan ut orden p� sk�rmen i bakv�nd ordning mot hur de matades in. Allts� ordet man skrev in sist, skrivs ut f�rst.

## 8. F�rdr�jd utskrift

Skapa ett program som ber anv�ndaren att skriva in ett ord. Sedan ett till, och ett till i all evighet. Varje g�ng man skrivit in ett ord s� ska programmet skriva ut det ord man skrev 10 inmatningar tidigare. Men om man inte skrivit in 10 ord �n s� kan den ist�llet skriva just det: �Du har inte skrivit in 10 ord �n.�

## 9. Bokstavspyramid

Skapa ett program som skriver ut f�rsta tecknet i "Hello World" p� f�rsta raden, de 2 f�rsta tecknen p� andra raden osv.

**Exempel:**
```
H
He
Hel
...
Hello Worl
Hello World
```

## 10. F�rgade bokst�ver

Man kan byta f�rg som anv�nds f�r utskrift i console med hj�lp av Console.ForegroundColor (t.ex Console.ForegroundColor = ConsoleColor.Red)

Skapa ett program som ber anv�ndaren mata in en text. Be sedan anv�ndaren mata in en bokstav. Skriv ut str�ngen som matades in; de bokst�ver som �r samma som den anv�ndaren valde ska skriva ut med r�d f�rg, alla andra med gr�..

**Exempel:**

Mata in en text: Hejsan hoppsan!  
V�lj en bokstav: s  
Hej<span style="color:red">s</span>an hopp<span style="color:red">s</span>an!

***OBS!*** *F�rgkodning i markdown verkar inte visas p� GitHub. Check ut och visa denna filen i visual studio eller visual studio code ist�llet!*

## 11. Start & Stop

Be anv�ndaren mata in en text. Be sedan om ett startindex, och sedan om ett stopindex. Skriv ut hela texten, men alla tecken fr�n startindex till stopindex ska vara r�da.

**Exempel:**

Mata in en text: Detta �r en text  
V�lj startindex: 3  
V�lj stopindex: 9  
Det<span style="color:red">ta �r e</span>n text

## 12. V�xla f�rg

Be anv�ndaren mata in en text. Be sedan anv�ndaren mata in en bokstav. Skriv ut hela texten, r�dmarkera fr�n f�rsta st�llet den hittar bokstaven till andra st�llet den hittar bokstaven, fr�n tredje st�llet till fj�rde o.s.v.

**Exempel:**

Mata in text: How much wood would a woodchuck chuck if a woodchuck could chuck wood?  
V�lj bokstav: o

H<span style="color:red">ow much wood wo</span>uld a w<span style="color:red">oo</span>dchuck chuck if a w<span style="color:red">oo</span>dchuck c<span style="color:red">ould chuck wo</span>od?
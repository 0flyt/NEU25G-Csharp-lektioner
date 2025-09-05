# �vningsuppgifter med loopar

## 1. Skriv talen 20 till 30

Skriv en loop som skriver ut alla tal fr�n 20 till  30.

**Exempel:**
```
20
21
...
29
30
```

## 2. J�mna tal

Skriv en loop som skriver ut alla j�mna tal fr�n 0 till 30.

**Exempel:**
```
0
2
...
28
30
```

## 3. Var tredje "Hej"

Skriv en loop som skriver ut tal fr�n 0 till 30, men om talet �r j�mnt delbart med 3 skriv ist�llet �Hej�

**Exempel:**
```
"Hej"
1
2
"Hej"
4
...
29
"Hej"
```

## 4. G�ngertabell

G�r ett program som ber anv�ndaren mata in ett tal, skriv ut det talets �g�ngertabell� dvs, multiplikationer av talet med alla tal fr�n 1 t.o.m. 10.

**Exempel:**
```
Skriv in ett tal: 4
1 * 4 = 4
2 * 4 = 8
...
10 * 4 = 40
```

## 5. Summa

Summan av alla tal 1 till 4, �r 10 (1+2+3+4). G�r ett program som r�knar ut summan av alla tal 1 till 1000.

## 6. Riskorn p� shackbr�de

Enligt legenden s� fick den man som hade konstruerat det formidabla spelet
schack �nska sig n�got v�rdefullt av den
�verf�rtjuste kungen. Monarken blev f�rv�nad �ver uppfinnarens anspr�ksl�shet n�r g�van skulle best� av riskorn.

Antalet riskorn best�mdes enligt f�ljande regel:
ett korn skulle l�mnas f�r f�rsta rutan p� ett
schackbr�de, tv� korn f�r andra rutan, fyra
f�r tredje, �tta f�r fj�rde och s� �nd� till den
sista rutan. 

Skriv ett program som hj�lper kungen att ber�kna antalet riskorn p� vardera ruta.

**Exempel:**
```
Ruta 1: 1
Ruta 2: 2
Ruta 3: 4
Ruta 4: 8
Ruta 5: 16
...
Ruta 64: ???
```

## 7. Fylld box

G�r ett program som ber anv�ndaren mata in h�jd och bredd. Printa ut en �box� med bokstaven X p� sk�rmen med den h�jd och bredd som matats in.

**Exempel:**
```
Mata in h�jd: 3
Mata in bredd: 5
XXXXX
XXXXX
XXXXX
```

## 8. Randig box

Samma som uppgift 7, men f�r varannan kolumn skrivs bokstaven O ist�llet f�r X.

**Exempel:**
```
Mata in h�jd: 3
Mata in bredd: 5
XOXOX
XOXOX
XOXOX
```

## 9. Rutig box

Samma som uppgift 8, men med ett schackrutem�nster.

**Exempel:**
```
Mata in h�jd: 3
Mata in bredd: 5
XOXOX
OXOXO
XOXOX
```

## 10. Ih�lig box

 Fr�ga efter bredd och h�jd och skriv ut en �box� som inte �r fylld.

**Exempel:**
```
Mata in h�jd: 4
Mata in bredd: 5
XXXXX
X   X
X   X
XXXXX
```

## 11. Sifferpyramid

G�r ett program som skriver �1� p� f�rsta raden, �12� p� n�sta, sen �123� osv upp till rad 9 d�r det st�r �123456789�

**Exempel:**
```
1
12
123
...
123456789
```

## 12. Nio sifferpyramider

G�r ett program som skriver ut �pyramider� som i uppgiften ovan, den f�rsta ska vara med en rad, f�ljt av en pyramid med 2 rader, sen 3 rader etc. �nda upp till 9 rader i den sista pyramiden.

**Exempel:**
```
1

1
12

1
12
123

...
12345678
123456789
```

## 13. Primtal

Primtal �r heltal st�rre �n 1 som inte g�r att j�mnt dela med n�got annat heltal (f�rutom 1 eller talet sj�lv, eftersom alla tal �r delbara med sig sj�lva och 1).
De 5 f�rsta primtalen �r 2, 3, 5, 7, 11.
Skriv ett program som listar de f�rsta 20 primtalen.

## 14. Spel - Gissa tal
G�r ett gissa-spel som har ett hemligt nummer (lagrat i en variabel i koden) mellan 1 och 100. N�r spelet startar ombeds spelaren att gissa ett tal mellan 1-100. Gissar man f�r l�gt skriver programmet ut att man gissat f�r l�gt, och man f�r gissa igen. Gissar man f�r h�gt skriver programmet att man gissat f�r h�gt och man f�r gissa igen. Gissar man r�tt s� skriver programmet att man gissat r�tt, samt antal gissningar som kr�vdes f�r att gissa r�tt.

***Extrauppgift:*** *Klassen �Random� i .NET kan anv�ndas f�r att s�tta den hemliga variabeln till ett slumpm�ssigt tal 1-100. Googla �C# Random� och se om du f�r det att fungera s� det blir olika tal varje g�ng man k�r programmet.*

***Extrauppgift 2:*** *G�r s� att datorn sj�lv (automatiskt) spelar spelet, och gissar tal. Skriv ut output precis som innan s� man kan f�lja hur den spelat. F�rs�k f� den att l�sa det s� effektivt (s� f� drag) som m�jligt.*

## 15. Sten, sax, p�se
Skriv ett sten-sax-p�se spel. Anv�ndaren skriver in �sten�, �sax� eller �p�se�. Dators val slumpas med Random. Skriv sedan ut vad datorn valde, och vem som vann omg�ngen. L�gg det hela i en loop s� spelet forts�tter tills man matar in en tom str�ng (trycker enter utan att skriva n�got). Skriv �ven ut po�ng.
# �vningsuppgifter med delegat och lambda

## 1. Deklarera en egen delegat-typ

Skriv en metod som tar tv� str�ngar: firstName och lastName. Metoden ska returnera en ny str�ng som �r hela namnet. Deklarera en delegat-typ, och g�r en variabel som �r en referens till metoden. Anropa metoden via delegatet.

## 2. Anv�nd generiskt delegat
�ndra koden i uppgiften ovan s� att den anv�nder ett generiskt delegat ist�llet f�r den du sj�lv deklarerade.

## 3. Metod som tar delegat som inparameter
Skriv en ny metod som ocks� tar firstName och lastName. Denna metoden ska returnera en str�ng som inneh�ller variabelnamnen och dess v�rden p� tv� rader.

Exempel:
```
firstName: Fredrik
lastName: Johansson
```

Skriv sedan en metod som tar ett generiskt delegat (som matchar metoden ovan) som inparameter. Metoden ska, i tur och ordning, anropa delegatet med 3 olika f�r- och efternamn och skriva ut resultatet. Testa att anropa denna metod f�rst med en referens till metoden i uppgift 1 och sedan med metoden ovan (uppgift 3).

## 4. Skriv ut summan av tv� v�rden
Skapa ett generiskt delegat med ett lambda uttryck som tar tv� tal och skriver ut summan av dessa p� konsolen. Testa genom att anropa med tv� v�rden.

## 5. Returnera summan av tv� v�rden
Skapa ett generiskt delegat med ett lambda uttryck som tar tv� tal och returnerar summan av dessa. Testa genom att anropa med tv� v�rden, och skriva ut resultatet.

## 6. Lambda som argument
Anropa metoden (den som tar ett generiskt delegat) i uppgift 3. Som argument skriver du ett lambdauttryck som returnerar en string med antal tecken i namnen:
Ex. "firstName has 7 letters, lastName has 9 letters."

## 7. Modifiera utskrift med lambdauttryck 
Skriv en metod som tar en string[] som inparameter och skriver ut alla str�ngar i arrayen p� varsin rad. Uppdatera sedan metoden s� att den tar en andra parameter: Func<string, string> modifier, och anropa modifier() p� varje string i arrayen innan du skriver ut den.

Skapa en en string[] med namnen p� fem st�der som du kan skicka in i metoden.

G�r 3 anrop till metoden (med olika lambda-uttryck):
- Ett som skriver ut alla st�der i UPPERCASE
- Ett som skriver ut de 3 f�rsta tecknen i varje stad
- Ett som skriver ut l�ngden p� varje stads namn.

## 8. Filtrera array (utskrift)
Skapa en metod som tar en array med heltal, samt ett delegat som tar en int som inparameter och returnerar en bool. Metoden ska sedan anropa delegatet f�r varje tal i arrayen och endast skriva ut de tal som returnerar true.

Skapa en int[] med 10 tal som du kan skicka in i metoden:

G�r 3 anrop till metoden:
- Ett som listar alla negativa tal
- Ett som listar alla tal mellan 10 och 20
- Ett som listar alla j�mna tal

## 9. Filtrera array (till ny array)
G�r om metoden i uppgift 8 s� att den ist�llet f�r att skriva ut talen returnerar en ny array med de tal som matchar villkoren i lambdautrycket man skickar in.
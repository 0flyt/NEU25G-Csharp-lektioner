# �vningsuppgifter med LINQ

## 1. Anonyma datatyper
Skapa en array "people" med anonyma datatyper. Varje objekt i arrayen ska ha f�ljande properties: FirstName, LastName, Age, Height, Weight. 

L�gg till minst 8 s�dana objekt i arrayen.

Anv�nd dig sedan av LINQ f�r att l�sa f�ljande uppgifter:

## 2. Filtrera p� �lder
Filtrera arrayen (uppgift 1) s� du f�r en ny lista med endast de anv�ndare som �r mellan 20 och 40 �r gamla. 

## 3. �r n�gon l�ngre �n 190 cm?
�r n�gon av personerna mellan 20 och 40 �r l�ngre �n 190 cm l�ng?

## 4. Filtrera p� namn
 Filtrera arrayen fr�n uppgift 1 s� att du f�r en ny lista med endast de anv�ndare vars f�rnamn �r l�ngre �n efternamnet (d.v.s st�rre antal bokst�ver). I den nya listan vill vi att objekten ska ha endast properties FirstName och LastName.

## 5. Hela namnet tillsammans med BMI
Skapa en ny lista fr�n arrayen (fr�n uppgift 1) som inneh�ller objekt med properties Name (hela namnet), samt BMI (utr�knat fr�n l�ngd och vikt) f�r alla personer.

## 6. Filtrera listan ovan p� BMI
Filtrera listan (fr�n uppgift 5) s� att du endast f�r med personer med BMI under 20 eller BMI �ver 25.

## 7. Filtrera orginallistan p� BMI
Filtrera arrayen (fr�n uppgift 1) s� att du endast f�r med personer med BMI under 20 eller BMI �ver 25.

## 8. Username tillsammans med Category 
Skapa en ny lista fr�n arrayen (i uppgift 1) som inneh�ller objekt med properties Username (f�rnamnet + �ldern, ex. �Kalle23�), samt Category (som har v�rdet �Child� eller �Adult� beroende p� om personen �r under 18 eller inte).

## 9. Query syntax
L�s alla uppgifter 2 - 8 med query-syntax (om du anv�nt method-syntax, annars tv�rtom).

## 10. Sortera efter l�ngd
LINQ anv�nder metoderna .OrderBy() och .OrderByDescending() f�r att sortera data.

Skriv ut alla personer (fr�n uppgift 1) i l�ngdordning (kortast f�rst).

## 11. Sortera �ldst till yngst
Skriv ut alla personer (fr�n uppgift 1) sortera efter �lder; fr�n �ldst till yngst.

## 12. Sortering i f�rsta och andra hand
Efter .OrderBy eller .OrderByDescending() kan man anv�nda .ThenBy() och .ThenByDescending() f�r att sortera p� n�got annat i andra hand (om flera objekt har samma v�rden i f�rsta sorteringen).

Skriv ut alla personer (fr�n uppgift 1) sorterade p� efternamn i stigande ordning (A -> Z). Om flera personer har samma efternamn, sortera dessa p� f�rnamn i fallande ordning (Z -> A).
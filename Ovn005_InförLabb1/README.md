# F�rberedelse�vningar - Labb 1

H�r har ni fler �vningsuppgifter med loopar och indexering av str�ngar. Dessa kan vara bra att l�sa innan man ger sig p� labb 1, d� ni kommer l�ra er en del saker som kan hj�lpa er p� labben.

***OBS!*** *F�rgkodning i markdown verkar inte visas p� GitHub. Checka ut och visa denna filen i Visual studio eller Visual studio code ist�llet!*

## 1. Bokstav f�r bokstav - fram till space
Utg� fr�n str�ngen (skapa en variabel med) "Hello World!", skriv ut hela str�ngen bokstav f�r bokstav, men avsluta n�r det kommer ett space. (Den ska allts� bara skriva �Hello�).

## 2. Bokstav f�r bokstav - radbyte p� space
Utg� fr�n str�ngen "This is just some other text". Skriv ut str�ngen bokstav f�r bokstav, men n�r det kommer ett space, g�r radbyte ist�llet. (Du ska f� ett ord p� varje rad).

## 3. Bokstav f�r bokstav - varannan stj�rna
Utg� fr�n str�ngen "Detta �r uppgift 3". Skriv ut bokstav f�r bokstav. Men om index �r en j�mn siffra, skriv ist�llet ut *

## 4. Bokstav f�r bokstav - gr�na o, r�da l
Utg� fr�n str�ngen "Hello world!". Skriv ut bokstav f�r bokstav. Alla 'o' ska vara gr�n f�rg, alla 'l' ska vara r�d f�rg. �vriga bokst�ver �r vita/gr�.

## 5. Bokstav f�r bokstav - dubbla med gr�n f�rg
Utg� fr�n str�ngen "Hello world". Skriv ut bokstav f�r bokstav. Om tv� tecken p� rad �r samma s� ska dessa vara gr�n f�rg. �vriga bokst�ver �r vita/gr�.

## 6. Bokstav f�r bokstav - gr�n substring
Utg� fr�n str�ngen "How much wood would a woodchuck chuck if a woodchuck could chuck wood?", samt den mindre str�ngen "oo". Skriv ut den l�nga str�ngen bokstav f�r bokstav. Varje g�ng den mindre str�ngen f�rekommer (tv� 'o' p� raken) s� ska dessa vara med gr�n f�rg. �vriga bokst�ver �r vita/gr�.

## 7. Bokstav f�r bokstav - gr�n substring 2
Samma som uppgift 6, men den mindre str�ngen �r "chuck" ist�llet f�r "oo". D.v.s. alla g�nger "chuck" f�rekommer i den l�ngre str�ngen skrivs dessa med gr�n text.

## 8. Bokstav f�r bokstav - gr�n substring 3
Samma som uppgift 6 igen, men denna g�ngen kan anv�ndaren mata in den kortare str�ngen, allts� valfri text som ska s�kas (f�rgas gr�n) i den l�ngre texten.

## 9. Bokstavspyramid
Utg� fr�n str�ngen "Hello world!". G�r ett program som skriver ut f�rsta bokstaven en g�ng p� f�rsta raden. Andra bokstaven 2 g�nger p� andra raden. Tredje 3 g�nger p� n�sta rad osv. Allts�:
```
H
ee
lll
... etc
```

## 10. Ordpyramid
Utg� fr�n str�ngen �How much wood would a woodchuck chuck if a woodchuck could chuck wood?�. G�r ett program som skriver ut f�rsta ordet en g�ng p� f�rsta raden; andra ordet tv� g�nger p� n�sta rad. Tredje ordet tre g�nger p� n�sta. etc. allts�:
```
How
much much
wood wood wood
... etc
```

## 11. Ordpyramid 2
Utg� fr�n str�ngen �How much wood would a woodchuck chuck if a woodchuck could chuck wood?�. G�r ett program som p� f�rsta raden skriver ut f�rsta ordet. P� n�sta rad skriver ut de tv� f�rsta orden, sedan de tre f�rsta orden p� n�sta rad o.s.v till man kommit till raden som skriver ut hela meningen. Allts�:
```
How
How much
How much wood
... etc
```

## 12. R�dmarkerade ord
Utg� fr�n samma str�ng igen, men denna g�ng ska programmet skriva ut hela str�ngen p� varje rad. P� f�rsta raden ska f�rsta ordet vara r�tt (�vriga vita), p� andra raden ska andra ordet vara r�tt. P� tredje raden ska tredje vara r�tt osv. Allts�:

<span style="color:red; font-weight:bold">How</span> much wood would a woodchuck chuck if a woodchuck could chuck wood?  
How <span style="color:red; font-weight:bold">much</span> wood would a woodchuck chuck if a woodchuck could chuck wood?  
How much <span style="color:red; font-weight:bold">wood</span> would a woodchuck chuck if a woodchuck could chuck wood?  
... etc

## 13. R�dmarkerade bokst�ver
Utg� fr�n str�ngen "abcdefghijklmnopqrstuvwxyz". Hela str�ngen skrivs ut p� varje rad. P� f�rsta raden �r de 5 f�rsta tecknen r�da. P� n�sta rad �r �bcdef� r�da, sedan �cedfg� osv.. allts� alltid 5 tecken, men de flyttas ett steg �t h�ger f�r varje rad, tills sista raden har �vwxyz� r�df�rgad. Allts�:

<span style="color:red; font-weight:bold">abcde</span>fghijklmnopqrstuvwxyz  
a<span style="color:red; font-weight:bold">bcdef</span>ghijklmnopqrstuvwxyz  
ab<span style="color:red; font-weight:bold">cdefg</span>hijklmnopqrstuvwxyz  
... etc

## 14. R�dmarkerade bokst�ver 2
Anv�ndaren matar in valfri str�ng. Programmet skriver ut hela str�ngen bokstav f�r bokstav. Alla bokst�verna �r r�da fram tills du st�ter p� ett tecken som �r samma som f�rsta tecknet i str�ngen. D�refter skriver den ut resten av bokst�verna med vit/gr� f�rg. N�gra exempel vid olika inmatningar/k�rningar:

<span style="color:red; font-weight:bold">ajdfhva</span>jhdfd  
<span style="color:red; font-weight:bold">hh</span>fgijff  
<span style="color:red; font-weight:bold">fjpdpog</span>  


## 15. R�dmarkerade bokst�ver 3
Anv�ndaren matar in valfri str�ng. Programmet skriver sedan ut en hela str�ngen flera g�nger. P� f�rsta raden b�rjar den skriva med r�d f�rg p� f�rsta bokstaven och fram tills den hittar samma bokstav igen. P� andra raden b�rjar den skriva med r�d f�rg p� andra bokstaven och fram tills den hittar samma bokstav igen. P� tredje raden b�rjar den skriva med r�d text p� tredje bokstaven och fram tills den hittar samma igen... etc. Om man t.ex matar in �ajdfhvajhdfd� blir det d�:

<span style="color:red; font-weight:bold">ajdfhva</span>jhdfd  
a<span style="color:red; font-weight:bold">jdfhvaj</span>hdfd  
aj<span style="color:red; font-weight:bold">dfhvajhd</span>fd  
ajd<span style="color:red; font-weight:bold">fhvajhdf</span>d  
... etc
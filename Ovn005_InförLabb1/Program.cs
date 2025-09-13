//Förberedelseövningar - Labb 1

//Här har ni fler övningsuppgifter med loopar och indexering av strängar.
//Dessa kan vara bra att lösa innan man ger sig på labb 1, då ni kommer lära er en del saker som kan hjälpa er på labben.

//OBS! Färgkodning i markdown verkar inte visas på GitHub.
//Checka ut och visa denna filen i Visual studio eller Visual studio code istället!
//1. Bokstav för bokstav - fram till space

//Utgå från strängen (skapa en variabel med) "Hello World!", skriv ut hela strängen bokstav för bokstav,
//men avsluta när det kommer ett space. (Den ska alltså bara skriva “Hello”).

string text = "Hello World!";

//foreach (var t in text)
//{
//    if (t == ' ')
//    {
//        break;
//    }
//    Console.Write(t);
//}

Console.WriteLine($"{text.Remove(text.IndexOf(' '))}\n");

//2. Bokstav för bokstav - radbyte på space

//Utgå från strängen "This is just some other text".
//Skriv ut strängen bokstav för bokstav, men när det kommer ett space, gör radbyte istället. (Du ska få ett ord på varje rad).

text = "This is just some other text";

Console.WriteLine($"{text.Replace(' ', '\n')}\n");

//3. Bokstav för bokstav - varannan stjärna

//Utgå från strängen "Detta är uppgift 3". Skriv ut bokstav för bokstav. Men om index är en jämn siffra, skriv istället ut *

text = "Detta är uppgift 3";

for (int i = 0; i < text.Length; i++)
{
    Console.Write(i % 2 != 0 ? text[i] : '*');
}
Console.WriteLine();

//4. Bokstav för bokstav - gröna o, röda l

//Utgå från strängen "Hello world!". Skriv ut bokstav för bokstav.
//Alla 'o' ska vara grön färg, alla 'l' ska vara röd färg. Övriga bokstäver är vita/grå.

text = "Hello world! Hello";

foreach (var letter in text)
{
    if (letter == 'o' || letter == 'l')
    {   
        Console.ForegroundColor = letter == 'o' ? ConsoleColor.Green : ConsoleColor.Red;
    }
    Console.Write(letter);
    Console.ForegroundColor = ConsoleColor.Gray;
}
Console.WriteLine();
//5. Bokstav för bokstav - dubbla med grön färg

//Utgå från strängen "Hello world". Skriv ut bokstav för bokstav.
//Om två tecken på rad är samma så ska dessa vara grön färg. Övriga bokstäver är vita/grå.
text = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
int endColor = 0;
for (int i = 0; i < text.Length; i++)
{
    if (i < text.Length - 1 && text[i] == text[i + 1])
    {
        Console.ForegroundColor = ConsoleColor.Green;
        endColor = i + 1;
    }
    if (i > endColor)
    {
        endColor = 0;
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    Console.Write(text[i]);

}
Console.WriteLine();
//6. Bokstav för bokstav - grön substring

//Utgå från strängen "How much wood would a woodchuck chuck if a woodchuck could chuck wood?", samt den mindre strängen "oo".
//Skriv ut den långa strängen bokstav för bokstav.
//Varje gång den mindre strängen förekommer (två 'o' på raken) så ska dessa vara med grön färg. Övriga bokstäver är vita/grå.

// Redan löst ovan.

//7. Bokstav för bokstav - grön substring 2

//Samma som uppgift 6, men den mindre strängen är "chuck" istället för "oo".
//D.v.s. alla gånger "chuck" förekommer i den längre strängen skrivs dessa med grön text.

string chuck = "chuck";
//string chuck = Console.ReadLine();
int endChuck = 0;

for (int i = 0; i < text.Length; i++)
{
    if (i< text.Length - chuck.Length && text.Substring(i, chuck.Length) == chuck)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        endChuck = i + chuck.Length;
    }

    if (i >= endChuck)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        endChuck = 0;
    }
    Console.Write(text[i]);
}
Console.WriteLine();

//8. Bokstav för bokstav - grön substring 3

//Samma som uppgift 6 igen, men denna gången kan användaren mata in den kortare strängen,
//alltså valfri text som ska sökas (färgas grön) i den längre texten.

// Löste den ovan.

//9. Bokstavspyramid

//Utgå från strängen "Hello world!". Gör ett program som skriver ut första bokstaven en gång på första raden.
//Andra bokstaven 2 gånger på andra raden. Tredje 3 gånger på nästa rad osv. Alltså:

//H
//ee
//lll
//... etc

text = "Hello world";
for (int i = 0; i < text.Length; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write(text[i]);
    }
    Console.WriteLine();
}
Console.WriteLine();


//10. Ordpyramid

//Utgå från strängen “How much wood would a woodchuck chuck if a woodchuck could chuck wood?”.
//Gör ett program som skriver ut första ordet en gång på första raden; andra ordet två gånger på nästa rad.
//Tredje ordet tre gånger på nästa. etc. alltså:

//How
//much much
//wood wood wood
//... etc

text = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
string[] myText = text.Split(' ');
for (int i = 0; i < myText.Length; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write(myText[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

//11. Ordpyramid 2

//Utgå från strängen “How much wood would a woodchuck chuck if a woodchuck could chuck wood?”.
//Gör ett program som på första raden skriver ut första ordet.
//På nästa rad skriver ut de två första orden, sedan de tre första orden på nästa rad o.s.v
//till man kommit till raden som skriver ut hela meningen. Alltså:

//How
//How much
//How much wood
//... etc

//string growingText = "";
//for (int i = 0; i < myText.Length; i++)
//{
//    growingText += myText[i] + " ";
//    Console.WriteLine(growingText);
//}

for (int i = 0; i < myText.Length; i++)
{
    Console.WriteLine(string.Join(" ", myText.Take(i + 1)));
}
Console.WriteLine();
//12. Rödmarkerade ord

//Utgå från samma sträng igen, men denna gång ska programmet skriva ut hela strängen på varje rad.
//På första raden ska första ordet vara rött (övriga vita), på andra raden ska andra ordet vara rött.
//På tredje raden ska tredje vara rött osv. Alltså:

//How much wood would a woodchuck chuck if a woodchuck could chuck wood?
//How much wood would a woodchuck chuck if a woodchuck could chuck wood?
//How much wood would a woodchuck chuck if a woodchuck could chuck wood?
//... etc

for (int i = 0; i < myText.Length; i++)
{
    Console.Write(string.Join(" ", myText.Take(i)));
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write($"{( i == 0 ? myText[i] + " " : " " + myText[i] + " ")}");
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write(string.Join(" ", myText.Skip(i + 1)));
    Console.WriteLine();
}
Console.WriteLine();
//13. Rödmarkerade bokstäver

//Utgå från strängen "abcdefghijklmnopqrstuvwxyz". Hela strängen skrivs ut på varje rad. På första raden är de 5 första tecknen röda.
//På nästa rad är “bcdef” röda, sedan “cedfg” osv.. alltså alltid 5 tecken, men de flyttas ett steg åt höger för varje rad, tills sista raden har “vwxyz” rödfärgad.
//Alltså:

//abcdefghijklmnopqrstuvwxyz
//abcdefghijklmnopqrstuvwxyz
//abcdefghijklmnopqrstuvwxyz
//... etc

text = "abcdefghijklmnopqrstuvwxyz";

for (int i = 0; i <= text.Length - 5; i++)
{
    Console.Write(text.Substring(0, i));
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(text.Substring(i, 5));
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write(text.Substring(i + 5));
    Console.WriteLine();
}

//14. Rödmarkerade bokstäver 2

//Användaren matar in valfri sträng. Programmet skriver ut hela strängen bokstav för bokstav.
//Alla bokstäverna är röda fram tills du stöter på ett tecken som är samma som första tecknet i strängen.
//Därefter skriver den ut resten av bokstäverna med vit/grå färg. Några exempel vid olika inmatningar/körningar:

//ajdfhvajhdfd
//hhfgijff
//fjpdpog

text = Console.ReadLine();
Console.WriteLine();
int endTarget = 0;
Console.ForegroundColor = ConsoleColor.Red;
for (int i = 1; i < text.Length; i++)
{
    if (text[0] == text[i])
    {
        endTarget = i;
        break;
    }
}

for (int i = 0; i < text.Length; i++)
{
    if (i > endTarget)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    Console.Write(text[i]);
}
Console.WriteLine();

//15. Rödmarkerade bokstäver 3

//Användaren matar in valfri sträng. Programmet skriver sedan ut en hela strängen flera gånger.
//På första raden börjar den skriva med röd färg på första bokstaven och fram tills den hittar samma bokstav igen.
//På andra raden börjar den skriva med röd färg på andra bokstaven och fram tills den hittar samma bokstav igen.
//På tredje raden börjar den skriva med röd text på tredje bokstaven och fram tills den hittar samma igen... etc. Om man t.ex matar in “ajdfhvajhdfd” blir det då:

//ajdfhvajhdfd
//ajdfhvajhdfd
//ajdfhvajhdfd
//ajdfhvajhdfd
//... etc
text = Console.ReadLine();
Console.WriteLine();
int newEndIndex = 0;
for (int i = 0; i < text.Length; i++)
{

    for (int j = 1; j < text.Length; j++)
    {
        if (text[i] == text[j] && i < j)
        {
            newEndIndex = j + 1;
            break;
        }
        newEndIndex = text.Length;
    }
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write(text.Substring(0, i));

    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(text.Substring(i, newEndIndex - i));

    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write(text.Substring(newEndIndex));
    Console.WriteLine();

}

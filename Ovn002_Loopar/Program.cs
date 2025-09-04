//using System;

//Övningsuppgifter med loopar
//1. Skriv talen 20 till 30

//Skriv en loop som skriver ut alla tal från 20 till 30.

//Exempel:

//20
//21...
//29
//30

//int i = 20;
//while (i <= 30)
//{
//    Console.WriteLine(i);
//    i++;
//}

//2.Jämna tal

//Skriv en loop som skriver ut alla jämna tal från 0 till 30.

//Exempel:

//0
//2...
//28
//30

//int i = 0;
//while (i <= 30)
//{
//    if (i % 2 == 0)
//        Console.WriteLine(i);
//
//    i++;
//}

//3.Var tredje "Hej"

//Skriv en loop som skriver ut tal från 0 till 30, men om talet är jämnt delbart med 3 skriv istället “Hej”

//Exempel:

//"Hej"
//1
//2
//"Hej"
//4...
//29
//"Hej"

//int i = 0;
//while (i <= 30)
//{
//    if (i % 3 == 0)
//        Console.WriteLine("Hej");
//    else
//        Console.WriteLine(i);

//    i++;
//}

//4.Gångertabell

//Gör ett program som ber användaren mata in ett tal, skriv ut det talets “gångertabell” dvs, multiplikationer av talet med alla tal från 1 t.o.m. 10.

//Exempel:

//Skriv in ett tal: 4
//1 * 4 = 4
//2 * 4 = 8...
//10 * 4 = 40

//Console.Write("Skriv in ett tal: ");
//int tal = Int32.Parse(Console.ReadLine());
//int i = 0;
//while (i <= 10)
//{
//    Console.WriteLine(i * tal);
//    i++;
//}

//5.Summa

//Summan av alla tal 1 till 4, är 10 (1+2+3+4). Gör ett program som räknar ut summan av alla tal 1 till 1000.

//int i = 1;
//int result = 0;

//while (i <= 1000)
//{
//    Console.Write($"\t{result} + {i} = ");
//    Console.WriteLine(result += i);

//    i++;
//}


//6. Riskorn på shackbräde

//Enligt legenden så fick den man som hade konstruerat det formidabla spelet schack önska sig något värdefullt av den överförtjuste kungen. Monarken blev förvånad över uppfinnarens anspråkslöshet när gåvan skulle bestå av riskorn.

//Antalet riskorn bestämdes enligt följande regel: ett korn skulle lämnas för första rutan på ett schackbräde, två korn för andra rutan, fyra för tredje, åtta för fjärde och så ändå till den sista rutan.

//Skriv ett program som hjälper kungen att beräkna antalet riskorn på vardera ruta.

//Exempel:

//Ruta 1: 1
//Ruta 2: 2
//Ruta 3: 4
//Ruta 4: 8
//Ruta 5: 16...
//Ruta 64: ???

//int i = 1;
//decimal result = 1;

//while (i <= 64)
//{
//    if (i == 1)
//    {
//        Console.WriteLine($"Ruta {i}: {i}");
//    }
//    else
//    {
//        Console.WriteLine($"Ruta {i}: {result *= 2}");
//    }

//    i++;
//}

//7.Fylld box

//Gör ett program som ber användaren mata in höjd och bredd. Printa ut en “box” med bokstaven X på skärmen med den höjd och bredd som matats in.

//Exempel:

//Mata in höjd: 3
//Mata in bredd: 5
//XXXXX
//XXXXX
//XXXXX

//Console.Write("Mata in höjd: ");
//int h = Int32.Parse(Console.ReadLine());

//Console.Write("Mata in bredd: ");
//int w = Int32.Parse(Console.ReadLine());

//int i = 1;

//while (i <= h)
//{
//    int j = 1;
//    while (j <= w)
//    {
//        Console.Write("X");
//        j++;
//    }
//    Console.WriteLine();
//    i++;
//}


//8. Randig box

//Samma som uppgift 7, men för varannan kolumn skrivs bokstaven O istället för X.

//Exempel:

//Mata in höjd: 3
//Mata in bredd: 5
//XOXOX
//XOXOX
//XOXOX

//Console.Write("Mata in höjd: ");
//int h = Int32.Parse(Console.ReadLine());

//Console.Write("Mata in bredd: ");
//int w = Int32.Parse(Console.ReadLine());

//int i = 1;
//while (i <= h)
//{
//    int j = 1;
//    while (j <= w)
//    {
//        if (j % 2 == 0)
//        {
//            Console.Write("O");
//        }
//        else
//        {
//            Console.Write("X");
//        }
//        j++;
//    }
//    Console.WriteLine();
//    i++;
//}

//9. Rutig box

//Samma som uppgift 8, men med ett schackrutemönster.

//Exempel:

//Mata in höjd: 3
//Mata in bredd: 5
//XOXOX
//OXOXO
//XOXOX

//Console.Write("Mata in höjd: ");
//int h = Int32.Parse(Console.ReadLine());

//Console.Write("Mata in bredd: ");
//int w = Int32.Parse(Console.ReadLine());

//int i = 1;
//while (i <= h)
//{
//    if (i % 2 == 0)
//    {
//        int j = 1;
//        while (j <= w)
//        {
//            if (j % 2 == 0)
//            {
//                Console.Write("O");
//            }
//            else
//            {
//                Console.Write("X");
//            }
//            j++;
//        }
//    }
//    else
//    {
//        int j = 1;
//        while (j <= w)
//        {
//            if (j % 2 != 0)
//            {
//                Console.Write("O");
//            }
//            else
//            {
//                Console.Write("X");
//            }
//            j++;
//        }
//    }
//    Console.WriteLine();
//    i++;

//}

//10. Ihålig box

//Fråga efter bredd och höjd och skriv ut en “box” som inte är fylld.

//Exempel:

//Mata in höjd: 4
//Mata in bredd: 5
//XXXXX
//X   X
//X   X
//XXXXX

// Test 1
//Console.Write("Mata in höjd: ");
//int h = Int32.Parse(Console.ReadLine());

//Console.Write("Mata in bredd: ");
//int w = Int32.Parse(Console.ReadLine());

//int i = 1;
//while (i <= h)
//{
//    if (i == 1 || i == h)
//    {
//        int j = 1;
//        while (j <= w)
//        {
//            Console.Write("X");
//            j++;
//        }
//        Console.WriteLine();
//        i++;

//    }
//    else if (i > 1 || i < h)
//    {
//        int j = 1;
//        while (j <= w)
//        {
//            if (j == 1 || j == w)
//                Console.Write("X");
//            else if (j > 1 || j < w)
//                Console.Write(" ");
//            j++;
//        }
//        Console.WriteLine();
//        i++;
//    }
//}

//Test 2

//Console.Write("Mata in höjd: ");
//int h = Int32.Parse(Console.ReadLine());

//Console.Write("Mata in bredd: ");
//int w = Int32.Parse(Console.ReadLine());

//int i = 1;
//while (i <= h)
//{
//    int j = 1;
//    while (j <= w)
//    {
//        if (i == 1 || i == h || j == 1 || j == w)
//        {
//            Console.Write("X");
//        }
//        else
//        {
//            Console.Write(" ");
//        }
//        j++;
//    }
//    Console.WriteLine();
//    i++;

//}


//11. Sifferpyramid

//Gör ett program som skriver “1” på första raden, “12” på nästa, sen “123” osv upp till rad 9 där det står “123456789”

//Exempel:

//1
//12
//123...
//123456789

//int i = 1;
//string result = "";
//while (i <= 9)
//{
//    Console.WriteLine(result += i.ToString());
//    i++;
//}

//12.Nio sifferpyramider

//Gör ett program som skriver ut “pyramider” som i uppgiften ovan, den första ska vara med en rad, följt av en pyramid med 2 rader, sen 3 rader etc. ända upp till 9 rader i den sista pyramiden.

//Exempel:

//1

//1
//12

//1
//12
//123...
//12345678
//123456789

//int i = 1;
//while (i <= 9)
//{
//    int j = 1;
//    string result = "";
//    while (j <= i)
//    {
//        Console.WriteLine(result += j.ToString());
//        j++;
//    }
//    Console.WriteLine();
//    i++;
//}

//13.Primtal

//Primtal är heltal större än 1 som inte går att jämnt dela med något annat heltal (förutom 1 eller talet själv, eftersom alla tal är delbara med sig själva och 1). De 5 första primtalen är 2, 3, 5, 7, 11. Skriv ett program som listar de första 20 primtalen.


//Test1:

//int i = 2;
//while (i <= 71)
//{
//        int j = 2;
//        int p = 0;
//        while (j <= 100)
//        {

//            if (i % j == 0)
//                p++;
//            j++;
//        }
//        if (p == 1)
//            Console.WriteLine(i);

//    i++;
//}

// Test 2:

//int i = 2;
//// TODO: Lägg till så jag kan välja hur många primtal den ska hitta innan den slutar.
//while (i <= 71)
//{
//    int j = 2;
//    int p = 0;
//    while (j <= i) // Lade till 'i' för att undvika att köra fler gånger än nödvändigt.
//    {

//        if (i % j == 0)
//            p++;
//        j++;
//    }
//    if (p == 1)
//        Console.WriteLine(i);

//    i++;
//}


//14. Spel - Gissa tal

//Gör ett gissa-spel som har ett hemligt nummer (lagrat i en variabel i koden) mellan 1 och 100. När spelet startar ombeds spelaren att gissa ett tal mellan 1-100. Gissar man för lågt skriver programmet ut att man gissat för lågt, och man får gissa igen. Gissar man för högt skriver programmet att man gissat för högt och man får gissa igen. Gissar man rätt så skriver programmet att man gissat rätt, samt antal gissningar som krävdes för att gissa rätt.

//int secret = 50;
//int guesses = 0;
//while (true)
//{
//    Console.Write("Guess the number: ");
//    int guess = Int32.Parse(Console.ReadLine());
//    guesses++;
    
//    if (guess == secret)
//    {
//        Console.WriteLine("Correct!");
//        break;
//    }
//    else if (guess > secret)
//        Console.WriteLine("Too high! Try again.");
//    else
//        Console.WriteLine("Too low! Try again.");
//}
//Console.WriteLine($"You made: {guesses} guesses.");

//Extrauppgift: Klassen “Random” i .NET kan användas för att sätta den hemliga variabeln till ett slumpmässigt tal 1-100. Googla “C# Random” och se om du får det att fungera så det blir olika tal varje gång man kör programmet.

//Random random = new Random();
//int secret = random.Next(1, 101);
//int guesses = 0;
//while (true)
//{
//    Console.Write("Guess the number: ");
//    int guess = Int32.Parse(Console.ReadLine());
//    guesses++;

//    if (guess == secret)
//    {
//        Console.WriteLine("Correct!");
//        break;
//    }
//    else if (guess > secret)
//        Console.WriteLine("Too high! Try again.");
//    else
//        Console.WriteLine("Too low! Try again.");
//}
//Console.WriteLine($"You made: {guesses} guesses.");

//Extrauppgift 2: Gör så att datorn själv (automatiskt) spelar spelet, och gissar tal. Skriv ut output precis som innan så man kan följa hur den spelat. Försök få den att lösa det så effektivt (så få drag) som möjligt.

//Random random = new Random();
//int secret = random.Next(1, 101);

//int guess = 50;
//int tooHighGuess = 101;
//int tooLowGuess = 1;
//int guesses = 0;
//while (true)
//{
//    Console.Write("Guess the number: ");
//    Console.WriteLine(guess);

//    if (guess == secret)
//    {
//        Console.WriteLine("Correct!");
//        break;
//    }
//    else if (guess > secret)
//    {
//        tooHighGuess = guess;
//        Console.WriteLine("Too high! Try again.");
//    }
//    else
//    {
//        tooLowGuess = guess;
//        Console.WriteLine("Too low! Try again.");
//    }
//    guesses++;
//    guess = (tooHighGuess + tooLowGuess) / 2;

//}
//Console.WriteLine($"You made: {guesses} guesses.");

//15. Sten, sax, påse
//Skriv ett sten-sax-påse spel. Användaren skriver in “sten”, “sax” eller “påse”. Dators val slumpas med Random. Skriv sedan ut vad datorn valde, och vem som vann omgången. Lägg det hela i en loop så spelet fortsätter tills man matar in en tom sträng (trycker enter utan att skriva något). Skriv även ut poäng.

Console.WriteLine("Välj sten, sax, eller påse.");
Random random = new Random();

int gamesPlayed = 0;
int computerWins = 0;
int playerWins = 0;
while (true)
{
    int computer = random.Next(1, 4);
    int playerChoose = 0;
    //int player = Int32.Parse(Console.ReadLine());
    string player = Console.ReadLine().ToLower();

    switch (player)
    {
        case "sten":
            {
                playerChoose = 1;
                break;
            }
        case "sax":
            {
                playerChoose = 2;
                break;
            }
        case "påse":
            {
                playerChoose = 3;
                break;
            }
        default: break;
    }
   

    if (playerChoose == 0)
        break;
    else if (playerChoose == 1)
    {
        if (computer == 1)
        {
            Console.WriteLine("Sten vs sten: Det blev lika.");
            
        }
        else if (computer == 2)
        {
            Console.WriteLine("Sten vs sax: Du vann!");
            playerWins++;
        }
        else
        {
            Console.WriteLine("Sten vs påse: Du förlorade!");
            computerWins++;
        }
        
    }
    else if (playerChoose == 2)
    {
        if (computer == 1)
        {
            Console.WriteLine("Sax vs sten: Du förlorade!");
            computerWins++;

        }
        else if (computer == 2)
        {
            Console.WriteLine("Sax vs sax: Det blev lika.");
        }
        else
        {
            Console.WriteLine("Sax vs påse: Du vann!");
            playerWins++;
        }
        
    }
    else
    {
        if (computer == 1)
        {
            Console.WriteLine("Påse vs sten: Du vann!");
            playerWins++;

        }
        else if (computer == 2)
        {
            Console.WriteLine("Påse vs sax: Du förlorade!");
            computerWins++;
        }
        else
        {
            Console.WriteLine("Påse vs påse: Det blev lika.");
        }
        
    }
    gamesPlayed++;
    
}
Console.WriteLine();
Console.WriteLine($"Ni körde {gamesPlayed} spel.");
Console.WriteLine($"Du vann {playerWins} {(playerWins == 1 ? "gång" : "gånger")}");
Console.WriteLine($"Datorn vann {computerWins} {(computerWins == 1 ? "gång" : "gånger")}\n");
Console.WriteLine("Tack för att du spelade!");
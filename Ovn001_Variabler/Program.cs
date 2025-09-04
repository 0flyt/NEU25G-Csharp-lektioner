//Övningsuppgifter med variabler
//1. Hälsa på användaren

//Skriv ett program som frågar efter användarens namn och skriver ut en hälsning på konsolen.

//Exempel:

//Skriv ditt namn: David
//Hej David!

//Console.WriteLine("Vad heter du?");
//string name = Console.ReadLine();
//Console.WriteLine($"Hej {name}!");

//2. Multiplicera två tal

//Skriv ett program som ber användaren mata in två heltal. Skriv ut talen multiplicerade med varandra.

//Exempel:

//Skriv in första talet: 5
//Skriv in andra talet: 12
//5 * 12 = 60

//Tips: Använd Int32.Parse();

//Console.WriteLine("Skriv in två heltal som ska multipliceras:");
//Console.Write("Första: ");
//int intFirst = Int32.Parse(Console.ReadLine());
//Console.Write("Andra: ");
//int intSecond = Int32.Parse(Console.ReadLine());
//Console.WriteLine($"{intFirst} * {intSecond} = {intFirst*intSecond}");

//3.Verifiera lösenord

//Skriv ett program som frågar användaren efter ett lösenord. Hitta på ett hemligt lösenord och spara det i en variabel. När användaren har skrivit in ett lösenord ska programmet jämföra med det sparade lösenordet och skriva ut om det var rätt eller inte. Använd en if-sats.

//Exempel:

//Lösenord: abc123
//Fel lösenord!

//string guess = string.Empty;
//string password = "passw0rd";

//while (true)
//{
//    Console.WriteLine("Password:");
//    guess = Console.ReadLine();

//    if (string.IsNullOrEmpty(guess))
//    {
//        Console.WriteLine("Lösenordet får inte vara tomt eller mellanslag.");
//        continue;
//    }

//    if (guess != password)
//        Console.WriteLine("Fel! Försök igen.");
//    else
//    {
//        Console.WriteLine("Rätt!");
//        break;
//    }
//}


//4.Jämför tal

//Skriv ett program som frågar användaren efter ett tal. Det ska skriva ut om talet är mindre, större eller lika med 100.

//Exempel:

//Skriv ett tal: 45
//Ditt tal är mindre än 100.

//Console.WriteLine("Skriv ett tal:");
//int guess = Int32.Parse(Console.ReadLine());

//if (guess < 100)
//    Console.WriteLine("Ditt tal är mindre än 100");
//else if (guess > 100)
//    Console.WriteLine("Ditt tal är större än 100");
//else
//    Console.WriteLine("Ditt tal är lika med 100");

//5. Dubblera och halvera tal

//Be användaren mata in ett tal. Skriv ut talet som är dubbelt, respektive hälften.

//Exempel:

//Skriv in ett tal: 5
//10 är dubbelt så mycket som 5.
//2.5 är hälften så mycket som 5.

//Console.Write("Skriv in ett tal: ");
//double tal = double.Parse(Console.ReadLine());

//Console.WriteLine($"{tal*2} är dubbelt så mycket som {tal}.");
//Console.WriteLine($"{tal/2} är hälften så mycket som {tal}.");

//6. Miniräknare

//Skriv ett program som först frågar efter ett tal, sedan frågar efter ett av följande tecken: +, -, *eller /.Därefter ska ytterligare ett tal efterfrågas. Programmet ska fungera som en simpel miniräknare. Om man t.ex matat in först 3, sedan *, och sist 5, så ska programmet skriva ut “3 * 5 = 15”.

//Exempel:

//Första talet: 7
//Välj +, -, *, /: +
//Andra talet: 2
//7 + 2 = 9

//Console.Write("Första talet: ");
//double operand1 = double.Parse(Console.ReadLine());

//Console.Write("Välj +, -, *, /: ");
//string operator1 = Console.ReadLine();

//Console.Write("Andra talet: ");
//double operand2 = double.Parse(Console.ReadLine());

//double result = operator1 switch
//{
//    "+" => operand1 + operand2,
//    "-" => operand1 - operand2,
//    "*" => operand1 * operand2,
//    "/" => operand1 / operand2,
//};

//if ((operand2 == 0) && (operator1 == "/"))
//    Console.WriteLine("Du kan inte dela med 0.");
//else
//    Console.WriteLine($"{operand1} {operator1} {operand2} = {result}");

//7.Summa och medelvärde

//Skriv ett program som upprepade gånger frågar användaren efter ett tal ända till man skriver något som inte är ett tal (t.ex bara trycker enter). Efter varje inmatning ska summan av alla tal som matats in skrivas ut, innan nästa inmatning efterfrågas. Innan programmet avslutas ska man även skriva ut medelvärde av de inmatade talen.

//Exempel:

//Skriv in ett tal: 3
//3
//Skriv in ett tal: 2
//5
//Skriv in ett tal: 7
//12
//Skriv in ett tal:
//Medelvärde: 4


//int result = 0;
//Console.Write("Skriv in ett tal: ");
//int tal1 = Int32.Parse(Console.ReadLine());
//Console.WriteLine(result += tal1);

//Console.Write("Skriv in ett till tal: ");
//int tal2 = Int32.Parse(Console.ReadLine());
//Console.WriteLine(result += tal2);

//Console.Write("Skriv in ett till tal: ");
//int tal3 = Int32.Parse(Console.ReadLine());
//Console.WriteLine(result += tal3);

//Console.WriteLine(result / 3);

//int adderade = 0;
//int i = 0;

//while (true)
//{
//    Console.Write("Skriv in ett tal: ");
//    string tal = Console.ReadLine();
//    if (string.IsNullOrEmpty(tal) || !int.TryParse(tal, out int result))
//    {
//        if (i == 0)
//            continue;
//        else
//            Console.WriteLine($"Medeltal: {adderade / i}");
//        break;
//    }
//    else
//    {
//        Console.WriteLine(adderade += result);
//        i++;
//    }
//}

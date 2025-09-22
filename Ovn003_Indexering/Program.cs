//Övningsuppgifter med indexering av strängar och arrayer
//1. En bokstav på varje rad

//Be användaren mata in en sträng. Skriv ut varje tecken i strängen på en egen rad.

//Exempel:

//Skriv något: Hej
//H
//e
//j

//Console.Write("Skriv något: ");
//string myString = Console.ReadLine();
//myString.ToCharArray().ToList().ForEach(Console.WriteLine);

//foreach (char letter in myString)
//{
//    Console.WriteLine(letter);
//}



//2. Siffror till text

//Skapa ett program med en array som innehåller strängarna “noll”,
//“ett”, “två”, “tre”, “fyra”, “fem”, “sex”, “sju”, “åtta”, “nio”.
//Be sedan användaren att mata in en siffra. Använd arrayen för att skriva ut siffrans ord. Ex. Inmatning “3” => “tre”.

//Exempel:

//Skriv en siffra: 3
//tre

//string[] myArray = ["noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio"];
//Console.WriteLine("Skriv en siffra mellan 0-9");
//int myInt = Int32.Parse(Console.ReadLine());
//Console.WriteLine(myArray[myInt]);

//Extra utmaning: Användaren kan mata in en sträng med fritt antal siffror,
//om man skriver in t.ex 432 så svarar programmet: “fyra - tre - två”.

//string[] myArray = ["noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio"];
//Console.Write("Skriv ett tal (t.ex 456): ");

//string input = Console.ReadLine();

//int[] myInt = new int[input.Length];

//for (int i = 0; i < input.Length; i++)
//    myInt[i] = int.Parse(input[i].ToString());

//for (int i = 0; i < myInt.Length; i++)
//    Console.Write($"{myArray[myInt[i]]} {(i == myInt.Length -1 ? "" : " - ")}");

//  --- Förkortad version ---

//string[] myArray = ["noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio"];
//Console.Write("Skriv ett tal (t.ex 456): ");

//string input = Console.ReadLine();

//for (int i = 0; i < input.Length; i++)
//{
//    int digit = input[i] - '0'; // Sätt för att göra om char till int.
//    Console.Write($"{myArray[digit]} {(i == input.Length - 1 ? "" : " - ")}");
//}


//3.Baklänges

//Be användaren mata in en text. Skriv sedan ut texten baklänges.

//Exempel:

//Skriv något: Hello there!
//!ereht olleH

//Console.Write("Skriv en text: ");
//string myText = Console.ReadLine();
//Console.WriteLine(new string(myText.Reverse().ToArray())); // linq exemple
//for (int i = myText.Length - 1; i >= 0; i--)
//{
//    Console.Write(myText[i]);
//}


//4. Dölj vokaler

//Be användaren mata in en text. Skriv ut texten med alla vokaler ersatta med *

//Exempel:

//Skriv något: Hejsan, jag heter Fredrik!
//H*js*n, j*g h*t*r Fr*dr*k!

//Console.Write("Skriv in en mening: ");
//string myString = Console.ReadLine();
//string vokaler = "aeiouyåäö";

//for (int i = 0; i < myString.Length; i++)
//{
//    if (vokaler.Contains(myString[i]))
//    {

//        Console.Write("*");
//    }
//    else
//    {
//        Console.Write(myString[i]);
//    }
//}

//  --- Utan .Contains samt med ToUpper ---

//Console.Write("Skriv in en mening: ");
//string myString = Console.ReadLine();
//string vokaler = "aeiouyåäö";

//foreach (char c in myString)
//{
//    bool isVokal = false;

//    foreach (char v in vokaler)
//    {
//        if (v == c || v.ToString().ToUpper() == c.ToString().ToUpper())
//        {
//            isVokal = true;
//            break;
//        }
//    }
//    Console.Write($"{(isVokal ? "*" : c)}");
//    isVokal = false;
//}

//Extra utmaning: Skriv ut texten översatt till rövarspråket.

//Console.Write("Skriv in en mening: ");
//string myString = Console.ReadLine().ToLower();
//string vokaler = "aeiouyåäö";

//foreach (char c in myString)
//{
//    bool isVokal = vokaler.Contains(c);

//    if (!isVokal && char.IsLetter(c))
//        Console.Write($"{c}o{c}");
//    else
//        Console.Write(c);
//}

//5. Palindrom

//Ett palindrom är ett ord som blir samma framlänges som baklänges. Be användaren skriva in ett ord och ange sedan om det är ett palindrom eller inte.

//Exempel:

//Skriv ett ord: Kajak
//Kajak är ett palindrom.

//Console.Write("Skriv ett ord: ");
//string myString = Console.ReadLine().ToLower();
//string reversedString = "";

//for (int i = myString.Length - 1; i >= 0; i--)
//    reversedString += myString[i];

//Console.WriteLine($"{myString} är {(myString == reversedString ? "ett palindrom" : "INTE ett palindrom")}");

//6. Miniräknare

//Skapa en enkel miniräknare som kan hantera de fyra räknesätten med två operander.
//Till skillnad från uppgift 6 i övningsuppgifter med variabler, så ska inmatningen nu ske på en rad
//(första talet, operator, andra talet). Ignorera inmatade mellanslag i strängen.
//Om man t.ex. matar in strängen "34 - 14", så ska programmet skriva ut "= 20".

//Exempel:

//Vad vill du räkna ut? 15 * 4
//= 60

//Console.Write("Vad vill du räkna ut? ");
//string input = Console.ReadLine();
//string[] inputArray = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//int operandOne = Int32.Parse(inputArray[0]);
//string operatorOne = inputArray[1];
//int operandTwo = Int32.Parse(inputArray[2]);


//int result = operatorOne switch
//{
//    "+" => operandOne + operandTwo,
//    "-" => operandOne - operandTwo,
//    "*" => operandOne * operandTwo,
//    "/" => operandOne / operandTwo
//};

//Console.WriteLine(result);


//7. Omvänd ordning

//Be användaren skriva in ett ord, sedan ett till, och ett till; tills man skrivit in 7 ord.
//Skriv sedan ut orden på skärmen i bakvänd ordning mot hur de matades in. Alltså ordet man skrev in sist, skrivs ut först.

//string[] myArray = new string[7];

//for (int i = 0; i < myArray.Length; i++)
//{
//    Console.Write($"Skriv in ett ord ({i + 1}/7): ");
//    myArray[i] = Console.ReadLine();
//}
//for (int i = 6; i >= 0; i--)
//{
//    Console.WriteLine(myArray[i]);
//}

//8. Fördröjd utskrift

//Skapa ett program som ber användaren att skriva in ett ord. Sedan ett till, och ett till i all evighet.
//Varje gång man skrivit in ett ord så ska programmet skriva ut det ord man skrev 10 inmatningar tidigare.
//Men om man inte skrivit in 10 ord än så kan den istället skriva just det: “Du har inte skrivit in 10 ord än.”

//string[] myArray = new string[10];
//int i = 0;
//bool overTen = false;
//while (true)
//{
//    Console.Write("Skriv in ett ord: ");
//    myArray[i] = Console.ReadLine();
//    i++;
//    if (i == 10)
//    {
//        overTen = true;
//        i = 0;
//    }
//    if (overTen == true)
//        Console.WriteLine($"{myArray[i]}");
//    else
//        Console.WriteLine("Du har inte skrivit in tio ord än.");
//}

//9. Bokstavspyramid

//Skapa ett program som skriver ut första tecknet i "Hello World" på första raden, de 2 första tecknen på andra raden osv.

//Exempel:

//H
//He
//Hel
//...
//Hello Worl
//Hello World

//string myString = "Hello World";
//int j = 0;
//foreach (char letter in myString)
//{
//    for (int i = 0; i <= j; i++)
//    {
//        Console.Write(myString[i]);
//    }
//    Console.WriteLine();
//    j++;
//}


//10. Färgade bokstäver

//Man kan byta färg som används för utskrift i console med hjälp av Console.ForegroundColor
//(t.ex Console.ForegroundColor = ConsoleColor.Red)

//Skapa ett program som ber användaren mata in en text. Be sedan användaren mata in en bokstav.
//Skriv ut strängen som matades in; de bokstäver som är samma som den användaren valde ska skriva ut med röd färg, alla andra med grå..

//Exempel:

//Mata in en text: Hejsan hoppsan!
//Välj en bokstav: s
//Hejsan hoppsan!

//OBS! Färgkodning i markdown verkar inte visas på GitHub.
//Check ut och visa denna filen i visual studio eller visual studio code istället!

//Console.Write("Mata in en mening: ");
//string myString = Console.ReadLine().ToLower();
//Console.Write("Välj en bokstav: ");
//char letter = Console.ReadKey().KeyChar;
//Console.WriteLine();

//foreach (var item in myString)
//{
//    if (item == letter)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.Write(item);
//    }
//    else
//    {
//        Console.ForegroundColor = ConsoleColor.Gray;
//        Console.Write(item);
//    }
//}

//11. Start & Stop

//Be användaren mata in en text. Be sedan om ett startindex, och sedan om ett stopindex.
//Skriv ut hela texten, men alla tecken från startindex till stopindex ska vara röda.

//Exempel:

//Mata in en text: Detta är en text
//Välj startindex: 3
//Välj stopindex: 9
//Detta är en text

//Console.Write("Mata in en text: ");
//string myString = Console.ReadLine();
//Console.Write("Välj startindex: ");
//int myStart = Int32.Parse(Console.ReadLine());
//Console.Write("Välj stoppindex: ");
//int myStop = Int32.Parse(Console.ReadLine());

//for (int i = 0; i < myString.Length - 1; i++)
//{
//    if (i < myStart || i > myStop)
//    {
//        Console.ForegroundColor = ConsoleColor.Gray;
//    }
//    else
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        
//    }
//    Console.Write(myString[i]);
//}   

//12. Växla färg

//Be användaren mata in en text. Be sedan användaren mata in en bokstav.
//Skriv ut hela texten, rödmarkera från första stället den hittar bokstaven till andra stället den hittar bokstaven,
//från tredje stället till fjärde o.s.v.

//Exempel:

//Mata in text: How much wood would a woodchuck chuck if a woodchuck could chuck wood?
//Välj bokstav: o

//How much wood would a woodchuck chuck if a woodchuck could chuck wood?

//Console.Write("Mata in en mening: ");
//string myString = Console.ReadLine().ToLower();

//Console.Write("Välj en bokstav: ");
//char letter = Console.ReadKey().KeyChar;
//Console.WriteLine();
//int count = 0;

//for (int i = 0; i < myString.Length - 1; i++)
//{
//    if (letter == myString[i])
//        count++;
//}

//if (count % 2 != 0)
//    count--;

//int limitLoop = 0;
//foreach (char c in myString)
//{
//    if (c == letter)
//    {
//        limitLoop++;
//        count--;
//    }

//    Console.ForegroundColor = ((limitLoop == 1 || limitLoop == 2) && count >= 0)
//        ? Console.ForegroundColor = ConsoleColor.Red
//        : Console.ForegroundColor = ConsoleColor.Gray;
//    Console.Write(c);

//    if (limitLoop == 2)
//        limitLoop = 0;
//}
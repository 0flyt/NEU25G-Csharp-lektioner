// Operators är specialtecken i C# som används för att utföra en operation på (oftast) två operander.
// Aritmetiska operatorer (räkneoperationer):
Console.WriteLine(5 + 3);
Console.WriteLine(5 - 3);
Console.WriteLine(5 * 3);
Console.WriteLine(5 / 2); // Delar man två heltal får du enbart ett heltal som svar
Console.WriteLine(5.0 / 3); // Lägger man till .0 får man ett double som svar
Console.WriteLine(5 % 3); //Modulus

int myInt = 5; // Tilldelningsoperator (Assignment) ett enkelt likamedtecken (=)
Console.WriteLine(5);

// Jämförelseoperator (Comparison)
Console.WriteLine(myInt == 5); // Jämnför om två värden är exakt lika (==). Ger: True
Console.WriteLine(myInt != 5); // Inte lika med. Ger: False
Console.WriteLine(myInt > 5); // Större än
Console.WriteLine(myInt < 5); // Mindre än
Console.WriteLine(myInt >= 5); // Större eller lika med
Console.WriteLine(myInt <= 5); //Mindre eller lika med

// Logiska operationer (Logical Operators)
Console.WriteLine(!true);
Console.WriteLine(!false);

Console.WriteLine(true && true);
Console.WriteLine(true && false);
Console.WriteLine(false && true);
Console.WriteLine(false && false);

Console.WriteLine(true || true);
Console.WriteLine(true || false);
Console.WriteLine(false || true);
Console.WriteLine(false || false);

Console.WriteLine(myInt > 2 && myInt < 7);

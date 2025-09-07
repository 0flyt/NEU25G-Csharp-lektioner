string myString = "Hello World!";

Console.WriteLine(myString.Length);

for (int i = 0; i < myString.Length; i++)
{
    Console.WriteLine(myString[i]);
}
Console.WriteLine(myString[4]);
Console.WriteLine();

foreach (char letter in myString)
{
    Console.WriteLine(letter);
}
// Standard string literal
Console.WriteLine("Hello\t\"World\" \\n");

// Escape sequences - backslash (\) följt av vissa andra tecken har specifika betydelser
// '\n' - new line
// '\t' - tab
// '\"' - double quote (")
// '\\' - backslash (\)

Console.WriteLine();

// Verbatim string literal, startar med @
Console.WriteLine(@"Hello
world");
Console.WriteLine(@"C:\Dator\Chris\Mapp");
Console.WriteLine(@"Hello ""world"".");

//Interpolation strings
Console.WriteLine($"{myString}");
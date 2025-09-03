// Variables (variabler) är en container (behållare) för att lagra data (av en given typ).
// I C# måste variabler deklareras innan de kan användas.

int y;
int x = 3;
char letterA = 'A';         // Char literal values surrounded by single quotes ''
string name = "Pelle";      // String literal values surrounded by double quotes ""
double z = 3.45;
bool isEnabled = true;

// Literal values
// t.ex 3, 3.45, 'A', "Pelle", true
// literal values kan använda sig av suffix för att avgöra typen på det "hårdkodade" värdet:
// T.ex: 1.0f är float-värde, medan 1.0 är double-värde.

// Data types (datatyper) - Anger vilken typ av data vi lagrar i t.ex en variabel.

// C# är ett statiskt typat språk:
// Innan koden kompileras måste datatypen för varje enskild variabel vara känd.

// C# är ett starkt typat språk:
// Om man försöker sätta in data av felaktig typ i en variabel så resulterar det i ett kompileringsfel.
// name = 3; <-- Får kompileringsfel

// C# är ett typsäkert språk:
// Man kan bara utföra operationer som en given datatyp tillåter
Console.WriteLine(x + 3);
// Console.WriteLine(isEnabled + 3); <-- Otillåten operation mellan bool och int.

// byte myByte = 300;
// short myShort = 300;
// byte myOtherByte = -2;
// sbyte mySignedByte = -2;

// Imlicit (underförstått) & Explicit (uttryckligen) typade variabler.

// Explicit typad variabel
int myInt; // Likvärdigt med Int32, Int32 är namnet på .NET-typen, och inte C# alias för Int32

// Implicit typad variabel - Med keyword var så avgör kompliatorn datatyp.
var myVariable = 5;
// myVariable = 6.5; <-- får error, kan inte byta datatyp

// Scope - En variabels (ett objekts) livstid (lifetime).
// Class-scope, Method-scope, och Block-scope.

bool myBool = false;
if (isEnabled)
{
    bool myOtherBool = true;
    if (1 == 1)
    {
        bool myThirdBool = false;
        Console.WriteLine(myBool);
        Console.WriteLine(myOtherBool);
        Console.WriteLine(myThirdBool);
    }

    Console.WriteLine(myBool);
    Console.WriteLine(myOtherBool);
    Console.WriteLine(myThirdBool);
}

Console.WriteLine(myBool);
Console.WriteLine(myOtherBool);
Console.WriteLine(myThirdBool);

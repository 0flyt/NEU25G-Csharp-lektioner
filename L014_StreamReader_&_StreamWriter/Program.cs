
//Console.WriteLine($"Current directory: {Directory.GetCurrentDirectory()}");
//Directory.SetCurrentDirectory(@"c:\");

//var path = @"C:\Users\chris\source\repos\NEU25G-Csharp-lektioner\L013_Path_and_Directory\program.cs";

//using (StreamReader reader = new StreamReader(path))
//{
//    //Console.WriteLine(reader.ReadToEnd());

//    while (!reader.EndOfStream)
//    {
//        Console.Write((char)reader.Read());
//        Thread.Sleep(20);
//    }
//}

using (var writer = new StreamWriter("myFile.txt", append: true)) //Append true om man vill fortsätta skriva i filen. Annars skriver den över.
{
    writer.WriteLine("Hello");
    writer.WriteLine("World");

    for (int i = 65; i < 90; i++)
    {
        writer.Write((char)i);
    }

    writer.WriteLine();


}

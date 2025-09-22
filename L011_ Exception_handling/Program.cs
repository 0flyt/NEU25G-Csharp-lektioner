// OverflowException: 'Arithmetic operation resulted in an over flow.'
//checked // Utan checkedblocket får vi ingen exception.
//{
//    byte myByte = 200;
//    Console.WriteLine(myByte);
//    myByte += 100;
//    Console.WriteLine(myByte);
//}

//Byte.Parse("Hej"); // 'The input string 'Hej' was not in a correct format.'

// IndexOutOfRangeException: 'Index was outside the bounds of the array.'

//int[] myArray = new int[10];
//myArray[15] = 3;

// DivideByZeroException: 'Attempted to divide by zero.'
//int x = 0;
//int y = 1 / x;


static void tryCatchExample()
{
    try
    {
        //Byte.Parse("Hej");
        //int x = 0;
        //int y = 1 / x;
        Console.WriteLine("Start of try block.");
        int[] myArray = new int[10];
      
        myArray[15] = 3;
        Console.WriteLine("End of try block.");
    }
    catch (IndexOutOfRangeException ex)
    {
        Console.WriteLine($"Array indexing wrong: {ex}");
    }
    catch (FormatException ex)
    {
        Console.WriteLine($"Parsing went wrong: {ex}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Catch all uncatched exceptions: {ex.Message} {ex.GetType}");
    }
    finally
    {
        Console.WriteLine("Kör finally trots return.");
    }
}

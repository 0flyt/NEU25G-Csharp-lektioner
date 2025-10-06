namespace L031_Library;

public static class StringExtensions
{
    public static int CountWords(this string test)
    {
        return test.Split(' ').Length;
    }
}

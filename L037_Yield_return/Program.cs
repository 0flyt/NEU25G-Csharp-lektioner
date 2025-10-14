
//foreach (var s in GetStrings)
//{
//    Console.WriteLine(s);
//}

//IEnumerable<string> GetStrings()
//{
//    yield return "First";
//    yield return "Second";
//    yield return "Third";
//}

IEnumerable<int> GenerateWithoutYield()
{
    var list = new List<int>();
    for (int i = 0; i < 10; i++)
    {
        list.Add(i);
    }
    return list;
}

IEnumerable<int> GenerateWithYield()
{
    for (int i = 0; i < 10; i++)
    {
        yield return i;
    }
}

foreach (var i in GenerateWithoutYield().Take(3))
{
    Console.WriteLine(i);
}
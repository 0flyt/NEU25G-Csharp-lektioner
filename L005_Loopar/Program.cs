//int i = 1;
//while (i <= 5)
//{
//    Console.WriteLine(i);
//    i++;
//}

//string name = string.Empty;
//while (name != "fredrik")
//{
//    Console.Write("Skriv ditt namn: ");
//    name = Console.ReadLine();
//}

//Console.WriteLine("Du heter rätt");

//string ord = string.Empty;
//do
//{
//    Console.Write("Gissa ordet: ");
//    ord = Console.ReadLine();
//}
//while (ord != "banan");
//Console.WriteLine($"{ord} var rätt!");

//int j = 10;
//while (j >= 1)
//{
//    if (j == 7)
//    {
//        j--;
//        continue;
//    }

//    Console.WriteLine(j);
//    j--;

//    if (j < 5)
//    {
//        break;
//    }
//}

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i);
//    if (i == 5)
//        break;
//}


for (int i = 1; i <= 10; i++)
{
    if (i == 5) continue;
    Console.WriteLine(i);
}
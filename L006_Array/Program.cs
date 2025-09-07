string city = "Göteborg";

string[] cities;

cities = new string[5] {"Borås", "Stockholm", "Malmö", "Uppsala", "Kiruna"};

//Console.WriteLine(cities[0]);

//cities[0] = city;

//Console.WriteLine(cities[0]);
//Console.WriteLine(city[0]);

//for (int i = 0; i < cities.Length; i++)
//{
//    Console.WriteLine(cities[i]);
//}

foreach (string stad in cities)
{
    Console.WriteLine(stad);
}

foreach (char b in city)
{
    Console.WriteLine(b);
}
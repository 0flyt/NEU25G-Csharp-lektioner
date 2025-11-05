using System.Text.Json;
using System.Text.Json.Serialization;

//var people = new Person[]
//{
//    new Person("Anders", "Andersson", 25, 182.0),
//    new Person("Pelle", "Pellsson", 35, 193.5),
//    new Person("Sara", "Sarsson", 19, 162.5)
//};

////people[0].BestFriend = people[1];
////people[1].BestFriend = people[0];

//var options = new JsonSerializerOptions()
//{
//    WriteIndented = true,
//    //IncludeFields = false,
//    //IgnoreReadOnlyProperties = true,
//    //PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
//    //ReferenceHandler = ReferenceHandler.IgnoreCycles
//};

//string json = JsonSerializer.Serialize(people, options);

//Console.WriteLine(json);


//// WriteAllTextAsync
//File.WriteAllText("people.json", json);

string json = File.ReadAllText("people.json");

//Console.WriteLine(json);

List<Person> people;

var options = new JsonSerializerOptions()
{
    UnmappedMemberHandling = JsonUnmappedMemberHandling.Skip
};

people = JsonSerializer.Deserialize<List<Person>>(json, options);


Console.WriteLine(json);


class Person
{
    [JsonPropertyName("Name")]
    [JsonPropertyOrder(1)]
    public string FirstName { get; set; }

    [JsonIgnore]
    public string LastName { get; }
    public int Age { get; set; }
    //public Person BestFriend { get; set; }

    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }


}
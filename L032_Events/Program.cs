
var publisher = new Publisher();

var subscriber1 = new Subscriber("Adam");
var subscriber2 = new Subscriber("Ava");
var subscriber3 = new Subscriber("Jonas");

publisher.Message += subscriber1.OnMessageRecieved;
publisher.Message += subscriber2.OnMessageRecieved;
publisher.Message += subscriber3.OnMessageRecieved;

publisher.SendMessage("This is the first message");

publisher.Message -= subscriber2.OnMessageRecieved;

Console.WriteLine();
publisher.SendMessage("This is the second message");
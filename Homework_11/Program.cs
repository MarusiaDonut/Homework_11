using Homework_11;

Random rnd = new Random();
var t = new OtusDictionary() {Key = 1, Value = "hello" };
OtusDictionary otusDictionary = new OtusDictionary();

for (int i = 0; i < 32; i++)
{
    otusDictionary.Add(rnd.Next(0, 32), "Элемент " + i);
}

Console.WriteLine(otusDictionary.Get(2));
Console.ReadLine();


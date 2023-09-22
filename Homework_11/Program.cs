using Homework_11;

Random rnd = new Random();
OtusDictionary otusDictionary = new OtusDictionary();

for (int i = 0; i < 33; i++)
{
    otusDictionary.Add(rnd.Next(0, 10000), "Элемент " + i);
}

Console.WriteLine(otusDictionary.Get(10));

Console.ReadLine();


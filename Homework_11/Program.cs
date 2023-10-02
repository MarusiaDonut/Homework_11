using Homework_11;

Random rnd = new Random();
OtusDictionary otusDictionary = new OtusDictionary();

//for (int i = 0; i < 33; i++)
//{
//    otusDictionary.Add(rnd.Next(0, 10000), "Элемент " + i);
//}

otusDictionary.Add(1, "Элемент " + 1);
otusDictionary.Add(10, "Элемент " + 10);
otusDictionary.Add(100, "Элемент " + 100);

otusDictionary.Add(1, "Элемент " + 1);

Console.WriteLine(otusDictionary.Get(1));
Console.WriteLine(otusDictionary.Get(10));
Console.WriteLine(otusDictionary.Get(100));

Console.ReadLine();


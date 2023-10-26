using Iterator.Business;

MyCollection collection = new MyCollection();

collection.Add(1);
collection.Add(2);
collection.Add(3);

foreach (int item in collection)
    Console.WriteLine(item);

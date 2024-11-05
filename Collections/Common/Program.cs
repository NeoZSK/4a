// List, Array, ArrayList

// Array
using System.Collections;

int[] myArray = new int[5] { 1, 2, 4, 5, 6 };

for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = i * 10;
    Console.WriteLine(myArray[i]);
}

// List
List<int> myList = new List<int>() { 1, 2, 4, 5, 6 };

myList.Add(10);
myList.Add(20);
myList.Add(30);
myList.Add(30);


for (int i = 0; i < myList.Count; i++)
{
    Console.WriteLine($"{i}: {myList[i]}");
    // Console.WriteLine(myList.ElementAt(i));
}

Console.WriteLine("---");
myList.ForEach(item => Console.WriteLine(item));

Console.WriteLine("---");
myList.Remove(30);
myList.ForEach(item => Console.WriteLine(item));

Console.WriteLine("---");
myList.RemoveAt(0);
myList.ForEach(item => Console.WriteLine(item));

Console.WriteLine("---");
myList.Insert(0, 14);
myList.ForEach(item => Console.WriteLine(item));




// ArrayList

ArrayList myArrayList = new ArrayList();

myArrayList.Add(1);
myArrayList.Add("coto");
myArrayList.Add(1.54);

for(int i = 0;i < myArrayList.Count;i++)
{
    // use of typeof
    Console.WriteLine(myArrayList[i]);
}

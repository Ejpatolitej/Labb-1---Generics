using Labb_1___Generics;
using System.Collections;

BoxCollection boxList = new BoxCollection();

boxList.Add(new Box(8, 10, 5));
boxList.Add(new Box(9, 9, 9));
boxList.Add(new Box(5, 2, 8));
boxList.Add(new Box(79, 53, 28));
boxList.Add(new Box(25, 120, 35));

//Try adding box already in list
boxList.Add(new Box(5, 2, 8));

Console.WriteLine("\n----------------------------------------------\n");

//Test remove method
Display(boxList);
boxList.Remove(new Box(5, 2, 8));
Display(boxList);

Console.WriteLine("\n----------------------------------------------\n");

//Test contains method
Box BoxCheck = new Box(9, 9, 9);
Console.WriteLine("Contains box {0}x{1}x{2} by dimensions: {3}",
    BoxCheck.Height.ToString(), BoxCheck.Length.ToString(),
    BoxCheck.Width.ToString(), boxList.Contains(BoxCheck).ToString());

Console.WriteLine("\n----------------------------------------------\n");

//Test specific contains method
Console.WriteLine("Contains box {0}x{1}x{2} by volume: {3}",
    BoxCheck.Height.ToString(), BoxCheck.Length.ToString(),
    BoxCheck.Width.ToString(), boxList.Contains(BoxCheck,
    new BoxSameVol()).ToString());

Console.WriteLine("\n----------------------------------------------\n");

Display(boxList);


static void Display(BoxCollection boxList)
{
    foreach (Box box in boxList)
    {
        Console.WriteLine("Height: {0}, Length: {1}, Width: {2}", box.Height.ToString(), box.Length.ToString(), box.Width.ToString());    
    }
    Console.WriteLine();
}

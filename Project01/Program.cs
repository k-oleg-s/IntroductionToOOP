using Lesson04;

Console.WriteLine("\n  Task 1");

var bld = new JustBuilding();
bld.Height = 40;
bld.Flors = 10;
Console.WriteLine($" высота этажа {bld.GetFlorH}");


Console.WriteLine("\n \n   Task 2");
int[] k = new int[3];
k[0] = Creator.CreateBuild();
k[1] = Creator.CreateBuild();
k[2] = Creator.CreateBuild();

foreach (int i in k)
{
    if (Creator.GetBuilding(i) is not null)
        Console.WriteLine($" ключ k={i}  with building number : {Creator.GetBuilding(i).GetNumber()} ");

}

Console.WriteLine("\n  удалим один building:");
Creator.DeleteBuild(k[1]);

foreach (int i in k)
{
    if ( Creator.GetBuilding(i) is not null)
    Console.WriteLine($" ключ k={i}  with building number : {Creator.GetBuilding(i).GetNumber()} ");

}

Console.ReadLine();

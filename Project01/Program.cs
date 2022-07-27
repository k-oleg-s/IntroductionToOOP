using System.IO;
using Lesson06;
using Figures;


Console.WriteLine("\r \n Task 1");

var a1 = new BankAccount(BType.personal);
var a2 = new BankAccount(BType.company);
var a3 = new BankAccount(BType.personal);

a1.Sum = 200;
a2.Sum = 300;
a3.Sum = 200;

Console.WriteLine(" сравнение а1 и а2 счетов ");
Console.WriteLine("{0}; {1},  a1 == a2: {2},   a1.Equals(a2): {3},   a1.GetHashCode(): {4},   a2.GetHashCode(): {5} ", a1, a2, a1 == a2, a1.Equals(a2), a1.GetHashCode(), a2.GetHashCode());

Console.WriteLine("\r\n сравнение а1 и а3 счетов ");
Console.WriteLine("{0}; {1},  a1 == a3: {2},   a1.Equals(a3): {3},   a1.GetHashCode(): {4},   a3.GetHashCode(): {5} ", a1, a3, a1 == a3, a1.Equals(a3), a1.GetHashCode(), a3.GetHashCode());

Console.WriteLine("\r \n \n Task 2");

var f = new Figure("green", true, 10, 15);
var p = new Point("red", false, 30, 35);
var c = new Circle("blue", true, 20, 23, 3);
var r = new Rectangle("yellow", false, 40, 43, 4, 5);

Console.WriteLine($" {f}  \n {p} \n {c} area:{c.GetArea()}  \n {r}  area:{r.GetArea()}  \n ");


Console.WriteLine(" Изначально объекты: \r\n");
Console.WriteLine($"  {p} \n   {r} \n   ");
p.MoveToXY(31, 36);
r.MoveToXY(41, 44);
Console.WriteLine(" Передвинули объекты: \r\n");
Console.WriteLine($"  {p} \n   {r} \n   ");


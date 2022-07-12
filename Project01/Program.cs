using Lesson03;
using System.Text;

///////---------------------------------
Console.WriteLine(" \n \n Task1");

var ba1 = new BankAccount(100);
var ba2 = new BankAccount(120);

Console.WriteLine(" balance on ba1:{0},   on ba2:{1}", ba1.Balance, ba2.Balance);
Console.WriteLine(" transfer result:{0}, ", ba1.TransferToThisAccount(ref ba2, 19));
Console.WriteLine(" balance on ba1:{0},   on ba2:{1}", ba1.Balance, ba2.Balance);


///////---------------------------------
Console.WriteLine(" \n \n Task2");

var some = "This is task 2 testing";
Console.WriteLine("from string {0} reverse to {1}", some, StringReverse(some));

string StringReverse(string str)
{
    char[] chars = str.ToCharArray();
    var builder = new StringBuilder();

    for (int i = chars.Length-1; i >= 0; i--)
    {
        builder.Append(chars[i]);
    }

    return builder.ToString();
}


///////---------------------------------
Console.WriteLine(" \n \n Task3");

var ww = new WwLines();

string f_read = @"C:\T\FIOandEmails.txt";
string f_write = @"C:\T\JustEmails.txt";

ww.ReadAndCreateFile(f_read, f_write);


using Figures;
using Lesson07;

string word = "Привет";

Console.WriteLine("\r \n \n ACoder");

ACoder ac = new();

Console.WriteLine($" encoded:  {ac.Encode(word)}");
Console.WriteLine($" decoded:  {ac.Decode(ac.Encode(word))}");



Console.WriteLine("\r \n \n BCoder");

BCoder bc = new();

Console.WriteLine($" encoded:  {bc.Encode(word)}");
Console.WriteLine($" decoded:  {bc.Decode(bc.Encode(word))}");





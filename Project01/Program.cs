using  Lesson05;

Console.WriteLine(" проверки операторов:");


//var t = new RationalNumber(2, 3);


RationalNumber[] rns = { new RationalNumber(2, 3), new RationalNumber(-1, 5), new RationalNumber(3, 1) };

foreach (RationalNumber r in rns)
{

    RationalNumber r1 = rns[0];
    RationalNumber r2 = r;
    Console.WriteLine($" операции с {r1.ToString()}   и   {r.ToString()}");
    Console.WriteLine(" {r1 + r2}                           {r1 - r2}                           {r1 * r2}                   {(float)r2}         {r1 == r2}        {++r2} ");
    Console.WriteLine($" {r1 + r2}   {r1 - r2}   {r1 * r2}               {(float)r2}         {r1 == r2}     {++r2}   \n \n \n ");

}
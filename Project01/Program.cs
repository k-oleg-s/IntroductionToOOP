using Lesson2;


// Task 1
//  
Console.WriteLine("Task 1");

BankAccountTask1 ba = new BankAccountTask1();
ba.set_num(9001);
ba.set_balance(1200);
ba.set_type(account_type.personal); // тип : 0 1 2 3

Console.WriteLine(" account number: {0}, balance: {1}, type:{2} ", ba.get_num(), ba.get_balance(), ba.get_type());



// Task 3
//  check constructors
Console.WriteLine(" \n \n Task 2, 3");

List<BankAccountTask2> bankAccounts = new List<BankAccountTask2>();
BankAccountTask2 ba1 = new BankAccountTask2();
BankAccountTask2 ba2 = new BankAccountTask2(3000m);
BankAccountTask2 ba3 = new BankAccountTask2(account_type.federal);
BankAccountTask2 ba4 = new BankAccountTask2(199m, 3); // тип : 0 1 2 3
bankAccounts.Add(ba1);
bankAccounts.Add(ba2);
bankAccounts.Add(ba3);
bankAccounts.Add(ba4);

foreach (BankAccountTask2 b in bankAccounts)
{
    Console.WriteLine(" account number: {0}, balance: {1}, type:{2} ", b.Number, b.Balance, b.Type);
}



// Task 4
// using set properties
Console.WriteLine(" \n \n Task 4");

ba2.Balance = 4000;
ba3.Type = account_type.company;
ba4.Balance = 210; ba4.Type = account_type.personal;

foreach (BankAccountTask2 b in bankAccounts)
{
    Console.WriteLine(" account number: {0}, balance: {1}, type:{2} ", b.Number, b.Balance, b.Type);
}



// Task 5
// using set properties
Console.WriteLine(" \n \n Task 5");
int x;

ba1.Balance = 1000;
Console.WriteLine(" account number: {0}, balance: {1}, type:{2} ", ba1.Number, ba1.Balance, ba1.Type);
x = 1001;
Console.WriteLine( "take from account {0}, result {1} ", x ,  ba1.TakeFromAccount(x));


ba1.Balance = 1000;
Console.WriteLine(" account number: {0}, balance: {1}, type:{2} ", ba1.Number, ba1.Balance, ba1.Type);
x = 999;
Console.WriteLine("take from account {0}, result {1}", x, ba1.TakeFromAccount(x));


ba1.Balance = 1000;
Console.WriteLine(" account number: {0}, balance: {1}, type:{2} ", ba1.Number, ba1.Balance, ba1.Type);
x = 44;
Console.WriteLine("put to account {0}, result {1}", x, ba1.PutOnAccount(x));


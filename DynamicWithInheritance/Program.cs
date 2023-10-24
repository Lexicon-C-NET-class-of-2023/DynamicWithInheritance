using DynamicWithInheritance;


Accounts.AccountPrime account = new Accounts.AccountPrime();
account.Name = "Anders";
account.Age = 42;
account.Type = "Prime";
account.SomethingFromPrime = "I've got a Prime Account\n";

Accounts.AccountBasic account2 = new Accounts.AccountBasic();
account2.Name = "Nathalie";
account2.Age = 37;
account2.Type = "Basic";
account2.SomethingFromBasic = "I've got a Basic Account\n";

Accounts.AccountBasic account3 = new Accounts.AccountBasic();
account3.Name = "Anna";
account3.Age = 14;
account3.Type = "Basic";
account3.SomethingFromBasic = "I've got a Basic Account\n";


List<dynamic> dynamicList = new List<dynamic>
{
    account,
    account2,
    account3
};


foreach (var item in dynamicList)
{
    Console.WriteLine("Name " + item.Name);
    Console.WriteLine("Name " + item.Age);
    Console.WriteLine("Name " + item.Type);
    if (item is Accounts.AccountPrime) Console.WriteLine("Name " + item.SomethingFromPrime);
    if (item is Accounts.AccountBasic) Console.WriteLine("Name " + item.SomethingFromBasic);
}

Console.WriteLine("THIS IS PRIME------------ " + dynamicList[0]);
Console.WriteLine("THIS IS BASIC------------ " + dynamicList[1]);
Console.WriteLine("THIS IS BASIC------------ " + dynamicList[2]);





Console.WriteLine("\n\n\n-------------------------------AND BACK AGAIN-------------------------------\n\n\n");




List<Accounts.AccountPrime> listOfPrime = new List<Accounts.AccountPrime>();
List<Accounts.AccountBasic> listOfBasic = new List<Accounts.AccountBasic>();

foreach (var item in dynamicList)
{
    if (item is Accounts.AccountPrime) listOfPrime.Add(item);
    if (item is Accounts.AccountBasic) listOfBasic.Add(item);
}


Console.WriteLine("*List of Prime Accounts");
foreach (var item in listOfPrime)
{
    Console.WriteLine("Name " + item.Name);
    Console.WriteLine("Name " + item.Age);
    Console.WriteLine("Name " + item.Type);
    Console.WriteLine("Name " + item.SomethingFromPrime);
}


Console.WriteLine("\n*List of Basic Accounts");
foreach (var item in listOfBasic)
{
    Console.WriteLine("Name " + item.Name);
    Console.WriteLine("Name " + item.Age);
    Console.WriteLine("Name " + item.Type);
    Console.WriteLine("Name " + item.SomethingFromBasic);
}
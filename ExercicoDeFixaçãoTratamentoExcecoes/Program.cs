using ExercicoDeFixaçãoTratamentoExcecoes.Entities;
using ExercicoDeFixaçãoTratamentoExcecoes.Entities.Exceptions;
try
{
    Console.WriteLine("Enter Account data");
    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    string holder = Console.ReadLine();
    Console.Write("Initial balance: ");
    double balance = double.Parse(Console.ReadLine());
    Console.Write("Withdraw limit: ");
    double withdrawLimit = double.Parse(Console.ReadLine());

    Account account = new Account(number, holder, balance, withdrawLimit);

    Console.WriteLine("");
    Console.Write("Enter amount for withdraw");
    double withdraw = double.Parse(Console.ReadLine());
    account.Withdrawn(withdraw);
    
}
catch(DomainException e)
{
    Console.WriteLine("Error In Withdraw" + e.Message);
}
catch(FormatException e)
{
    Console.WriteLine("Error in format " + e.Message);
}
catch(Exception e)
{
    Console.WriteLine("Unexpected error: " + e.Message);
}

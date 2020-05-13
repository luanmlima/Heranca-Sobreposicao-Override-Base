using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Account Acc1 = new Account(1001, "Alex", 500.0);
            Account Acc2 = new SavingsAccount(1002, "Ana", 500.0, 0.01);

            Acc1.WithDraw(10);
            Acc2.WithDraw(10);

            System.Console.WriteLine(Acc1.Balance);
            System.Console.WriteLine(Acc2.Balance);


        }


    }
}

using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var card = new Card(1234);
            var atm = new ATM();

            try
            {
                atm.InsertCard(card);
                atm.InsertPin(0000);
                atm.InsertCard(card);
                atm.InsertPin(1234);
                atm.WithdrawMoney(100);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Illegal operation");
            }

            Console.ReadKey();

        }
    }
}

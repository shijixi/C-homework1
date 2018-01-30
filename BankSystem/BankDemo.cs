using System;

public class BankDemo {
	public static void Main(string [] args)
	{
        bool flag = true;
        Bank bank = new Bank();
		bank.OpenAccount("2222", "2222", 20);
		bank.OpenAccount("3333", "3333", 50);
        bank.OpenCreditCard(100,"4444", "4444", 50);
        bank.OpenCreditCard(100, "5555", "5555", 500);
        ATM atm = new ATM(bank);

        while (flag)
        {
            Console.Clear();
            atm.Transaction();

        }
		
	}
	
}

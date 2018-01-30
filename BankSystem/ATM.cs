using System;
using System.Collections;

public class ATM {
	
	Bank bank;
    
	public ATM( Bank bank)
	{
		this.bank = bank;
	}
	
	public void Transaction()
	{
        bool flag = true;
        Show("please insert your card");
		string id = GetInput();

		Show("please enter your password");
		string pwd = GetInput();
		
		Account account = bank.FindAccount(id, pwd);

        if (account == null)
        {


            CreditCard creditCards = bank.FindCreditCard(id, pwd);
            if (creditCards == null)
            {
                Show("card invalid or password not correct");
                return;
            }
            while (flag)
            {
                Show("0:esc; 1: display; 2: deposit; 3: withdraw; 4: Creditline ");
                string op1 = GetInput();
                if(op1=="0")
                {
                    break;
                }
                else if (op1 == "1")
                {
                    Show("balance: " + creditCards.getMoney());
                }
                else if (op1 == "2")
                {
                    Show("save money");
                    string smoney = GetInput();
                    double money = double.Parse(smoney);

                    bool ok = creditCards.SaveMoney(money);
                    if (ok) Show("ok");
                    else Show("error");

                    Show("balance: " + creditCards.getMoney());
                }
                else if (op1 == "3")
                {
                    Show("withdraw money");
                    string smoney = GetInput();
                    double money = double.Parse(smoney);

                    bool ok = creditCards.WithdrawMoney(money);
                    if (ok) Show("ok");
                    else Show("eeer");

                    Show("balance: " + creditCards.getMoney());

                }
                else if (op1 == "4")
                {
                    Show("Creditline:" + creditCards.getCredit());
                }

            }
         }
        else
        {
            while (flag)
            {
                Show("0:esc; 1: display; 2: deposit; 3: withdraw");
                string op = GetInput();
                if(op=="0")
                {
                    break;
                }
                else if (op == "1")
                {
                    Show("balance: " + account.getMoney());
                }
                else if (op == "2")
                {
                    Show("save money");
                    string smoney = GetInput();
                    double money = double.Parse(smoney);

                    bool ok = account.SaveMoney(money);
                    if (ok) Show("ok");
                    else Show("error");

                    Show("balance: " + account.getMoney());
                }
                else if (op == "3")
                {
                    Show("withdraw money");
                    string smoney = GetInput();
                    double money = double.Parse(smoney);

                    bool ok = account.WithdrawMoney(money);
                    if (ok) Show("ok");
                    else Show("eeer");

                    Show("balance: " + account.getMoney());

                }
            }
        }
	}
	
	
	public void Show(string msg)
	{
		Console.WriteLine(msg);
	}
	public string GetInput()
	{
		return Console.ReadLine();// ÊäÈë×Ö·û
	}
}

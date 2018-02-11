using System;
using System.Collections;
using System.Collections.Generic;

public class Bank {

	List<Account> accounts = new List<Account>();
    List<CreditCard> creditCards = new List<CreditCard>();
    public Account OpenAccount(string id, string pwd, double money)
	{
		Account account = new Account(id, pwd, money);
		accounts.Add( account );
		
		return account;
	}

    public CreditCard OpenCreditCard(double creditline, string id, string pwd, double money)
    {
        CreditCard creditCard = new CreditCard(creditline, id, pwd, money);
        creditCards.Add(creditCard);

        return creditCard;
    }


    public bool CloseAccount( Account account) 
	{
		int idx = accounts.IndexOf(account);
		if( idx<0 )return false;
		accounts.Remove(account);
		return true;		
	}

    public bool CloseCreditCard(CreditCard creditCard)
    {
        int idx = accounts.IndexOf(creditCard);
        if (idx < 0) return false;
        accounts.Remove(creditCard);
        return true;
    }
    public Account FindAccount(string id, string pwd)
	{
		foreach(Account account in accounts)
		{
			if( account.IsMatch(id, pwd))
			{
				return account;
			}
		}
        
		return null;
	}

    public CreditCard FindCreditCard(string id, string pwd)
    {
        foreach (CreditCard creditCard in creditCards)
        {
            if (creditCard.IsMatch(id, pwd))
            {
                return creditCard;
            }
        }
       

        return null;
    }

}

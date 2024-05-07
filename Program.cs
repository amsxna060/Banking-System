using System.Runtime.CompilerServices;
using Accounts;
using Transactions;

/* For Checking Account class */
// Account ac1 = new Account();

// ac1.getsetAccountNumber = "12345678910";
// ac1.getSetBalance = 500.00m;  
// System.Console.WriteLine("Balance at openings...");
// System.Console.WriteLine(ac1);
// System.Console.WriteLine("\nBalance After Depositing $200");
// ac1.Deposit(200);
// System.Console.WriteLine(ac1);

// System.Console.WriteLine("\nBalance After Withdrawing $100 ");
// ac1.Withdraw(100);
// System.Console.WriteLine(ac1);

/* Testing SavingsAccount class */
// SavingsAccount sacc1 = new SavingsAccount();
// SavingsAccount sacc2 = new SavingsAccount("ABC00000123",100000,1000,8);

// sacc1.getsetAccountNumber="BAC00000321";
// sacc1.getSetBalance = 5000m;
// sacc1.MinBalance = 1200m;

// System.Console.WriteLine(sacc1);
// System.Console.WriteLine(sacc2);

/* For Checking Acconts */
// CheckingAccount c1 = new CheckingAccount();

// System.Console.WriteLine(c1);

Account a1 = new Account("ABC00000123",1000);
Account a2 = new Account("BCA00000890",500);

Transaction t1 = new Transaction();
t1.Transfer(a1,a2,300);

System.Console.WriteLine(a1);
System.Console.WriteLine(a2);

t1.Transfer(a1,a2,500);

System.Console.WriteLine(a1);
System.Console.WriteLine(a2);

t1.Transfer(a1,a2,300);

System.Console.WriteLine(a1);
System.Console.WriteLine(a2);

// Action Delicate
// Action<Account,Account,decimal> TransferTo = t1.Transfer;
Action<Account,Account,decimal> TransferTo = new Transaction().Transfer;

TransferTo(a1,a2,500);
System.Console.WriteLine(a1);
System.Console.WriteLine(a2);





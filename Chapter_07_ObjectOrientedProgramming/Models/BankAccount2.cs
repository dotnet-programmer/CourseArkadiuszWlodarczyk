namespace Chapter_07_ObjectOrientedProgramming.Models;

internal class BankAccount2 : IBankAccount
{
	private decimal _balance;
	public decimal Balance => _balance;

	public void Deposit(decimal amount)
		=> _balance += amount;

	public bool Withdraw(decimal amount)
	{
		if (_balance > amount)
		{
			_balance -= amount;
			return true;
		}
		Console.WriteLine("Za mało funduszy na koncie");
		return false;
	}

	public bool TransferMoneyTo(IBankAccount target, decimal amount)
	{
		bool canDeposit = Withdraw(amount);
		if (canDeposit)
		{
			target.Deposit(amount);
		}
		return canDeposit;
	}
}
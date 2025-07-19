namespace Chapter_07_ObjectOrientedProgramming.Models;

internal interface IBankAccount
{
	decimal Balance { get; }
	void Deposit(decimal amount);
	bool Withdraw(decimal amount);
	bool TransferMoneyTo(IBankAccount target, decimal amount);
}
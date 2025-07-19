namespace Chapter_07_ObjectOrientedProgramming.Models;

internal class AccountBalance
{
	private ushort _penny;

	public AccountBalance(uint zl, ushort gr)
	{
		Zloty = zl;
		Penny = gr;
	}

	public AccountBalance(AccountBalance accountBalance) : this(accountBalance.Zloty, accountBalance.Penny)
	{
	}

	public uint Zloty { get; private set; }

	public ushort Penny
	{
		get => _penny;

		private set
		{
			if (value <= 0)
			{
				_penny = 0;
			}
			else if (value >= 100)
			{
				uint zlotyInPennies = (uint)(value / 100);
				Zloty += zlotyInPennies;
				_penny = (ushort)(value - zlotyInPennies * 100);
			}
			else
			{
				_penny = value;
			}
		}
	}

	public static bool operator ==(AccountBalance lhs, AccountBalance rhs)
		=> lhs.Penny == rhs.Penny && lhs.Zloty == rhs.Zloty;

	public static bool operator !=(AccountBalance lhs, AccountBalance rhs)
		=> !(lhs == rhs);

	public static AccountBalance operator +(AccountBalance lhs, AccountBalance rhs)
	{
		uint zloty = lhs.Zloty + rhs.Zloty;
		ushort penny = (ushort)(lhs.Penny + rhs.Penny);

		uint zlotyInPennies = (uint)(penny / 100);
		zloty += zlotyInPennies;
		penny = (ushort)(penny - zlotyInPennies * 100);

		return new AccountBalance(zloty, penny);
	}

	public override bool Equals(object? obj)
		=> obj is AccountBalance balance && this == balance;

	public override int GetHashCode()
		=> (Zloty * 4 + Penny * 20).GetHashCode();

	public override string ToString()
		=> Zloty + " zł i " + Penny + "gr";

	// implicit - niejawne rzutowanie, dzięki temu rzutowanie następuje automatycznie, nie trzeba pisać że ma być zrobione rzutowanie
	// explicit - jawne rzutowanie, dzięki temu nie jest możliwe automatyczne rzutowanie, trzeba jawnie napisać że ma być zrobione rzutowanie
	// operator float - oznacza typ, na jaki będzie rzutowany argument
	// argument - typ, który będzie rzutowany
	public static explicit operator float(AccountBalance value)
		=> value.Zloty + (value.Penny / 100.0f);

	public static explicit operator AccountBalance(float value)
	{
		uint zloty = (uint)value;
		ushort penny = Convert.ToUInt16((value - (uint)value) * 100);
		return new AccountBalance(zloty, penny);
	}
}
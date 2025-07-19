namespace Chapter_10_AdvancedWpf.Models;

internal class PersonData2
{
	public enum Gender
	{
		Male,
		Female
	}

	public string? Name { get; set; }
	public int Age { get; set; }
	public string? Email { get; set; }
	public bool IsSubscribedToNewsletter { get; set; }
	public Uri? Website { get; set; }
	public Gender GenderType { get; set; }
	public string? Image { get; set; }
	public string? Description { get; set; }
}
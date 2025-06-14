namespace Chapter_7_ObjectOrientedProgramming;

internal class Sentence(string sentence)
{
	private readonly string[] _words = sentence.Split();

	public string this[int index]
	{
		get => _words.Length > index ? _words[index] : null;
		set
		{
			if (_words.Length > index)
			{
				_words[index] = value;
			}
		}
	}
}
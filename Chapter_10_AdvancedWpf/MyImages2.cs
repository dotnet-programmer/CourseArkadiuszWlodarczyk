using System.IO;

namespace Chapter_10_AdvancedWpf;

public class MyImages2
{
	public MyImages2()
	{
		PathToImage = @"\images\logo.png";
		NameOfImage = "Logo";
	}

	public MyImages2(string pathToImage, string nameOfImage)
	{
		string absolutePathToSource = Path.Combine(Directory.GetCurrentDirectory(), pathToImage);
		PathToImage = absolutePathToSource;
		NameOfImage = nameOfImage;
		IsFound = File.Exists(absolutePathToSource);
	}

	public string PathToImage { get; set; }
	public string NameOfImage { get; set; }
	public bool IsFound { get; set; }
}
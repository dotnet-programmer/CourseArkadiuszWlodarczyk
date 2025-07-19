using System.IO;

namespace Chapter_10_AdvancedWpf.Models;

public class MyImages2
{
	public MyImages2()
	{
		PathToImage = @"\Images\logo.png";
		NameOfImage = "Logo";
	}

	public MyImages2(string pathToImage, string nameOfImage)
	{
		string absolutePathToSource = Path.Combine(Directory.GetCurrentDirectory(), pathToImage);
		IsFound = File.Exists(absolutePathToSource);
		//PathToImage = absolutePathToSource;
		PathToImage = Path.Combine("..", absolutePathToSource);
		NameOfImage = nameOfImage;
	}

	public string PathToImage { get; set; }
	public string NameOfImage { get; set; }
	public bool IsFound { get; set; }
}
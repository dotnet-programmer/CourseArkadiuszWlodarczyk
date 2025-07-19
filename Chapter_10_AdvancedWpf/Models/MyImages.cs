using System.IO;

namespace Chapter_10_AdvancedWpf.Models;

internal class MyImages
{
	public MyImages()
	{
		PathToImage = @"\Images\logo.png";
		NameOfImage = "Logo";
	}

	public MyImages(string pathToImage, string nameOfImage)
	{
		string appLocation = Directory.GetCurrentDirectory();
		string path = Path.Combine(appLocation, pathToImage);
		IsFound = File.Exists(path);

		PathToImage = Path.Combine("..", path);
		NameOfImage = nameOfImage;
	}

	public string PathToImage { get; set; }
	public string NameOfImage { get; set; }
	public bool IsFound { get; set; }
}
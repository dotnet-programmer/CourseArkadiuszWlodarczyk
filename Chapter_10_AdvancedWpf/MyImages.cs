using System.IO;

namespace Chapter_10_AdvancedWpf;

internal class MyImages
{
	public MyImages()
	{
		PathToImage = @"\images\logo.png";
		NameOfImage = "Logo";
	}

	public MyImages(string pathToImage, string nameOfImage)
	{
		PathToImage = pathToImage;
		NameOfImage = nameOfImage;

		string appLocation = Directory.GetCurrentDirectory();
		string path = Path.Combine(appLocation, pathToImage);
		IsFound = File.Exists(path);
	}

	public string PathToImage { get; set; }
	public string NameOfImage { get; set; }
	public bool IsFound { get; set; }
}
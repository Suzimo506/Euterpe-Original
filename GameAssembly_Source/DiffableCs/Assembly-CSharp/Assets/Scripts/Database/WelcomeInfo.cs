namespace Assets.Scripts.Database;

public class WelcomeInfo : BaseDataObject
{
	public string chipImage; //Field offset: 0x20
	public string chipName; //Field offset: 0x28
	public string image; //Field offset: 0x30
	public int chipAmount; //Field offset: 0x38
	public string chipDescription; //Field offset: 0x40
	public string artist1; //Field offset: 0x48
	public string homepage1; //Field offset: 0x50
	public string artist2; //Field offset: 0x58
	public string homepage2; //Field offset: 0x60
	public bool free; //Field offset: 0x68
	public bool hide; //Field offset: 0x69
	public bool hexie; //Field offset: 0x6A

	public string getArtist1
	{
		 get { } //Length: 182
	}

	public string getArtist2
	{
		 get { } //Length: 182
	}

	public string getHomepage1
	{
		 get { } //Length: 182
	}

	public string getHomepage2
	{
		 get { } //Length: 182
	}

	public WelcomeInfo() { }

	public string get_getArtist1() { }

	public string get_getArtist2() { }

	public string get_getHomepage1() { }

	public string get_getHomepage2() { }

}


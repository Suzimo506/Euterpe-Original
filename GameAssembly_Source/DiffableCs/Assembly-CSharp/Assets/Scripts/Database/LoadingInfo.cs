namespace Assets.Scripts.Database;

public class LoadingInfo : BaseDataObject
{
	public string chipImage; //Field offset: 0x20
	public string chipName; //Field offset: 0x28
	public string image; //Field offset: 0x30
	public string hexieImage; //Field offset: 0x38
	public int chipAmount; //Field offset: 0x40
	public string chipDescription; //Field offset: 0x48
	public string artist1; //Field offset: 0x50
	public string homepage1; //Field offset: 0x58
	public string artist2; //Field offset: 0x60
	public string homepage2; //Field offset: 0x68
	public bool free; //Field offset: 0x70
	public bool hide; //Field offset: 0x71
	public bool egg; //Field offset: 0x72
	public int adaptation; //Field offset: 0x74

	public string getArtist1
	{
		 get { } //Length: 256
	}

	public string getArtist2
	{
		 get { } //Length: 256
	}

	public string getHomepage1
	{
		 get { } //Length: 256
	}

	public string getHomepage2
	{
		 get { } //Length: 256
	}

	public string getImageName
	{
		 get { } //Length: 205
	}

	public LoadingInfo() { }

	public string get_getArtist1() { }

	public string get_getArtist2() { }

	public string get_getHomepage1() { }

	public string get_getHomepage2() { }

	public string get_getImageName() { }

}


namespace Assets.Scripts.Database;

public class MusicSearchTagInfo : BaseDataObject
{
	[JsonProperty]
	private string uid; //Field offset: 0x20
	[JsonProperty]
	private String[] tag; //Field offset: 0x28

	public bool isValid
	{
		 get { } //Length: 18
	}

	public string musicUid
	{
		 get { } //Length: 5
	}

	public MusicSearchTagInfo() { }

	public bool Contains(string value) { }

	public bool get_isValid() { }

	public string get_musicUid() { }

}


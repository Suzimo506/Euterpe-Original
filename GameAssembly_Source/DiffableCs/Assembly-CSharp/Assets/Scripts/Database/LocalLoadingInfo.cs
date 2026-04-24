namespace Assets.Scripts.Database;

public class LocalLoadingInfo : BaseDataObject
{
	public string chipName; //Field offset: 0x20
	public string chipDescription; //Field offset: 0x28
	public string artist1; //Field offset: 0x30
	public string artist2; //Field offset: 0x38
	public string homepage1; //Field offset: 0x40
	public string homepage2; //Field offset: 0x48

	public LocalLoadingInfo() { }

}


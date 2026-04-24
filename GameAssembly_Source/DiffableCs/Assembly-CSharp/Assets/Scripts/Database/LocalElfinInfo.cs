namespace Assets.Scripts.Database;

public class LocalElfinInfo : BaseDataObject
{
	public string name; //Field offset: 0x20
	public string description; //Field offset: 0x28
	public string skill; //Field offset: 0x30
	public string chipName; //Field offset: 0x38
	public string chipDescription; //Field offset: 0x40

	public LocalElfinInfo() { }

}


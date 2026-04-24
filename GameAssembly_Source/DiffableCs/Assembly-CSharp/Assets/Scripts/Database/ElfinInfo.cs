namespace Assets.Scripts.Database;

public class ElfinInfo : BaseDataObject
{
	public string name; //Field offset: 0x20
	public string description; //Field offset: 0x28
	public string skill; //Field offset: 0x30
	public int chipAmount; //Field offset: 0x38
	public string prefab; //Field offset: 0x40
	public string mainShow; //Field offset: 0x48
	public string chipName; //Field offset: 0x50
	public string chipDescription; //Field offset: 0x58
	public string chipImage; //Field offset: 0x60
	public string rarity; //Field offset: 0x68
	public bool free; //Field offset: 0x70
	public int order; //Field offset: 0x74
	public bool hide; //Field offset: 0x78

	public ElfinInfo() { }

}


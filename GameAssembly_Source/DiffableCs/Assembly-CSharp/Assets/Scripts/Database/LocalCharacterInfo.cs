namespace Assets.Scripts.Database;

public class LocalCharacterInfo : BaseDataObject
{
	public string characterName; //Field offset: 0x20
	public string cosName; //Field offset: 0x28
	public string description; //Field offset: 0x30
	public string skill; //Field offset: 0x38
	public List<String> skills; //Field offset: 0x40
	public string chipName; //Field offset: 0x48
	public string chipDescription; //Field offset: 0x50
	public string cv; //Field offset: 0x58
	public List<List`1<String>> expressions; //Field offset: 0x60
	public List<List`1<String>> reviewExpressions; //Field offset: 0x68
	public List<List`1<String>> catExpressions; //Field offset: 0x70

	public LocalCharacterInfo() { }

	public string GetSkill(int index) { }

}


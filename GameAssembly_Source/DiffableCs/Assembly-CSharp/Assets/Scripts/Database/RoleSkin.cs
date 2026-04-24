namespace Assets.Scripts.Database;

public class RoleSkin
{
	public int index; //Field offset: 0x10
	public int albumJsonIndex; //Field offset: 0x14
	public string mainShow; //Field offset: 0x18
	public string battleShow; //Field offset: 0x20
	public string victoryShow; //Field offset: 0x28
	public string failShow; //Field offset: 0x30
	public bool free; //Field offset: 0x38
	public bool hide; //Field offset: 0x39

	public bool isCat
	{
		 get { } //Length: 70
	}

	public RoleSkin() { }

	public bool get_isCat() { }

}


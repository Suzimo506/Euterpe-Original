namespace Assets.Scripts.Database;

public class BOSSInfo : BaseDataObject
{
	public string boss_name; //Field offset: 0x20
	public string scene_name; //Field offset: 0x28
	public string fever; //Field offset: 0x30

	public BOSSInfo() { }

}


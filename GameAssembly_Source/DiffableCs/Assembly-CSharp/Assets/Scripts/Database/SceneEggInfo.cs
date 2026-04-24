namespace Assets.Scripts.Database;

public class SceneEggInfo : BaseDataObject
{
	public String[] musicIds; //Field offset: 0x20
	public Int32[] albumIds; //Field offset: 0x28
	public Int32[] roleIds; //Field offset: 0x30
	public int eggId; //Field offset: 0x38

	public SceneEggInfo() { }

	private bool CheckContainsId(Int32[] ids, int id) { }

	public void CheckingSceneEgg(string musicId, int albumId, int roleId, List<Int32> buffer) { }

	private bool CheckMusicContainsId(string id) { }

}


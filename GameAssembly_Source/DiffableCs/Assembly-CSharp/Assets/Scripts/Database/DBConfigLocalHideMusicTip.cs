namespace Assets.Scripts.Database;

public class DBConfigLocalHideMusicTip : BaseDBConfigObject
{
	private Dictionary<String, String> m_HideTips; //Field offset: 0x38

	public DBConfigLocalHideMusicTip() { }

	public virtual void Deserialize(string str) { }

	public string GetHideTipsByMusicUid(string musicUid) { }

}


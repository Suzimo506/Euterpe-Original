namespace Assets.Scripts.Structs.Modules;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class MusicInfoResult
{
	private List<MusicInfo> m_Lock; //Field offset: 0x10
	private List<MusicInfo> m_Unlock; //Field offset: 0x18

	public int count
	{
		 get { } //Length: 71
	}

	public MusicInfo Item
	{
		 get { } //Length: 154
	}

	public List<MusicInfo> lockInfos
	{
		 get { } //Length: 5
	}

	public List<MusicInfo> unlockInfos
	{
		 get { } //Length: 5
	}

	public MusicInfoResult() { }

	public void Add(MusicInfo info, bool isUnlock) { }

	public void Clear() { }

	public void Filter() { }

	public int get_count() { }

	public MusicInfo get_Item(int index) { }

	public List<MusicInfo> get_lockInfos() { }

	public List<MusicInfo> get_unlockInfos() { }

	public void Merge(MusicInfoResult result) { }

}


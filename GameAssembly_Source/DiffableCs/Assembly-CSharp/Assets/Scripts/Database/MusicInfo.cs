namespace Assets.Scripts.Database;

public class MusicInfo : BaseDataObject
{
	public string uid; //Field offset: 0x20
	public string name; //Field offset: 0x28
	public string author; //Field offset: 0x30
	public string bpm; //Field offset: 0x38
	public string music; //Field offset: 0x40
	public string demo; //Field offset: 0x48
	public string cover; //Field offset: 0x50
	public string hexieCover; //Field offset: 0x58
	public string noteJson; //Field offset: 0x60
	public string scene; //Field offset: 0x68
	public string levelDesigner; //Field offset: 0x70
	public string levelDesigner1; //Field offset: 0x78
	public string levelDesigner2; //Field offset: 0x80
	public string levelDesigner3; //Field offset: 0x88
	public string levelDesigner4; //Field offset: 0x90
	public string levelDesigner5; //Field offset: 0x98
	public string difficulty1; //Field offset: 0xA0
	public string difficulty2; //Field offset: 0xA8
	public string difficulty3; //Field offset: 0xB0
	public string difficulty4; //Field offset: 0xB8
	public string difficulty5; //Field offset: 0xC0
	public int unlockLevel; //Field offset: 0xC8
	protected MusicExInfo m_MusicExInfo; //Field offset: 0xD0

	public int albumIndex
	{
		 get { } //Length: 7
	}

	public int albumJsonIndex
	{
		 get { } //Length: 7
	}

	public string albumJsonName
	{
		 get { } //Length: 143
	}

	public string albumUidName
	{
		 get { } //Length: 143
	}

	public string coverName
	{
		 get { } //Length: 205
	}

	public string mapName
	{
		 get { } //Length: 153
	}

	public int musicIndex
	{
		 get { } //Length: 7
	}

	public string musicName
	{
		 get { } //Length: 153
	}

	public MusicInfo() { }

	public virtual void ClearMaskValue() { }

	public int get_albumIndex() { }

	public int get_albumJsonIndex() { }

	public string get_albumJsonName() { }

	public string get_albumUidName() { }

	public string get_coverName() { }

	public string get_mapName() { }

	public int get_musicIndex() { }

	public string get_musicName() { }

	public int GetDifficulty(int diff) { }

	public string GetLevelDesignerStringByIndex(int index) { }

	public LocalALBUMInfo GetLocal(int language = 0) { }

	public int GetMusicLevelIntByDiff(int index, bool mask = true) { }

	public string GetMusicLevelStringByDiff(int index, bool mask = true) { }

	public virtual void Init(int index) { }

	private bool InitExInfo() { }

	public void SetDifficulty(int diffIndex, int changedDiff) { }

}


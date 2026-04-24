namespace Assets.Scripts.Structs;

public struct TalkBaseImg
{
	public int index; //Field offset: 0x0
	public Sprite roleLTSp; //Field offset: 0x8
	public Sprite roleLBSp; //Field offset: 0x10
	public Sprite bossRTSp; //Field offset: 0x18
	public Sprite bossRBSp; //Field offset: 0x20
	public Sprite asideUpSp; //Field offset: 0x28
	public Sprite asideDownSp; //Field offset: 0x30

	public bool isValid
	{
		 get { } //Length: 7
	}

	public bool get_isValid() { }

	public Sprite GetAsideTalkBase(int dirIndex) { }

	public Sprite GetBossTalkBase(int dirIndex) { }

	public Sprite GetRoleTalkBase(int dirIndex) { }

	public Sprite GetTalkBase(int charIndex, int dirIndex) { }

}


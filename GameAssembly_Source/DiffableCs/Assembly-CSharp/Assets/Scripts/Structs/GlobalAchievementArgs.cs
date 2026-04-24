namespace Assets.Scripts.Structs;

public struct GlobalAchievementArgs
{
	public bool isSuccess; //Field offset: 0x0
	public bool isValidFail; //Field offset: 0x1
	public int difficulty; //Field offset: 0x4
	public MusicInfo musicInfo; //Field offset: 0x8
	public int evaluateNum; //Field offset: 0x10
	public int score; //Field offset: 0x14
	public int maxCombo; //Field offset: 0x18
	public float accuracy; //Field offset: 0x1C
	public int level; //Field offset: 0x20
	public int musicCount; //Field offset: 0x24
	public int bloodCount; //Field offset: 0x28
	public int hitCount; //Field offset: 0x2C
	public int normalNoteTotalCount; //Field offset: 0x30
	public int perfectCount; //Field offset: 0x34
	public int greatCount; //Field offset: 0x38
	public bool isFullCombo; //Field offset: 0x3C
	public int selectedRoleIndex; //Field offset: 0x40
	public int selectedElfinIndex; //Field offset: 0x44
	public int missCount; //Field offset: 0x48
	public int failCount; //Field offset: 0x4C
	public int totalFailCount; //Field offset: 0x50
	public int totalFullComboCount; //Field offset: 0x54
	public int totalLongFinishCount; //Field offset: 0x58
	public int totalPressingHitCount; //Field offset: 0x5C
	public int totalBlockCount; //Field offset: 0x60
	public int totalBossNearCount; //Field offset: 0x64
	public int totalNoteHitCount; //Field offset: 0x68
	public int totalHideNoteCount; //Field offset: 0x6C
	public int totalBloodCount; //Field offset: 0x70
	public int totalMusicCount; //Field offset: 0x74
	public int totalPassCount; //Field offset: 0x78
	public int totalDPassCount; //Field offset: 0x7C
	public int totalCPassCount; //Field offset: 0x80
	public int totalBPassCount; //Field offset: 0x84
	public int totalAPassCount; //Field offset: 0x88
	public int totalEasyPassCount; //Field offset: 0x8C
	public int totalHardPassCount; //Field offset: 0x90
	public int totalMasterPassCount; //Field offset: 0x94
	public int totalFailCharacterCount; //Field offset: 0x98

	public string globalAchiUid
	{
		 get { } //Length: 791
	}

	public string get_globalAchiUid() { }

}


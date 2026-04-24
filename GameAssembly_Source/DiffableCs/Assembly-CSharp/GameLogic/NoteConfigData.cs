namespace GameLogic;

public struct NoteConfigData
{
	public const int PATHWAY_AIR = 1; //Field offset: 0x0
	public const int PATHWAY_ROAD = 0; //Field offset: 0x0
	public static UInt32[] NODE_TYPE_IS_ADD_COMBO; //Field offset: 0x0
	public static UInt32[] NODE_TYPE_IS_MISS_COMBO; //Field offset: 0x8
	public static UInt32[] NODE_TYPE_IS_SHOW_PLAY_EFFECT; //Field offset: 0x10
	public string id; //Field offset: 0x0
	public string ibms_id; //Field offset: 0x8
	public string uid; //Field offset: 0x10
	public string mirror_uid; //Field offset: 0x18
	public string scene; //Field offset: 0x20
	public string des; //Field offset: 0x28
	public string prefab_name; //Field offset: 0x30
	public uint type; //Field offset: 0x38
	public string effect; //Field offset: 0x40
	public string key_audio; //Field offset: 0x48
	public string boss_action; //Field offset: 0x50
	public List<String> sceneChangeNames; //Field offset: 0x58
	public decimal left_perfect_range; //Field offset: 0x60
	public decimal left_great_range; //Field offset: 0x70
	public decimal right_perfect_range; //Field offset: 0x80
	public decimal right_great_range; //Field offset: 0x90
	public int damage; //Field offset: 0xA0
	public int pathway; //Field offset: 0xA4
	public int speed; //Field offset: 0xA8
	public int score; //Field offset: 0xAC
	public int fever; //Field offset: 0xB0
	public bool missCombo; //Field offset: 0xB4
	public bool addCombo; //Field offset: 0xB5
	public bool jumpNote; //Field offset: 0xB6
	public bool isShowPlayEffect; //Field offset: 0xB7
	private BmsNodeUid m_BmsUid; //Field offset: 0xB8
	[CompilerGenerated]
	private int <noteUid>k__BackingField; //Field offset: 0xBC

	public BmsNodeUid bmsUid
	{
		 get { } //Length: 7
	}

	public bool isValid
	{
		 get { } //Length: 24
	}

	public decimal leftRange
	{
		 get { } //Length: 159
	}

	public private int noteUid
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public decimal rightRange
	{
		 get { } //Length: 165
	}

	private static NoteConfigData() { }

	public BmsNodeUid get_bmsUid() { }

	public bool get_isValid() { }

	public decimal get_leftRange() { }

	[CompilerGenerated]
	public int get_noteUid() { }

	public decimal get_rightRange() { }

	public void Init() { }

	[CompilerGenerated]
	private void set_noteUid(int value) { }

}


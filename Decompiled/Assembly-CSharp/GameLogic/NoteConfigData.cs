using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using PeroPeroGames.GlobalDefines;

namespace GameLogic;

[Token(Token = "0x20004AA")]
public struct NoteConfigData
{
	[Token(Token = "0x400194A")]
	public const int PATHWAY_AIR = 1;

	[Token(Token = "0x400194B")]
	public const int PATHWAY_ROAD = 0;

	[Token(Token = "0x400194C")]
	public static uint[] NODE_TYPE_IS_ADD_COMBO;

	[Token(Token = "0x400194D")]
	public static uint[] NODE_TYPE_IS_MISS_COMBO;

	[Token(Token = "0x400194E")]
	public static uint[] NODE_TYPE_IS_SHOW_PLAY_EFFECT;

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400194F")]
	public string id;

	[Token(Token = "0x4001950")]
	[FieldOffset(Offset = "0x8")]
	public string ibms_id;

	[Token(Token = "0x4001951")]
	[FieldOffset(Offset = "0x10")]
	public string uid;

	[Token(Token = "0x4001952")]
	[FieldOffset(Offset = "0x18")]
	public string mirror_uid;

	[Token(Token = "0x4001953")]
	[FieldOffset(Offset = "0x20")]
	public string scene;

	[Token(Token = "0x4001954")]
	[FieldOffset(Offset = "0x28")]
	public string des;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001955")]
	public string prefab_name;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001956")]
	public uint type;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001957")]
	public string effect;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001958")]
	public string key_audio;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001959")]
	public string boss_action;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400195A")]
	public List<string> sceneChangeNames;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400195B")]
	public decimal left_perfect_range;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400195C")]
	public decimal left_great_range;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400195D")]
	public decimal right_perfect_range;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400195E")]
	public decimal right_great_range;

	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400195F")]
	public int damage;

	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4001960")]
	public int pathway;

	[Token(Token = "0x4001961")]
	[FieldOffset(Offset = "0xA8")]
	public int speed;

	[Token(Token = "0x4001962")]
	[FieldOffset(Offset = "0xAC")]
	public int score;

	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4001963")]
	public int fever;

	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x4001964")]
	public bool missCombo;

	[FieldOffset(Offset = "0xB5")]
	[Token(Token = "0x4001965")]
	public bool addCombo;

	[Token(Token = "0x4001966")]
	[FieldOffset(Offset = "0xB6")]
	public bool jumpNote;

	[Token(Token = "0x4001967")]
	[FieldOffset(Offset = "0xB7")]
	public bool isShowPlayEffect;

	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4001968")]
	private BmsNodeUid m_BmsUid;

	[Token(Token = "0x170004CF")]
	public BmsNodeUid bmsUid
	{
		[Address(RVA = "0x484490", Offset = "0x482C90", Length = "0x7")]
		[Token(Token = "0x6003527")]
		get
		{
			return default(BmsNodeUid);
		}
	}

	[Token(Token = "0x170004D0")]
	public int noteUid
	{
		[Token(Token = "0x6003528")]
		[Address(RVA = "0x5D5140", Offset = "0x5D3940", Length = "0x7")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[Token(Token = "0x6003529")]
		[Address(RVA = "0x5D5200", Offset = "0x5D3A00", Length = "0x7")]
		private set
		{
		}
	}

	[Token(Token = "0x170004D1")]
	public decimal leftRange
	{
		[Token(Token = "0x600352B")]
		[Address(RVA = "0x5D50A0", Offset = "0x5D38A0", Length = "0x9F")]
		get
		{
			return default(decimal);
		}
	}

	[Token(Token = "0x170004D2")]
	public decimal rightRange
	{
		[Address(RVA = "0x5D5150", Offset = "0x5D3950", Length = "0xA5")]
		[Token(Token = "0x600352C")]
		get
		{
			return default(decimal);
		}
	}

	[Token(Token = "0x170004D3")]
	public bool isValid
	{
		[Address(RVA = "0x5D5080", Offset = "0x5D3880", Length = "0x15")]
		[Token(Token = "0x600352D")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600352A")]
	[Address(RVA = "0x5D4EE0", Offset = "0x5D36E0", Length = "0xAC")]
	public void Init()
	{
	}
}

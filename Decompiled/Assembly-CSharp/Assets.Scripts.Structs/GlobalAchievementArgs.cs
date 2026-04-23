using Assets.Scripts.Database;
using Cpp2ILInjected;

namespace Assets.Scripts.Structs;

[Token(Token = "0x200057D")]
public struct GlobalAchievementArgs
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400205E")]
	public bool isSuccess;

	[Token(Token = "0x400205F")]
	[FieldOffset(Offset = "0x1")]
	public bool isValidFail;

	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4002060")]
	public int difficulty;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4002061")]
	public MusicInfo musicInfo;

	[Token(Token = "0x4002062")]
	[FieldOffset(Offset = "0x10")]
	public int evaluateNum;

	[Token(Token = "0x4002063")]
	[FieldOffset(Offset = "0x14")]
	public int score;

	[Token(Token = "0x4002064")]
	[FieldOffset(Offset = "0x18")]
	public int maxCombo;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4002065")]
	public float accuracy;

	[Token(Token = "0x4002066")]
	[FieldOffset(Offset = "0x20")]
	public int level;

	[Token(Token = "0x4002067")]
	[FieldOffset(Offset = "0x24")]
	public int musicCount;

	[Token(Token = "0x4002068")]
	[FieldOffset(Offset = "0x28")]
	public int bloodCount;

	[Token(Token = "0x4002069")]
	[FieldOffset(Offset = "0x2C")]
	public int hitCount;

	[Token(Token = "0x400206A")]
	[FieldOffset(Offset = "0x30")]
	public int normalNoteTotalCount;

	[Token(Token = "0x400206B")]
	[FieldOffset(Offset = "0x34")]
	public int perfectCount;

	[Token(Token = "0x400206C")]
	[FieldOffset(Offset = "0x38")]
	public int greatCount;

	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400206D")]
	public bool isFullCombo;

	[Token(Token = "0x400206E")]
	[FieldOffset(Offset = "0x40")]
	public int selectedRoleIndex;

	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400206F")]
	public int selectedElfinIndex;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002070")]
	public int missCount;

	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4002071")]
	public int failCount;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002072")]
	public int totalFailCount;

	[Token(Token = "0x4002073")]
	[FieldOffset(Offset = "0x54")]
	public int totalFullComboCount;

	[Token(Token = "0x4002074")]
	[FieldOffset(Offset = "0x58")]
	public int totalLongFinishCount;

	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4002075")]
	public int totalPressingHitCount;

	[Token(Token = "0x4002076")]
	[FieldOffset(Offset = "0x60")]
	public int totalBlockCount;

	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4002077")]
	public int totalBossNearCount;

	[Token(Token = "0x4002078")]
	[FieldOffset(Offset = "0x68")]
	public int totalNoteHitCount;

	[Token(Token = "0x4002079")]
	[FieldOffset(Offset = "0x6C")]
	public int totalHideNoteCount;

	[Token(Token = "0x400207A")]
	[FieldOffset(Offset = "0x70")]
	public int totalBloodCount;

	[Token(Token = "0x400207B")]
	[FieldOffset(Offset = "0x74")]
	public int totalMusicCount;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400207C")]
	public int totalPassCount;

	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x400207D")]
	public int totalDPassCount;

	[Token(Token = "0x400207E")]
	[FieldOffset(Offset = "0x80")]
	public int totalCPassCount;

	[Token(Token = "0x400207F")]
	[FieldOffset(Offset = "0x84")]
	public int totalBPassCount;

	[Token(Token = "0x4002080")]
	[FieldOffset(Offset = "0x88")]
	public int totalAPassCount;

	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x4002081")]
	public int totalEasyPassCount;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4002082")]
	public int totalHardPassCount;

	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4002083")]
	public int totalMasterPassCount;

	[Token(Token = "0x4002084")]
	[FieldOffset(Offset = "0x98")]
	public int totalFailCharacterCount;

	[Token(Token = "0x17000523")]
	public string globalAchiUid
	{
		[Token(Token = "0x600386F")]
		[Address(RVA = "0x656AC0", Offset = "0x6552C0", Length = "0x72")]
		get
		{
			return null;
		}
	}
}

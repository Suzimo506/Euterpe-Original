using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Newtonsoft.Json;

namespace Assets.Scripts.Structs;

[Token(Token = "0x2000588")]
public class StageAchievement
{
	[FieldOffset(Offset = "0x10")]
	[JsonProperty]
	[Token(Token = "0x4002099")]
	private string uid;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400209A")]
	[JsonProperty]
	private StageAchiConditionType conditionType;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400209B")]
	[JsonProperty]
	private StageAchiPunch punch;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400209C")]
	[JsonProperty]
	private StageAchiScore score;

	[JsonProperty]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400209D")]
	private StageAchiFever fever;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400209E")]
	[JsonProperty]
	private StageAchiJudge judge;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400209F")]
	[JsonProperty]
	private StageAchiEvaluate evaluate;

	[JsonProperty]
	[Token(Token = "0x40020A0")]
	[FieldOffset(Offset = "0x48")]
	private StageAchiHurt hurt;

	[JsonProperty]
	[Token(Token = "0x40020A1")]
	[FieldOffset(Offset = "0x50")]
	private StageAchiCombo combo;

	[Token(Token = "0x6003883")]
	[Address(RVA = "0x65DF00", Offset = "0x65C700", Length = "0xA9")]
	public bool Do(ref AchievementArgs args, out AchiInfo achiInfo)
	{
		System.Runtime.CompilerServices.Unsafe.As<AchiInfo, @null>(ref achiInfo) = null;
		return default(bool);
	}

	[Token(Token = "0x6003884")]
	[Address(RVA = "0x65DFB0", Offset = "0x65C7B0", Length = "0x12A")]
	private bool Private_Do(StageAchiConditionType condition, ref AchievementArgs args, ref AchiInfo achiInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6003885")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public StageAchievement()
	{
	}
}

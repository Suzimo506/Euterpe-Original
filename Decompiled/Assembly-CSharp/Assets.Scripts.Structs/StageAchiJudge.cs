using Cpp2ILInjected;

namespace Assets.Scripts.Structs;

[Token(Token = "0x2000583")]
internal class StageAchiJudge : AbstractStageAchi
{
	[Token(Token = "0x6003879")]
	[Address(RVA = "0x65DDE0", Offset = "0x65C5E0", Length = "0x93")]
	public override bool Do(ref AchievementArgs args, ref AchiInfo achiInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x600387A")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public StageAchiJudge()
	{
	}
}

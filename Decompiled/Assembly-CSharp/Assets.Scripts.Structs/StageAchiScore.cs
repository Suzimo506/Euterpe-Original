using Cpp2ILInjected;

namespace Assets.Scripts.Structs;

[Token(Token = "0x2000582")]
internal class StageAchiScore : AbstractStageAchi
{
	[Token(Token = "0x6003877")]
	[Address(RVA = "0x65DEE0", Offset = "0x65C6E0", Length = "0x18")]
	public override bool Do(ref AchievementArgs args, ref AchiInfo achiInfo)
	{
		return default(bool);
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003878")]
	public StageAchiScore()
	{
	}
}

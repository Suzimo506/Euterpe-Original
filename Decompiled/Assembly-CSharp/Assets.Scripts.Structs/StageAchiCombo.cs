using Cpp2ILInjected;

namespace Assets.Scripts.Structs;

[Token(Token = "0x2000587")]
internal class StageAchiCombo : AbstractStageAchi
{
	[Token(Token = "0x6003881")]
	[Address(RVA = "0x65DC80", Offset = "0x65C480", Length = "0x32")]
	public override bool Do(ref AchievementArgs args, ref AchiInfo achiInfo)
	{
		return default(bool);
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003882")]
	public StageAchiCombo()
	{
	}
}

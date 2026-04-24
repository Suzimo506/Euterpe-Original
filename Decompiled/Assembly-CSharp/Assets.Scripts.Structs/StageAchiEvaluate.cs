using Cpp2ILInjected;

namespace Assets.Scripts.Structs;

[Token(Token = "0x2000584")]
internal class StageAchiEvaluate : AbstractStageAchi
{
	[Token(Token = "0x600387B")]
	[Address(RVA = "0x65DCC0", Offset = "0x65C4C0", Length = "0xD3")]
	public override bool Do(ref AchievementArgs args, ref AchiInfo achiInfo)
	{
		return default(bool);
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x600387C")]
	public StageAchiEvaluate()
	{
	}
}

using Cpp2ILInjected;

namespace Assets.Scripts.Structs;

[Token(Token = "0x2000585")]
internal class StageAchiFever : AbstractStageAchi
{
	[Token(Token = "0x600387D")]
	[Address(RVA = "0x65DDA0", Offset = "0x65C5A0", Length = "0x18")]
	public override bool Do(ref AchievementArgs args, ref AchiInfo achiInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x600387E")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public StageAchiFever()
	{
	}
}

using Cpp2ILInjected;

namespace Assets.Scripts.Structs;

[Token(Token = "0x2000586")]
internal class StageAchiHurt : AbstractStageAchi
{
	[Token(Token = "0x600387F")]
	[Address(RVA = "0x65DDC0", Offset = "0x65C5C0", Length = "0x18")]
	public override bool Do(ref AchievementArgs args, ref AchiInfo achiInfo)
	{
		return default(bool);
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003880")]
	public StageAchiHurt()
	{
	}
}

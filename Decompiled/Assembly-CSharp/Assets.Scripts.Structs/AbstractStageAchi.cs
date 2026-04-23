using Cpp2ILInjected;
using Newtonsoft.Json;

namespace Assets.Scripts.Structs;

[Token(Token = "0x2000580")]
internal abstract class AbstractStageAchi
{
	[JsonProperty]
	[Token(Token = "0x4002095")]
	[FieldOffset(Offset = "0x10")]
	protected int value;

	[Token(Token = "0x4002096")]
	[FieldOffset(Offset = "0x14")]
	[JsonProperty]
	protected int count;

	[JsonProperty]
	[Token(Token = "0x4002097")]
	[FieldOffset(Offset = "0x18")]
	protected byte subValue;

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6003873")]
	public abstract bool Do(ref AchievementArgs args, ref AchiInfo achiInfo);

	[Token(Token = "0x6003874")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	protected AbstractStageAchi()
	{
	}
}

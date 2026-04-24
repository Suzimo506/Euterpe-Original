using Cpp2ILInjected;
using Newtonsoft.Json;
using PeroPeroGames.GlobalDefines;

namespace Assets.Scripts.Structs;

[Token(Token = "0x2000581")]
internal class StageAchiPunch : AbstractStageAchi
{
	[FieldOffset(Offset = "0x20")]
	[JsonProperty]
	[Token(Token = "0x4002098")]
	protected BmsNodeUid[] valueArray;

	[Address(RVA = "0x65DE80", Offset = "0x65C680", Length = "0x53")]
	[Token(Token = "0x6003875")]
	public override bool Do(ref AchievementArgs args, ref AchiInfo achiInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6003876")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public StageAchiPunch()
	{
	}
}

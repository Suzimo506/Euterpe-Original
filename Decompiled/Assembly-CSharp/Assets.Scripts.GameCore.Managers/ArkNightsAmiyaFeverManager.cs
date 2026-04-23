using Cpp2ILInjected;
using GameLogic;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x200073B")]
public class ArkNightsAmiyaFeverManager : AbstractFeverManager
{
	[Attribute(Name = "DecimalConstantAttribute", RVA = "0x859D0", Offset = "0x84DD0")]
	[Token(Token = "0x4002632")]
	public static readonly decimal ban_fever_time;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4002633")]
	private decimal m_BanAddFeverStart;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4002634")]
	private decimal m_BanAddFeverEnd;

	[Address(RVA = "0x7883E0", Offset = "0x786BE0", Length = "0x109")]
	[Token(Token = "0x600434D")]
	public override void AwakeInit()
	{
	}

	[Address(RVA = "0x7885D0", Offset = "0x786DD0", Length = "0x49")]
	[Token(Token = "0x600434E")]
	public override void StartInit()
	{
	}

	[Token(Token = "0x600434F")]
	[Address(RVA = "0x788260", Offset = "0x786A60", Length = "0x140")]
	public override void AddFever(ref MusicData md, int result)
	{
	}

	[Token(Token = "0x6004350")]
	[Address(RVA = "0x7884F0", Offset = "0x786CF0", Length = "0xD4")]
	public override bool InvokeFever()
	{
		return default(bool);
	}

	[Token(Token = "0x6004351")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public ArkNightsAmiyaFeverManager()
	{
	}
}

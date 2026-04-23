using Assets.Scripts.Database;
using Cpp2ILInjected;
using GameLogic;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x200073F")]
public class TouhouFeverManager : AbstractFeverManager
{
	[Attribute(Name = "DecimalConstantAttribute", RVA = "0x87DD0", Offset = "0x871D0")]
	[Token(Token = "0x4002639")]
	private static readonly decimal touhou_fever_time;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400263A")]
	protected DBTouhou m_DbTouhou;

	[Token(Token = "0x600436C")]
	[Address(RVA = "0x7DCA30", Offset = "0x7DB230", Length = "0xF5")]
	public override void AwakeInit()
	{
	}

	[Token(Token = "0x600436D")]
	[Address(RVA = "0x7DCF60", Offset = "0x7DB760", Length = "0x57")]
	public override void StartInit()
	{
	}

	[Token(Token = "0x600436E")]
	[Address(RVA = "0x7DC7F0", Offset = "0x7DAFF0", Length = "0x48")]
	public override void AddFever(ref MusicData md, int result)
	{
	}

	[Token(Token = "0x600436F")]
	[Address(RVA = "0x7DCC00", Offset = "0x7DB400", Length = "0x1B")]
	public override float GetFeverNormalize()
	{
		return default(float);
	}

	[Token(Token = "0x6004370")]
	[Address(RVA = "0x7DC8F0", Offset = "0x7DB0F0", Length = "0x138")]
	protected override void AddFever(int value)
	{
	}

	[Token(Token = "0x6004371")]
	[Address(RVA = "0x7DCC20", Offset = "0x7DB420", Length = "0x2CA")]
	public override bool InvokeFever()
	{
		return default(bool);
	}

	[Address(RVA = "0x7DCB30", Offset = "0x7DB330", Length = "0xCA")]
	[Token(Token = "0x6004372")]
	protected override void FeverEnd()
	{
	}

	[Token(Token = "0x6004373")]
	[Address(RVA = "0x7DCEF0", Offset = "0x7DB6F0", Length = "0x6B")]
	public override void Release()
	{
	}

	[Token(Token = "0x6004374")]
	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	public TouhouFeverManager()
	{
	}
}

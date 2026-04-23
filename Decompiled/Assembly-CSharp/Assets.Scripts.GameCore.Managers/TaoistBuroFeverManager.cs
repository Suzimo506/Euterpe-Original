using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x200073E")]
public class TaoistBuroFeverManager : AbstractFeverManager
{
	[Address(RVA = "0x7D3910", Offset = "0x7D2110", Length = "0x49")]
	[Token(Token = "0x6004366")]
	public override void StartInit()
	{
	}

	[Token(Token = "0x6004367")]
	[Address(RVA = "0x7D36B0", Offset = "0x7D1EB0", Length = "0x109")]
	public override void AwakeInit()
	{
	}

	[Address(RVA = "0x7D37C0", Offset = "0x7D1FC0", Length = "0x13")]
	[Token(Token = "0x6004368")]
	public void ReduceFever(int value)
	{
	}

	[Token(Token = "0x6004369")]
	[Address(RVA = "0x7D37E0", Offset = "0x7D1FE0", Length = "0x12A")]
	public void SetReduceTimeWhileFeverInvoking(int costFeverValue)
	{
	}

	[Address(RVA = "0x7D3520", Offset = "0x7D1D20", Length = "0x184")]
	[Token(Token = "0x600436A")]
	protected override void AddFever(int value)
	{
	}

	[Token(Token = "0x600436B")]
	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	public TaoistBuroFeverManager()
	{
	}
}

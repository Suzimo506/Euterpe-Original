using Cpp2ILInjected;

[Token(Token = "0x2000035")]
public class AirGoldController : BaseEnemyObjectController
{
	[Token(Token = "0x4000156")]
	[FieldOffset(Offset = "0x218")]
	private bool isBeAttacked;

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
	public override bool OnControllerMiss(int idx)
	{
		return default(bool);
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x5939A0", Offset = "0x5921A0", Length = "0x219")]
	public override void OnControllerAttacked(int result, bool isDeaded)
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x593BC0", Offset = "0x5923C0", Length = "0x51")]
	public AirGoldController()
	{
	}
}

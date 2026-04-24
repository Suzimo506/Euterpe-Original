using Cpp2ILInjected;

namespace Assets.Scripts.Structs;

[Token(Token = "0x200056D")]
public class CatchInput
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001FF9")]
	public bool isGroundCatching;

	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x4001FFA")]
	public bool isAirCatching;

	[Token(Token = "0x4001FFB")]
	[FieldOffset(Offset = "0x14")]
	public float time;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x600383D")]
	public CatchInput()
	{
	}
}

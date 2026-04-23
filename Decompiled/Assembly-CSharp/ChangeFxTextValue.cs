using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000174")]
public class ChangeFxTextValue : MonoBehaviour
{
	[Token(Token = "0x2000A44")]
	public enum FxType
	{
		[Token(Token = "0x4003686")]
		Hp,
		[Token(Token = "0x4003687")]
		Hurt,
		[Token(Token = "0x4003688")]
		Score
	}

	[Token(Token = "0x4000939")]
	[FieldOffset(Offset = "0x18")]
	public FxType fxType;

	[Address(RVA = "0x463DA0", Offset = "0x4625A0", Length = "0xF7")]
	[Token(Token = "0x6000AB4")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000AB5")]
	public ChangeFxTextValue()
	{
	}
}

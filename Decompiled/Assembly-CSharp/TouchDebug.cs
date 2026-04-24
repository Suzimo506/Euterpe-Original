using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000004")]
public class TouchDebug : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000005")]
	public Button b;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x51F440", Offset = "0x51DC40", Length = "0x124")]
	private void Start()
	{
	}

	[Address(RVA = "0x51F570", Offset = "0x51DD70", Length = "0xF1")]
	[Token(Token = "0x600000E")]
	private void Update()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public TouchDebug()
	{
	}
}

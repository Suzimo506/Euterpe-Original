using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000050")]
public class JudgeDisplay : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001DB")]
	public GameObject imgEarly;

	[Token(Token = "0x40001DC")]
	[FieldOffset(Offset = "0x20")]
	public GameObject imgLate;

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x5D1F70", Offset = "0x5D0770", Length = "0x93")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000250")]
	public JudgeDisplay()
	{
	}
}

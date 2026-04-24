using Cpp2ILInjected;
using Rewired;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Commons;

[Token(Token = "0x2000687")]
public class HideCursor : MonoBehaviour
{
	[Token(Token = "0x40023CB")]
	[FieldOffset(Offset = "0x18")]
	public float hideTime;

	[Token(Token = "0x40023CC")]
	[FieldOffset(Offset = "0x1C")]
	private float m_Time;

	[Token(Token = "0x40023CD")]
	[FieldOffset(Offset = "0x20")]
	private Controller m_LastController;

	[Token(Token = "0x6003D9E")]
	[Address(RVA = "0x92CC30", Offset = "0x92B430", Length = "0x225")]
	private void Update()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6003D9F")]
	public HideCursor()
	{
	}
}

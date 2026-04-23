using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Common;

[Token(Token = "0x200098A")]
public class WelcomeAdapter : MonoBehaviour
{
	[Token(Token = "0x4003439")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 fourToThree;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400343A")]
	public Vector2 standard;

	[Token(Token = "0x400343B")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 extraStandard;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400343C")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x28D90", Offset = "0x28190")]
	private int m_Index;

	[Address(RVA = "0x7044E0", Offset = "0x702CE0", Length = "0x165")]
	[Token(Token = "0x60056D4")]
	public void OnEnable()
	{
	}

	[Address(RVA = "0x704650", Offset = "0x702E50", Length = "0xB7")]
	[Token(Token = "0x60056D5")]
	public WelcomeAdapter()
	{
	}
}

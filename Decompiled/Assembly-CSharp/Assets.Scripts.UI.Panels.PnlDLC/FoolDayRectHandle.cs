using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x200092E")]
public class FoolDayRectHandle : FoolDayHandle
{
	[Token(Token = "0x400316C")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rectTransform;

	[Token(Token = "0x400316D")]
	[FieldOffset(Offset = "0x20")]
	public float targetFoolDayHeight;

	[Token(Token = "0x400316E")]
	[FieldOffset(Offset = "0x24")]
	private Vector2 m_RectOrigin;

	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400316F")]
	private Vector2 m_RectTarget;

	[Token(Token = "0x6005327")]
	[Address(RVA = "0x42EA70", Offset = "0x42D270", Length = "0x7E")]
	public override void Awake()
	{
	}

	[Token(Token = "0x6005328")]
	[Address(RVA = "0x42EAF0", Offset = "0x42D2F0", Length = "0x44")]
	public override void ChangeByAlbumJsonIndex(int albumJsonIndex)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6005329")]
	public FoolDayRectHandle()
	{
	}
}

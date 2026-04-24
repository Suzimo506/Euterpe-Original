using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x2000930")]
[Attribute(Name = "RequireComponent", RVA = "0x8C760", Offset = "0x8BB60")]
public class FoolDayTextMultipleFontHandle : FoolDayHandle
{
	[Token(Token = "0x4003177")]
	[FieldOffset(Offset = "0x18")]
	public Font cs;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4003178")]
	public Font ct;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4003179")]
	public Font jp;

	[Token(Token = "0x400317A")]
	[FieldOffset(Offset = "0x30")]
	public Font kr;

	[Token(Token = "0x400317B")]
	[FieldOffset(Offset = "0x38")]
	public Font en;

	[Token(Token = "0x400317C")]
	[FieldOffset(Offset = "0x40")]
	public RectTransform forceRebuildRect;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400317D")]
	private Text m_Text;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400317E")]
	private Font originFont;

	[Address(RVA = "0x42F0A0", Offset = "0x42D8A0", Length = "0x17C")]
	[Token(Token = "0x600532D")]
	public override void ChangeByAlbumJsonIndex(int albumJsonIndex)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x600532E")]
	public FoolDayTextMultipleFontHandle()
	{
	}
}

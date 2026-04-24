using Cpp2ILInjected;
using TMPro;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x200092F")]
[Attribute(Name = "RequireComponent", RVA = "0x8C370", Offset = "0x8B770")]
public class FoolDayTMPMultipleFontHandle : FoolDayHandle
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4003170")]
	public TMP_FontAsset cs;

	[Token(Token = "0x4003171")]
	[FieldOffset(Offset = "0x20")]
	public TMP_FontAsset ct;

	[Token(Token = "0x4003172")]
	[FieldOffset(Offset = "0x28")]
	public TMP_FontAsset jp;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4003173")]
	public TMP_FontAsset kr;

	[Token(Token = "0x4003174")]
	[FieldOffset(Offset = "0x38")]
	public TMP_FontAsset en;

	[Token(Token = "0x4003175")]
	[FieldOffset(Offset = "0x40")]
	private TMP_Text m_Text;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4003176")]
	private GlobalScriptableObjectData globalData;

	[Address(RVA = "0x42EB40", Offset = "0x42D340", Length = "0x37E")]
	[Token(Token = "0x600532A")]
	public override void ChangeByAlbumJsonIndex(int albumJsonIndex)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x600532B")]
	public FoolDayTMPMultipleFontHandle()
	{
	}
}

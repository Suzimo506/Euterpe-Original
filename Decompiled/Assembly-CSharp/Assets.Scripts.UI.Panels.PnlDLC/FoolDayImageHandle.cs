using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x200092B")]
public class FoolDayImageHandle : FoolDayHandle
{
	[Token(Token = "0x4003166")]
	[FieldOffset(Offset = "0x18")]
	public Image img;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4003167")]
	public Sprite spTarget;

	[Token(Token = "0x4003168")]
	[FieldOffset(Offset = "0x28")]
	private Sprite m_SpOrigin;

	[Address(RVA = "0x42E780", Offset = "0x42CF80", Length = "0x29")]
	[Token(Token = "0x600531E")]
	public override void Awake()
	{
	}

	[Address(RVA = "0x42E7B0", Offset = "0x42CFB0", Length = "0x30")]
	[Token(Token = "0x600531F")]
	public override void ChangeByAlbumJsonIndex(int albumJsonIndex)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6005320")]
	public FoolDayImageHandle()
	{
	}
}

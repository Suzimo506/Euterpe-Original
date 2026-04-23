using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x200092D")]
public class FoolDayObjHandle : FoolDayHandle
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400316B")]
	public GameObject targetObj;

	[Address(RVA = "0x42E9A0", Offset = "0x42D1A0", Length = "0xC7")]
	[Token(Token = "0x6005325")]
	public override void ChangeByAlbumJsonIndex(int albumJsonIndex)
	{
	}

	[Token(Token = "0x6005326")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public FoolDayObjHandle()
	{
	}
}

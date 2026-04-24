using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x2000927")]
public class FoolDayBindHandle : FoolDayHandle
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400315D")]
	public GameObject targetObj;

	[Address(RVA = "0x42E0B0", Offset = "0x42C8B0", Length = "0x95")]
	[Token(Token = "0x6005311")]
	public override void ChangeByAlbumJsonIndex(int albumJsonIndex)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6005312")]
	public FoolDayBindHandle()
	{
	}
}

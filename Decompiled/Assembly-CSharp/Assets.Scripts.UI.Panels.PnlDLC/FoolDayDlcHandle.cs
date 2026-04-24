using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x2000929")]
public class FoolDayDlcHandle : FoolDayHandle
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4003163")]
	public Transform transSongCell;

	[Token(Token = "0x4003164")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> lightingObjs;

	[Token(Token = "0x4003165")]
	[FieldOffset(Offset = "0x28")]
	private bool isInit;

	[Address(RVA = "0x42E260", Offset = "0x42CA60", Length = "0x9C")]
	[Token(Token = "0x6005316")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6005317")]
	[Address(RVA = "0x42E590", Offset = "0x42CD90", Length = "0x69")]
	public FoolDayDlcHandle()
	{
	}
}

using System.Collections.Generic;
using Assets.Scripts.UI.Panels;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000ED")]
public class OffsetAskSelect : UISelectManage
{
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40005F0")]
	public Button tvMode;

	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40005F1")]
	public Button handheldMode;

	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40005F2")]
	public PnlOffsetOption offsetOption;

	[Token(Token = "0x60006F3")]
	[Address(RVA = "0x86E150", Offset = "0x86C950", Length = "0xA8")]
	public override List<GameObject> SetSelectableObj()
	{
		return null;
	}

	[Address(RVA = "0x86DF30", Offset = "0x86C730", Length = "0x8F")]
	[Token(Token = "0x60006F4")]
	public override GameObject DefaultSelectObj()
	{
		return null;
	}

	[Address(RVA = "0x86DFC0", Offset = "0x86C7C0", Length = "0x180")]
	[Token(Token = "0x60006F5")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Token(Token = "0x60006F6")]
	[Address(RVA = "0x4C5020", Offset = "0x4C3820", Length = "0x7")]
	public OffsetAskSelect()
	{
	}
}

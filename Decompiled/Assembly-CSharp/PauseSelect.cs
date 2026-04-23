using System.Collections.Generic;
using Assets.Scripts.PeroTools.UI;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000F3")]
public class PauseSelect : UISelectManage
{
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000613")]
	public Transform buttons;

	[Token(Token = "0x6000728")]
	[Address(RVA = "0x8734B0", Offset = "0x871CB0", Length = "0x9F")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Address(RVA = "0x873720", Offset = "0x871F20", Length = "0xD8")]
	[Token(Token = "0x6000729")]
	public override List<GameObject> SetSelectableObj()
	{
		return null;
	}

	[Token(Token = "0x600072A")]
	[Address(RVA = "0x873450", Offset = "0x871C50", Length = "0x50")]
	public override void OnEnablePnl()
	{
	}

	[Address(RVA = "0x8735A0", Offset = "0x871DA0", Length = "0x170")]
	[Token(Token = "0x600072B")]
	public override void SetKeyBindings(GameObject obj, bool enable, bool isStart = false)
	{
	}

	[Token(Token = "0x600072C")]
	[Address(RVA = "0x873560", Offset = "0x871D60", Length = "0x31")]
	public override Transform SetEdgeObj(GameObject currentObj)
	{
		return null;
	}

	[Token(Token = "0x600072D")]
	[Address(RVA = "0x873550", Offset = "0x871D50", Length = "0x8")]
	public void SetButtonDirection(ButtonDirection buttonDirection)
	{
	}

	[Address(RVA = "0x4C5020", Offset = "0x4C3820", Length = "0x7")]
	[Token(Token = "0x600072E")]
	public PauseSelect()
	{
	}
}

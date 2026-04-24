using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000E9")]
public class InputCustomizeSelect : UISelectManage
{
	[Token(Token = "0x40005D4")]
	[FieldOffset(Offset = "0x118")]
	private List<GameObject> m_Buttons;

	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40005D5")]
	public Transform buttons;

	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40005D6")]
	public Button cancel;

	[Token(Token = "0x40005D7")]
	[FieldOffset(Offset = "0x130")]
	private int m_LastSelectButtonIndex;

	[Token(Token = "0x40005D8")]
	[FieldOffset(Offset = "0x138")]
	public Button empty;

	[Token(Token = "0x40005D9")]
	[FieldOffset(Offset = "0x140")]
	public Action<PCCustomKeyCell, bool> onSelect;

	[Token(Token = "0x60006C2")]
	[Address(RVA = "0x5C7E60", Offset = "0x5C6660", Length = "0x8C")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x60006C3")]
	[Address(RVA = "0x5C7B30", Offset = "0x5C6330", Length = "0xB4")]
	public override GameObject DefaultSelectObj()
	{
		return null;
	}

	[Token(Token = "0x60006C4")]
	[Address(RVA = "0x5C7E20", Offset = "0x5C6620", Length = "0x32")]
	public override void OnEnablePnl()
	{
	}

	[Address(RVA = "0x5C7DC0", Offset = "0x5C65C0", Length = "0x54")]
	[Token(Token = "0x60006C5")]
	public override void OnDisablePnl()
	{
	}

	[Address(RVA = "0x5C8100", Offset = "0x5C6900", Length = "0xD1")]
	[Token(Token = "0x60006C6")]
	public override List<GameObject> SetSelectableObj()
	{
		return null;
	}

	[Token(Token = "0x60006C7")]
	[Address(RVA = "0x5C7EF0", Offset = "0x5C66F0", Length = "0x20A")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Address(RVA = "0x5C7A70", Offset = "0x5C6270", Length = "0xB7")]
	[Token(Token = "0x60006C8")]
	public bool CheckAxisButtonPressed()
	{
		return default(bool);
	}

	[Token(Token = "0x60006C9")]
	[Address(RVA = "0x5C7C70", Offset = "0x5C6470", Length = "0x145")]
	private void OnClickCancel()
	{
	}

	[Token(Token = "0x60006CA")]
	[Address(RVA = "0x5C7BF0", Offset = "0x5C63F0", Length = "0x73")]
	public GameObject GetLastSelectObj()
	{
		return null;
	}

	[Token(Token = "0x60006CB")]
	[Address(RVA = "0x5C81E0", Offset = "0x5C69E0", Length = "0x6C")]
	public InputCustomizeSelect()
	{
	}
}

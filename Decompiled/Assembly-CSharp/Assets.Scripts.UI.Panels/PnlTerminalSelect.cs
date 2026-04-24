using System;
using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Actions;
using Assets.Scripts.PeroTools.UI;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008DF")]
public class PnlTerminalSelect : UISelectManage
{
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4002EF4")]
	[SerializeField]
	private Popup m_Popup;

	[Token(Token = "0x4002EF5")]
	[FieldOffset(Offset = "0x120")]
	public Button btnVerifying;

	[Token(Token = "0x4002EF6")]
	[FieldOffset(Offset = "0x128")]
	public Button backButton;

	[SerializeField]
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4002EF7")]
	public PeroInputField inputField;

	[Token(Token = "0x4002EF8")]
	[FieldOffset(Offset = "0x138")]
	public System.Action backEvent;

	[Address(RVA = "0x4C6540", Offset = "0x4C4D40", Length = "0x9F")]
	[Token(Token = "0x600504F")]
	public void SetSelectedGameObject(GameObject go)
	{
	}

	[Address(RVA = "0x4C60A0", Offset = "0x4C48A0", Length = "0x102")]
	[Token(Token = "0x6005050")]
	private bool ItemUpdate()
	{
		return default(bool);
	}

	[Token(Token = "0x6005051")]
	[Address(RVA = "0x4C6490", Offset = "0x4C4C90", Length = "0xA8")]
	public override List<GameObject> SetSelectableObj()
	{
		return null;
	}

	[Address(RVA = "0x4C61B0", Offset = "0x4C49B0", Length = "0xE0")]
	[Token(Token = "0x6005052")]
	protected override void OnAxisDown(ButtonDirection dir, ButtonDirection nullDir, GameObject current, GameObject lastGameObject)
	{
	}

	[Address(RVA = "0x4C62A0", Offset = "0x4C4AA0", Length = "0x1E9")]
	[Token(Token = "0x6005053")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Address(RVA = "0x4C5020", Offset = "0x4C3820", Length = "0x7")]
	[Token(Token = "0x6005054")]
	public PnlTerminalSelect()
	{
	}
}

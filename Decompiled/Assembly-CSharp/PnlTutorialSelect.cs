using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000D0")]
public class PnlTutorialSelect : UISelectManage
{
	[Token(Token = "0x400050C")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	private Button m_BtnLevelTeaching;

	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x400050D")]
	[SerializeField]
	private Button m_BtnFunctionDescription;

	[SerializeField]
	[Token(Token = "0x400050E")]
	[FieldOffset(Offset = "0x128")]
	private BaseMessageBox m_MessageBox;

	[SerializeField]
	[Token(Token = "0x400050F")]
	[FieldOffset(Offset = "0x130")]
	private List<GameObject> m_SelectedList;

	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000510")]
	private bool m_HasChangeRead;

	[Token(Token = "0x60005D3")]
	[Address(RVA = "0x564300", Offset = "0x562B00", Length = "0x15F")]
	private void Awake()
	{
	}

	[Token(Token = "0x60005D4")]
	[Address(RVA = "0x564460", Offset = "0x562C60", Length = "0xB7")]
	public override GameObject DefaultSelectObj()
	{
		return null;
	}

	[Token(Token = "0x60005D5")]
	[Address(RVA = "0x564580", Offset = "0x562D80", Length = "0x160")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Address(RVA = "0x564780", Offset = "0x562F80", Length = "0x8")]
	[Token(Token = "0x60005D6")]
	public override List<GameObject> SetSelectableObj()
	{
		return null;
	}

	[Address(RVA = "0x5646F0", Offset = "0x562EF0", Length = "0x84")]
	[Token(Token = "0x60005D7")]
	public override void OnUpdatePnl()
	{
	}

	[Address(RVA = "0x564520", Offset = "0x562D20", Length = "0x5D")]
	[Token(Token = "0x60005D8")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x4C5020", Offset = "0x4C3820", Length = "0x7")]
	[Token(Token = "0x60005D9")]
	public PnlTutorialSelect()
	{
	}
}

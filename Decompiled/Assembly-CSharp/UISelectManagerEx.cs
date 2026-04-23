using System.Collections.Generic;
using Assets.Scripts.Structs;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200007E")]
public class UISelectManagerEx : UISelectManage
{
	[SerializeField]
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000349")]
	protected UISetColor[] m_UiSelects;

	[Token(Token = "0x400034A")]
	[SerializeField]
	[FieldOffset(Offset = "0x120")]
	protected Color m_HighlightColor;

	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x400034B")]
	[SerializeField]
	protected Color m_NormalColor;

	[Token(Token = "0x400034C")]
	[FieldOffset(Offset = "0x140")]
	protected List<KeyValuePair<GameObject, GameObject>> m_SelectButtons;

	[Address(RVA = "0x4E8D80", Offset = "0x4E7580", Length = "0x1AB")]
	[Token(Token = "0x60003D8")]
	public override void OnInit()
	{
	}

	[Address(RVA = "0x4E9150", Offset = "0x4E7950", Length = "0x1FE")]
	[Token(Token = "0x60003D9")]
	public override List<GameObject> SetSelectableObj()
	{
		return null;
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x4E8F30", Offset = "0x4E7730", Length = "0x215")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x4E9350", Offset = "0x4E7B50", Length = "0x97")]
	public UISelectManagerEx()
	{
	}
}

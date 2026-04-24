using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000EC")]
public class MusicStageSelect : UISelectManage
{
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40005EC")]
	private List<GameObject> m_SelectObjs;

	[Token(Token = "0x40005ED")]
	[FieldOffset(Offset = "0x120")]
	private bool m_IsPress;

	[Token(Token = "0x40005EE")]
	[FieldOffset(Offset = "0x128")]
	private List<GameObject> m_CellObjs;

	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x40005EF")]
	private GameObject m_DefaultSelectObj;

	[Token(Token = "0x60006ED")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x60006EE")]
	[Address(RVA = "0x564780", Offset = "0x562F80", Length = "0x8")]
	public override GameObject DefaultSelectObj()
	{
		return null;
	}

	[Address(RVA = "0x8C7E20", Offset = "0x8C6620", Length = "0x18A")]
	[Token(Token = "0x60006EF")]
	public void GetSelectedObj(List<GameObject> objs, List<GameObject> tgls, float musicCellWidth)
	{
	}

	[Token(Token = "0x60006F0")]
	[Address(RVA = "0x8C8270", Offset = "0x8C6A70", Length = "0x40")]
	public override void OnUpdatePnl()
	{
	}

	[Token(Token = "0x60006F1")]
	[Address(RVA = "0x8C7FB0", Offset = "0x8C67B0", Length = "0x2BC")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Token(Token = "0x60006F2")]
	[Address(RVA = "0x8C82B0", Offset = "0x8C6AB0", Length = "0x9C")]
	public MusicStageSelect()
	{
	}
}

using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.StageBackground.DaveMainShow;

[Token(Token = "0x2000838")]
public class DaveFishViewSelectManage : UISelectManage
{
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Token(Token = "0x4002AD7")]
	private ScrollViewDaveFish m_ScrollView;

	[SerializeField]
	[Token(Token = "0x4002AD8")]
	[FieldOffset(Offset = "0x120")]
	private GameObject[] m_NormalSelecableObjs;

	[Token(Token = "0x4002AD9")]
	[FieldOffset(Offset = "0x128")]
	private List<GameObject> m_CachedSelectableObjs;

	[Token(Token = "0x6004BB0")]
	[Address(RVA = "0x60E400", Offset = "0x60CC00", Length = "0xE9")]
	public void RefreshSelectableObjs(List<GameObject> selectableObjs)
	{
	}

	[Token(Token = "0x6004BB1")]
	[Address(RVA = "0x60E4F0", Offset = "0x60CCF0", Length = "0x92")]
	public void SetSelectedObj(GameObject selectedObj)
	{
	}

	[Address(RVA = "0x60E280", Offset = "0x60CA80", Length = "0x17C")]
	[Token(Token = "0x6004BB2")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Token(Token = "0x6004BB3")]
	[Address(RVA = "0x4C5020", Offset = "0x4C3820", Length = "0x7")]
	public DaveFishViewSelectManage()
	{
	}
}

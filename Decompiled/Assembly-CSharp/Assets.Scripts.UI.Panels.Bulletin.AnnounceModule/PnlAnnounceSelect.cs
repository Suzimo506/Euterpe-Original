using System.Collections.Generic;
using Assets.Scripts.PeroTools.UI;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels.Bulletin.AnnounceModule;

[Token(Token = "0x200095A")]
public class PnlAnnounceSelect : UISelectManage
{
	[Token(Token = "0x4003300")]
	[FieldOffset(Offset = "0x118")]
	private PnlAnnounceController m_Controller;

	[Token(Token = "0x4003301")]
	[FieldOffset(Offset = "0x120")]
	private List<InputKeyBinding> m_ScrollKeybindingList;

	[Token(Token = "0x60054F6")]
	[Address(RVA = "0x6CB660", Offset = "0x6C9E60", Length = "0x8D")]
	public override void OnAwake()
	{
	}

	[Token(Token = "0x60054F7")]
	[Address(RVA = "0x6CB6F0", Offset = "0x6C9EF0", Length = "0x1A")]
	public override void OnDisablePnl()
	{
	}

	[Address(RVA = "0x6CB710", Offset = "0x6C9F10", Length = "0x3F")]
	[Token(Token = "0x60054F8")]
	public override void OnInit()
	{
	}

	[Address(RVA = "0x6CB750", Offset = "0x6C9F50", Length = "0x5C2")]
	[Token(Token = "0x60054F9")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Address(RVA = "0x6CBD20", Offset = "0x6CA520", Length = "0x1F1")]
	[Token(Token = "0x60054FA")]
	public override List<GameObject> SetSelectableObj()
	{
		return null;
	}

	[Address(RVA = "0x4C5020", Offset = "0x4C3820", Length = "0x7")]
	[Token(Token = "0x60054FB")]
	public PnlAnnounceSelect()
	{
	}
}

using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008F3")]
public class PnlReportCardSelect : UISelectManage
{
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4002FE9")]
	public List<GameObject> seletableObjs;

	[Address(RVA = "0x689970", Offset = "0x688170", Length = "0x11E")]
	[Token(Token = "0x6005155")]
	public override List<GameObject> SetSelectableObj()
	{
		return null;
	}

	[Address(RVA = "0x689A90", Offset = "0x688290", Length = "0x6C")]
	[Token(Token = "0x6005156")]
	public PnlReportCardSelect()
	{
	}
}

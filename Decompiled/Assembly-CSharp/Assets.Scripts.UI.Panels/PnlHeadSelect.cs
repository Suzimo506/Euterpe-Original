using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008F0")]
public class PnlHeadSelect : UISelectManage
{
	[Token(Token = "0x4002FAA")]
	[FieldOffset(Offset = "0x118")]
	public HeadGridView headGridView;

	[Address(RVA = "0x82E090", Offset = "0x82C890", Length = "0x9F")]
	[Token(Token = "0x6005123")]
	public override void OnEnablePnl()
	{
	}

	[Address(RVA = "0x82E1D0", Offset = "0x82C9D0", Length = "0xB4")]
	[Token(Token = "0x6005124")]
	private void RefreshSelectedObj(List<GameObject> objs)
	{
	}

	[Token(Token = "0x6005125")]
	[Address(RVA = "0x82E130", Offset = "0x82C930", Length = "0x9D")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Token(Token = "0x6005126")]
	[Address(RVA = "0x4C5020", Offset = "0x4C3820", Length = "0x7")]
	public PnlHeadSelect()
	{
	}
}

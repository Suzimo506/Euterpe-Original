using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000FB")]
public class PnlCloudAskSelect : UISelectManage
{
	[Token(Token = "0x400062B")]
	[FieldOffset(Offset = "0x118")]
	public Button btnYes;

	[Token(Token = "0x400062C")]
	[FieldOffset(Offset = "0x120")]
	private Button m_CurrentSelect;

	[Address(RVA = "0x4FD230", Offset = "0x4FBA30", Length = "0x8C")]
	[Token(Token = "0x600074F")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x6000750")]
	[Address(RVA = "0x4FD3A0", Offset = "0x4FBBA0", Length = "0x162")]
	public override List<GameObject> SetSelectableObj()
	{
		return null;
	}

	[Address(RVA = "0x4FD2C0", Offset = "0x4FBAC0", Length = "0xD4")]
	[Token(Token = "0x6000751")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Token(Token = "0x6000752")]
	[Address(RVA = "0x4C5020", Offset = "0x4C3820", Length = "0x7")]
	public PnlCloudAskSelect()
	{
	}
}

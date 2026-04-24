using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008E8")]
public class PnlLevelConfigSelect : UISelectManage
{
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4002F5C")]
	private PnlLevelConfig m_PnlLevelConfig;

	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4002F5D")]
	public LevelConfigGridView levelConfigGridView;

	[Address(RVA = "0x67A490", Offset = "0x678C90", Length = "0xFA")]
	[Token(Token = "0x60050CB")]
	public override void OnEnablePnl()
	{
	}

	[Token(Token = "0x60050CC")]
	[Address(RVA = "0x67A9B0", Offset = "0x6791B0", Length = "0xA7")]
	public void ResetSelectObj()
	{
	}

	[Address(RVA = "0x67A850", Offset = "0x679050", Length = "0x27")]
	[Token(Token = "0x60050CD")]
	private void RefreshSelectedObj(List<GameObject> objs)
	{
	}

	[Address(RVA = "0x67A590", Offset = "0x678D90", Length = "0x2B8")]
	[Token(Token = "0x60050CE")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Token(Token = "0x60050CF")]
	[Address(RVA = "0x67A880", Offset = "0x679080", Length = "0x12E")]
	private void ResetNavigationToBtnConfirm(GameObject currentObj)
	{
	}

	[Token(Token = "0x60050D0")]
	[Address(RVA = "0x4C5020", Offset = "0x4C3820", Length = "0x7")]
	public PnlLevelConfigSelect()
	{
	}
}

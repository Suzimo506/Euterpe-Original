using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008EB")]
public class PopupPresetUISelectManage : UISelectManage
{
	[Token(Token = "0x4002F6A")]
	[FieldOffset(Offset = "0x118")]
	private PopupPresetConfigSelect m_MainPnl;

	[Address(RVA = "0x4CFC00", Offset = "0x4CE400", Length = "0xA2")]
	[Token(Token = "0x60050EC")]
	public override void OnEnablePnl()
	{
	}

	[Address(RVA = "0x4CFCB0", Offset = "0x4CE4B0", Length = "0x1B8")]
	[Token(Token = "0x60050ED")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Address(RVA = "0x4C5020", Offset = "0x4C3820", Length = "0x7")]
	[Token(Token = "0x60050EE")]
	public PopupPresetUISelectManage()
	{
	}
}

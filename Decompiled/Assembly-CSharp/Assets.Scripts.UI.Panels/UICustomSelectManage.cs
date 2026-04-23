using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008E4")]
public class UICustomSelectManage : UISelectManage
{
	[SerializeField]
	[Token(Token = "0x4002F3E")]
	[FieldOffset(Offset = "0x118")]
	private List<GameObject> m_CanSelectableObj;

	[Address(RVA = "0x4D43A0", Offset = "0x4D2BA0", Length = "0xA7")]
	[Token(Token = "0x60050A6")]
	public override List<GameObject> SetSelectableObj()
	{
		return null;
	}

	[Token(Token = "0x60050A7")]
	[Address(RVA = "0x4D4450", Offset = "0x4D2C50", Length = "0x6C")]
	public UICustomSelectManage()
	{
	}
}

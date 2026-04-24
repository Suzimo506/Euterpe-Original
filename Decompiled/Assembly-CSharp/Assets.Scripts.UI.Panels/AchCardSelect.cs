using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008ED")]
public class AchCardSelect : UISelectManage
{
	[Token(Token = "0x4002F76")]
	[FieldOffset(Offset = "0x118")]
	public List<GameObject> seletableObjs;

	[Token(Token = "0x60050F6")]
	[Address(RVA = "0x6BEC90", Offset = "0x6BD490", Length = "0x11E")]
	public override List<GameObject> SetSelectableObj()
	{
		return null;
	}

	[Token(Token = "0x60050F7")]
	[Address(RVA = "0x6BEDB0", Offset = "0x6BD5B0", Length = "0x6C")]
	public AchCardSelect()
	{
	}
}

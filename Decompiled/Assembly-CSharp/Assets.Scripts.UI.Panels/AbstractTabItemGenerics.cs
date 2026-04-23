using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008CB")]
public abstract class AbstractTabItemGenerics<T> : AbstractTabItem where T : AbstractTabContainer
{
	[Token(Token = "0x4002DDC")]
	[FieldOffset(Offset = "0x0")]
	protected T m_GenericsParent;

	[Token(Token = "0x6004F47")]
	[Address(RVA = "0x1355BC0", Offset = "0x13543C0", Length = "0xDB")]
	public override void InitItem(AbstractTabContainer parent, List<GameObject> selectedObjects, int index)
	{
	}

	[Token(Token = "0x6004F48")]
	[Address(RVA = "0x1355CA0", Offset = "0x13544A0", Length = "0x19")]
	protected AbstractTabItemGenerics()
	{
	}
}

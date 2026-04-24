using Cpp2ILInjected;
using UnityEngine;

namespace PeroTools.Commons;

[Token(Token = "0x2000440")]
public static class ComponentExtensions
{
	[Token(Token = "0x600324E")]
	[Address(RVA = "0x7E5250", Offset = "0x7E3A50", Length = "0x189")]
	public static T[] GetComponentsInDirectChildren<T>(this Component gameObject, bool includeInactive = false) where T : Component
	{
		return null;
	}
}

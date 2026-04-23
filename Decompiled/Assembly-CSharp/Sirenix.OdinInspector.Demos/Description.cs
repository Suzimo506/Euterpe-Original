using Cpp2ILInjected;
using UnityEngine;

namespace Sirenix.OdinInspector.Demos;

[Attribute(Name = "AddComponentMenu", RVA = "0x372D0", Offset = "0x366D0")]
[Token(Token = "0x200045D")]
public class Description : SerializedMonoBehaviour
{
	[Token(Token = "0x40017C3")]
	[Multiline]
	[Space]
	[FieldOffset(Offset = "0x58")]
	public string WideMultilineTextField;

	[Token(Token = "0x6003295")]
	[Address(RVA = "0x620150", Offset = "0x61E950", Length = "0x46")]
	public Description()
	{
	}
}

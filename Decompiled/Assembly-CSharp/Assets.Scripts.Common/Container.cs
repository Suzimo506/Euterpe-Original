using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Common;

[Token(Token = "0x200097A")]
[Attribute(Name = "DefaultMemberAttribute", RVA = "0x2060", Offset = "0x1460")]
public class Container : MonoBehaviour
{
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40033FB")]
	private Component[] components;

	[Token(Token = "0x17000906")]
	public Component Item
	{
		[Address(RVA = "0x597790", Offset = "0x595F90", Length = "0xAF")]
		[Token(Token = "0x6005664")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6005665")]
	public Container()
	{
	}
}

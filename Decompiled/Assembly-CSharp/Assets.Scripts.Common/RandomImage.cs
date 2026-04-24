using System.Collections.Generic;
using Cpp2ILInjected;
using Sirenix.OdinInspector;

namespace Assets.Scripts.Common;

[Attribute(Name = "RequireComponent", RVA = "0x1CD20", Offset = "0x1C120")]
[Token(Token = "0x2000981")]
public class RandomImage : SerializedMonoBehaviour
{
	[Token(Token = "0x400340F")]
	[FieldOffset(Offset = "0x58")]
	public List<string> texNames;

	[Address(RVA = "0x702690", Offset = "0x700E90", Length = "0xB5")]
	[Token(Token = "0x600568A")]
	private void Start()
	{
	}

	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	[Token(Token = "0x600568B")]
	public RandomImage()
	{
	}
}

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.PeroTools.Nice.Components;

[Token(Token = "0x200060A")]
public class SetToggleGroup : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400222C")]
	public Transform parent;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400222D")]
	public ToggleGroup group;

	[Address(RVA = "0x983C00", Offset = "0x982400", Length = "0xBB")]
	[Token(Token = "0x6003B25")]
	private void Start()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6003B26")]
	public SetToggleGroup()
	{
	}
}

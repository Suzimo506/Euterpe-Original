using System.Collections;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Specials;

[Token(Token = "0x2000877")]
public class PnlAchvFix : MonoBehaviour
{
	[Token(Token = "0x4002C33")]
	[FieldOffset(Offset = "0x18")]
	public GameObject target;

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x35B20", Offset = "0x34F20")]
	[Token(Token = "0x6004D3F")]
	[Address(RVA = "0x611010", Offset = "0x60F810", Length = "0x65")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6004D40")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlAchvFix()
	{
	}
}

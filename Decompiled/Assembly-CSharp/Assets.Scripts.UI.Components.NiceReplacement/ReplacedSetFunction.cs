using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Components.NiceReplacement;

[Token(Token = "0x20008C3")]
public class ReplacedSetFunction : MonoBehaviour, IPlayable
{
	[Token(Token = "0x4002DC4")]
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	private string m_EnumKey;

	[Token(Token = "0x6004F01")]
	[Address(RVA = "0x5B5300", Offset = "0x5B3B00", Length = "0x105")]
	public void Execute()
	{
	}

	[Token(Token = "0x6004F02")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public ReplacedSetFunction()
	{
	}
}

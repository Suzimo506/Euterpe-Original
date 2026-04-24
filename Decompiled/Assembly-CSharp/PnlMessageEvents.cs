using System.Collections;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200012A")]
public class PnlMessageEvents : MonoBehaviour
{
	[Token(Token = "0x4000756")]
	[FieldOffset(Offset = "0x18")]
	public AudioClip sfxClip;

	[Token(Token = "0x4000757")]
	[FieldOffset(Offset = "0x20")]
	public Button btnDone;

	[Token(Token = "0x600086F")]
	[Address(RVA = "0x7A83F0", Offset = "0x7A6BF0", Length = "0xB2")]
	private void Update()
	{
	}

	[Address(RVA = "0x7A82F0", Offset = "0x7A6AF0", Length = "0xFD")]
	[Token(Token = "0x6000870")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x7A84B0", Offset = "0x7A6CB0", Length = "0x65")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1EC30", Offset = "0x1E030")]
	[Token(Token = "0x6000871")]
	private IEnumerator Wait()
	{
		return null;
	}

	[Token(Token = "0x6000872")]
	[Address(RVA = "0x7A8250", Offset = "0x7A6A50", Length = "0x95")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000873")]
	public PnlMessageEvents()
	{
	}
}

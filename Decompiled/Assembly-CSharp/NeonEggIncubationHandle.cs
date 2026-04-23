using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200005A")]
public class NeonEggIncubationHandle : MonoBehaviour
{
	[Token(Token = "0x4000228")]
	[FieldOffset(Offset = "0x18")]
	public GameObject r6;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000229")]
	public GameObject saya;

	[Token(Token = "0x400022A")]
	[FieldOffset(Offset = "0x28")]
	public GameObject lin;

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x86A300", Offset = "0x868B00", Length = "0x1B7")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x86A4C0", Offset = "0x868CC0", Length = "0x1B7")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x86A680", Offset = "0x868E80", Length = "0x299")]
	private void OnFever()
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public NeonEggIncubationHandle()
	{
	}
}

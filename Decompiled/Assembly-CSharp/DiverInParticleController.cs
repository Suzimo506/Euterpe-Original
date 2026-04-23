using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000032")]
public class DiverInParticleController : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400014A")]
	public GameObject bubblesObj;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400014B")]
	public GameObject smokeObj;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400014C")]
	public GameObject diverInLightObj;

	[Token(Token = "0x400014D")]
	[FieldOffset(Offset = "0x30")]
	public float bubbleShowDelay;

	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400014E")]
	public float smokeShowDelay;

	[Token(Token = "0x400014F")]
	[FieldOffset(Offset = "0x38")]
	public float hideDelay;

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x441790", Offset = "0x43FF90", Length = "0x82")]
	public void Start()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x441700", Offset = "0x43FF00", Length = "0x20")]
	private void ShowBubbles()
	{
	}

	[Address(RVA = "0x441730", Offset = "0x43FF30", Length = "0x58")]
	[Token(Token = "0x600011B")]
	private void ShowSmoke()
	{
	}

	[Address(RVA = "0x4416B0", Offset = "0x43FEB0", Length = "0x4C")]
	[Token(Token = "0x600011C")]
	private void HideBubblesAndSmoke()
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x441820", Offset = "0x440020", Length = "0x1C")]
	public DiverInParticleController()
	{
	}
}

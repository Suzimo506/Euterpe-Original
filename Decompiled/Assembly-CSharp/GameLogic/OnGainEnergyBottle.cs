using Cpp2ILInjected;
using Spine;
using UnityEngine;

namespace GameLogic;

[Token(Token = "0x20004A1")]
public class OnGainEnergyBottle : DoNothing
{
	[Token(Token = "0x4001908")]
	private static GameObject recoveryEffect;

	[Token(Token = "0x60034D0")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void Start()
	{
	}

	[Token(Token = "0x60034D1")]
	[Address(RVA = "0x5D5430", Offset = "0x5D3C30", Length = "0x9E")]
	private void PlayRecoveryEffect()
	{
	}

	[Address(RVA = "0x5D5210", Offset = "0x5D3A10", Length = "0x21C")]
	[Token(Token = "0x60034D2")]
	public override void Do(TrackEntry entry)
	{
	}

	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	[Token(Token = "0x60034D3")]
	public OnGainEnergyBottle()
	{
	}
}

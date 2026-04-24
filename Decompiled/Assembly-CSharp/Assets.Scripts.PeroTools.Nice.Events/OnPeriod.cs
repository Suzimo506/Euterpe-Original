using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Events;

[DisallowMultipleComponent]
[Token(Token = "0x20005F9")]
public class OnPeriod : Event
{
	[Token(Token = "0x40021BF")]
	[FieldOffset(Offset = "0x70")]
	public float frequency;

	[Address(RVA = "0x9802B0", Offset = "0x97EAB0", Length = "0x4A")]
	[Token(Token = "0x6003A62")]
	protected override void OnEnter()
	{
	}

	[Address(RVA = "0x980300", Offset = "0x97EB00", Length = "0x3B")]
	[Token(Token = "0x6003A63")]
	protected override void OnExit()
	{
	}

	[Token(Token = "0x6003A64")]
	[Address(RVA = "0x97F310", Offset = "0x97DB10", Length = "0x7")]
	public OnPeriod()
	{
	}
}

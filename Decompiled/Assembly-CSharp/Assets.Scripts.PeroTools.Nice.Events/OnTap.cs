using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Events;

[Token(Token = "0x20005FD")]
[DisallowMultipleComponent]
public class OnTap : Event
{
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40021C1")]
	private float m_HardTime;

	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40021C2")]
	private float m_TapTime;

	[Address(RVA = "0x9804A0", Offset = "0x97ECA0", Length = "0xAD")]
	[Token(Token = "0x6003A6D")]
	protected override void OnEnter()
	{
	}

	[Address(RVA = "0x980550", Offset = "0x97ED50", Length = "0x4B")]
	[Token(Token = "0x6003A6E")]
	protected override void OnExit()
	{
	}

	[Address(RVA = "0x980480", Offset = "0x97EC80", Length = "0x1D")]
	[Token(Token = "0x6003A6F")]
	private void Do()
	{
	}

	[Token(Token = "0x6003A70")]
	[Address(RVA = "0x980610", Offset = "0x97EE10", Length = "0xE")]
	public OnTap()
	{
	}
}

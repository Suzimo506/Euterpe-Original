using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.PeroTools.Nice.Events;

[DisallowMultipleComponent]
[Token(Token = "0x20005FF")]
public class OnToggleOff : Event
{
	[SerializeField]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40021C5")]
	private Toggle m_Toggle;

	[Token(Token = "0x40021C6")]
	[FieldOffset(Offset = "0x78")]
	private bool m_IsOn;

	[Address(RVA = "0x980640", Offset = "0x97EE40", Length = "0x9B")]
	[Token(Token = "0x6003A76")]
	protected override void OnEnter()
	{
	}

	[Address(RVA = "0x9806E0", Offset = "0x97EEE0", Length = "0x91")]
	[Token(Token = "0x6003A77")]
	protected override void OnExit()
	{
	}

	[Address(RVA = "0x980620", Offset = "0x97EE20", Length = "0x1B")]
	[Token(Token = "0x6003A78")]
	private void Listener(bool isOn)
	{
	}

	[Address(RVA = "0x97F310", Offset = "0x97DB10", Length = "0x7")]
	[Token(Token = "0x6003A79")]
	public OnToggleOff()
	{
	}
}

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.PeroTools.Nice.Events;

[DisallowMultipleComponent]
[Token(Token = "0x20005FE")]
public class OnToggle : Event
{
	[SerializeField]
	[Token(Token = "0x40021C3")]
	[FieldOffset(Offset = "0x70")]
	private Toggle m_Toggle;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40021C4")]
	private bool m_IsOn;

	[Token(Token = "0x6003A72")]
	[Address(RVA = "0x9808F0", Offset = "0x97F0F0", Length = "0x9B")]
	protected override void OnEnter()
	{
	}

	[Token(Token = "0x6003A73")]
	[Address(RVA = "0x980990", Offset = "0x97F190", Length = "0x91")]
	protected override void OnExit()
	{
	}

	[Address(RVA = "0x9808E0", Offset = "0x97F0E0", Length = "0x10")]
	[Token(Token = "0x6003A74")]
	private void Listener(bool isOn)
	{
	}

	[Address(RVA = "0x97F310", Offset = "0x97DB10", Length = "0x7")]
	[Token(Token = "0x6003A75")]
	public OnToggle()
	{
	}
}

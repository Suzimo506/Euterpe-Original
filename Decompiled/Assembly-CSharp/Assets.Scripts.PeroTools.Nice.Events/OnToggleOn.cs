using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.PeroTools.Nice.Events;

[Token(Token = "0x2000600")]
[DisallowMultipleComponent]
public class OnToggleOn : Event
{
	[SerializeField]
	[Token(Token = "0x40021C7")]
	[FieldOffset(Offset = "0x70")]
	private Toggle m_Toggle;

	[Token(Token = "0x40021C8")]
	[FieldOffset(Offset = "0x78")]
	private bool m_IsOn;

	[Address(RVA = "0x9807A0", Offset = "0x97EFA0", Length = "0x9B")]
	[Token(Token = "0x6003A7A")]
	protected override void OnEnter()
	{
	}

	[Address(RVA = "0x980840", Offset = "0x97F040", Length = "0x91")]
	[Token(Token = "0x6003A7B")]
	protected override void OnExit()
	{
	}

	[Address(RVA = "0x980780", Offset = "0x97EF80", Length = "0x1A")]
	[Token(Token = "0x6003A7C")]
	private void Listener(bool isOn)
	{
	}

	[Token(Token = "0x6003A7D")]
	[Address(RVA = "0x97F310", Offset = "0x97DB10", Length = "0x7")]
	public OnToggleOn()
	{
	}
}

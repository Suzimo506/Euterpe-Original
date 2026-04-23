using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.PeroTools.Nice.Events;

[DisallowMultipleComponent]
[Token(Token = "0x20005FB")]
public class OnSliderValueChanged : Event
{
	[SerializeField]
	[Token(Token = "0x40021C0")]
	[FieldOffset(Offset = "0x70")]
	private Slider m_Slider;

	[Token(Token = "0x6003A67")]
	[Address(RVA = "0x980340", Offset = "0x97EB40", Length = "0x91")]
	protected override void OnEnter()
	{
	}

	[Address(RVA = "0x9803E0", Offset = "0x97EBE0", Length = "0x91")]
	[Token(Token = "0x6003A68")]
	protected override void OnExit()
	{
	}

	[Token(Token = "0x6003A69")]
	[Address(RVA = "0x97F300", Offset = "0x97DB00", Length = "0x7")]
	private void Listener(float value)
	{
	}

	[Address(RVA = "0x97F310", Offset = "0x97DB10", Length = "0x7")]
	[Token(Token = "0x6003A6A")]
	public OnSliderValueChanged()
	{
	}
}

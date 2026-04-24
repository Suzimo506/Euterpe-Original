using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.PeroTools.Nice.Events;

[DisallowMultipleComponent]
[Token(Token = "0x20005F0")]
public class OnClick : Event
{
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x40021B0")]
	private Button m_Button;

	[Address(RVA = "0x97F320", Offset = "0x97DB20", Length = "0x8C")]
	[Token(Token = "0x6003A3C")]
	protected override void OnEnter()
	{
	}

	[Token(Token = "0x6003A3D")]
	[Address(RVA = "0x97F3B0", Offset = "0x97DBB0", Length = "0x8C")]
	protected override void OnExit()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6003A3E")]
	protected override void OnExecute()
	{
	}

	[Address(RVA = "0x97F300", Offset = "0x97DB00", Length = "0x7")]
	[Token(Token = "0x6003A3F")]
	protected void Run()
	{
	}

	[Token(Token = "0x6003A40")]
	[Address(RVA = "0x97F310", Offset = "0x97DB10", Length = "0x7")]
	public OnClick()
	{
	}
}

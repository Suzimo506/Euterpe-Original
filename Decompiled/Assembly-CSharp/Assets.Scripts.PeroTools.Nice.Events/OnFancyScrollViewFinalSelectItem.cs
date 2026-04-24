using Assets.Scripts.PeroTools.Nice.Components;
using Assets.Scripts.PeroTools.Nice.Variables;
using Assets.Scripts.PeroTools.PreWarm;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Nice.Events;

[Attribute(Name = "RequireComponent", RVA = "0xA10F0", Offset = "0xA04F0")]
[Token(Token = "0x20005F7")]
public class OnFancyScrollViewFinalSelectItem : Event, IPreWarm
{
	[Token(Token = "0x40021BB")]
	[FieldOffset(Offset = "0x70")]
	private VariableBehaviour m_Variables;

	[Token(Token = "0x40021BC")]
	[FieldOffset(Offset = "0x78")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView target;

	[Token(Token = "0x6003A5C")]
	[Address(RVA = "0x97FF50", Offset = "0x97E750", Length = "0xD9")]
	private void OnFinalSelectItem(int i)
	{
	}

	[Token(Token = "0x6003A5D")]
	[Address(RVA = "0x97FDB0", Offset = "0x97E5B0", Length = "0x19E")]
	protected override void OnEnter()
	{
	}

	[Token(Token = "0x6003A5E")]
	[Address(RVA = "0x97F310", Offset = "0x97DB10", Length = "0x7")]
	public OnFancyScrollViewFinalSelectItem()
	{
	}
}

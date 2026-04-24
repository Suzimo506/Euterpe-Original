using Assets.Scripts.PeroTools.Nice.Components;
using Assets.Scripts.PeroTools.Nice.Variables;
using Assets.Scripts.PeroTools.PreWarm;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Nice.Events;

[Token(Token = "0x20005F8")]
[Attribute(Name = "RequireComponent", RVA = "0xA1440", Offset = "0xA0840")]
public class OnFancyScrollViewSelectItem : Event, IPreWarm
{
	[Token(Token = "0x40021BD")]
	[FieldOffset(Offset = "0x70")]
	private VariableBehaviour m_Variables;

	[Token(Token = "0x40021BE")]
	[FieldOffset(Offset = "0x78")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView target;

	[Address(RVA = "0x9801D0", Offset = "0x97E9D0", Length = "0xD9")]
	[Token(Token = "0x6003A5F")]
	private void OnSelectItem(int i)
	{
	}

	[Address(RVA = "0x980030", Offset = "0x97E830", Length = "0x19E")]
	[Token(Token = "0x6003A60")]
	protected override void OnEnter()
	{
	}

	[Address(RVA = "0x97F310", Offset = "0x97DB10", Length = "0x7")]
	[Token(Token = "0x6003A61")]
	public OnFancyScrollViewSelectItem()
	{
	}
}

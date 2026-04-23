using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Nice.Events;

[Token(Token = "0x20005F1")]
public class OnCustomEvent : Event
{
	[Token(Token = "0x40021B1")]
	[FieldOffset(Offset = "0x70")]
	public string eventType;

	[Address(RVA = "0x97F440", Offset = "0x97DC40", Length = "0x9F")]
	[Token(Token = "0x6003A41")]
	protected override void OnEnter()
	{
	}

	[Address(RVA = "0x97F4E0", Offset = "0x97DCE0", Length = "0x9F")]
	[Token(Token = "0x6003A42")]
	protected override void OnExit()
	{
	}

	[Address(RVA = "0x97F580", Offset = "0x97DD80", Length = "0x75")]
	[Token(Token = "0x6003A43")]
	private void Trigger(object sender, object reciever, params object[] args)
	{
	}

	[Token(Token = "0x6003A44")]
	[Address(RVA = "0x97F310", Offset = "0x97DB10", Length = "0x7")]
	public OnCustomEvent()
	{
	}
}

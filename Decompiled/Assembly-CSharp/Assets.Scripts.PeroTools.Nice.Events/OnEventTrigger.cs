using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.PeroTools.Nice.Events;

[Token(Token = "0x20005F5")]
[DisallowMultipleComponent]
public class OnEventTrigger : Event
{
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40021B2")]
	[SerializeField]
	private EventTriggerType m_Type;

	[Token(Token = "0x40021B3")]
	[FieldOffset(Offset = "0x78")]
	private EventTrigger.TriggerEvent m_EventCallback;

	[Address(RVA = "0x97F600", Offset = "0x97DE00", Length = "0x13D")]
	[Token(Token = "0x6003A4A")]
	protected override void OnEnter()
	{
	}

	[Token(Token = "0x6003A4B")]
	[Address(RVA = "0x97F300", Offset = "0x97DB00", Length = "0x7")]
	private void OnEventTriggerExecute(BaseEventData eventData)
	{
	}

	[Token(Token = "0x6003A4C")]
	[Address(RVA = "0x97F740", Offset = "0x97DF40", Length = "0x84")]
	protected override void OnExit()
	{
	}

	[Address(RVA = "0x97F310", Offset = "0x97DB10", Length = "0x7")]
	[Token(Token = "0x6003A4D")]
	public OnEventTrigger()
	{
	}
}

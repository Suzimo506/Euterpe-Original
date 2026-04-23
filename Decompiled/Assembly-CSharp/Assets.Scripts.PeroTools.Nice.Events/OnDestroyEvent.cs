using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Events;

[Token(Token = "0x20005F4")]
[DisallowMultipleComponent]
public abstract class OnDestroyEvent : Event
{
	[Token(Token = "0x6003A48")]
	[Address(RVA = "0x97F300", Offset = "0x97DB00", Length = "0x7")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x97F310", Offset = "0x97DB10", Length = "0x7")]
	[Token(Token = "0x6003A49")]
	protected OnDestroyEvent()
	{
	}
}

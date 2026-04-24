using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Events;

[DisallowMultipleComponent]
[Token(Token = "0x20005F2")]
public class OnDeactivate : Event
{
	[Token(Token = "0x6003A45")]
	[Address(RVA = "0x97F300", Offset = "0x97DB00", Length = "0x7")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6003A46")]
	[Address(RVA = "0x97F310", Offset = "0x97DB10", Length = "0x7")]
	public OnDeactivate()
	{
	}
}

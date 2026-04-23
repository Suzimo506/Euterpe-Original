using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Events;

[Token(Token = "0x20005EE")]
[DisallowMultipleComponent]
public class OnActivate : Event
{
	[Address(RVA = "0x97F300", Offset = "0x97DB00", Length = "0x7")]
	[Token(Token = "0x6003A38")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x97F310", Offset = "0x97DB10", Length = "0x7")]
	[Token(Token = "0x6003A39")]
	public OnActivate()
	{
	}
}

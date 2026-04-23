using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Events;

[DisallowMultipleComponent]
[Token(Token = "0x20005EF")]
public class OnAwake : Event
{
	[Address(RVA = "0x97F300", Offset = "0x97DB00", Length = "0x7")]
	[Token(Token = "0x6003A3A")]
	private void Awake()
	{
	}

	[Address(RVA = "0x97F310", Offset = "0x97DB10", Length = "0x7")]
	[Token(Token = "0x6003A3B")]
	public OnAwake()
	{
	}
}

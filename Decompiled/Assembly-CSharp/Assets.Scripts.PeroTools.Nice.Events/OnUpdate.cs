using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Events;

[Token(Token = "0x2000601")]
[DisallowMultipleComponent]
public class OnUpdate : Event
{
	[Address(RVA = "0x97F300", Offset = "0x97DB00", Length = "0x7")]
	[Token(Token = "0x6003A7E")]
	private void Update()
	{
	}

	[Token(Token = "0x6003A7F")]
	[Address(RVA = "0x97F310", Offset = "0x97DB10", Length = "0x7")]
	public OnUpdate()
	{
	}
}

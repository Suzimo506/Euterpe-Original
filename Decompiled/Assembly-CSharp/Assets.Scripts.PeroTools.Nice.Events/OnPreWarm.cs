using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Events;

[Token(Token = "0x20005FA")]
[DisallowMultipleComponent]
public class OnPreWarm : Event
{
	[Address(RVA = "0x97F300", Offset = "0x97DB00", Length = "0x7")]
	[Token(Token = "0x6003A65")]
	protected override void OnEnter()
	{
	}

	[Address(RVA = "0x97F310", Offset = "0x97DB10", Length = "0x7")]
	[Token(Token = "0x6003A66")]
	public OnPreWarm()
	{
	}
}

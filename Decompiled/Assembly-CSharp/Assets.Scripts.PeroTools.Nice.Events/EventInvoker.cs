using System;
using Cpp2ILInjected;
using UnityEngine.Events;

namespace Assets.Scripts.PeroTools.Nice.Events;

[Serializable]
[Token(Token = "0x20005ED")]
public class EventInvoker : UnityEvent<Event>
{
	[Address(RVA = "0x979A00", Offset = "0x978200", Length = "0x38")]
	[Token(Token = "0x6003A37")]
	public EventInvoker()
	{
		((UnityEvent<T0>)(object)this)._002Ector();
	}
}

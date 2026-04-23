using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace Assets.Scripts.PeroTools.Commons;

[Token(Token = "0x2000697")]
public class UIEventUtils
{
	[Address(RVA = "0x9D9F20", Offset = "0x9D8720", Length = "0x3B0")]
	[Token(Token = "0x6003DF0")]
	public static void PassEvent<T>(PointerEventData data, ExecuteEvents.EventFunction<T> function, List<GameObject> gameObjects) where T : IEventSystemHandler
	{
	}

	[Address(RVA = "0x938ED0", Offset = "0x9376D0", Length = "0x1CA")]
	[Token(Token = "0x6003DF1")]
	public static EventTrigger.TriggerEvent OnEvent(GameObject go, EventTriggerType eventType, UnityAction<BaseEventData> callback)
	{
		return null;
	}

	[Token(Token = "0x6003DF2")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public UIEventUtils()
	{
	}
}

namespace PeroTools2.Commons;

public class UIEventUtils
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public EventTriggerType eventType; //Field offset: 0x10

		public <>c__DisplayClass1_0() { }

		internal bool <OnEvent>b__0(Entry e) { }

	}


	public UIEventUtils() { }

	public static TriggerEvent OnEvent(GameObject go, EventTriggerType eventType, UnityAction<BaseEventData> callback) { }

	public static void PassEvent(PointerEventData data, EventFunction<T> function, List<GameObject> gameObjects) { }

}


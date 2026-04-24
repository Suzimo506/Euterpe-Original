namespace DYUnityLib;

internal class GTrigger
{
	private static AbstractEventHandler[] m_EventTriggers; //Field offset: 0x0
	private static GEventHandler<Decimal> MUSIC_STEP_EVENT; //Field offset: 0x8

	private static GTrigger() { }

	public GTrigger() { }

	public static void ClearEvent() { }

	public static void FireEvent(uint eventIndex, decimal tick) { }

	public static void FireEvent(uint eventIndex, uint arg) { }

	public static GEventHandler<T> RegEvent(uint eventIndex) { }

	public static void UnRegEvent(uint eventIndex) { }

}


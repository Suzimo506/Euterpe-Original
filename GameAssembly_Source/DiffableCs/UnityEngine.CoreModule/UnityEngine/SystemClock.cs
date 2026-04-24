namespace UnityEngine;

[VisibleToOtherModules]
internal class SystemClock
{
	private static readonly DateTime s_Epoch; //Field offset: 0x2C927B4

	public static DateTime now
	{
		 get { } //Length: 72
	}

	private static SystemClock() { }

	public static DateTime get_now() { }

}


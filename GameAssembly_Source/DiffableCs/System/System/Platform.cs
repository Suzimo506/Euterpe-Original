namespace System;

internal static class Platform
{
	private static bool checkedOS; //Field offset: 0x0
	private static bool isMacOS; //Field offset: 0x1
	private static bool isFreeBSD; //Field offset: 0x2

	public static bool IsFreeBSD
	{
		 get { } //Length: 89
	}

	public static bool IsMacOS
	{
		 get { } //Length: 119
	}

	private static void CheckOS() { }

	public static bool get_IsFreeBSD() { }

	public static bool get_IsMacOS() { }

	private static int uname(IntPtr buf) { }

}


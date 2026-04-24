namespace ZenFulcrum.EmbeddedBrowser;

internal static class KeyMappings
{
	private static Dictionary<KeyCode, Int32> mappings; //Field offset: 0x0
	private static Dictionary<Int32, KeyCode> reverseMappings; //Field offset: 0x8

	private static KeyMappings() { }

	public static KeyCode GetUnityKeyCode(int windowsKeyCode) { }

	public static int GetWindowsKeyCode(Event ev) { }

}


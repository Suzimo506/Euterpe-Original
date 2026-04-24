namespace Assets.Scripts.Native;

internal static class PeroNative
{
	private const string dllName = "PeroPlugin"; //Field offset: 0x16EC75
	private const int PATH_MAX = 260; //Field offset: 0x16ECC0
	private static bool s_Inited; //Field offset: 0x2CAA6C8

	private static bool CheckSteamAPIDll(string path) { }

	internal static bool CheckSteamDll(string path) { }

	private static bool InitNativePlugin(string className, string windowTitle) { }

	private static bool OpenFileDialog(string title, string startPath, string filter, bool modal, StringBuilder result, int resultSize) { }

	internal static string OpenFileDialog(string title, string startPath, string filter, bool modal) { }

	private static bool OpenFolderDialog(string title, string startPath, bool modal, StringBuilder result, int resultSize) { }

	internal static string OpenFolderDialog(string title, string startPath, bool modal) { }

	internal static bool PeroNativeInit() { }

	internal static void SetTitle(string name) { }

	internal static void SetWindow(int width, int height, bool border) { }

	private static bool SetWindowSize(int width, int height, bool border) { }

	private static bool SetWindowTitle(string windowTitle) { }

}


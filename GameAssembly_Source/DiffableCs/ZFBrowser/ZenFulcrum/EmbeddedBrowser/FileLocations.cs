namespace ZenFulcrum.EmbeddedBrowser;

public static class FileLocations
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, Char, String> <>9__5_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <GetFolderName>b__5_0(string current, char ch) { }

	}

	internal class CEFDirs
	{
		public string resourcesPath; //Field offset: 0x10
		public string binariesPath; //Field offset: 0x18
		public string localesPath; //Field offset: 0x20
		public string subprocessFile; //Field offset: 0x28
		public string logFile; //Field offset: 0x30
		public bool logFileIsUnityLog; //Field offset: 0x38

		public CEFDirs() { }

	}

	public const string SlaveExecutable = "ZFGameBrowser"; //Field offset: 0x6A3FC
	private static CEFDirs _dirs; //Field offset: 0x2C927B4

	public static CEFDirs Dirs
	{
		 get { } //Length: 106
	}

	public static CEFDirs get_Dirs() { }

	private static CEFDirs GetCEFDirs() { }

	private static string GetFolderName(string name) { }

}


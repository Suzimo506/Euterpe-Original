namespace System.IO;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public static class Directory
{
	public sealed class SearchData
	{
		public readonly string fullPath; //Field offset: 0x10
		public readonly string userPath; //Field offset: 0x18
		public readonly SearchOption searchOption; //Field offset: 0x20

		public SearchData(string fullPath, string userPath, SearchOption searchOption) { }

	}


	private static DirectoryInfo CreateDirectoriesInternal(string path) { }

	public static DirectoryInfo CreateDirectory(string path) { }

	public static void Delete(string path, bool recursive) { }

	public static void Delete(string path) { }

	public static IEnumerable<String> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption) { }

	private static IEnumerable<String> EnumerateFileSystemNames(string path, string searchPattern, SearchOption searchOption, bool includeFiles, bool includeDirs) { }

	public static bool Exists(string path) { }

	public static string GetCurrentDirectory() { }

	internal static string GetDemandDir(string fullPath, bool thisDirOnly) { }

	public static String[] GetDirectories(string path, string searchPattern) { }

	public static String[] GetDirectories(string path) { }

	public static String[] GetFiles(string path, string searchPattern, SearchOption searchOption) { }

	public static String[] GetFiles(string path, string searchPattern) { }

	public static String[] GetFiles(string path) { }

	public static DirectoryInfo GetParent(string path) { }

	internal static string InsecureGetCurrentDirectory() { }

	private static IEnumerable<String> InternalEnumerateDirectories(string path, string searchPattern, SearchOption searchOption) { }

	private static String[] InternalGetDirectories(string path, string searchPattern, SearchOption searchOption) { }

	internal static String[] InternalGetFileDirectoryNames(string path, string userPathOriginal, string searchPattern, bool includeFiles, bool includeDirs, SearchOption searchOption, bool checkHost) { }

	private static String[] InternalGetFiles(string path, string searchPattern, SearchOption searchOption) { }

	private static bool IsRootDirectory(string path) { }

	private static void RecursiveDelete(string path) { }

}


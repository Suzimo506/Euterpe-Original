namespace Sirenix.Utilities;

[Extension]
public static class PathUtilities
{

	public static bool CanMakeRelative(string absoluteParentPath, string absolutePath) { }

	public static string Combine(string a, string b) { }

	[Extension]
	public static DirectoryInfo FindParentDirectoryWithName(DirectoryInfo dir, string folderName) { }

	public static string GetDirectoryName(string x) { }

	[Extension]
	public static bool HasSubDirectory(DirectoryInfo parentDir, DirectoryInfo subDir) { }

	public static string MakeRelative(string absoluteParentPath, string absolutePath) { }

	public static bool TryMakeRelative(string absoluteParentPath, string absolutePath, out string relativePath) { }

}


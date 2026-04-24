namespace System.IO;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public static class File
{

	public static void Copy(string sourceFileName, string destFileName) { }

	public static void Copy(string sourceFileName, string destFileName, bool overwrite) { }

	public static FileStream Create(string path) { }

	public static FileStream Create(string path, int bufferSize) { }

	public static StreamWriter CreateText(string path) { }

	public static void Delete(string path) { }

	public static bool Exists(string path) { }

	internal static int FillAttributeInfo(string path, ref MonoIOStat data, bool tryagain, bool returnErrorOnNotFound) { }

	public static FileAttributes GetAttributes(string path) { }

	public static FileStream Open(string path, FileMode mode) { }

	public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share) { }

	public static FileStream OpenRead(string path) { }

	public static StreamReader OpenText(string path) { }

	public static FileStream OpenWrite(string path) { }

	public static Byte[] ReadAllBytes(string path) { }

	public static string ReadAllText(string path) { }

	public static void SetAttributes(string path, FileAttributes fileAttributes) { }

	public static void WriteAllBytes(string path, Byte[] bytes) { }

	public static void WriteAllText(string path, string contents, Encoding encoding) { }

	public static void WriteAllText(string path, string contents) { }

}


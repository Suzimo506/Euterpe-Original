namespace ThinkingSDK.PC.Storage;

public class ThinkingSDKFile
{

	public static void DeleteData(string key) { }

	public static void DeleteData(string prefix, string key) { }

	public static object GetData(string key, Type type) { }

	public static object GetData(string prefix, string key, Type type) { }

	public static string GetKey(string prefix, string key) { }

	public static void SaveData(string prefix, string key, object value) { }

	public static void SaveData(string key, object value) { }

}


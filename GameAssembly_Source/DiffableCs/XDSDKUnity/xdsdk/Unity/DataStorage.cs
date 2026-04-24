namespace xdsdk.Unity;

public static class DataStorage
{
	private static Dictionary<String, String> dataCache; //Field offset: 0x0
	private static Byte[] Keys; //Field offset: 0x8

	private static DataStorage() { }

	private static string DecodeString(string decryptString) { }

	private static string EncodeString(string encryptString) { }

	private static string GetMacAddress() { }

	public static string GetUniqueID() { }

	public static string LoadString(string key) { }

	private static string LoadStringFromCache(string key) { }

	public static void SaveString(string key, string value) { }

	private static void SaveStringToCache(string key, string value) { }

}


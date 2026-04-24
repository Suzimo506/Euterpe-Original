namespace FSG.iOSKeychain;

public static class Keychain
{
	private static Crypto mCryptoInstance; //Field offset: 0x2C927BC

	private static Keychain() { }

	public static void DeleteValue(string key) { }

	private static string GetPath(string key) { }

	public static string GetValue(string key) { }

	public static void SetValue(string key, string value) { }

}


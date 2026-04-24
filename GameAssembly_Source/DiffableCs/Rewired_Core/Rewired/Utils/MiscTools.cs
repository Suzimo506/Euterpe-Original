namespace Rewired.Utils;

[CustomClassObfuscation]
[CustomObfuscation]
internal static class MiscTools
{
	private static uint UfbDpTYcezabbPeLhPNXQJNYuQGf; //Field offset: 0x0
	private static uint NyRXSiYCabjIYNauVIndADwroKkX; //Field offset: 0x4
	private static uint pfQJYncTHWBSDgskSqetUwFUApxN; //Field offset: 0x8
	private static int VxHpyPQQaMagxQNVOYBdhxJxJXEI; //Field offset: 0xC
	private static int PaLgQccCYJjvOurAjGHcxfpPgRTY; //Field offset: 0x10
	private static int raDaBwAKXgjWijARZFDVwVbyfQiM; //Field offset: 0x14

	private static MiscTools() { }

	public static object Clone(object obj) { }

	public static T Clone(T obj) { }

	public static Guid CreateGuidHashSHA1(string text) { }

	public static Guid CreateGuidHashSHA256(string text) { }

	public static Guid CreateHIDProductGuid(int vendorId, int productId) { }

	public static T DeepClone(T obj) { }

	public static T DeepClone(T obj, bool createIfNull) { }

	public static T[] DeepClone(T[] obj) { }

	public static List<T> DeepClone(List<T> obj) { }

	public static Dictionary<TKey, TValue> DeepClone(Dictionary<TKey, TValue> dictionary) { }

	public static bool IsTickNewer(int tick1, int tick2) { }

	public static bool IsTickNewer(uint tick1, uint tick2) { }

	public static bool IsTickNewerOrEqualTo(int tick1, int tick2) { }

	public static bool IsTickNewerOrEqualTo(uint tick1, uint tick2) { }

	public static bool IsTickValid(uint tick) { }

	public static bool IsTickValid(int tick) { }

	public static bool IsValidGuid(string guid) { }

	public static void Swap(ref T a, ref T b) { }

	public static int Tick(int counter) { }

	public static uint Tick(uint counter) { }

	public static long TickDifference(uint tick1, uint tick2) { }

	public static int TickDifference(int tick1, int tick2) { }

	public static int TickPrev(int counter) { }

	public static uint TickPrev(uint counter) { }

	public static long ToLongUnchecked(object value) { }

}


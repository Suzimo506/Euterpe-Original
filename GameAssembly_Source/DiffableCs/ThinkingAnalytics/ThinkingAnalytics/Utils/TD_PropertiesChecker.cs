namespace ThinkingAnalytics.Utils;

public class TD_PropertiesChecker
{
	private static readonly Regex keyPattern; //Field offset: 0x6ADE6

	private static TD_PropertiesChecker() { }

	public static bool CheckProperties(Dictionary<String, V> properties) { }

	public static bool CheckProperties(List<Object> properties) { }

	public static bool CheckProperties(List<String> properties) { }

	public static bool CheckProperties(string properties) { }

	public static bool CheckProperties(double properties) { }

	public static bool CheckString(string eventName) { }

	public static bool IsDictionary(object obj) { }

	public static bool IsList(object obj) { }

	public static bool IsNumeric(object obj) { }

	public static bool IsString(object obj) { }

	public static void MergeProperties(Dictionary<String, Object> source, Dictionary<String, Object> dest) { }

}


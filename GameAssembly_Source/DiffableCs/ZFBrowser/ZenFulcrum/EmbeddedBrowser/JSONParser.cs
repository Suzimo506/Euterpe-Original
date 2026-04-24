namespace ZenFulcrum.EmbeddedBrowser;

internal static class JSONParser
{
	private const int TOKEN_NONE = 0; //Field offset: 0x0
	private const int TOKEN_CURLY_OPEN = 1; //Field offset: 0x0
	private const int TOKEN_CURLY_CLOSE = 2; //Field offset: 0x0
	private const int TOKEN_SQUARED_OPEN = 3; //Field offset: 0x0
	private const int TOKEN_SQUARED_CLOSE = 4; //Field offset: 0x0
	private const int TOKEN_COLON = 5; //Field offset: 0x0
	private const int TOKEN_COMMA = 6; //Field offset: 0x0
	private const int TOKEN_STRING = 7; //Field offset: 0x0
	private const int TOKEN_NUMBER = 8; //Field offset: 0x0
	private const int TOKEN_TRUE = 9; //Field offset: 0x0
	private const int TOKEN_FALSE = 10; //Field offset: 0x0
	private const int TOKEN_NULL = 11; //Field offset: 0x0
	private const int BUILDER_CAPACITY = 2000; //Field offset: 0x0
	private static readonly Char[] EscapeTable; //Field offset: 0x0
	private static readonly Char[] EscapeCharacters; //Field offset: 0x8

	private static JSONParser() { }

	private static string ConvertFromUtf32(int utf32) { }

	private static void EatWhitespace(Char[] json, ref int index) { }

	public static string EscapeToJavascriptString(string jsonString) { }

	private static int GetLastIndexOfNumber(Char[] json, int index) { }

	private static int LookAhead(Char[] json, int index) { }

	private static int NextToken(Char[] json, ref int index) { }

	public static JSONNode Parse(string json) { }

	private static JSONNode ParseArray(Char[] json, ref int index, ref bool success) { }

	private static JSONNode ParseNumber(Char[] json, ref int index, ref bool success) { }

	private static JSONNode ParseObject(Char[] json, ref int index, ref bool success) { }

	private static JSONNode ParseString(Char[] json, ref int index, ref bool success) { }

	private static JSONNode ParseValue(Char[] json, ref int index, ref bool success) { }

	public static string Serialize(JSONNode node) { }

	private static bool SerializeArray(IEnumerable<JSONNode> anArray, StringBuilder builder) { }

	private static bool SerializeNumber(double number, StringBuilder builder) { }

	private static bool SerializeObject(IEnumerable<String> keys, IEnumerable<JSONNode> values, StringBuilder builder) { }

	private static bool SerializeString(string aString, StringBuilder builder) { }

	private static bool SerializeValue(JSONNode value, StringBuilder builder) { }

	public static bool TryDeserializeObject(string json, out JSONNode obj) { }

}


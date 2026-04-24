namespace ThinkingSDK.PC.Utils;

public class ThinkingSDKJSON
{
	private sealed class Parser : IDisposable
	{
		private enum TOKEN
		{
			NONE = 0,
			CURLY_OPEN = 1,
			CURLY_CLOSE = 2,
			SQUARED_OPEN = 3,
			SQUARED_CLOSE = 4,
			COLON = 5,
			COMMA = 6,
			STRING = 7,
			NUMBER = 8,
			TRUE = 9,
			FALSE = 10,
			NULL = 11,
		}

		private StringReader json; //Field offset: 0x10

		private char NextChar
		{
			private get { } //Length: 112
		}

		private TOKEN NextToken
		{
			private get { } //Length: 388
		}

		private string NextWord
		{
			private get { } //Length: 290
		}

		private char PeekChar
		{
			private get { } //Length: 112
		}

		private Parser(string jsonString) { }

		public override void Dispose() { }

		private void EatWhitespace() { }

		private char get_NextChar() { }

		private TOKEN get_NextToken() { }

		private string get_NextWord() { }

		private char get_PeekChar() { }

		public static bool IsWordBreak(char c) { }

		public static Dictionary<String, Object> Parse(string jsonString) { }

		private List<Object> ParseArray() { }

		private object ParseByToken(TOKEN token) { }

		private object ParseNumber() { }

		private Dictionary<String, Object> ParseObject() { }

		private string ParseString() { }

		private object ParseValue() { }

	}

	private sealed class Serializer
	{
		private StringBuilder builder; //Field offset: 0x10
		private Func<DateTime, String> func; //Field offset: 0x18

		private Serializer() { }

		public static string Serialize(object obj, Func<DateTime, String> func) { }

		private void SerializeArray(IList anArray) { }

		private void SerializeObject(IDictionary obj) { }

		private void SerializeOther(object value) { }

		private void SerializeString(string str) { }

		private void SerializeValue(object value) { }

	}


	public static Dictionary<String, Object> Deserialize(string json) { }

	public static string Serialize(object obj, Func<DateTime, String> func = null) { }

}


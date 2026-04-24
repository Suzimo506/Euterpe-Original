namespace Newtonsoft.Json.Linq;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class JTokenReader : JsonReader, IJsonLineInfo
{
	private readonly JToken _root; //Field offset: 0x78
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string _initialPath; //Field offset: 0x80
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private JToken _parent; //Field offset: 0x88
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private JToken _current; //Field offset: 0x90

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public JToken CurrentToken
	{
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 8
	}

	private override int Newtonsoft.Json.IJsonLineInfo.LineNumber
	{
		private get { } //Length: 84
	}

	private override int Newtonsoft.Json.IJsonLineInfo.LinePosition
	{
		private get { } //Length: 84
	}

	public virtual string Path
	{
		 get { } //Length: 235
	}

	public JTokenReader(JToken token) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public JToken get_CurrentToken() { }

	public virtual string get_Path() { }

	private Nullable<JsonToken> GetEndToken(JContainer c) { }

	private override int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	private override int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	private override bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	public virtual bool Read() { }

	private bool ReadInto(JContainer c) { }

	private bool ReadOver(JToken t) { }

	private bool ReadToEnd() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string SafeToString(object value) { }

	private bool SetEnd(JContainer c) { }

	private void SetToken(JToken token) { }

}


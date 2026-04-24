namespace Newtonsoft.Json.Utilities;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class Base64Encoder
{
	private readonly Char[] _charsLine; //Field offset: 0x10
	private readonly TextWriter _writer; //Field offset: 0x18
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Byte[] _leftOverBytes; //Field offset: 0x20
	private int _leftOverBytesCount; //Field offset: 0x28

	public Base64Encoder(TextWriter writer) { }

	public void Encode(Byte[] buffer, int index, int count) { }

	public void Flush() { }

	private bool FulfillFromLeftover(Byte[] buffer, int index, ref int count) { }

	private void StoreLeftOverBytes(Byte[] buffer, int index, ref int count) { }

	private void ValidateEncode(Byte[] buffer, int index, int count) { }

	private void WriteChars(Char[] chars, int index, int count) { }

}


namespace Google.Protobuf;

internal static class ParsingPrimitivesMessages
{
	private static readonly Byte[] ZeroLengthMessageStreamData; //Field offset: 0x2C927B4

	private static ParsingPrimitivesMessages() { }

	private static void CheckLastTagWas(ref ParserInternalState state, uint expectedTag) { }

	public static void CheckReadEndOfStreamTag(ref ParserInternalState state) { }

	public static void ReadGroup(ref ParseContext ctx, int fieldNumber, UnknownFieldSet set) { }

	public static KeyValuePair<TKey, TValue> ReadMapEntry(ref ParseContext ctx, Codec<TKey, TValue> codec) { }

	public static void ReadMessage(ref ParseContext ctx, IMessage message) { }

	public static void ReadRawMessage(ref ParseContext ctx, IMessage message) { }

	public static void SkipGroup(ref ReadOnlySpan<Byte>& buffer, ref ParserInternalState state, uint startGroupTag) { }

	public static void SkipLastField(ref ReadOnlySpan<Byte>& buffer, ref ParserInternalState state) { }

}


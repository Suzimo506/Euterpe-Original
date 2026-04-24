namespace Google.Protobuf;

public static class FieldCodec
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static ValueReader<String> <>9__16_0; //Field offset: 0x8
		public static ValueWriter<String> <>9__16_1; //Field offset: 0x10
		public static ValueReader<Int32> <>9__19_0; //Field offset: 0x18
		public static ValueWriter<Int32> <>9__19_1; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal int <ForInt32>b__19_0(ref ParseContext ctx) { }

		internal void <ForInt32>b__19_1(ref WriteContext output, int value) { }

		internal string <ForString>b__16_0(ref ParseContext ctx) { }

		internal void <ForString>b__16_1(ref WriteContext ctx, string value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__32
	{
		public static readonly <>c__32<T> <>9; //Field offset: 0x0
		public static ValueWriter<T> <>9__32_1; //Field offset: 0x0
		public static ValuesMerger<T> <>9__32_3; //Field offset: 0x0
		public static Func<T, Int32> <>9__32_4; //Field offset: 0x0

		private static <>c__32`1() { }

		public <>c__32`1() { }

		internal void <ForMessage>b__32_1(ref WriteContext output, T value) { }

		internal bool <ForMessage>b__32_3(ref T v, T v2) { }

		internal int <ForMessage>b__32_4(T message) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public MessageParser<T> parser; //Field offset: 0x0

		public <>c__DisplayClass32_0`1() { }

		internal T <ForMessage>b__0(ref ParseContext ctx) { }

		internal void <ForMessage>b__2(ref ParseContext ctx, ref T v) { }

	}


	public static FieldCodec<Int32> ForInt32(uint tag) { }

	public static FieldCodec<Int32> ForInt32(uint tag, int defaultValue) { }

	public static FieldCodec<T> ForMessage(uint tag, MessageParser<T> parser) { }

	public static FieldCodec<String> ForString(uint tag) { }

	public static FieldCodec<String> ForString(uint tag, string defaultValue) { }

}


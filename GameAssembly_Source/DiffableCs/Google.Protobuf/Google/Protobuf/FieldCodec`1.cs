namespace Google.Protobuf;

public sealed class FieldCodec
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<T> <>9; //Field offset: 0x0
		public static ValuesMerger<T> <>9__39_1; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__39_1(ref T v, T v2) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass39_0
	{
		public ValueReader<T> reader; //Field offset: 0x0

		public <>c__DisplayClass39_0() { }

		internal void <.ctor>b__0(ref ParseContext ctx, ref T v) { }

	}

	public sealed class InputMerger : MulticastDelegate
	{

		public InputMerger(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref ParseContext ctx, ref T value, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref ParseContext ctx, ref T value, IAsyncResult result) { }

		public override void Invoke(ref ParseContext ctx, ref T value) { }

	}

	public sealed class ValuesMerger : MulticastDelegate
	{

		public ValuesMerger(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref T value, T other, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref T value, IAsyncResult result) { }

		public override bool Invoke(ref T value, T other) { }

	}

	private static readonly EqualityComparer<T> EqualityComparer; //Field offset: 0x0
	private static readonly T DefaultDefault; //Field offset: 0x0
	private static readonly bool TypeSupportsPacking; //Field offset: 0x0
	[CompilerGenerated]
	private readonly bool <PackedRepeatedField>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly ValueWriter<T> <ValueWriter>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly Func<T, Int32> <ValueSizeCalculator>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly ValueReader<T> <ValueReader>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly InputMerger<T> <ValueMerger>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly ValuesMerger<T> <FieldMerger>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly int <FixedSize>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly uint <Tag>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly uint <EndTag>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly T <DefaultValue>k__BackingField; //Field offset: 0x0
	private readonly int tagSize; //Field offset: 0x0

	internal T DefaultValue
	{
		[CompilerGenerated]
		internal get { } //Length: 4
	}

	internal uint EndTag
	{
		[CompilerGenerated]
		internal get { } //Length: 4
	}

	internal int FixedSize
	{
		[CompilerGenerated]
		internal get { } //Length: 4
	}

	internal bool PackedRepeatedField
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	internal uint Tag
	{
		[CompilerGenerated]
		internal get { } //Length: 4
	}

	internal ValueReader<T> ValueReader
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	internal Func<T, Int32> ValueSizeCalculator
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	internal ValueWriter<T> ValueWriter
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	private static FieldCodec`1() { }

	internal FieldCodec`1(ValueReader<T> reader, ValueWriter<T> writer, InputMerger<T> inputMerger, ValuesMerger<T> valuesMerger, Func<T, Int32> sizeCalculator, uint tag, uint endTag, T defaultValue) { }

	internal FieldCodec`1(ValueReader<T> reader, ValueWriter<T> writer, InputMerger<T> inputMerger, ValuesMerger<T> valuesMerger, Func<T, Int32> sizeCalculator, uint tag, uint endTag = 0) { }

	internal FieldCodec`1(ValueReader<T> reader, ValueWriter<T> writer, Func<T, Int32> sizeCalculator, uint tag, T defaultValue) { }

	public int CalculateSizeWithTag(T value) { }

	[CompilerGenerated]
	internal T get_DefaultValue() { }

	[CompilerGenerated]
	internal uint get_EndTag() { }

	[CompilerGenerated]
	internal int get_FixedSize() { }

	[CompilerGenerated]
	internal bool get_PackedRepeatedField() { }

	[CompilerGenerated]
	internal uint get_Tag() { }

	[CompilerGenerated]
	internal ValueReader<T> get_ValueReader() { }

	[CompilerGenerated]
	internal Func<T, Int32> get_ValueSizeCalculator() { }

	[CompilerGenerated]
	internal ValueWriter<T> get_ValueWriter() { }

	private bool IsDefault(T value) { }

	internal static bool IsPackedRepeatedField(uint tag) { }

	public T Read(CodedInputStream input) { }

	public T Read(ref ParseContext ctx) { }

	public void WriteTagAndValue(ref WriteContext ctx, T value) { }

}


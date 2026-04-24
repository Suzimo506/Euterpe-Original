namespace System.Diagnostics.Tracing;

internal class TraceLoggingMetadataCollector
{
	private class Impl
	{
		internal readonly List<FieldMetadata> fields; //Field offset: 0x10
		internal short scratchSize; //Field offset: 0x18
		internal sbyte dataCount; //Field offset: 0x1A
		internal sbyte pinCount; //Field offset: 0x1B
		private int bufferNesting; //Field offset: 0x1C
		private bool scalar; //Field offset: 0x20

		public Impl() { }

		public void AddNonscalar() { }

		public void AddScalar(int size) { }

		public void BeginBuffered() { }

		public int Encode(Byte[] metadata) { }

		public void EndBuffered() { }

	}

	private readonly Impl impl; //Field offset: 0x10
	private readonly FieldMetadata currentGroup; //Field offset: 0x18
	private int bufferedArrayFieldCount; //Field offset: 0x20
	[CompilerGenerated]
	private EventFieldTags <Tags>k__BackingField; //Field offset: 0x24

	private bool BeginningBufferedArray
	{
		private get { } //Length: 8
	}

	internal int DataCount
	{
		internal get { } //Length: 27
	}

	internal int PinCount
	{
		internal get { } //Length: 27
	}

	internal int ScratchSize
	{
		internal get { } //Length: 27
	}

	internal EventFieldTags Tags
	{
		[CompilerGenerated]
		internal get { } //Length: 4
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal TraceLoggingMetadataCollector() { }

	private TraceLoggingMetadataCollector(TraceLoggingMetadataCollector other, FieldMetadata group) { }

	public void AddArray(string name, TraceLoggingDataType type) { }

	public void AddBinary(string name, TraceLoggingDataType type) { }

	private void AddField(FieldMetadata fieldMetadata) { }

	public TraceLoggingMetadataCollector AddGroup(string name) { }

	public void AddScalar(string name, TraceLoggingDataType type) { }

	public void BeginBufferedArray() { }

	public void EndBufferedArray() { }

	private bool get_BeginningBufferedArray() { }

	internal int get_DataCount() { }

	internal int get_PinCount() { }

	internal int get_ScratchSize() { }

	[CompilerGenerated]
	internal EventFieldTags get_Tags() { }

	internal Byte[] GetMetadata() { }

	[CompilerGenerated]
	internal void set_Tags(EventFieldTags value) { }

}


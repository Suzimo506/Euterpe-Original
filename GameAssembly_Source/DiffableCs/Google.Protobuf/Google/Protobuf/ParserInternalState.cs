namespace Google.Protobuf;

internal struct ParserInternalState
{
	internal int bufferPos; //Field offset: 0x0
	internal int bufferSize; //Field offset: 0x4
	internal int bufferSizeAfterLimit; //Field offset: 0x8
	internal int currentLimit; //Field offset: 0xC
	internal int totalBytesRetired; //Field offset: 0x10
	internal int recursionDepth; //Field offset: 0x14
	internal SegmentedBufferHelper segmentedBufferHelper; //Field offset: 0x18
	internal uint lastTag; //Field offset: 0x68
	internal uint nextTag; //Field offset: 0x6C
	internal bool hasNextTag; //Field offset: 0x70
	internal int sizeLimit; //Field offset: 0x74
	internal int recursionLimit; //Field offset: 0x78
	[CompilerGenerated]
	private bool <DiscardUnknownFields>k__BackingField; //Field offset: 0x7C
	[CompilerGenerated]
	private ExtensionRegistry <ExtensionRegistry>k__BackingField; //Field offset: 0x80

	internal CodedInputStream CodedInputStream
	{
		internal get { } //Length: 5
	}

	internal bool DiscardUnknownFields
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal ExtensionRegistry ExtensionRegistry
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 12
	}

	internal CodedInputStream get_CodedInputStream() { }

	[CompilerGenerated]
	internal bool get_DiscardUnknownFields() { }

	[CompilerGenerated]
	internal ExtensionRegistry get_ExtensionRegistry() { }

	[CompilerGenerated]
	internal void set_DiscardUnknownFields(bool value) { }

	[CompilerGenerated]
	internal void set_ExtensionRegistry(ExtensionRegistry value) { }

}


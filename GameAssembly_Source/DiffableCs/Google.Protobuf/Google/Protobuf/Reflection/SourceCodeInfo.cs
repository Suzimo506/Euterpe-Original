namespace Google.Protobuf.Reflection;

public sealed class SourceCodeInfo : IMessage<SourceCodeInfo>, IMessage, IEquatable<SourceCodeInfo>, IDeepCloneable<SourceCodeInfo>, IBufferMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x2C927A8

		private static <>c() { }

		public <>c() { }

		internal SourceCodeInfo <.cctor>b__28_0() { }

	}

	[DebuggerNonUserCode]
	internal static class Types
	{
		internal sealed class Location : IMessage<Location>, IMessage, IEquatable<Location>, IDeepCloneable<Location>, IBufferMessage
		{
			[CompilerGenerated]
			private sealed class <>c
			{
				public static readonly <>c <>9; //Field offset: 0x69CDE

				private static <>c() { }

				public <>c() { }

				internal Location <.cctor>b__55_0() { }

			}

			private static readonly MessageParser<Location> _parser; //Field offset: 0x0
			private static readonly FieldCodec<Int32> _repeated_path_codec; //Field offset: 0x8
			private static readonly FieldCodec<Int32> _repeated_span_codec; //Field offset: 0x10
			private static readonly string LeadingCommentsDefaultValue; //Field offset: 0x18
			private static readonly string TrailingCommentsDefaultValue; //Field offset: 0x20
			private static readonly FieldCodec<String> _repeated_leadingDetachedComments_codec; //Field offset: 0x28
			private UnknownFieldSet _unknownFields; //Field offset: 0x10
			private readonly RepeatedField<Int32> path_; //Field offset: 0x18
			private readonly RepeatedField<Int32> span_; //Field offset: 0x20
			private string leadingComments_; //Field offset: 0x28
			private string trailingComments_; //Field offset: 0x30
			private readonly RepeatedField<String> leadingDetachedComments_; //Field offset: 0x38

			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				 get { } //Length: 108
			}

			[DebuggerNonUserCode]
			public bool HasLeadingComments
			{
				 get { } //Length: 9
			}

			[DebuggerNonUserCode]
			public bool HasTrailingComments
			{
				 get { } //Length: 9
			}

			[DebuggerNonUserCode]
			public string LeadingComments
			{
				 get { } //Length: 102
				 set { } //Length: 90
			}

			[DebuggerNonUserCode]
			public RepeatedField<String> LeadingDetachedComments
			{
				 get { } //Length: 5
			}

			[DebuggerNonUserCode]
			public static MessageParser<Location> Parser
			{
				 get { } //Length: 86
			}

			[DebuggerNonUserCode]
			public RepeatedField<Int32> Path
			{
				 get { } //Length: 5
			}

			[DebuggerNonUserCode]
			private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
			{
				private get { } //Length: 165
			}

			[DebuggerNonUserCode]
			public RepeatedField<Int32> Span
			{
				 get { } //Length: 5
			}

			[DebuggerNonUserCode]
			public string TrailingComments
			{
				 get { } //Length: 102
				 set { } //Length: 90
			}

			private static Location() { }

			[DebuggerNonUserCode]
			public Location() { }

			[DebuggerNonUserCode]
			public Location(Location other) { }

			[DebuggerNonUserCode]
			public override int CalculateSize() { }

			[DebuggerNonUserCode]
			public override Location Clone() { }

			[DebuggerNonUserCode]
			public override bool Equals(Location other) { }

			[DebuggerNonUserCode]
			public virtual bool Equals(object other) { }

			public static MessageDescriptor get_Descriptor() { }

			public bool get_HasLeadingComments() { }

			public bool get_HasTrailingComments() { }

			public string get_LeadingComments() { }

			public RepeatedField<String> get_LeadingDetachedComments() { }

			public static MessageParser<Location> get_Parser() { }

			public RepeatedField<Int32> get_Path() { }

			public RepeatedField<Int32> get_Span() { }

			public string get_TrailingComments() { }

			[DebuggerNonUserCode]
			public virtual int GetHashCode() { }

			[DebuggerNonUserCode]
			public override void MergeFrom(Location other) { }

			[DebuggerNonUserCode]
			public override void MergeFrom(CodedInputStream input) { }

			[DebuggerNonUserCode]
			private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

			[DebuggerNonUserCode]
			private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

			private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

			public void set_LeadingComments(string value) { }

			public void set_TrailingComments(string value) { }

			[DebuggerNonUserCode]
			public virtual string ToString() { }

			[DebuggerNonUserCode]
			public override void WriteTo(CodedOutputStream output) { }

		}


	}

	private static readonly MessageParser<SourceCodeInfo> _parser; //Field offset: 0x0
	private static readonly FieldCodec<Location> _repeated_location_codec; //Field offset: 0x8
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	private readonly RepeatedField<Location> location_; //Field offset: 0x18

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 191
	}

	[DebuggerNonUserCode]
	public RepeatedField<Location> Location
	{
		 get { } //Length: 5
	}

	[DebuggerNonUserCode]
	public static MessageParser<SourceCodeInfo> Parser
	{
		 get { } //Length: 86
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 72
	}

	private static SourceCodeInfo() { }

	[DebuggerNonUserCode]
	public SourceCodeInfo() { }

	[DebuggerNonUserCode]
	public SourceCodeInfo(SourceCodeInfo other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override SourceCodeInfo Clone() { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	[DebuggerNonUserCode]
	public override bool Equals(SourceCodeInfo other) { }

	public static MessageDescriptor get_Descriptor() { }

	public RepeatedField<Location> get_Location() { }

	public static MessageParser<SourceCodeInfo> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(SourceCodeInfo other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}


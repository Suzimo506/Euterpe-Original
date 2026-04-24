namespace Google.Protobuf.Reflection;

public sealed class EnumDescriptorProto : IMessage<EnumDescriptorProto>, IMessage, IEquatable<EnumDescriptorProto>, IDeepCloneable<EnumDescriptorProto>, IBufferMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x2C927BC

		private static <>c() { }

		public <>c() { }

		internal EnumDescriptorProto <.cctor>b__52_0() { }

	}

	[DebuggerNonUserCode]
	internal static class Types
	{
		internal sealed class EnumReservedRange : IMessage<EnumReservedRange>, IMessage, IEquatable<EnumReservedRange>, IDeepCloneable<EnumReservedRange>, IBufferMessage
		{
			[CompilerGenerated]
			private sealed class <>c
			{
				public static readonly <>c <>9; //Field offset: 0x69B03

				private static <>c() { }

				public <>c() { }

				internal EnumReservedRange <.cctor>b__41_0() { }

			}

			private static readonly MessageParser<EnumReservedRange> _parser; //Field offset: 0x0
			private static readonly int StartDefaultValue; //Field offset: 0x8
			private static readonly int EndDefaultValue; //Field offset: 0xC
			private UnknownFieldSet _unknownFields; //Field offset: 0x10
			private int _hasBits0; //Field offset: 0x18
			private int start_; //Field offset: 0x1C
			private int end_; //Field offset: 0x20

			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				 get { } //Length: 108
			}

			[DebuggerNonUserCode]
			public int End
			{
				 get { } //Length: 107
				 set { } //Length: 8
			}

			[DebuggerNonUserCode]
			public bool HasEnd
			{
				 get { } //Length: 8
			}

			[DebuggerNonUserCode]
			public bool HasStart
			{
				 get { } //Length: 7
			}

			[DebuggerNonUserCode]
			public static MessageParser<EnumReservedRange> Parser
			{
				 get { } //Length: 182
			}

			[DebuggerNonUserCode]
			private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
			{
				private get { } //Length: 165
			}

			[DebuggerNonUserCode]
			public int Start
			{
				 get { } //Length: 107
				 set { } //Length: 102
			}

			private static EnumReservedRange() { }

			[DebuggerNonUserCode]
			public EnumReservedRange() { }

			[DebuggerNonUserCode]
			public EnumReservedRange(EnumReservedRange other) { }

			[DebuggerNonUserCode]
			public override int CalculateSize() { }

			[DebuggerNonUserCode]
			public override EnumReservedRange Clone() { }

			[DebuggerNonUserCode]
			public override bool Equals(EnumReservedRange other) { }

			[DebuggerNonUserCode]
			public virtual bool Equals(object other) { }

			public static MessageDescriptor get_Descriptor() { }

			public int get_End() { }

			public bool get_HasEnd() { }

			public bool get_HasStart() { }

			public static MessageParser<EnumReservedRange> get_Parser() { }

			public int get_Start() { }

			[DebuggerNonUserCode]
			public virtual int GetHashCode() { }

			[DebuggerNonUserCode]
			public override void MergeFrom(EnumReservedRange other) { }

			[DebuggerNonUserCode]
			public override void MergeFrom(CodedInputStream input) { }

			[DebuggerNonUserCode]
			private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

			[DebuggerNonUserCode]
			private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

			private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

			public void set_End(int value) { }

			public void set_Start(int value) { }

			[DebuggerNonUserCode]
			public virtual string ToString() { }

			[DebuggerNonUserCode]
			public override void WriteTo(CodedOutputStream output) { }

		}


	}

	private static readonly MessageParser<EnumDescriptorProto> _parser; //Field offset: 0x0
	private static readonly string NameDefaultValue; //Field offset: 0x8
	private static readonly FieldCodec<EnumValueDescriptorProto> _repeated_value_codec; //Field offset: 0x10
	private static readonly FieldCodec<EnumReservedRange> _repeated_reservedRange_codec; //Field offset: 0x18
	private static readonly FieldCodec<String> _repeated_reservedName_codec; //Field offset: 0x20
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	private string name_; //Field offset: 0x18
	private readonly RepeatedField<EnumValueDescriptorProto> value_; //Field offset: 0x20
	private EnumOptions options_; //Field offset: 0x28
	private readonly RepeatedField<EnumReservedRange> reservedRange_; //Field offset: 0x30
	private readonly RepeatedField<String> reservedName_; //Field offset: 0x38

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 191
	}

	[DebuggerNonUserCode]
	public bool HasName
	{
		 get { } //Length: 9
	}

	[DebuggerNonUserCode]
	public string Name
	{
		 get { } //Length: 102
		 set { } //Length: 90
	}

	[DebuggerNonUserCode]
	public EnumOptions Options
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	[DebuggerNonUserCode]
	public static MessageParser<EnumDescriptorProto> Parser
	{
		 get { } //Length: 182
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 72
	}

	[DebuggerNonUserCode]
	public RepeatedField<EnumValueDescriptorProto> Value
	{
		 get { } //Length: 5
	}

	private static EnumDescriptorProto() { }

	[DebuggerNonUserCode]
	public EnumDescriptorProto() { }

	[DebuggerNonUserCode]
	public EnumDescriptorProto(EnumDescriptorProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override EnumDescriptorProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(EnumDescriptorProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public bool get_HasName() { }

	public string get_Name() { }

	public EnumOptions get_Options() { }

	public static MessageParser<EnumDescriptorProto> get_Parser() { }

	public RepeatedField<EnumValueDescriptorProto> get_Value() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(EnumDescriptorProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Name(string value) { }

	public void set_Options(EnumOptions value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}


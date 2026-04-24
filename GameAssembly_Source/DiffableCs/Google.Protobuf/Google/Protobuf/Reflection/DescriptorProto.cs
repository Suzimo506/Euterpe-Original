namespace Google.Protobuf.Reflection;

public sealed class DescriptorProto : IMessage<DescriptorProto>, IMessage, IEquatable<DescriptorProto>, IDeepCloneable<DescriptorProto>, IBufferMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x69A60

		private static <>c() { }

		public <>c() { }

		internal DescriptorProto <.cctor>b__77_0() { }

	}

	[DebuggerNonUserCode]
	internal static class Types
	{
		internal sealed class ExtensionRange : IMessage<ExtensionRange>, IMessage, IEquatable<ExtensionRange>, IDeepCloneable<ExtensionRange>, IBufferMessage
		{
			[CompilerGenerated]
			private sealed class <>c
			{
				public static readonly <>c <>9; //Field offset: 0x69A36

				private static <>c() { }

				public <>c() { }

				internal ExtensionRange <.cctor>b__46_0() { }

			}

			private static readonly MessageParser<ExtensionRange> _parser; //Field offset: 0x0
			private static readonly int StartDefaultValue; //Field offset: 0x8
			private static readonly int EndDefaultValue; //Field offset: 0xC
			private UnknownFieldSet _unknownFields; //Field offset: 0x10
			private int _hasBits0; //Field offset: 0x18
			private int start_; //Field offset: 0x1C
			private int end_; //Field offset: 0x20
			private ExtensionRangeOptions options_; //Field offset: 0x28

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
			public ExtensionRangeOptions Options
			{
				 get { } //Length: 5
				 set { } //Length: 12
			}

			[DebuggerNonUserCode]
			public static MessageParser<ExtensionRange> Parser
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

			private static ExtensionRange() { }

			[DebuggerNonUserCode]
			public ExtensionRange() { }

			[DebuggerNonUserCode]
			public ExtensionRange(ExtensionRange other) { }

			[DebuggerNonUserCode]
			public override int CalculateSize() { }

			[DebuggerNonUserCode]
			public override ExtensionRange Clone() { }

			[DebuggerNonUserCode]
			public override bool Equals(ExtensionRange other) { }

			[DebuggerNonUserCode]
			public virtual bool Equals(object other) { }

			public static MessageDescriptor get_Descriptor() { }

			public int get_End() { }

			public bool get_HasEnd() { }

			public bool get_HasStart() { }

			public ExtensionRangeOptions get_Options() { }

			public static MessageParser<ExtensionRange> get_Parser() { }

			public int get_Start() { }

			[DebuggerNonUserCode]
			public virtual int GetHashCode() { }

			[DebuggerNonUserCode]
			public override void MergeFrom(ExtensionRange other) { }

			[DebuggerNonUserCode]
			public override void MergeFrom(CodedInputStream input) { }

			[DebuggerNonUserCode]
			private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

			[DebuggerNonUserCode]
			private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

			private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

			public void set_End(int value) { }

			public void set_Options(ExtensionRangeOptions value) { }

			public void set_Start(int value) { }

			[DebuggerNonUserCode]
			public virtual string ToString() { }

			[DebuggerNonUserCode]
			public override void WriteTo(CodedOutputStream output) { }

		}

		internal sealed class ReservedRange : IMessage<ReservedRange>, IMessage, IEquatable<ReservedRange>, IDeepCloneable<ReservedRange>, IBufferMessage
		{
			[CompilerGenerated]
			private sealed class <>c
			{
				public static readonly <>c <>9; //Field offset: 0x2C927FC

				private static <>c() { }

				public <>c() { }

				internal ReservedRange <.cctor>b__41_0() { }

			}

			private static readonly MessageParser<ReservedRange> _parser; //Field offset: 0x0
			private static readonly int StartDefaultValue; //Field offset: 0x8
			private static readonly int EndDefaultValue; //Field offset: 0xC
			private UnknownFieldSet _unknownFields; //Field offset: 0x10
			private int _hasBits0; //Field offset: 0x18
			private int start_; //Field offset: 0x1C
			private int end_; //Field offset: 0x20

			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				 get { } //Length: 111
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
			public static MessageParser<ReservedRange> Parser
			{
				 get { } //Length: 182
			}

			[DebuggerNonUserCode]
			private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
			{
				private get { } //Length: 168
			}

			[DebuggerNonUserCode]
			public int Start
			{
				 get { } //Length: 107
				 set { } //Length: 102
			}

			private static ReservedRange() { }

			[DebuggerNonUserCode]
			public ReservedRange() { }

			[DebuggerNonUserCode]
			public ReservedRange(ReservedRange other) { }

			[DebuggerNonUserCode]
			public override int CalculateSize() { }

			[DebuggerNonUserCode]
			public override ReservedRange Clone() { }

			[DebuggerNonUserCode]
			public override bool Equals(ReservedRange other) { }

			[DebuggerNonUserCode]
			public virtual bool Equals(object other) { }

			public static MessageDescriptor get_Descriptor() { }

			public int get_End() { }

			public bool get_HasEnd() { }

			public bool get_HasStart() { }

			public static MessageParser<ReservedRange> get_Parser() { }

			public int get_Start() { }

			[DebuggerNonUserCode]
			public virtual int GetHashCode() { }

			[DebuggerNonUserCode]
			public override void MergeFrom(ReservedRange other) { }

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

	private static readonly MessageParser<DescriptorProto> _parser; //Field offset: 0x0
	private static readonly string NameDefaultValue; //Field offset: 0x8
	private static readonly FieldCodec<FieldDescriptorProto> _repeated_field_codec; //Field offset: 0x10
	private static readonly FieldCodec<FieldDescriptorProto> _repeated_extension_codec; //Field offset: 0x18
	private static readonly FieldCodec<DescriptorProto> _repeated_nestedType_codec; //Field offset: 0x20
	private static readonly FieldCodec<EnumDescriptorProto> _repeated_enumType_codec; //Field offset: 0x28
	private static readonly FieldCodec<ExtensionRange> _repeated_extensionRange_codec; //Field offset: 0x30
	private static readonly FieldCodec<OneofDescriptorProto> _repeated_oneofDecl_codec; //Field offset: 0x38
	private static readonly FieldCodec<ReservedRange> _repeated_reservedRange_codec; //Field offset: 0x40
	private static readonly FieldCodec<String> _repeated_reservedName_codec; //Field offset: 0x48
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	private string name_; //Field offset: 0x18
	private readonly RepeatedField<FieldDescriptorProto> field_; //Field offset: 0x20
	private readonly RepeatedField<FieldDescriptorProto> extension_; //Field offset: 0x28
	private readonly RepeatedField<DescriptorProto> nestedType_; //Field offset: 0x30
	private readonly RepeatedField<EnumDescriptorProto> enumType_; //Field offset: 0x38
	private readonly RepeatedField<ExtensionRange> extensionRange_; //Field offset: 0x40
	private readonly RepeatedField<OneofDescriptorProto> oneofDecl_; //Field offset: 0x48
	private MessageOptions options_; //Field offset: 0x50
	private readonly RepeatedField<ReservedRange> reservedRange_; //Field offset: 0x58
	private readonly RepeatedField<String> reservedName_; //Field offset: 0x60

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 191
	}

	[DebuggerNonUserCode]
	public RepeatedField<EnumDescriptorProto> EnumType
	{
		 get { } //Length: 5
	}

	[DebuggerNonUserCode]
	public RepeatedField<FieldDescriptorProto> Extension
	{
		 get { } //Length: 5
	}

	[DebuggerNonUserCode]
	public RepeatedField<FieldDescriptorProto> Field
	{
		 get { } //Length: 5
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
	public RepeatedField<DescriptorProto> NestedType
	{
		 get { } //Length: 5
	}

	[DebuggerNonUserCode]
	public RepeatedField<OneofDescriptorProto> OneofDecl
	{
		 get { } //Length: 5
	}

	[DebuggerNonUserCode]
	public MessageOptions Options
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	[DebuggerNonUserCode]
	public static MessageParser<DescriptorProto> Parser
	{
		 get { } //Length: 182
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 72
	}

	private static DescriptorProto() { }

	[DebuggerNonUserCode]
	public DescriptorProto() { }

	[DebuggerNonUserCode]
	public DescriptorProto(DescriptorProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override DescriptorProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(DescriptorProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public RepeatedField<EnumDescriptorProto> get_EnumType() { }

	public RepeatedField<FieldDescriptorProto> get_Extension() { }

	public RepeatedField<FieldDescriptorProto> get_Field() { }

	public bool get_HasName() { }

	public string get_Name() { }

	public RepeatedField<DescriptorProto> get_NestedType() { }

	public RepeatedField<OneofDescriptorProto> get_OneofDecl() { }

	public MessageOptions get_Options() { }

	public static MessageParser<DescriptorProto> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(DescriptorProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Name(string value) { }

	public void set_Options(MessageOptions value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}


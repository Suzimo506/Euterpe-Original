namespace Google.Protobuf.Reflection;

public sealed class GeneratedCodeInfo : IMessage<GeneratedCodeInfo>, IMessage, IEquatable<GeneratedCodeInfo>, IDeepCloneable<GeneratedCodeInfo>, IBufferMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x69D2D

		private static <>c() { }

		public <>c() { }

		internal GeneratedCodeInfo <.cctor>b__28_0() { }

	}

	[DebuggerNonUserCode]
	internal static class Types
	{
		internal sealed class Annotation : IMessage<Annotation>, IMessage, IEquatable<Annotation>, IDeepCloneable<Annotation>, IBufferMessage
		{
			[CompilerGenerated]
			private sealed class <>c
			{
				public static readonly <>c <>9; //Field offset: 0x69CE0

				private static <>c() { }

				public <>c() { }

				internal Annotation <.cctor>b__55_0() { }

			}

			private static readonly MessageParser<Annotation> _parser; //Field offset: 0x0
			private static readonly FieldCodec<Int32> _repeated_path_codec; //Field offset: 0x8
			private static readonly string SourceFileDefaultValue; //Field offset: 0x10
			private static readonly int BeginDefaultValue; //Field offset: 0x18
			private static readonly int EndDefaultValue; //Field offset: 0x1C
			private UnknownFieldSet _unknownFields; //Field offset: 0x10
			private int _hasBits0; //Field offset: 0x18
			private readonly RepeatedField<Int32> path_; //Field offset: 0x20
			private string sourceFile_; //Field offset: 0x28
			private int begin_; //Field offset: 0x30
			private int end_; //Field offset: 0x34

			[DebuggerNonUserCode]
			public int Begin
			{
				 get { } //Length: 107
				 set { } //Length: 8
			}

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
			public bool HasBegin
			{
				 get { } //Length: 7
			}

			[DebuggerNonUserCode]
			public bool HasEnd
			{
				 get { } //Length: 8
			}

			[DebuggerNonUserCode]
			public bool HasSourceFile
			{
				 get { } //Length: 9
			}

			[DebuggerNonUserCode]
			public static MessageParser<Annotation> Parser
			{
				 get { } //Length: 86
			}

			[DebuggerNonUserCode]
			private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
			{
				private get { } //Length: 165
			}

			[DebuggerNonUserCode]
			public string SourceFile
			{
				 get { } //Length: 102
				 set { } //Length: 90
			}

			private static Annotation() { }

			[DebuggerNonUserCode]
			public Annotation() { }

			[DebuggerNonUserCode]
			public Annotation(Annotation other) { }

			[DebuggerNonUserCode]
			public override int CalculateSize() { }

			[DebuggerNonUserCode]
			public override Annotation Clone() { }

			[DebuggerNonUserCode]
			public override bool Equals(Annotation other) { }

			[DebuggerNonUserCode]
			public virtual bool Equals(object other) { }

			public int get_Begin() { }

			public static MessageDescriptor get_Descriptor() { }

			public int get_End() { }

			public bool get_HasBegin() { }

			public bool get_HasEnd() { }

			public bool get_HasSourceFile() { }

			public static MessageParser<Annotation> get_Parser() { }

			public string get_SourceFile() { }

			[DebuggerNonUserCode]
			public virtual int GetHashCode() { }

			[DebuggerNonUserCode]
			public override void MergeFrom(Annotation other) { }

			[DebuggerNonUserCode]
			public override void MergeFrom(CodedInputStream input) { }

			[DebuggerNonUserCode]
			private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

			[DebuggerNonUserCode]
			private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

			private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

			public void set_Begin(int value) { }

			public void set_End(int value) { }

			public void set_SourceFile(string value) { }

			[DebuggerNonUserCode]
			public virtual string ToString() { }

			[DebuggerNonUserCode]
			public override void WriteTo(CodedOutputStream output) { }

		}


	}

	private static readonly MessageParser<GeneratedCodeInfo> _parser; //Field offset: 0x0
	private static readonly FieldCodec<Annotation> _repeated_annotation_codec; //Field offset: 0x8
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	private readonly RepeatedField<Annotation> annotation_; //Field offset: 0x18

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 191
	}

	[DebuggerNonUserCode]
	public static MessageParser<GeneratedCodeInfo> Parser
	{
		 get { } //Length: 86
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 72
	}

	private static GeneratedCodeInfo() { }

	[DebuggerNonUserCode]
	public GeneratedCodeInfo() { }

	[DebuggerNonUserCode]
	public GeneratedCodeInfo(GeneratedCodeInfo other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override GeneratedCodeInfo Clone() { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	[DebuggerNonUserCode]
	public override bool Equals(GeneratedCodeInfo other) { }

	public static MessageDescriptor get_Descriptor() { }

	public static MessageParser<GeneratedCodeInfo> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(GeneratedCodeInfo other) { }

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


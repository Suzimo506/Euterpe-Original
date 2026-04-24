namespace Google.Protobuf.Reflection;

public sealed class ExtensionCollection
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<MessageDescriptor, IList`1<FieldDescriptor>>, MessageDescriptor> <>9__9_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<MessageDescriptor, IList`1<FieldDescriptor>>, IList`1<FieldDescriptor>> <>9__9_1; //Field offset: 0x10
		public static Func<KeyValuePair`2<MessageDescriptor, IList`1<FieldDescriptor>>, MessageDescriptor> <>9__9_2; //Field offset: 0x18
		public static Func<FieldDescriptor, Int32> <>9__9_4; //Field offset: 0x20
		public static Func<KeyValuePair`2<MessageDescriptor, IList`1<FieldDescriptor>>, IList`1<FieldDescriptor>> <>9__9_3; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal MessageDescriptor <CrossLink>b__9_0(KeyValuePair<MessageDescriptor, IList`1<FieldDescriptor>> kvp) { }

		internal IList<FieldDescriptor> <CrossLink>b__9_1(KeyValuePair<MessageDescriptor, IList`1<FieldDescriptor>> kvp) { }

		internal MessageDescriptor <CrossLink>b__9_2(KeyValuePair<MessageDescriptor, IList`1<FieldDescriptor>> kvp) { }

		internal IList<FieldDescriptor> <CrossLink>b__9_3(KeyValuePair<MessageDescriptor, IList`1<FieldDescriptor>> kvp) { }

		internal int <CrossLink>b__9_4(FieldDescriptor field) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public Extension[] extensions; //Field offset: 0x10
		public FileDescriptor file; //Field offset: 0x18

		public <>c__DisplayClass2_0() { }

		internal FieldDescriptor <.ctor>b__0(FieldDescriptorProto extension, int i) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public Extension[] extensions; //Field offset: 0x10
		public MessageDescriptor message; //Field offset: 0x18

		public <>c__DisplayClass3_0() { }

		internal FieldDescriptor <.ctor>b__0(FieldDescriptorProto extension, int i) { }

	}

	private IDictionary<MessageDescriptor, IList`1<FieldDescriptor>> extensionsByTypeInDeclarationOrder; //Field offset: 0x10
	private IDictionary<MessageDescriptor, IList`1<FieldDescriptor>> extensionsByTypeInNumberOrder; //Field offset: 0x18
	[CompilerGenerated]
	private readonly IList<FieldDescriptor> <UnorderedExtensions>k__BackingField; //Field offset: 0x20

	public IList<FieldDescriptor> UnorderedExtensions
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal ExtensionCollection(FileDescriptor file, Extension[] extensions) { }

	internal ExtensionCollection(MessageDescriptor message, Extension[] extensions) { }

	internal void CrossLink() { }

	[CompilerGenerated]
	public IList<FieldDescriptor> get_UnorderedExtensions() { }

}


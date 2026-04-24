namespace Google.Protobuf.Reflection;

public sealed class FileOptions : IExtendableMessage<FileOptions>, IMessage<FileOptions>, IMessage, IEquatable<FileOptions>, IDeepCloneable<FileOptions>, IBufferMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x69B70

		private static <>c() { }

		public <>c() { }

		internal FileOptions <.cctor>b__219_0() { }

	}

	[DebuggerNonUserCode]
	internal static class Types
	{
		internal enum OptimizeMode
		{
			Speed = 1,
			CodeSize = 2,
			LiteRuntime = 3,
		}


	}

	private static readonly MessageParser<FileOptions> _parser; //Field offset: 0x0
	private static readonly string JavaPackageDefaultValue; //Field offset: 0x8
	private static readonly string JavaOuterClassnameDefaultValue; //Field offset: 0x10
	private static readonly bool JavaMultipleFilesDefaultValue; //Field offset: 0x18
	private static readonly bool JavaGenerateEqualsAndHashDefaultValue; //Field offset: 0x19
	private static readonly bool JavaStringCheckUtf8DefaultValue; //Field offset: 0x1A
	private static readonly OptimizeMode OptimizeForDefaultValue; //Field offset: 0x1C
	private static readonly string GoPackageDefaultValue; //Field offset: 0x20
	private static readonly bool CcGenericServicesDefaultValue; //Field offset: 0x28
	private static readonly bool JavaGenericServicesDefaultValue; //Field offset: 0x29
	private static readonly bool PyGenericServicesDefaultValue; //Field offset: 0x2A
	private static readonly bool PhpGenericServicesDefaultValue; //Field offset: 0x2B
	private static readonly bool DeprecatedDefaultValue; //Field offset: 0x2C
	private static readonly bool CcEnableArenasDefaultValue; //Field offset: 0x2D
	private static readonly string ObjcClassPrefixDefaultValue; //Field offset: 0x30
	private static readonly string CsharpNamespaceDefaultValue; //Field offset: 0x38
	private static readonly string SwiftPrefixDefaultValue; //Field offset: 0x40
	private static readonly string PhpClassPrefixDefaultValue; //Field offset: 0x48
	private static readonly string PhpNamespaceDefaultValue; //Field offset: 0x50
	private static readonly string PhpMetadataNamespaceDefaultValue; //Field offset: 0x58
	private static readonly string RubyPackageDefaultValue; //Field offset: 0x60
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; //Field offset: 0x68
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	internal ExtensionSet<FileOptions> _extensions; //Field offset: 0x18
	private int _hasBits0; //Field offset: 0x20
	private string javaPackage_; //Field offset: 0x28
	private string javaOuterClassname_; //Field offset: 0x30
	private bool javaMultipleFiles_; //Field offset: 0x38
	private bool javaGenerateEqualsAndHash_; //Field offset: 0x39
	private bool javaStringCheckUtf8_; //Field offset: 0x3A
	private OptimizeMode optimizeFor_; //Field offset: 0x3C
	private string goPackage_; //Field offset: 0x40
	private bool ccGenericServices_; //Field offset: 0x48
	private bool javaGenericServices_; //Field offset: 0x49
	private bool pyGenericServices_; //Field offset: 0x4A
	private bool phpGenericServices_; //Field offset: 0x4B
	private bool deprecated_; //Field offset: 0x4C
	private bool ccEnableArenas_; //Field offset: 0x4D
	private string objcClassPrefix_; //Field offset: 0x50
	private string csharpNamespace_; //Field offset: 0x58
	private string swiftPrefix_; //Field offset: 0x60
	private string phpClassPrefix_; //Field offset: 0x68
	private string phpNamespace_; //Field offset: 0x70
	private string phpMetadataNamespace_; //Field offset: 0x78
	private string rubyPackage_; //Field offset: 0x80
	private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; //Field offset: 0x88

	[DebuggerNonUserCode]
	public bool CcEnableArenas
	{
		 get { } //Length: 112
		 set { } //Length: 11
	}

	[DebuggerNonUserCode]
	public bool CcGenericServices
	{
		 get { } //Length: 109
		 set { } //Length: 8
	}

	[DebuggerNonUserCode]
	public string CsharpNamespace
	{
		 get { } //Length: 102
		 set { } //Length: 90
	}

	[DebuggerNonUserCode]
	public bool Deprecated
	{
		 get { } //Length: 109
		 set { } //Length: 8
	}

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 191
	}

	[DebuggerNonUserCode]
	public string GoPackage
	{
		 get { } //Length: 102
		 set { } //Length: 90
	}

	[DebuggerNonUserCode]
	public bool HasCcEnableArenas
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public bool HasCcGenericServices
	{
		 get { } //Length: 8
	}

	[DebuggerNonUserCode]
	public bool HasCsharpNamespace
	{
		 get { } //Length: 9
	}

	[DebuggerNonUserCode]
	public bool HasDeprecated
	{
		 get { } //Length: 8
	}

	[DebuggerNonUserCode]
	public bool HasGoPackage
	{
		 get { } //Length: 9
	}

	[DebuggerNonUserCode]
	[Obsolete]
	public bool HasJavaGenerateEqualsAndHash
	{
		 get { } //Length: 8
	}

	[DebuggerNonUserCode]
	public bool HasJavaGenericServices
	{
		 get { } //Length: 8
	}

	[DebuggerNonUserCode]
	public bool HasJavaMultipleFiles
	{
		 get { } //Length: 8
	}

	[DebuggerNonUserCode]
	public bool HasJavaOuterClassname
	{
		 get { } //Length: 9
	}

	[DebuggerNonUserCode]
	public bool HasJavaPackage
	{
		 get { } //Length: 9
	}

	[DebuggerNonUserCode]
	public bool HasJavaStringCheckUtf8
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public bool HasObjcClassPrefix
	{
		 get { } //Length: 9
	}

	[DebuggerNonUserCode]
	public bool HasOptimizeFor
	{
		 get { } //Length: 7
	}

	[DebuggerNonUserCode]
	public bool HasPhpClassPrefix
	{
		 get { } //Length: 9
	}

	[DebuggerNonUserCode]
	public bool HasPhpGenericServices
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public bool HasPhpMetadataNamespace
	{
		 get { } //Length: 9
	}

	[DebuggerNonUserCode]
	public bool HasPhpNamespace
	{
		 get { } //Length: 9
	}

	[DebuggerNonUserCode]
	public bool HasPyGenericServices
	{
		 get { } //Length: 8
	}

	[DebuggerNonUserCode]
	public bool HasRubyPackage
	{
		 get { } //Length: 12
	}

	[DebuggerNonUserCode]
	public bool HasSwiftPrefix
	{
		 get { } //Length: 9
	}

	[DebuggerNonUserCode]
	[Obsolete]
	public bool JavaGenerateEqualsAndHash
	{
		 get { } //Length: 109
		 set { } //Length: 8
	}

	[DebuggerNonUserCode]
	public bool JavaGenericServices
	{
		 get { } //Length: 109
		 set { } //Length: 8
	}

	[DebuggerNonUserCode]
	public bool JavaMultipleFiles
	{
		 get { } //Length: 109
		 set { } //Length: 8
	}

	[DebuggerNonUserCode]
	public string JavaOuterClassname
	{
		 get { } //Length: 102
		 set { } //Length: 90
	}

	[DebuggerNonUserCode]
	public string JavaPackage
	{
		 get { } //Length: 102
		 set { } //Length: 90
	}

	[DebuggerNonUserCode]
	public bool JavaStringCheckUtf8
	{
		 get { } //Length: 109
		 set { } //Length: 11
	}

	[DebuggerNonUserCode]
	public string ObjcClassPrefix
	{
		 get { } //Length: 102
		 set { } //Length: 90
	}

	[DebuggerNonUserCode]
	public OptimizeMode OptimizeFor
	{
		 get { } //Length: 107
		 set { } //Length: 8
	}

	[DebuggerNonUserCode]
	public static MessageParser<FileOptions> Parser
	{
		 get { } //Length: 86
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 248
	}

	[DebuggerNonUserCode]
	public string PhpClassPrefix
	{
		 get { } //Length: 102
		 set { } //Length: 90
	}

	[DebuggerNonUserCode]
	public bool PhpGenericServices
	{
		 get { } //Length: 112
		 set { } //Length: 11
	}

	[DebuggerNonUserCode]
	public string PhpMetadataNamespace
	{
		 get { } //Length: 102
		 set { } //Length: 90
	}

	[DebuggerNonUserCode]
	public string PhpNamespace
	{
		 get { } //Length: 102
		 set { } //Length: 90
	}

	[DebuggerNonUserCode]
	public bool PyGenericServices
	{
		 get { } //Length: 109
		 set { } //Length: 8
	}

	[DebuggerNonUserCode]
	public string RubyPackage
	{
		 get { } //Length: 105
		 set { } //Length: 93
	}

	[DebuggerNonUserCode]
	public string SwiftPrefix
	{
		 get { } //Length: 102
		 set { } //Length: 90
	}

	private static FileOptions() { }

	[DebuggerNonUserCode]
	public FileOptions() { }

	[DebuggerNonUserCode]
	public FileOptions(FileOptions other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override FileOptions Clone() { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	[DebuggerNonUserCode]
	public override bool Equals(FileOptions other) { }

	public bool get_CcEnableArenas() { }

	public bool get_CcGenericServices() { }

	public string get_CsharpNamespace() { }

	public bool get_Deprecated() { }

	public static MessageDescriptor get_Descriptor() { }

	public string get_GoPackage() { }

	public bool get_HasCcEnableArenas() { }

	public bool get_HasCcGenericServices() { }

	public bool get_HasCsharpNamespace() { }

	public bool get_HasDeprecated() { }

	public bool get_HasGoPackage() { }

	public bool get_HasJavaGenerateEqualsAndHash() { }

	public bool get_HasJavaGenericServices() { }

	public bool get_HasJavaMultipleFiles() { }

	public bool get_HasJavaOuterClassname() { }

	public bool get_HasJavaPackage() { }

	public bool get_HasJavaStringCheckUtf8() { }

	public bool get_HasObjcClassPrefix() { }

	public bool get_HasOptimizeFor() { }

	public bool get_HasPhpClassPrefix() { }

	public bool get_HasPhpGenericServices() { }

	public bool get_HasPhpMetadataNamespace() { }

	public bool get_HasPhpNamespace() { }

	public bool get_HasPyGenericServices() { }

	public bool get_HasRubyPackage() { }

	public bool get_HasSwiftPrefix() { }

	public bool get_JavaGenerateEqualsAndHash() { }

	public bool get_JavaGenericServices() { }

	public bool get_JavaMultipleFiles() { }

	public string get_JavaOuterClassname() { }

	public string get_JavaPackage() { }

	public bool get_JavaStringCheckUtf8() { }

	public string get_ObjcClassPrefix() { }

	public OptimizeMode get_OptimizeFor() { }

	public static MessageParser<FileOptions> get_Parser() { }

	public string get_PhpClassPrefix() { }

	public bool get_PhpGenericServices() { }

	public string get_PhpMetadataNamespace() { }

	public string get_PhpNamespace() { }

	public bool get_PyGenericServices() { }

	public string get_RubyPackage() { }

	public string get_SwiftPrefix() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(FileOptions other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_CcEnableArenas(bool value) { }

	public void set_CcGenericServices(bool value) { }

	public void set_CsharpNamespace(string value) { }

	public void set_Deprecated(bool value) { }

	public void set_GoPackage(string value) { }

	public void set_JavaGenerateEqualsAndHash(bool value) { }

	public void set_JavaGenericServices(bool value) { }

	public void set_JavaMultipleFiles(bool value) { }

	public void set_JavaOuterClassname(string value) { }

	public void set_JavaPackage(string value) { }

	public void set_JavaStringCheckUtf8(bool value) { }

	public void set_ObjcClassPrefix(string value) { }

	public void set_OptimizeFor(OptimizeMode value) { }

	public void set_PhpClassPrefix(string value) { }

	public void set_PhpGenericServices(bool value) { }

	public void set_PhpMetadataNamespace(string value) { }

	public void set_PhpNamespace(string value) { }

	public void set_PyGenericServices(bool value) { }

	public void set_RubyPackage(string value) { }

	public void set_SwiftPrefix(string value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}


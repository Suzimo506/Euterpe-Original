namespace UnityEngine.AddressableAssets;

public class InvalidKeyException : Exception
{
	[CompilerGenerated]
	private object <Key>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private Type <Type>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private readonly Nullable<MergeMode> <MergeMode>k__BackingField; //Field offset: 0x98

	public private object Key
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public Nullable<MergeMode> MergeMode
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public virtual string Message
	{
		 get { } //Length: 822
	}

	public private Type Type
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public InvalidKeyException(object key) { }

	public InvalidKeyException(object key, Type type) { }

	public InvalidKeyException(object key, Type type, MergeMode mergeMode) { }

	public InvalidKeyException() { }

	public InvalidKeyException(string message) { }

	public InvalidKeyException(string message, Exception innerException) { }

	protected InvalidKeyException(SerializationInfo message, StreamingContext context) { }

	[CompilerGenerated]
	public object get_Key() { }

	[CompilerGenerated]
	public Nullable<MergeMode> get_MergeMode() { }

	public virtual string get_Message() { }

	[CompilerGenerated]
	public Type get_Type() { }

	[CompilerGenerated]
	private void set_Key(object value) { }

	[CompilerGenerated]
	private void set_Type(Type value) { }

}


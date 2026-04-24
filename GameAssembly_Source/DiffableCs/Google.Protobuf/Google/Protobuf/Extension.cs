namespace Google.Protobuf;

public abstract class Extension
{
	[CompilerGenerated]
	private readonly int <FieldNumber>k__BackingField; //Field offset: 0x10

	public int FieldNumber
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	internal abstract bool IsRepeated
	{
		internal get { } //Length: 0
	}

	internal abstract Type TargetType
	{
		internal get { } //Length: 0
	}

	internal abstract IExtensionValue CreateValue() { }

	[CompilerGenerated]
	public int get_FieldNumber() { }

	internal abstract bool get_IsRepeated() { }

	internal abstract Type get_TargetType() { }

}


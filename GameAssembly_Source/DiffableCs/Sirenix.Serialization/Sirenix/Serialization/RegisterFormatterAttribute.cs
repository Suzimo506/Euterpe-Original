namespace Sirenix.Serialization;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class RegisterFormatterAttribute : Attribute
{
	[CompilerGenerated]
	private Type <FormatterType>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <Priority>k__BackingField; //Field offset: 0x18

	public private Type FormatterType
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private int Priority
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public RegisterFormatterAttribute(Type formatterType, int priority = 0) { }

	[CompilerGenerated]
	public Type get_FormatterType() { }

	[CompilerGenerated]
	public int get_Priority() { }

	[CompilerGenerated]
	private void set_FormatterType(Type value) { }

	[CompilerGenerated]
	private void set_Priority(int value) { }

}


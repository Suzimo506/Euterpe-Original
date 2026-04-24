namespace Sirenix.Serialization;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class RegisterFormatterLocatorAttribute : Attribute
{
	[CompilerGenerated]
	private Type <FormatterLocatorType>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <Priority>k__BackingField; //Field offset: 0x18

	public private Type FormatterLocatorType
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

	public RegisterFormatterLocatorAttribute(Type formatterLocatorType, int priority = 0) { }

	[CompilerGenerated]
	public Type get_FormatterLocatorType() { }

	[CompilerGenerated]
	public int get_Priority() { }

	[CompilerGenerated]
	private void set_FormatterLocatorType(Type value) { }

	[CompilerGenerated]
	private void set_Priority(int value) { }

}


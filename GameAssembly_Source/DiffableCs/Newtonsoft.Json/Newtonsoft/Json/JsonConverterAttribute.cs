namespace Newtonsoft.Json;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class JsonConverterAttribute : Attribute
{
	private readonly Type _converterType; //Field offset: 0x10
	[CompilerGenerated]
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private readonly Object[] <ConverterParameters>k__BackingField; //Field offset: 0x18

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Object[] ConverterParameters
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Type ConverterType
	{
		 get { } //Length: 5
	}

	[CompilerGenerated]
	public Object[] get_ConverterParameters() { }

	public Type get_ConverterType() { }

}


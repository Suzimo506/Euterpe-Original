namespace Sirenix.Serialization;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Obsolete]
public class CustomGenericFormatterAttribute : CustomFormatterAttribute
{
	public readonly Type SerializedGenericTypeDefinition; //Field offset: 0x18

	public CustomGenericFormatterAttribute(Type serializedGenericTypeDefinition, int priority = 0) { }

}


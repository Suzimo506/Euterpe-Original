namespace Sirenix.Serialization;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class RegisterDictionaryKeyPathProviderAttribute : Attribute
{
	public readonly Type ProviderType; //Field offset: 0x10

	public RegisterDictionaryKeyPathProviderAttribute(Type providerType) { }

}


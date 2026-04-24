namespace Google.Protobuf.Reflection;

public sealed class DescriptorValidationException : Exception
{
	private readonly string name; //Field offset: 0x88
	private readonly string description; //Field offset: 0x90

	internal DescriptorValidationException(IDescriptor problemDescriptor, string description) { }

}


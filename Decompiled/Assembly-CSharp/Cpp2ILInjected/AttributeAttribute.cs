using System;

namespace Cpp2ILInjected;

public sealed class AttributeAttribute : Attribute
{
	public string Name;

	public string RVA;

	public string Offset;
}

namespace System.Reflection;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Flags]
public enum ResourceLocation
{
	Embedded = 1,
	ContainedInAnotherAssembly = 2,
	ContainedInManifestFile = 4,
}


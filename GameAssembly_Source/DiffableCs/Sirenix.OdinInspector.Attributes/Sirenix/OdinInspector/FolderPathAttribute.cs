namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class FolderPathAttribute : Attribute
{
	public bool AbsolutePath; //Field offset: 0x10
	public string ParentFolder; //Field offset: 0x18
	[Obsolete]
	public bool RequireValidPath; //Field offset: 0x20
	public bool RequireExistingPath; //Field offset: 0x21
	public bool UseBackslashes; //Field offset: 0x22

	public FolderPathAttribute() { }

}


namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class FilePathAttribute : Attribute
{
	public bool AbsolutePath; //Field offset: 0x10
	public string Extensions; //Field offset: 0x18
	public string ParentFolder; //Field offset: 0x20
	[Obsolete]
	public bool RequireValidPath; //Field offset: 0x28
	public bool RequireExistingPath; //Field offset: 0x29
	public bool UseBackslashes; //Field offset: 0x2A
	[CompilerGenerated]
	private bool <ReadOnly>k__BackingField; //Field offset: 0x2B

	[Obsolete]
	public bool ReadOnly
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public FilePathAttribute() { }

	[CompilerGenerated]
	public bool get_ReadOnly() { }

	[CompilerGenerated]
	public void set_ReadOnly(bool value) { }

}


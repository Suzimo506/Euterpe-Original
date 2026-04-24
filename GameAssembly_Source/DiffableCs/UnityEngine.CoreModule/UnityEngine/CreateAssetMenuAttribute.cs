namespace UnityEngine;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class CreateAssetMenuAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string <menuName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string <fileName>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int <order>k__BackingField; //Field offset: 0x20

	public string fileName
	{
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public string menuName
	{
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public int order
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public CreateAssetMenuAttribute() { }

	[CompilerGenerated]
	public void set_fileName(string value) { }

	[CompilerGenerated]
	public void set_menuName(string value) { }

	[CompilerGenerated]
	public void set_order(int value) { }

}


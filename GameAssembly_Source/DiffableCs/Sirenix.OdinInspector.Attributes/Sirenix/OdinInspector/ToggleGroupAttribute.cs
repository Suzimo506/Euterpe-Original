namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class ToggleGroupAttribute : PropertyGroupAttribute
{
	public string ToggleGroupTitle; //Field offset: 0x38
	public bool CollapseOthersOnExpand; //Field offset: 0x40
	[CompilerGenerated]
	private string <TitleStringMemberName>k__BackingField; //Field offset: 0x48

	[Obsolete]
	public string TitleStringMemberName
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public string ToggleMemberName
	{
		 get { } //Length: 5
	}

	public ToggleGroupAttribute(string toggleMemberName, float order = 0, string groupTitle = null) { }

	public ToggleGroupAttribute(string toggleMemberName, string groupTitle) { }

	[Obsolete]
	public ToggleGroupAttribute(string toggleMemberName, float order, string groupTitle, string titleStringMemberName) { }

	protected virtual void CombineValuesWith(PropertyGroupAttribute other) { }

	[CompilerGenerated]
	public string get_TitleStringMemberName() { }

	public string get_ToggleMemberName() { }

	[CompilerGenerated]
	public void set_TitleStringMemberName(string value) { }

}


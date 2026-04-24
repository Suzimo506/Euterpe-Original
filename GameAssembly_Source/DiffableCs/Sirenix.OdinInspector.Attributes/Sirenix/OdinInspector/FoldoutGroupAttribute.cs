namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class FoldoutGroupAttribute : PropertyGroupAttribute
{
	private bool expanded; //Field offset: 0x38
	[CompilerGenerated]
	private bool <HasDefinedExpanded>k__BackingField; //Field offset: 0x39

	public bool Expanded
	{
		 get { } //Length: 5
		 set { } //Length: 8
	}

	public private bool HasDefinedExpanded
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public FoldoutGroupAttribute(string groupName, float order = 0) { }

	public FoldoutGroupAttribute(string groupName, bool expanded, float order = 0) { }

	protected virtual void CombineValuesWith(PropertyGroupAttribute other) { }

	public bool get_Expanded() { }

	[CompilerGenerated]
	public bool get_HasDefinedExpanded() { }

	public void set_Expanded(bool value) { }

	[CompilerGenerated]
	private void set_HasDefinedExpanded(bool value) { }

}


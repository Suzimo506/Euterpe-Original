namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class TabGroupAttribute : PropertyGroupAttribute, ISubGroupProviderAttribute
{
	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal class TabSubGroupAttribute : PropertyGroupAttribute
	{

		public TabSubGroupAttribute(string groupId, float order) { }

	}

	public const string DEFAULT_NAME = "_DefaultTabGroup"; //Field offset: 0x0
	public string TabName; //Field offset: 0x38
	public bool UseFixedHeight; //Field offset: 0x40
	public bool Paddingless; //Field offset: 0x41
	public bool HideTabGroupIfTabGroupOnlyHasOneTab; //Field offset: 0x42
	[CompilerGenerated]
	private List<String> <Tabs>k__BackingField; //Field offset: 0x48

	public private List<String> Tabs
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public TabGroupAttribute(string tab, bool useFixedHeight = false, float order = 0) { }

	public TabGroupAttribute(string group, string tab, bool useFixedHeight = false, float order = 0) { }

	protected virtual void CombineValuesWith(PropertyGroupAttribute other) { }

	[CompilerGenerated]
	public List<String> get_Tabs() { }

	[CompilerGenerated]
	private void set_Tabs(List<String> value) { }

	private override IList<PropertyGroupAttribute> Sirenix.OdinInspector.Internal.ISubGroupProviderAttribute.GetSubGroupAttributes() { }

	private override string Sirenix.OdinInspector.Internal.ISubGroupProviderAttribute.RepathMemberAttribute(PropertyGroupAttribute attr) { }

}


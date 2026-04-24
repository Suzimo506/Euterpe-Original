namespace PeroTools.Others;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class AnimationSelector : Attribute
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, GUIContent> <>9__6_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal GUIContent <StringsToGUIContents>b__6_0(string s) { }

	}

	[CompilerGenerated]
	private string <animatorFieldName>k__BackingField; //Field offset: 0x10

	public private string animatorFieldName
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public AnimationSelector() { }

	public AnimationSelector(string animFieldName) { }

	[CompilerGenerated]
	public string get_animatorFieldName() { }

	[CompilerGenerated]
	private void set_animatorFieldName(string value) { }

	private static GUIContent[] StringsToGUIContents(String[] strs) { }

}


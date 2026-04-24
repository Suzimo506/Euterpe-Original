namespace Sirenix.Utilities;

public static class GUILayoutOptions
{
	internal sealed class GUILayoutOptionsInstance : IEquatable<GUILayoutOptionsInstance>
	{
		private float value; //Field offset: 0x10
		internal GUILayoutOptionsInstance Parent; //Field offset: 0x18
		internal GUILayoutOptionType GUILayoutOptionType; //Field offset: 0x20

		internal GUILayoutOptionsInstance() { }

		private GUILayoutOptionsInstance Clone() { }

		private GUILayoutOption[] CreateOptionsArary() { }

		public override bool Equals(GUILayoutOptionsInstance other) { }

		public GUILayoutOptionsInstance ExpandHeight(bool expand = true) { }

		public GUILayoutOptionsInstance ExpandWidth(bool expand = true) { }

		private GUILayoutOption[] GetCachedOptions() { }

		public virtual int GetHashCode() { }

		public GUILayoutOptionsInstance Height(float height) { }

		public GUILayoutOptionsInstance MaxHeight(float height) { }

		public GUILayoutOptionsInstance MaxWidth(float width) { }

		public GUILayoutOptionsInstance MinHeight(float height) { }

		public GUILayoutOptionsInstance MinWidth(float width) { }

		public static GUILayoutOption[] op_Implicit(GUILayoutOptionsInstance options) { }

		internal void SetValue(GUILayoutOptionType type, float value) { }

		internal void SetValue(GUILayoutOptionType type, bool value) { }

		public GUILayoutOptionsInstance Width(float width) { }

	}

	public enum GUILayoutOptionType
	{
		Width = 0,
		Height = 1,
		MinWidth = 2,
		MaxHeight = 3,
		MaxWidth = 4,
		MinHeight = 5,
		ExpandHeight = 6,
		ExpandWidth = 7,
	}

	private static int CurrentCacheIndex; //Field offset: 0x0
	private static readonly GUILayoutOptionsInstance[] GUILayoutOptionsInstanceCache; //Field offset: 0x8
	private static readonly Dictionary<GUILayoutOptionsInstance, GUILayoutOption[]> GUILayoutOptionsCache; //Field offset: 0x10
	public static readonly GUILayoutOption[] EmptyGUIOptions; //Field offset: 0x18

	private static GUILayoutOptions() { }

	public static GUILayoutOptionsInstance ExpandHeight(bool expand = true) { }

	public static GUILayoutOptionsInstance ExpandWidth(bool expand = true) { }

	public static GUILayoutOptionsInstance Height(float height) { }

	public static GUILayoutOptionsInstance MaxHeight(float height) { }

	public static GUILayoutOptionsInstance MaxWidth(float width) { }

	public static GUILayoutOptionsInstance MinHeight(float height) { }

	public static GUILayoutOptionsInstance MinWidth(float width) { }

	public static GUILayoutOptionsInstance Width(float width) { }

}


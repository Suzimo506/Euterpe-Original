namespace UnityEngine.Rendering;

public class VolumeComponent : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<FieldInfo, Boolean> <>9__10_0; //Field offset: 0x8
		public static Func<FieldInfo, Int32> <>9__10_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <OnEnable>b__10_0(FieldInfo t) { }

		internal int <OnEnable>b__10_1(FieldInfo t) { }

	}

	public bool active; //Field offset: 0x18
	[CompilerGenerated]
	private string <displayName>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private ReadOnlyCollection<VolumeParameter> <parameters>k__BackingField; //Field offset: 0x28
	[SerializeField]
	private bool m_AdvancedMode; //Field offset: 0x30

	public string displayName
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public private ReadOnlyCollection<VolumeParameter> parameters
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public VolumeComponent() { }

	[CompilerGenerated]
	private VolumeParameter <OnEnable>b__10_2(FieldInfo t) { }

	[CompilerGenerated]
	public string get_displayName() { }

	[CompilerGenerated]
	public ReadOnlyCollection<VolumeParameter> get_parameters() { }

	public virtual int GetHashCode() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	public override void Override(VolumeComponent state, float interpFactor) { }

	[CompilerGenerated]
	protected void set_displayName(string value) { }

	[CompilerGenerated]
	private void set_parameters(ReadOnlyCollection<VolumeParameter> value) { }

	public void SetAllOverridesTo(bool state) { }

	private void SetAllOverridesTo(IEnumerable<VolumeParameter> enumerable, bool state) { }

}


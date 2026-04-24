namespace UnityEngine.Rendering;

public sealed class VolumeManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Type, Boolean> <>9__21_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal VolumeManager <.cctor>b__36_0() { }

		internal bool <ReloadBaseTypes>b__21_0(Type t) { }

	}

	internal static bool needIsolationFilteredByRenderer; //Field offset: 0x0
	private const int k_MaxLayerCount = 32; //Field offset: 0x0
	private static readonly Lazy<VolumeManager> s_Instance; //Field offset: 0x8
	[CompilerGenerated]
	private VolumeStack <stack>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private IEnumerable<Type> <baseComponentTypes>k__BackingField; //Field offset: 0x18
	private readonly Dictionary<Int32, List`1<Volume>> m_SortedVolumes; //Field offset: 0x20
	private readonly List<Volume> m_Volumes; //Field offset: 0x28
	private readonly Dictionary<Int32, Boolean> m_SortNeeded; //Field offset: 0x30
	private readonly List<VolumeComponent> m_ComponentsDefaultState; //Field offset: 0x38
	private readonly List<Collider> m_TempColliders; //Field offset: 0x40

	public private IEnumerable<Type> baseComponentTypes
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public static VolumeManager instance
	{
		 get { } //Length: 108
	}

	public private VolumeStack stack
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	private static VolumeManager() { }

	private VolumeManager() { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public void CheckBaseTypes() { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public void CheckStack(VolumeStack stack) { }

	public VolumeStack CreateStack() { }

	public void DestroyStack(VolumeStack stack) { }

	[CompilerGenerated]
	public IEnumerable<Type> get_baseComponentTypes() { }

	public static VolumeManager get_instance() { }

	[CompilerGenerated]
	public VolumeStack get_stack() { }

	private List<Volume> GrabVolumes(LayerMask mask) { }

	public bool IsComponentActiveInMask(LayerMask layerMask) { }

	private static bool IsVolumeRenderedByCamera(Volume volume, Camera camera) { }

	private void OverrideData(VolumeStack stack, List<VolumeComponent> components, float interpFactor) { }

	public void Register(Volume volume, int layer) { }

	private void ReloadBaseTypes() { }

	private void ReplaceData(VolumeStack stack, List<VolumeComponent> components) { }

	[CompilerGenerated]
	private void set_baseComponentTypes(IEnumerable<Type> value) { }

	[CompilerGenerated]
	private void set_stack(VolumeStack value) { }

	internal void SetLayerDirty(int layer) { }

	private static void SortByPriority(List<Volume> volumes) { }

	public void Unregister(Volume volume, int layer) { }

	public void Update(Transform trigger, LayerMask layerMask) { }

	public void Update(VolumeStack stack, Transform trigger, LayerMask layerMask) { }

	internal void UpdateVolumeLayer(Volume volume, int prevLayer, int newLayer) { }

}


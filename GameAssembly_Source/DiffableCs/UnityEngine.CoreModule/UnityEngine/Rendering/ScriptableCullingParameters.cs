namespace UnityEngine.Rendering;

[UsedByNativeCode]
public struct ScriptableCullingParameters : IEquatable<ScriptableCullingParameters>
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <m_CullingPlanes>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <m_LayerFarCullDistances>e__FixedBuffer
	{
		public float FixedElementField; //Field offset: 0x0

	}

	public static readonly int maximumCullingPlaneCount; //Field offset: 0x0
	public static readonly int layerCount; //Field offset: 0x4
	private int m_IsOrthographic; //Field offset: 0x0
	private LODParameters m_LODParameters; //Field offset: 0x4
	[FixedBuffer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal <m_CullingPlanes>e__FixedBuffer m_CullingPlanes; //Field offset: 0x20
	private int m_CullingPlaneCount; //Field offset: 0xC0
	private uint m_CullingMask; //Field offset: 0xC4
	private ulong m_SceneMask; //Field offset: 0xC8
	[FixedBuffer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal <m_LayerFarCullDistances>e__FixedBuffer m_LayerFarCullDistances; //Field offset: 0xD0
	private int m_LayerCull; //Field offset: 0x150
	private Matrix4x4 m_CullingMatrix; //Field offset: 0x154
	private Vector3 m_Origin; //Field offset: 0x194
	private float m_ShadowDistance; //Field offset: 0x1A0
	private CullingOptions m_CullingOptions; //Field offset: 0x1A4
	private ReflectionProbeSortingCriteria m_ReflectionProbeSortingCriteria; //Field offset: 0x1A8
	private CameraProperties m_CameraProperties; //Field offset: 0x1AC
	private float m_AccurateOcclusionThreshold; //Field offset: 0x590
	private int m_MaximumPortalCullingJobs; //Field offset: 0x594
	private Matrix4x4 m_StereoViewMatrix; //Field offset: 0x598
	private Matrix4x4 m_StereoProjectionMatrix; //Field offset: 0x5D8
	private float m_StereoSeparationDistance; //Field offset: 0x618
	private int m_maximumVisibleLights; //Field offset: 0x61C

	public int cullingPlaneCount
	{
		 get { } //Length: 9
	}

	private static ScriptableCullingParameters() { }

	public override bool Equals(ScriptableCullingParameters other) { }

	public virtual bool Equals(object obj) { }

	public int get_cullingPlaneCount() { }

	public Plane GetCullingPlane(int index) { }

	public virtual int GetHashCode() { }

	public float GetLayerCullingDistance(int layerIndex) { }

}


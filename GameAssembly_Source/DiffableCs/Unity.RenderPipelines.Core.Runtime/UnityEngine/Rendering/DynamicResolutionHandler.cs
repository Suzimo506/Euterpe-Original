namespace UnityEngine.Rendering;

public class DynamicResolutionHandler
{
	private static DynamicResolutionHandler s_Instance; //Field offset: 0x0
	private bool m_Enabled; //Field offset: 0x10
	private float m_MinScreenFraction; //Field offset: 0x14
	private float m_MaxScreenFraction; //Field offset: 0x18
	private float m_CurrentFraction; //Field offset: 0x1C
	private float m_PrevFraction; //Field offset: 0x20
	private bool m_ForcingRes; //Field offset: 0x24
	private bool m_CurrentCameraRequest; //Field offset: 0x25
	private bool m_ForceSoftwareFallback; //Field offset: 0x26
	private float m_PrevHWScaleWidth; //Field offset: 0x28
	private float m_PrevHWScaleHeight; //Field offset: 0x2C
	private Vector2Int m_LastScaledSize; //Field offset: 0x30
	private DynamicResScalePolicyType m_ScalerType; //Field offset: 0x38
	private Vector2Int cachedOriginalSize; //Field offset: 0x3C
	[CompilerGenerated]
	private DynamicResUpscaleFilter <filter>k__BackingField; //Field offset: 0x44
	private DynamicResolutionType type; //Field offset: 0x45
	private PerformDynamicRes m_DynamicResMethod; //Field offset: 0x48

	public DynamicResUpscaleFilter filter
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public static DynamicResolutionHandler instance
	{
		 get { } //Length: 86
	}

	private static DynamicResolutionHandler() { }

	private DynamicResolutionHandler() { }

	private static float DefaultDynamicResMethod() { }

	public bool DynamicResolutionEnabled() { }

	public void ForceSoftwareFallback() { }

	[CompilerGenerated]
	public DynamicResUpscaleFilter get_filter() { }

	public static DynamicResolutionHandler get_instance() { }

	public float GetCurrentScale() { }

	public Vector2Int GetLastScaledSize() { }

	public Vector2Int GetScaledSize(Vector2Int size) { }

	public bool HardwareDynamicResIsEnabled() { }

	private void ProcessSettings(GlobalDynamicResolutionSettings settings) { }

	public bool RequestsHardwareDynamicResolution() { }

	[CompilerGenerated]
	public void set_filter(DynamicResUpscaleFilter value) { }

	public void SetCurrentCameraRequest(bool cameraRequest) { }

	public static void SetDynamicResScaler(PerformDynamicRes scaler, DynamicResScalePolicyType scalerType = 1) { }

	public bool SoftwareDynamicResIsEnabled() { }

	public void Update(GlobalDynamicResolutionSettings settings, Action OnResolutionChange = null) { }

}


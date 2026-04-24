namespace UnityEngine.Rendering;

public class RTHandle
{
	internal RTHandleSystem m_Owner; //Field offset: 0x10
	internal RenderTexture m_RT; //Field offset: 0x18
	internal Texture m_ExternalTexture; //Field offset: 0x20
	internal RenderTargetIdentifier m_NameID; //Field offset: 0x28
	internal bool m_EnableMSAA; //Field offset: 0x50
	internal bool m_EnableRandomWrite; //Field offset: 0x51
	internal bool m_EnableHWDynamicScale; //Field offset: 0x52
	internal string m_Name; //Field offset: 0x58
	[CompilerGenerated]
	private Vector2 <scaleFactor>k__BackingField; //Field offset: 0x60
	internal ScaleFunc scaleFunc; //Field offset: 0x68
	[CompilerGenerated]
	private bool <useScaling>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private Vector2Int <referenceSize>k__BackingField; //Field offset: 0x74

	public string name
	{
		 get { } //Length: 5
	}

	public RenderTargetIdentifier nameID
	{
		 get { } //Length: 29
	}

	public internal Vector2Int referenceSize
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	public RenderTexture rt
	{
		 get { } //Length: 5
	}

	public RTHandleProperties rtHandleProperties
	{
		 get { } //Length: 49
	}

	public internal Vector2 scaleFactor
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	public internal bool useScaling
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal RTHandle(RTHandleSystem owner) { }

	public string get_name() { }

	public RenderTargetIdentifier get_nameID() { }

	[CompilerGenerated]
	public Vector2Int get_referenceSize() { }

	public RenderTexture get_rt() { }

	public RTHandleProperties get_rtHandleProperties() { }

	[CompilerGenerated]
	public Vector2 get_scaleFactor() { }

	[CompilerGenerated]
	public bool get_useScaling() { }

	public Vector2Int GetScaledSize(Vector2Int refSize) { }

	public static RenderTexture op_Implicit(RTHandle handle) { }

	public static Texture op_Implicit(RTHandle handle) { }

	public static RenderTargetIdentifier op_Implicit(RTHandle handle) { }

	public void Release() { }

	[CompilerGenerated]
	internal void set_referenceSize(Vector2Int value) { }

	[CompilerGenerated]
	internal void set_scaleFactor(Vector2 value) { }

	[CompilerGenerated]
	internal void set_useScaling(bool value) { }

	internal void SetRenderTexture(RenderTexture rt) { }

	internal void SetTexture(Texture tex) { }

}


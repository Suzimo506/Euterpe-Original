namespace UnityEngine.Rendering;

[UsedByNativeCode]
public struct VisibleLight : IEquatable<VisibleLight>
{
	private LightType m_LightType; //Field offset: 0x0
	private Color m_FinalColor; //Field offset: 0x4
	private Rect m_ScreenRect; //Field offset: 0x14
	private Matrix4x4 m_LocalToWorldMatrix; //Field offset: 0x24
	private float m_Range; //Field offset: 0x64
	private float m_SpotAngle; //Field offset: 0x68
	private int m_InstanceId; //Field offset: 0x6C
	private VisibleLightFlags m_Flags; //Field offset: 0x70

	public override bool Equals(VisibleLight other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

}


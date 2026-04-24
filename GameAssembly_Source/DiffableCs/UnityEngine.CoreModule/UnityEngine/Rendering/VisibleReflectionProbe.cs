namespace UnityEngine.Rendering;

[UsedByNativeCode]
public struct VisibleReflectionProbe : IEquatable<VisibleReflectionProbe>
{
	private Bounds m_Bounds; //Field offset: 0x0
	private Matrix4x4 m_LocalToWorldMatrix; //Field offset: 0x18
	private Vector4 m_HdrData; //Field offset: 0x58
	private Vector3 m_Center; //Field offset: 0x68
	private float m_BlendDistance; //Field offset: 0x74
	private int m_Importance; //Field offset: 0x78
	private int m_BoxProjection; //Field offset: 0x7C
	private int m_InstanceId; //Field offset: 0x80
	private int m_TextureId; //Field offset: 0x84

	public override bool Equals(VisibleReflectionProbe other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

}


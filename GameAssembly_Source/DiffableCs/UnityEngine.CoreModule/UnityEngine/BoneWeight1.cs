namespace UnityEngine;

[UsedByNativeCode]
public struct BoneWeight1 : IEquatable<BoneWeight1>
{
	[SerializeField]
	private float m_Weight; //Field offset: 0x0
	[SerializeField]
	private int m_BoneIndex; //Field offset: 0x4

	public int boneIndex
	{
		 get { } //Length: 6
	}

	public float weight
	{
		 get { } //Length: 7
	}

	public virtual bool Equals(object other) { }

	public override bool Equals(BoneWeight1 other) { }

	public int get_boneIndex() { }

	public float get_weight() { }

	public virtual int GetHashCode() { }

}


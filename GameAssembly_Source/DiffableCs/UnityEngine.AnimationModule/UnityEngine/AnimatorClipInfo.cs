namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[UsedByNativeCode]
public struct AnimatorClipInfo
{
	private int m_ClipInstanceID; //Field offset: 0x0
	private float m_Weight; //Field offset: 0x4

	public AnimationClip clip
	{
		 get { } //Length: 61
	}

	public float weight
	{
		 get { } //Length: 8
	}

	public AnimationClip get_clip() { }

	public float get_weight() { }

	[FreeFunction]
	private static AnimationClip InstanceIDToAnimationClipPPtr(int instanceID) { }

}


namespace UnityEngine.XR;

[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequiredByNativeCode]
[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct Hand : IEquatable<Hand>
{
	private ulong m_DeviceId; //Field offset: 0x0
	private uint m_FeatureIndex; //Field offset: 0x8

	internal ulong deviceId
	{
		internal get { } //Length: 6
	}

	internal uint featureIndex
	{
		internal get { } //Length: 6
	}

	public virtual bool Equals(object obj) { }

	public override bool Equals(Hand other) { }

	internal ulong get_deviceId() { }

	internal uint get_featureIndex() { }

	public virtual int GetHashCode() { }

}


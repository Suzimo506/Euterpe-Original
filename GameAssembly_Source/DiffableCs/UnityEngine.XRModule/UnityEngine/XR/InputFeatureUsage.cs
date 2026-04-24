namespace UnityEngine.XR;

[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequiredByNativeCode]
public struct InputFeatureUsage : IEquatable<InputFeatureUsage>
{
	internal string m_Name; //Field offset: 0x0
	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal InputFeatureType m_InternalType; //Field offset: 0x8

	internal InputFeatureType internalType
	{
		internal get { } //Length: 6
	}

	public string name
	{
		 get { } //Length: 6
	}

	public virtual bool Equals(object obj) { }

	public override bool Equals(InputFeatureUsage other) { }

	internal InputFeatureType get_internalType() { }

	public string get_name() { }

	public virtual int GetHashCode() { }

}


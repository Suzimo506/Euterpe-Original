namespace UnityEngine.Rendering;

public struct DepthState : IEquatable<DepthState>
{
	private byte m_WriteEnabled; //Field offset: 0x0
	private sbyte m_CompareFunction; //Field offset: 0x1

	public CompareFunction compareFunction
	{
		 set { } //Length: 4
	}

	public static DepthState defaultValue
	{
		 get { } //Length: 89
	}

	public bool writeEnabled
	{
		 set { } //Length: 96
	}

	public DepthState(bool writeEnabled = true, CompareFunction compareFunction = 2) { }

	public override bool Equals(DepthState other) { }

	public virtual bool Equals(object obj) { }

	public static DepthState get_defaultValue() { }

	public virtual int GetHashCode() { }

	public void set_compareFunction(CompareFunction value) { }

	public void set_writeEnabled(bool value) { }

}


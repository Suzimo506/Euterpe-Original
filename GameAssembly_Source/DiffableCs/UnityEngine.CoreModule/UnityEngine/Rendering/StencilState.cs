namespace UnityEngine.Rendering;

public struct StencilState : IEquatable<StencilState>
{
	private byte m_Enabled; //Field offset: 0x0
	private byte m_ReadMask; //Field offset: 0x1
	private byte m_WriteMask; //Field offset: 0x2
	private byte m_Padding; //Field offset: 0x3
	private byte m_CompareFunctionFront; //Field offset: 0x4
	private byte m_PassOperationFront; //Field offset: 0x5
	private byte m_FailOperationFront; //Field offset: 0x6
	private byte m_ZFailOperationFront; //Field offset: 0x7
	private byte m_CompareFunctionBack; //Field offset: 0x8
	private byte m_PassOperationBack; //Field offset: 0x9
	private byte m_FailOperationBack; //Field offset: 0xA
	private byte m_ZFailOperationBack; //Field offset: 0xB

	public static StencilState defaultValue
	{
		 get { } //Length: 140
	}

	public bool enabled
	{
		 set { } //Length: 96
	}

	public StencilState(bool enabled = true, byte readMask = 255, byte writeMask = 255, CompareFunction compareFunction = 8, StencilOp passOperation = 0, StencilOp failOperation = 0, StencilOp zFailOperation = 0) { }

	public StencilState(bool enabled, byte readMask, byte writeMask, CompareFunction compareFunctionFront, StencilOp passOperationFront, StencilOp failOperationFront, StencilOp zFailOperationFront, CompareFunction compareFunctionBack, StencilOp passOperationBack, StencilOp failOperationBack, StencilOp zFailOperationBack) { }

	public override bool Equals(StencilState other) { }

	public virtual bool Equals(object obj) { }

	public static StencilState get_defaultValue() { }

	public virtual int GetHashCode() { }

	public void set_enabled(bool value) { }

}


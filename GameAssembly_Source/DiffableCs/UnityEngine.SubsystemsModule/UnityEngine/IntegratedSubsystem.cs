namespace UnityEngine;

[NativeType]
[UsedByNativeCode]
public class IntegratedSubsystem : ISubsystem
{
	internal IntPtr m_Ptr; //Field offset: 0x10
	internal ISubsystemDescriptor m_subsystemDescriptor; //Field offset: 0x18

	public IntegratedSubsystem() { }

	internal void SetHandle(IntegratedSubsystem inst) { }

}


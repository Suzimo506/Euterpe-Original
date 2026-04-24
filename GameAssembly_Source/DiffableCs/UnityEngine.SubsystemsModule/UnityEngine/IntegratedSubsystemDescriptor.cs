namespace UnityEngine;

[UsedByNativeCode]
public abstract class IntegratedSubsystemDescriptor : ISubsystemDescriptorImpl, ISubsystemDescriptor
{
	internal IntPtr m_Ptr; //Field offset: 0x10

	private override IntPtr UnityEngine.ISubsystemDescriptorImpl.ptr
	{
		private set { } //Length: 5
	}

	protected IntegratedSubsystemDescriptor() { }

	private override void UnityEngine.ISubsystemDescriptorImpl.set_ptr(IntPtr value) { }

}


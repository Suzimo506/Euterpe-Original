namespace UnityEngine.VFX;

[NativeType]
[RequiredByNativeCode]
public sealed class VFXSpawnerState : IDisposable
{
	private IntPtr m_Ptr; //Field offset: 0x10
	private bool m_Owner; //Field offset: 0x18

	internal VFXSpawnerState(IntPtr ptr, bool owner) { }

	[RequiredByNativeCode]
	internal static VFXSpawnerState CreateSpawnerStateWrapper() { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	[NativeMethod]
	private static void Internal_Destroy(IntPtr ptr) { }

	private void Release() { }

	[RequiredByNativeCode]
	internal void SetWrapValue(IntPtr ptr) { }

}


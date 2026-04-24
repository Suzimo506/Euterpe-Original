namespace UnityEngine;

public class AndroidJavaObject : IDisposable
{
	private static bool enableDebugPrints; //Field offset: 0x0
	internal GlobalJavaObjectRef m_jobject; //Field offset: 0x10
	internal GlobalJavaObjectRef m_jclass; //Field offset: 0x18

	private void _AndroidJavaObject(string className, Object[] args) { }

	protected ReturnType _Call(string methodName, Object[] args) { }

	protected ReturnType _CallStatic(string methodName, Object[] args) { }

	protected void _CallStatic(string methodName, Object[] args) { }

	protected IntPtr _GetRawClass() { }

	protected IntPtr _GetRawObject() { }

	private static AndroidJavaObject() { }

	internal AndroidJavaObject(IntPtr jobject) { }

	internal AndroidJavaObject() { }

	public AndroidJavaObject(string className, Object[] args) { }

	internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass) { }

	internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject) { }

	public ReturnType Call(string methodName, Object[] args) { }

	public ReturnType CallStatic(string methodName, Object[] args) { }

	public void CallStatic(string methodName, Object[] args) { }

	protected void DebugPrint(string msg) { }

	protected override void Dispose(bool disposing) { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	public IntPtr GetRawClass() { }

	public IntPtr GetRawObject() { }

}


namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequiredByNativeCode]
public class AsyncOperation : YieldInstruction
{
	internal IntPtr m_Ptr; //Field offset: 0x10
	private Action<AsyncOperation> m_completeCallback; //Field offset: 0x18

	public event Action<AsyncOperation> completed
	{
		 add { } //Length: 198
		 remove { } //Length: 118
	}

	public bool allowSceneActivation
	{
		[NativeMethod]
		 get { } //Length: 51
		[NativeMethod]
		 set { } //Length: 66
	}

	public bool isDone
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	public int priority
	{
		[NativeMethod]
		 set { } //Length: 64
	}

	public float progress
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	public AsyncOperation() { }

	public void add_completed(Action<AsyncOperation> value) { }

	protected virtual void Finalize() { }

	[NativeMethod]
	public bool get_allowSceneActivation() { }

	[NativeMethod]
	public bool get_isDone() { }

	[NativeMethod]
	public float get_progress() { }

	[NativeMethod]
	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void InternalDestroy(IntPtr ptr) { }

	[RequiredByNativeCode]
	internal void InvokeCompletionEvent() { }

	public void remove_completed(Action<AsyncOperation> value) { }

	[NativeMethod]
	public void set_allowSceneActivation(bool value) { }

	[NativeMethod]
	public void set_priority(int value) { }

}


namespace UnityEngine;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequiredByNativeCode]
public class AnimationCurve : IEquatable<AnimationCurve>
{
	internal IntPtr m_Ptr; //Field offset: 0x10

	public Keyframe Item
	{
		 get { } //Length: 141
	}

	public Keyframe[] keys
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public int length
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	public WrapMode postWrapMode
	{
		[NativeMethod]
		 get { } //Length: 51
		[NativeMethod]
		 set { } //Length: 64
	}

	public WrapMode preWrapMode
	{
		[NativeMethod]
		 get { } //Length: 51
		[NativeMethod]
		 set { } //Length: 64
	}

	public AnimationCurve(Keyframe[] keys) { }

	[RequiredByNativeCode]
	public AnimationCurve() { }

	public int AddKey(Keyframe key) { }

	[FreeFunction]
	public int AddKey(float time, float value) { }

	[NativeMethod]
	private int AddKey_Internal(Keyframe key) { }

	private int AddKey_Internal_Injected(ref Keyframe key) { }

	public override bool Equals(AnimationCurve other) { }

	public virtual bool Equals(object o) { }

	[ThreadSafe]
	public float Evaluate(float time) { }

	protected virtual void Finalize() { }

	public Keyframe get_Item(int index) { }

	public Keyframe[] get_keys() { }

	[NativeMethod]
	public int get_length() { }

	[NativeMethod]
	public WrapMode get_postWrapMode() { }

	[NativeMethod]
	public WrapMode get_preWrapMode() { }

	public virtual int GetHashCode() { }

	[FreeFunction]
	[NativeThrows]
	private Keyframe GetKey(int index) { }

	private void GetKey_Injected(int index, out Keyframe ret) { }

	[FreeFunction]
	private Keyframe[] GetKeys() { }

	[FreeFunction]
	private static IntPtr Internal_Create(Keyframe[] keys) { }

	[FreeFunction]
	private static void Internal_Destroy(IntPtr ptr) { }

	[FreeFunction]
	private bool Internal_Equals(IntPtr other) { }

	public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	[FreeFunction]
	[NativeThrows]
	public int MoveKey(int index, Keyframe key) { }

	private int MoveKey_Injected(int index, ref Keyframe key) { }

	[FreeFunction]
	[NativeThrows]
	public void RemoveKey(int index) { }

	public void set_keys(Keyframe[] value) { }

	[NativeMethod]
	public void set_postWrapMode(WrapMode value) { }

	[NativeMethod]
	public void set_preWrapMode(WrapMode value) { }

	[FreeFunction]
	private void SetKeys(Keyframe[] keys) { }

	[FreeFunction]
	[NativeThrows]
	public void SmoothTangents(int index, float weight) { }

}


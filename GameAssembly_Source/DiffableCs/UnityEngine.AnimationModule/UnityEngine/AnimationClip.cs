namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeType]
public sealed class AnimationClip : Motion
{

	public bool empty
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	public AnimationEvent[] events
	{
		 get { } //Length: 129
		 set { } //Length: 66
	}

	[NativeProperty]
	public float frameRate
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public bool hasGenericRootTransform
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	public bool hasMotionCurves
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	public bool hasMotionFloatCurves
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	public bool hasRootCurves
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	internal bool hasRootMotion
	{
		[FreeFunction]
		internal get { } //Length: 51
	}

	public bool humanMotion
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	public bool legacy
	{
		[NativeMethod]
		 get { } //Length: 51
		[NativeMethod]
		 set { } //Length: 66
	}

	[NativeProperty]
	public float length
	{
		 get { } //Length: 51
	}

	[NativeProperty]
	public Bounds localBounds
	{
		 get { } //Length: 81
		 set { } //Length: 66
	}

	[NativeProperty]
	internal float startTime
	{
		internal get { } //Length: 51
	}

	[NativeProperty]
	internal float stopTime
	{
		internal get { } //Length: 51
	}

	[NativeProperty]
	public WrapMode wrapMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public AnimationClip() { }

	public void AddEvent(AnimationEvent evt) { }

	[GeneratedByOldBindingsGenerator]
	internal void AddEventInternal(object evt) { }

	public void ClearCurves() { }

	public void EnsureQuaternionContinuity() { }

	[NativeMethod]
	public bool get_empty() { }

	public AnimationEvent[] get_events() { }

	public float get_frameRate() { }

	[NativeMethod]
	public bool get_hasGenericRootTransform() { }

	[NativeMethod]
	public bool get_hasMotionCurves() { }

	[NativeMethod]
	public bool get_hasMotionFloatCurves() { }

	[NativeMethod]
	public bool get_hasRootCurves() { }

	[FreeFunction]
	internal bool get_hasRootMotion() { }

	[NativeMethod]
	public bool get_humanMotion() { }

	[NativeMethod]
	public bool get_legacy() { }

	public float get_length() { }

	public Bounds get_localBounds() { }

	private void get_localBounds_Injected(out Bounds ret) { }

	internal float get_startTime() { }

	internal float get_stopTime() { }

	public WrapMode get_wrapMode() { }

	[GeneratedByOldBindingsGenerator]
	internal Array GetEventsInternal() { }

	[FreeFunction]
	private static void Internal_CreateAnimationClip(AnimationClip self) { }

	[FreeFunction]
	[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal static void SampleAnimation(GameObject go, AnimationClip clip, float inTime, WrapMode wrapMode) { }

	public void SampleAnimation(GameObject go, float time) { }

	public void set_events(AnimationEvent[] value) { }

	public void set_frameRate(float value) { }

	[NativeMethod]
	public void set_legacy(bool value) { }

	public void set_localBounds(Bounds value) { }

	private void set_localBounds_Injected(ref Bounds value) { }

	public void set_wrapMode(WrapMode value) { }

	[FreeFunction]
	public void SetCurve(string relativePath, Type type, string propertyName, AnimationCurve curve) { }

	[GeneratedByOldBindingsGenerator]
	internal void SetEventsInternal(Array value) { }

}


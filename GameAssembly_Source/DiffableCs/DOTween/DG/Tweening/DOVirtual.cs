namespace DG.Tweening;

public static class DOVirtual
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public float val; //Field offset: 0x10
		public TweenCallback<Single> onVirtualUpdate; //Field offset: 0x18

		public <>c__DisplayClass0_0() { }

		internal float <Float>b__0() { }

		internal void <Float>b__1(float x) { }

		internal void <Float>b__2() { }

	}


	public static Tween DelayedCall(float delay, TweenCallback callback, bool ignoreTimeScale = true) { }

	public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType) { }

	public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float overshoot) { }

	public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float amplitude, float period) { }

	public static float EasedValue(float from, float to, float lifetimePercentage, AnimationCurve easeCurve) { }

	public static Tweener Float(float from, float to, float duration, TweenCallback<Single> onVirtualUpdate) { }

}


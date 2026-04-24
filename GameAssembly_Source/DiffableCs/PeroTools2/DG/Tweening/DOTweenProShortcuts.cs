namespace DG.Tweening;

[Extension]
public static class DOTweenProShortcuts
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public Transform target; //Field offset: 0x10

		public <>c__DisplayClass1_0() { }

		internal Vector3 <DOSpiral>b__0() { }

		internal void <DOSpiral>b__1(Vector3 x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public Rigidbody target; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		internal Vector3 <DOSpiral>b__0() { }

	}


	private static DOTweenProShortcuts() { }

	[Extension]
	public static Tweener DOSpiral(Transform target, float duration, Nullable<Vector3> axis = null, SpiralMode mode = 0, float speed = 1, float frequency = 10, float depth = 0, bool snapping = false) { }

	[Extension]
	public static Tweener DOSpiral(Rigidbody target, float duration, Nullable<Vector3> axis = null, SpiralMode mode = 0, float speed = 1, float frequency = 10, float depth = 0, bool snapping = false) { }

}


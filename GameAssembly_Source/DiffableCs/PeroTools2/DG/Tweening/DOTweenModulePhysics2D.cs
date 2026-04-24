namespace DG.Tweening;

[Extension]
public static class DOTweenModulePhysics2D
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public Rigidbody2D target; //Field offset: 0x10

		public <>c__DisplayClass0_0() { }

		internal Vector2 <DOMove>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public Rigidbody2D target; //Field offset: 0x10

		public <>c__DisplayClass1_0() { }

		internal Vector2 <DOMoveX>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public Rigidbody2D target; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		internal Vector2 <DOMoveY>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public Rigidbody2D target; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal float <DORotate>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public Rigidbody2D target; //Field offset: 0x10
		public float startPosY; //Field offset: 0x18
		public bool offsetYSet; //Field offset: 0x1C
		public float offsetY; //Field offset: 0x20
		public Sequence s; //Field offset: 0x28
		public Vector2 endValue; //Field offset: 0x30
		public Tween yTween; //Field offset: 0x38

		public <>c__DisplayClass4_0() { }

		internal Vector2 <DOJump>b__0() { }

		internal void <DOJump>b__1(Vector2 x) { }

		internal void <DOJump>b__2() { }

		internal Vector2 <DOJump>b__3() { }

		internal void <DOJump>b__4(Vector2 x) { }

		internal void <DOJump>b__5() { }

	}


	[Extension]
	public static Sequence DOJump(Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false) { }

	[Extension]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false) { }

	[Extension]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(Rigidbody2D target, float endValue, float duration, bool snapping = false) { }

	[Extension]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(Rigidbody2D target, float endValue, float duration, bool snapping = false) { }

	[Extension]
	public static TweenerCore<Single, Single, FloatOptions> DORotate(Rigidbody2D target, float endValue, float duration) { }

}


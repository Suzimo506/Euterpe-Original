namespace DG.Tweening;

[Extension]
public static class DOTweenModuleUnityVersion
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public Material target; //Field offset: 0x10
		public int propertyID; //Field offset: 0x18

		public <>c__DisplayClass8_0() { }

		internal Vector2 <DOOffset>b__0() { }

		internal void <DOOffset>b__1(Vector2 x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public Material target; //Field offset: 0x10
		public int propertyID; //Field offset: 0x18

		public <>c__DisplayClass9_0() { }

		internal Vector2 <DOTiling>b__0() { }

		internal void <DOTiling>b__1(Vector2 x) { }

	}


	[Extension]
	public static Sequence DOGradientColor(Material target, Gradient gradient, float duration) { }

	[Extension]
	public static Sequence DOGradientColor(Material target, Gradient gradient, string property, float duration) { }

	[Extension]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(Material target, Vector2 endValue, int propertyID, float duration) { }

	[Extension]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(Material target, Vector2 endValue, int propertyID, float duration) { }

	[Extension]
	public static CustomYieldInstruction WaitForCompletion(Tween t, bool returnCustomYieldInstruction) { }

	[Extension]
	public static CustomYieldInstruction WaitForElapsedLoops(Tween t, int elapsedLoops, bool returnCustomYieldInstruction) { }

	[Extension]
	public static CustomYieldInstruction WaitForKill(Tween t, bool returnCustomYieldInstruction) { }

	[Extension]
	public static CustomYieldInstruction WaitForPosition(Tween t, float position, bool returnCustomYieldInstruction) { }

	[Extension]
	public static CustomYieldInstruction WaitForRewind(Tween t, bool returnCustomYieldInstruction) { }

	[Extension]
	public static CustomYieldInstruction WaitForStart(Tween t, bool returnCustomYieldInstruction) { }

}


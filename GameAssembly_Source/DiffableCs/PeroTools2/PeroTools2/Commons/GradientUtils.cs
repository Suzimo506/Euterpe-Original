namespace PeroTools2.Commons;

public class GradientUtils
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public float time; //Field offset: 0x10

		public <>c__DisplayClass0_0() { }

		internal bool <GetUnusedColorTime>b__0(GradientColorKey c) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public float time; //Field offset: 0x10

		public <>c__DisplayClass1_0() { }

		internal bool <GetUnusedAlphaTime>b__0(GradientAlphaKey c) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public GradientColorKey lColorKey; //Field offset: 0x10
		public GradientColorKey rColorKey; //Field offset: 0x24

		public <>c__DisplayClass2_0() { }

		internal bool <BlendGradient>b__0(GradientColorKey c) { }

		internal bool <BlendGradient>b__1(GradientColorKey c) { }

		internal bool <BlendGradient>b__2(GradientColorKey c) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_1
	{
		public GradientAlphaKey lAlphaKey; //Field offset: 0x10
		public GradientAlphaKey rAlphaKey; //Field offset: 0x18

		public <>c__DisplayClass2_1() { }

		internal bool <BlendGradient>b__3(GradientAlphaKey c) { }

		internal bool <BlendGradient>b__4(GradientAlphaKey c) { }

		internal bool <BlendGradient>b__5(GradientAlphaKey c) { }

	}


	public GradientUtils() { }

	public static Gradient BlendGradient(Gradient l, Gradient r, float percent) { }

	public static float GetUnusedAlphaTime(Gradient gradient) { }

	public static float GetUnusedColorTime(Gradient gradient) { }

}


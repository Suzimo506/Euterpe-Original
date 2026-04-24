namespace Assets.Scripts.PeroTools.Nice.Actions;

public class PlayAnimation : Action
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<IVariable, String> <>9__12_2; //Field offset: 0x8
		public static Func<IVariable, String> <>9__12_3; //Field offset: 0x10
		public static Func<IVariable, String> <>9__12_4; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal string <Execute>b__12_2(IVariable n) { }

		internal string <Execute>b__12_3(IVariable n) { }

		internal string <Execute>b__12_4(IVariable n) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public PlayAnimation <>4__this; //Field offset: 0x10
		public Animator animator; //Field offset: 0x18
		public DOTweenAnimation doTweenAnimation; //Field offset: 0x20

		public <>c__DisplayClass12_0() { }

		internal void <Execute>b__0() { }

		internal bool <Execute>b__1() { }

		internal bool <Execute>b__7() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_1
	{
		public string animName; //Field offset: 0x10
		public <>c__DisplayClass12_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass12_1() { }

		internal bool <Execute>b__5(AnimationClip a) { }

		internal void <Execute>b__6() { }

	}

	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_Object; //Field offset: 0x10
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_Loop; //Field offset: 0x18
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_Speed; //Field offset: 0x20
	[SerializeField]
	private int m_Layer; //Field offset: 0x28
	[SerializeField]
	private AnimationType m_AnimationType; //Field offset: 0x2C
	[SerializeField]
	private ActionType m_ActionType; //Field offset: 0x30
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private List<IVariable> m_AnimNames; //Field offset: 0x38
	[SerializeField]
	private object m_AnimObject; //Field offset: 0x40
	[SerializeField]
	private float m_Duration; //Field offset: 0x48
	private bool m_IsPlaying; //Field offset: 0x4C

	public virtual float duration
	{
		 get { } //Length: 6
	}

	public bool isComplete
	{
		 get { } //Length: 755
	}

	public PlayAnimation() { }

	public virtual void Execute() { }

	public virtual float get_duration() { }

	public bool get_isComplete() { }

}


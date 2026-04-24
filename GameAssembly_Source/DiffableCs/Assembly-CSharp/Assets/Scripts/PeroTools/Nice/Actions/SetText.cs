namespace Assets.Scripts.PeroTools.Nice.Actions;

public class SetText : Action
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<IVariable, String> <>9__23_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <Execute>b__23_0(IVariable data) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public float numValue; //Field offset: 0x10
		public SetText <>4__this; //Field offset: 0x18

		public <>c__DisplayClass27_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_1
	{
		public float curNumValue; //Field offset: 0x10
		public <>c__DisplayClass27_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass27_1() { }

		internal void <DoText>b__0(float t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_2
	{
		public float curNumValue; //Field offset: 0x10
		public <>c__DisplayClass27_0 CS$<>8__locals2; //Field offset: 0x18

		public <>c__DisplayClass27_2() { }

		internal void <DoText>b__1(float t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_3
	{
		public float curNumValue; //Field offset: 0x10
		public <>c__DisplayClass27_0 CS$<>8__locals3; //Field offset: 0x18

		public <>c__DisplayClass27_3() { }

		internal void <DoText>b__2(float t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_4
	{
		public float curNumValue; //Field offset: 0x10
		public <>c__DisplayClass27_0 CS$<>8__locals4; //Field offset: 0x18

		public <>c__DisplayClass27_4() { }

		internal void <DoText>b__3(float t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_5
	{
		public float curNumValue; //Field offset: 0x10
		public <>c__DisplayClass27_0 CS$<>8__locals5; //Field offset: 0x18

		public <>c__DisplayClass27_5() { }

		internal void <DoText>b__4(float t) { }

	}

	private static readonly String[] tmpStrArray; //Field offset: 0x0
	private const string tmpStr = "%s"; //Field offset: 0x0
	private static List<String> m_Strs; //Field offset: 0x8
	private static StringBuilder m_OutVal; //Field offset: 0x10
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_Object; //Field offset: 0x10
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_Curve; //Field offset: 0x18
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_Duration; //Field offset: 0x20
	public string value; //Field offset: 0x28
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private List<IVariable> m_Datas; //Field offset: 0x30
	private String[] m_SplitStrs; //Field offset: 0x38
	private Text m_Text; //Field offset: 0x40
	private YlyRichText m_YlyRichText; //Field offset: 0x48
	private TextMeshProUGUI m_TextMeshProUGUI; //Field offset: 0x50
	private TextMeshPro m_TextMeshPro; //Field offset: 0x58
	private InputField m_InputField; //Field offset: 0x60
	private AnimationCurve m_AnimationCurve; //Field offset: 0x68
	private Looper m_Looper; //Field offset: 0x70
	private string m_OriginText; //Field offset: 0x78

	public virtual float duration
	{
		 get { } //Length: 94
	}

	public Text Object
	{
		 get { } //Length: 57
	}

	private static SetText() { }

	public SetText() { }

	private void DoText(string str) { }

	public virtual void Enter() { }

	public virtual void Execute() { }

	public virtual void Exit() { }

	public virtual float get_duration() { }

	public Text get_Object() { }

	public virtual void Pause() { }

	public virtual void Resume() { }

}


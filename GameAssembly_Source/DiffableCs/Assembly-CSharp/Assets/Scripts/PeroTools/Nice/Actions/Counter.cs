namespace Assets.Scripts.PeroTools.Nice.Actions;

public class Counter : Action
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public int preLostCount; //Field offset: 0x10
		public int preCount; //Field offset: 0x14

		public <>c__DisplayClass3_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_1
	{
		public Text text; //Field offset: 0x10
		public TextMeshPro txtMesh; //Field offset: 0x18
		public TextMeshProUGUI txtMeshUGUI; //Field offset: 0x20
		public State txtState; //Field offset: 0x28
		public string txtAnimName; //Field offset: 0x30
		public string otherAnimName; //Field offset: 0x38
		public bool isTxtActive; //Field offset: 0x40
		public bool isOtherActive; //Field offset: 0x41
		public Animator txtAnimator; //Field offset: 0x48
		public Animator otherAnimator; //Field offset: 0x50
		public GameObject txtGameObject; //Field offset: 0x58
		public GameObject otherGameObject; //Field offset: 0x60
		public <>c__DisplayClass3_0 CS$<>8__locals1; //Field offset: 0x68

		public <>c__DisplayClass3_1() { }

		internal void <Enter>b__0(int value) { }

	}

	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_Value; //Field offset: 0x10
	[SerializeField]
	private List<State> m_States; //Field offset: 0x18
	private List<Action`1<Int32>> m_Callbacks; //Field offset: 0x20

	public Counter() { }

	public virtual void Enter() { }

	public virtual void Execute() { }

	public virtual void Pause() { }

	public virtual void Resume() { }

}


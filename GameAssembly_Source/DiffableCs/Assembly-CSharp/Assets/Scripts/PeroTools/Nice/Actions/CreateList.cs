namespace Assets.Scripts.PeroTools.Nice.Actions;

public class CreateList : Action
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, GameObject> <>9__13_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal GameObject <OnListChanged>b__13_0(string p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public CreateList <>4__this; //Field offset: 0x10
		public int count; //Field offset: 0x18
		public JArray jArray; //Field offset: 0x20

		public <>c__DisplayClass12_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_1
	{
		public int index; //Field offset: 0x10
		public <>c__DisplayClass12_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass12_1() { }

		internal void <OnJsonKeyChanged>g__Callback|0(GameObject gameObject) { }

	}

	[SerializeField]
	private object m_List; //Field offset: 0x10
	[HideInInspector]
	[SerializeField]
	private string m_Path; //Field offset: 0x18
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_Count; //Field offset: 0x20
	[SerializeField]
	private bool m_AutoCount; //Field offset: 0x28
	[SerializeField]
	private string m_JsonKey; //Field offset: 0x30
	[HideInInspector]
	[SerializeField]
	private List<GameObject> m_GameObjects; //Field offset: 0x38
	[SerializeField]
	private GameObject m_Parent; //Field offset: 0x40
	[HideInInspector]
	[SerializeField]
	private int m_MaxCount; //Field offset: 0x48
	private List<String> m_JsonKeys; //Field offset: 0x50

	public CreateList() { }

	public virtual void Enter() { }

	public virtual void Execute() { }

	private void OnJsonKeyChanged(string value) { }

	private void OnListChanged() { }

	public void SetCount(int count) { }

}


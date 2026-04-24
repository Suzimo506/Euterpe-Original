namespace Assets.Scripts.UI.Panels;

public class PnlRoleSubControl : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <SwitchSkin>d__33 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PnlRoleSubControl <>4__this; //Field offset: 0x20
		public int curIndex; //Field offset: 0x28
		public int switchIndex; //Field offset: 0x2C
		public Action<PnlRoleSubControl> switchedCallback; //Field offset: 0x30

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <SwitchSkin>d__33(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public VariableBehaviour m_VarIndex; //Field offset: 0x18
	public OnFancyScrollViewCellUpdate m_CellUpdate; //Field offset: 0x20
	[SerializeField]
	private Transform m_CreateTf; //Field offset: 0x28
	[SerializeField]
	private Animator m_SwitchAnimator; //Field offset: 0x30
	private int m_CellIndex; //Field offset: 0x38
	private int m_RoleIndex; //Field offset: 0x3C
	private float m_ToggleTimeMid; //Field offset: 0x40
	private Dictionary<Int32, CharacterApply> m_CharacterApplys; //Field offset: 0x48
	private List<Int32> m_SkinIndexs; //Field offset: 0x50
	private int m_CurSkinIndex; //Field offset: 0x58
	private List<RoleSkin> m_Skin; //Field offset: 0x60
	private bool m_Init; //Field offset: 0x68
	private Coroutine m_Coroutine; //Field offset: 0x70

	public bool canToggleSkin
	{
		 get { } //Length: 73
	}

	public int cellIndex
	{
		 get { } //Length: 4
	}

	public CharacterApply characterApply
	{
		 get { } //Length: 235
	}

	public int nextSkinIndex
	{
		 get { } //Length: 107
	}

	public int roleIndex
	{
		 get { } //Length: 4
	}

	public int skinIndex
	{
		 get { } //Length: 4
	}

	public PnlRoleSubControl() { }

	private void Clean() { }

	private CharacterApply CreateObject(int skinIndex, string prefabName) { }

	public bool get_canToggleSkin() { }

	public int get_cellIndex() { }

	public CharacterApply get_characterApply() { }

	public int get_nextSkinIndex() { }

	public int get_roleIndex() { }

	public int get_skinIndex() { }

	public bool GetSkin(int index, out RoleSkin skin) { }

	public bool GetSkin(out RoleSkin skin) { }

	private void Init() { }

	private void InitCharacterMainShow() { }

	private void OnDataIndexChanged(int i) { }

	public void PlayApplyAnim() { }

	private void PlaySwitchAnimtor() { }

	private void SaveToAccount() { }

	private void SetOrder(MeshRenderer[] rd) { }

	public void SetSkin(int skinIdx = -1, bool playAnimator = true, Action<PnlRoleSubControl> switchedCallback = null, bool test = false) { }

	private void Start() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator SwitchSkin(int curIndex, int switchIndex, Action<PnlRoleSubControl> switchedCallback) { }

}


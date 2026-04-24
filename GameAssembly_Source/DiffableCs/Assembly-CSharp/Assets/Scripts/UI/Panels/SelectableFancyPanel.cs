namespace Assets.Scripts.UI.Panels;

public class SelectableFancyPanel : SerializedMonoBehaviour, IPreWarm
{
	[CompilerGenerated]
	private sealed class <PlayScrollToAndUnLockAnims>d__16 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public SelectableFancyPanel <>4__this; //Field offset: 0x20
		private List<Int32> <lockIndexs>5__2; //Field offset: 0x28
		private int <j>5__3; //Field offset: 0x30

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
		public <PlayScrollToAndUnLockAnims>d__16(int <>1__state) { }

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

	[SerializeField]
	private BtnApply m_ApplyButton; //Field offset: 0x58
	[SerializeField]
	private ApplyShow m_ApplyShow; //Field offset: 0x60
	[SerializeField]
	private FancyScrollView m_FancyScrollView; //Field offset: 0x68
	[SerializeField]
	private MenuType m_MenuType; //Field offset: 0x70
	[SerializeField]
	private AudioClip m_ClickSfx; //Field offset: 0x78

	public BtnApply applyButton
	{
		 get { } //Length: 5
	}

	public FancyScrollView fsv
	{
		 get { } //Length: 5
	}

	public MenuType menuType
	{
		 get { } //Length: 4
	}

	public SelectableFancyPanel() { }

	public BtnApply get_applyButton() { }

	public FancyScrollView get_fsv() { }

	public MenuType get_menuType() { }

	public T GetCellComponent(int index = -1) { }

	private void OnApplyClicked() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void PlayApply(bool play) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator PlayScrollToAndUnLockAnims() { }

	public override void PreWarm(int slice) { }

}


namespace Assets.Scripts.UI.Panels;

public class PnlBattle : SerializedMonoBehaviour, IPause, IPreWarm
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__43_0; //Field offset: 0x8
		public static Action <>9__43_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <GameStart>b__43_0() { }

		internal void <GameStart>b__43_1() { }

	}

	[CompilerGenerated]
	private sealed class <BtnClickCool>d__34 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PnlBattle <>4__this; //Field offset: 0x20

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
		public <BtnClickCool>d__34(int <>1__state) { }

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

	private enum PnlBattleCompsType
	{
		Others = 0,
		Reimu = 1,
		Djmax = 2,
		Count = 3,
	}

	private static PnlBattle m_Instance; //Field offset: 0x0
	private PnlBattleComps currentComps; //Field offset: 0x58
	public List<PnlBattleComps> pnlBattleComps; //Field offset: 0x60
	public PnlBattleCombos pnlBattleCombos; //Field offset: 0x68
	public AttackEffectManager attackEffectManager; //Field offset: 0x70
	public CountAnimator mulCountAnimator; //Field offset: 0x78
	private Tweener m_TwnProgress; //Field offset: 0x80
	private Sequence m_SeqGirlIn; //Field offset: 0x88
	private Sequence m_SeqSongPlay; //Field offset: 0x90
	private bool m_IsiPhoneX; //Field offset: 0x98
	private bool m_Interactable; //Field offset: 0x99
	public RectTransform[] iPhoneXTransforms; //Field offset: 0xA0
	public RectTransform[] iPhoneXTransformsInverse; //Field offset: 0xA8
	public Dictionary<RectTransform, Vector3> iPhoneXScale; //Field offset: 0xB0
	public float offsetValue; //Field offset: 0xB8
	public GameObject pnlSkipTutorial; //Field offset: 0xC0
	public GameObject pnlPause; //Field offset: 0xC8
	public DialogMasterControl dialogMasterControl; //Field offset: 0xD0
	private float gradientTime; //Field offset: 0xD8
	private Color m_Color; //Field offset: 0xDC
	private ButtonDisplay m_PauseButton; //Field offset: 0xF0
	[CompilerGenerated]
	private bool <isBtnActivity>k__BackingField; //Field offset: 0x100

	public static PnlBattle instance
	{
		 get { } //Length: 158
	}

	public private bool isBtnActivity
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public override bool IsGlobal
	{
		 get { } //Length: 3
	}

	public PnlBattle() { }

	[CompilerGenerated]
	private void <ChangeBtnPauseStage>b__35_0() { }

	[CompilerGenerated]
	private float <MusicProgressInit>b__42_0() { }

	[CompilerGenerated]
	private void <MusicProgressInit>b__42_1(float value) { }

	[CompilerGenerated]
	private void <OnStageStart>b__48_0() { }

	private void Awake() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator BtnClickCool() { }

	public void ChangeBtnPauseStage(bool isActivity = false) { }

	public void GameStart() { }

	public void GameUiInit() { }

	public static PnlBattle get_instance() { }

	[CompilerGenerated]
	public bool get_isBtnActivity() { }

	public override bool get_IsGlobal() { }

	private void IPhoneXOffset() { }

	public bool IsIPhoneX() { }

	public void MusicProgressInit() { }

	private void OnDestroy() { }

	private void OnFail() { }

	private void OnNekoSkillTrigger(object sender, object reciever, Object[] args) { }

	private void OnPauseClicked() { }

	private void OnShowVictory(object sender, object rev, Object[] args) { }

	private void OnStageStart(object sender, object reciever, Object[] args) { }

	private void OnTutorialPauseClicked() { }

	public override void Pause(bool pauseCorountine) { }

	private void PnlBattleUIInit() { }

	public override void PreWarm(int slice) { }

	public override void Resume() { }

	[CompilerGenerated]
	private void set_isBtnActivity(bool value) { }

	private void SetPnlBattleUI() { }

	public void UIPause(bool isPause) { }

}


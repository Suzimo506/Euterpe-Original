namespace Assets.Scripts.UI.Panels;

public class PnlStage : VisBasePropertyModifier, IPreWarm
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UnityAction<Boolean> <>9__80_0; //Field offset: 0x8
		public static UnityAction<Boolean> <>9__80_1; //Field offset: 0x10
		public static UnityAction<Boolean> <>9__80_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal void <HandlerInit>b__80_0(bool isOn) { }

		internal void <HandlerInit>b__80_1(bool isOn) { }

		internal void <HandlerInit>b__80_2(bool isOn) { }

	}

	[CompilerGenerated]
	private sealed class <EnableAndPlayMusic1SecLater>d__99 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PnlStage <>4__this; //Field offset: 0x20

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
		public <EnableAndPlayMusic1SecLater>d__99(int <>1__state) { }

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

	private static bool s_StaticInited; //Field offset: 0x0
	private static bool s_AbilityDirty; //Field offset: 0x1
	[CompilerGenerated]
	private static Action<Single> s_MusicCellSelectedHandler; //Field offset: 0x8
	public GameObject albumCellPrefabs; //Field offset: 0x50
	public Text titleOwn; //Field offset: 0x58
	public GameObject imgFavoriteMusic; //Field offset: 0x60
	[Space]
	public FancyScrollView musicFancyScrollView; //Field offset: 0x68
	public Text musicNameTitle; //Field offset: 0x70
	public LongSongNameController musicLongNameController; //Field offset: 0x78
	public Text artistNameTitle; //Field offset: 0x80
	public LongSongNameController artistLongNameController; //Field offset: 0x88
	[Space]
	public GameObject musicRoot; //Field offset: 0x90
	public Animator pnlStageAnimator; //Field offset: 0x98
	public string animNameAlbumIn; //Field offset: 0xA0
	public string animNameAlbumOut; //Field offset: 0xA8
	public Button btnAhcievement; //Field offset: 0xB0
	public Button btnEnter; //Field offset: 0xB8
	public Button btnBackInPnlMenu; //Field offset: 0xC0
	public Button btnPlay; //Field offset: 0xC8
	public GameObject pnlPreparation; //Field offset: 0xD0
	public PnlPreparation pnlPreparationScript; //Field offset: 0xD8
	public float demoMusicFadeInTime; //Field offset: 0xE0
	public GameObject difficult1Lock; //Field offset: 0xE8
	public GameObject difficult2Lock; //Field offset: 0xF0
	public GameObject difficulty3Lock; //Field offset: 0xF8
	public Text difficulty1; //Field offset: 0x100
	public Text difficulty2; //Field offset: 0x108
	public Text difficulty3; //Field offset: 0x110
	public GameObject difficulty1Easy; //Field offset: 0x118
	public GameObject difficulty2Hard; //Field offset: 0x120
	public GameObject difficulty3Empty; //Field offset: 0x128
	public GameObject difficulty3Master; //Field offset: 0x130
	public GameObject emptyEasy; //Field offset: 0x138
	public GameObject emptyMaster; //Field offset: 0x140
	[SerializeField]
	private StageLikeToggle m_TglLikeScript; //Field offset: 0x148
	public GameObject achievementObj; //Field offset: 0x150
	public Image achievementPercent; //Field offset: 0x158
	public GameObject stageAchievementPercent; //Field offset: 0x160
	public GameObject nsNoCollectionTip; //Field offset: 0x168
	public GameObject noMusicFromHide; //Field offset: 0x170
	public GameObject noMusicSample; //Field offset: 0x178
	public PnlStageBgAlbum bgAlbumLock; //Field offset: 0x180
	public PnlStageBgAlbum bgAlbumFree; //Field offset: 0x188
	public GameObject txtBurnV1NotPurchase; //Field offset: 0x190
	public GameObject txtBurnV2NotPurchase; //Field offset: 0x198
	public Toggle tglDifficultyEasy; //Field offset: 0x1A0
	public Toggle tglDifficultyHard; //Field offset: 0x1A8
	public Toggle tglDifficultyMaster; //Field offset: 0x1B0
	public Scrollbar musicFsvShow; //Field offset: 0x1B8
	public Scrollbar musicFsvPlay; //Field offset: 0x1C0
	public Image bgFreeDiscount; //Field offset: 0x1C8
	private Animator m_MusicRootAnimator; //Field offset: 0x1D0
	private Coroutine m_PlayMusicCoroutine; //Field offset: 0x1D8
	private bool m_CanPlayMusic; //Field offset: 0x1E0
	public AudioClip clickSfx; //Field offset: 0x1E8
	public GameObject pnlItemAward; //Field offset: 0x1F0
	public GameObject visualizerManager; //Field offset: 0x1F8
	public GameObject parFlyAwardCoin; //Field offset: 0x200
	[SerializeField]
	private GameObject m_AlbumTitleObj; //Field offset: 0x208
	[SerializeField]
	private Text m_AlbumTitleTxt; //Field offset: 0x210
	[SerializeField]
	private Button m_BtnOwn; //Field offset: 0x218
	[SerializeField]
	private PnlMusicTag m_PnlMusicTag; //Field offset: 0x220
	private bool m_InvokePreparation; //Field offset: 0x228
	public EnableDisableHooker stageUiHook; //Field offset: 0x230
	private bool m_IsRandom; //Field offset: 0x238
	private bool m_IsHideToNoMusic; //Field offset: 0x239

	internal static event Action<Single> s_MusicCellSelectedHandler
	{
		[CompilerGenerated]
		internal add { } //Length: 254
		[CompilerGenerated]
		internal remove { } //Length: 254
	}

	private bool isCollection
	{
		private get { } //Length: 189
	}

	private static PnlStage() { }

	public PnlStage() { }

	[CompilerGenerated]
	private void <PreWarm>b__65_0() { }

	[CompilerGenerated]
	internal static void add_s_MusicCellSelectedHandler(Action<Single> value) { }

	public void Awake() { }

	private void ChangeFinalMusic(int i) { }

	private void ChangeMusic(int i) { }

	public void CheckFirstOpenHideVersion() { }

	private bool CheckStageIsBan(string stageUid) { }

	private static void DirtyHandler() { }

	private void DisableBtnPlayWhenDynamic(State state) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator EnableAndPlayMusic1SecLater() { }

	private bool get_isCollection() { }

	private void HandlerInit() { }

	private string HideSoundLogic(string uid, string musicName) { }

	private void InitTglLike() { }

	private void KnowMusic() { }

	private void OnAddCollection(MusicInfo musicInfo) { }

	private void OnBtnOwnClicked() { }

	private void OnBtnPlayClicked() { }

	public void OnClickMusicTagOkBtn(object sender, object reciever, Object[] args) { }

	public void OnClickPreviewFromPnlMusicTag(object sender, object reciever, Object[] args) { }

	public virtual void OnDestroy() { }

	private void OnDisable() { }

	public void OnDontShowAnchorBanValueChanged(object sender, object reciever, Object[] args) { }

	private void OnEnable() { }

	private void OnHideMusic(MusicInfo musicInfo) { }

	private void OnInvokeLongPressHideBms(object sender, object reciever, Object[] args) { }

	private void OnLanguageChanged(int languageIndex) { }

	private void OnMusicCellChange(float i) { }

	private void OnMusicDragBegin() { }

	private void OnMusicDragEnd() { }

	private void OnMusicFsvPlayValueChanged(float value) { }

	private void OnRemoveCollection(MusicInfo musicInfo) { }

	private void OnRemoveHideMusic(MusicInfo musicInfo) { }

	private void OnTriggerHideBmsEvent() { }

	private void OnUnlockStage(string unlockMusicUid) { }

	private void PlayAlbumSwitchAnim(bool isFadeIn) { }

	private void PlayCurrentSelectedMusicIfNeed() { }

	private void PlayMusic() { }

	private void PlayMusicDragAnimator(bool isIn, float normalize = 0) { }

	private void PlayRandomMusic() { }

	private void PlayStageAnimator(string name, float normalize = 0) { }

	public override void PreWarm(int slice) { }

	private void RefreshBg(MusicInfo musicInfo) { }

	private void RefreshMusicFSV() { }

	private void RefreshTagTitle() { }

	[CompilerGenerated]
	internal static void remove_s_MusicCellSelectedHandler(Action<Single> value) { }

	private void ReplayMusicWhenFormPnlMenuToPnlStage() { }

	private void ResetMusicDragAnim() { }

	private void SetAchievementPercent(MusicInfo musicInfo) { }

	private static void SetDirty() { }

	private void SetHideDifficulty() { }

	private void SetLikeAchiEmpty(bool isEmpty) { }

	private void SetLikeAndHideTglState(MusicInfo musicInfo, bool isUnlock) { }

	private void SetPnlMusicTagDirty() { }

	private void SetPnlNoMusicEnable(bool enable) { }

	public virtual void SetProperty(float propertyValue) { }

	private void ShowPnlStage() { }

	private void StageUiDisableHook(GameObject go, bool active) { }

	public virtual void Start() { }

	private void SwitchToAlbum1() { }

	private void UnknowMusic() { }

	private void UnlockAnchorModePlayMusic(object sender, object reciever, Object[] args) { }

	private void Update() { }

}


namespace PeroTools2.UI;

public class Popup : SerializedMonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<Tween> <>9__38_0; //Field offset: 0x8
		public static Comparison<Tween> <>9__42_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <Leave>b__42_0(Tween l, Tween r) { }

		internal int <Play>b__38_0(Tween l, Tween r) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public bool isShutAll; //Field offset: 0x10

		public <>c__DisplayClass32_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_1
	{
		public PlayPopuper thePeek; //Field offset: 0x10
		public <>c__DisplayClass32_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass32_1() { }

		internal void <Shutdown>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass42_0
	{
		public Popup <>4__this; //Field offset: 0x10
		public Action callback; //Field offset: 0x18

		public <>c__DisplayClass42_0() { }

		internal void <Leave>b__1() { }

	}

	internal class PlayPopuper
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			public Action callback; //Field offset: 0x10
			public PlayPopuper <>4__this; //Field offset: 0x18

			public <>c__DisplayClass5_0() { }

			internal void <Exit>b__0() { }

		}

		[CompilerGenerated]
		private readonly Popup <popup>k__BackingField; //Field offset: 0x10
		private readonly Action m_EndCallback; //Field offset: 0x18

		public Popup popup
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public PlayPopuper(Popup p, Action callback = null) { }

		public void Exit(Action callback = null) { }

		[CompilerGenerated]
		public Popup get_popup() { }

	}

	internal enum PopupType
	{
		Sequence = 0,
		Stack = 1,
	}

	private static readonly Stack<PlayPopuper> s_Popups; //Field offset: 0x0
	[SerializeField]
	private float m_InTime; //Field offset: 0x58
	[SerializeField]
	private float m_InDistance; //Field offset: 0x5C
	[SerializeField]
	private Ease m_MoveInEase; //Field offset: 0x60
	[SerializeField]
	private bool m_IsFadeIn; //Field offset: 0x64
	[SerializeField]
	private Ease m_FadeInEase; //Field offset: 0x68
	[SerializeField]
	private float m_OutTime; //Field offset: 0x6C
	[SerializeField]
	private float m_OutDistance; //Field offset: 0x70
	[SerializeField]
	private Ease m_MoveOutEase; //Field offset: 0x74
	[SerializeField]
	private bool m_IsFadeOut; //Field offset: 0x78
	[SerializeField]
	private Ease m_FadeOutEase; //Field offset: 0x7C
	[SerializeField]
	private Color m_MaskColor; //Field offset: 0x80
	[SerializeField]
	private bool m_Shut; //Field offset: 0x90
	[SerializeField]
	private bool m_ShutAll; //Field offset: 0x91
	[SerializeField]
	private PopupType m_Type; //Field offset: 0x94
	[SerializeField]
	private List<Button> m_ShutButtons; //Field offset: 0x98
	[SerializeField]
	private List<Button> m_ShutAllShutButtons; //Field offset: 0xA0
	[SerializeField]
	private AudioClip m_ShutClip; //Field offset: 0xA8
	[SerializeField]
	private float m_Volume; //Field offset: 0xB0
	private Vector3 m_OriginPos; //Field offset: 0xB4
	private GameObject m_BtnCancell; //Field offset: 0xC0
	private CanvasGroup m_CanvasGroup; //Field offset: 0xC8
	private AudioSource m_AudioSource; //Field offset: 0xD0
	private List<Tween> m_Tweens; //Field offset: 0xD8
	private bool m_Flag; //Field offset: 0xE0
	private bool m_IsClickShut; //Field offset: 0xE1
	private Action m_OnShown; //Field offset: 0xE8
	private Action m_OnClosed; //Field offset: 0xF0
	private Action m_OnShut; //Field offset: 0xF8

	public static PlayPopuper peek
	{
		 get { } //Length: 162
	}

	private static Popup() { }

	public Popup() { }

	[CompilerGenerated]
	private bool <OnDestroy>b__34_0(PlayPopuper v) { }

	[CompilerGenerated]
	private void <Play>b__38_1() { }

	private void Awake() { }

	public static PlayPopuper get_peek() { }

	private void KillAllTwns() { }

	private void Leave(Action callback) { }

	private void OnBgShutButtonClick() { }

	private void OnDestroy() { }

	private void OnShutAllShutButtonsClick() { }

	private void OnShutButtonsClick() { }

	public void Open(Action onShown = null, Action onClosed = null, Action onShut = null) { }

	private void Play() { }

	private void Push() { }

	private void SetShutButtonEnable(bool enable) { }

	public void Shutdown(bool isShutAll = false, Action onClosed = null) { }

}


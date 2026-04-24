//Type is in global namespace

public class Boss : IPause
{
	private static Boss instance; //Field offset: 0x0
	private bool m_DisappearBoss; //Field offset: 0x10
	private GameObject m_CurBossObject; //Field offset: 0x18
	private Dictionary<Int32, GameObject> m_BossObjects; //Field offset: 0x20
	private int m_CurBossIndex; //Field offset: 0x28
	[CompilerGenerated]
	private bool <curBossIsIn>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private SpineActionController <spineActionController>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private Animator <animator>k__BackingField; //Field offset: 0x38

	public private Animator animator
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private bool curBossIsIn
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public GameObject go
	{
		 get { } //Length: 103
	}

	public static Boss Instance
	{
		 get { } //Length: 386
	}

	public override bool IsGlobal
	{
		 get { } //Length: 3
	}

	public private SpineActionController spineActionController
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	private static Boss() { }

	public Boss() { }

	private string BossFestival(string bossFestivalName) { }

	[CompilerGenerated]
	public Animator get_animator() { }

	[CompilerGenerated]
	public bool get_curBossIsIn() { }

	public GameObject get_go() { }

	public static Boss get_Instance() { }

	public override bool get_IsGlobal() { }

	[CompilerGenerated]
	public SpineActionController get_spineActionController() { }

	private void InitBossObject(string name, int scene, bool isLast = false) { }

	public void InitUpdateAnim() { }

	public override void Pause(bool cor) { }

	public void Play(string key, bool playAnimator = true) { }

	public static void ReleaseReferences() { }

	public override void Resume() { }

	public void SceneBossChange(int idx) { }

	[CompilerGenerated]
	private void set_animator(Animator value) { }

	[CompilerGenerated]
	private void set_curBossIsIn(bool value) { }

	[CompilerGenerated]
	private void set_spineActionController(SpineActionController value) { }

	public void SetBoss() { }

	public void SetDisappear(bool enable) { }

}


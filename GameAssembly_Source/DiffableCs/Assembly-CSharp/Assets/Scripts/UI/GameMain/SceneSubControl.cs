namespace Assets.Scripts.UI.GameMain;

public class SceneSubControl : MonoBehaviour, IRelease, IPause
{
	private static WaitForSeconds s_WaitForSeconds; //Field offset: 0x0
	[SerializeField]
	private int m_SceneIdx; //Field offset: 0x18
	public GameObject scenePoint; //Field offset: 0x20
	private GameObject m_PointGameObject; //Field offset: 0x28
	private Coroutine m_Coroutine; //Field offset: 0x30
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Animator djmaxMidB; //Field offset: 0x38
	public Animator djmaxNearest; //Field offset: 0x40
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private Animator[] m_Animators; //Field offset: 0x48
	[SerializeField]
	private SkeletonAnimation[] m_SkeletonAnimations; //Field offset: 0x50
	[SerializeField]
	private ParticleSystem[] m_ParticleSystems; //Field offset: 0x58
	[SerializeField]
	private DOTweenAnimation[] m_DoTweenAnimations; //Field offset: 0x60
	private bool m_IsFreezeFlag; //Field offset: 0x68
	private bool m_IsPauseed; //Field offset: 0x69
	private bool m_IsPause; //Field offset: 0x6A
	[SerializeField]
	private SceneSurpriseController m_SceneSurpriseController; //Field offset: 0x70

	public bool freezeFlag
	{
		 get { } //Length: 5
	}

	public override bool IsGlobal
	{
		 get { } //Length: 3
	}

	public bool isPause
	{
		 get { } //Length: 5
	}

	public bool pauseed
	{
		 get { } //Length: 5
	}

	public int sceneIndex
	{
		 get { } //Length: 4
	}

	public SceneSubControl() { }

	[CompilerGenerated]
	private void <Init>b__23_0() { }

	public bool get_freezeFlag() { }

	public override bool get_IsGlobal() { }

	public bool get_isPause() { }

	public bool get_pauseed() { }

	public int get_sceneIndex() { }

	public void Init() { }

	private void OnBossIn(object sender, object rev, Object[] pars) { }

	private void OnBossOut(object sender, object rev, Object[] pars) { }

	private void OnEnable() { }

	public override void Pause(bool pauseCorountine) { }

	private void PlayDjmax(bool isIn, float time = 0) { }

	public override void Release(bool isEditor) { }

	public override void Resume() { }

	public void SetFreeze(bool freeze) { }

	private void SetPause_Private(bool pause) { }

}


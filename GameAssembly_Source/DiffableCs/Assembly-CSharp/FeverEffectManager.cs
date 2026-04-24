//Type is in global namespace

public class FeverEffectManager : MonoBehaviour, IPause
{
	private const float COME_OUT_DURING_TIME = 0.15; //Field offset: 0x0
	private const int christmas_fever = 3; //Field offset: 0x0
	private static FeverEffectManager m_Instance; //Field offset: 0x0
	private static int s_WaitingOutside; //Field offset: 0x8
	private static int s_ComeIn; //Field offset: 0xC
	private static int s_ComeOut; //Field offset: 0x10
	private static int s_Standby; //Field offset: 0x14
	[SerializeField]
	private int m_FeverIndex; //Field offset: 0x18
	private ReverseColor m_ReverseColor; //Field offset: 0x20
	[SerializeField]
	private GameObject m_Background; //Field offset: 0x28
	private Animator m_BgAnimator; //Field offset: 0x30
	[SerializeField]
	private SpriteRenderer m_WhitBoardRender; //Field offset: 0x38
	public Vector3 outScenePosition; //Field offset: 0x40
	[SerializeField]
	private GameObject[] m_Particles; //Field offset: 0x50
	[SerializeField]
	private GameObject[] m_EndParticles; //Field offset: 0x58
	private bool m_IsActivatedComeOut; //Field offset: 0x60
	private bool m_IfShow; //Field offset: 0x61
	private UnityGameManager m_UnityGameManager; //Field offset: 0x68
	private List<ParticleSystem> m_PauseParticleSystemList; //Field offset: 0x70
	protected Tweener m_FeverInTween; //Field offset: 0x78
	protected Tweener m_FeverOutTween; //Field offset: 0x80
	[CompilerGenerated]
	private bool <IsGlobal>k__BackingField; //Field offset: 0x88

	public static FeverEffectManager instance
	{
		 get { } //Length: 86
	}

	public private override bool IsGlobal
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private static FeverEffectManager() { }

	public FeverEffectManager() { }

	[CompilerGenerated]
	private float <CancelBadAppleFeverEffect>b__33_0() { }

	[CompilerGenerated]
	private void <CancelBadAppleFeverEffect>b__33_1(float value) { }

	[CompilerGenerated]
	private void <CancelBadAppleFeverEffect>b__33_2() { }

	[CompilerGenerated]
	private void <InitFeverEffect>b__26_0(float t) { }

	[CompilerGenerated]
	private float <InvokeBadAppleFever>b__32_0() { }

	[CompilerGenerated]
	private void <InvokeBadAppleFever>b__32_1(float value) { }

	public void ActivateFever(bool isForce = false) { }

	public void CancelBadAppleFeverEffect() { }

	public void CancelFeverEffect() { }

	private void EnableEndParticles(bool enable) { }

	private void EnableParticles(bool enable) { }

	public static FeverEffectManager get_instance() { }

	[CompilerGenerated]
	public override bool get_IsGlobal() { }

	public void InitFeverBadApple() { }

	public void InitFeverEffect() { }

	private void InvokeBadAppleFever() { }

	private void InvokeNormalFever() { }

	private void OnDestroy() { }

	public override void Pause(bool pauseCorountine) { }

	public override void Resume() { }

	[CompilerGenerated]
	private void set_IsGlobal(bool value) { }

	private void Start() { }

}


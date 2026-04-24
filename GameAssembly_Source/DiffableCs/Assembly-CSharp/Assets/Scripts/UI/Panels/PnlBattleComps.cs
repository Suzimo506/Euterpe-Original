namespace Assets.Scripts.UI.Panels;

public class PnlBattleComps : IPause
{
	public GameObject others; //Field offset: 0x10
	public Slider sldProgress; //Field offset: 0x18
	public Toggle tglAutoPlay; //Field offset: 0x20
	public Animator feverAnimator; //Field offset: 0x28
	public Animator pnlBattleAnim; //Field offset: 0x30
	public ChangeScoreValue scoreValue; //Field offset: 0x38
	public ButtonDisplay BtnPauseActivity; //Field offset: 0x40
	public ButtonDisplay BtnTutorialSkipActivity; //Field offset: 0x50
	public GameObject feverValue; //Field offset: 0x60
	[SerializeField]
	private DOTweenAnimation[] m_Animations; //Field offset: 0x68
	[SerializeField]
	private ParticleSystem[] m_ParticleSystems; //Field offset: 0x70

	public override bool IsGlobal
	{
		 get { } //Length: 3
	}

	public PnlBattleComps() { }

	public override bool get_IsGlobal() { }

	public override void Pause(bool pauseCorountine) { }

	public override void Resume() { }

}


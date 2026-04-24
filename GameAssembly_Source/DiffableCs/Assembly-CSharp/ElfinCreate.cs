//Type is in global namespace

public class ElfinCreate : MonoBehaviour, IPreWarm, IPause
{
	private GameObject m_ElfinObject; //Field offset: 0x18
	private Renderer m_Renderer; //Field offset: 0x20
	private SkeletonMecanim m_SkeletonMecanim; //Field offset: 0x28

	public override bool IsGlobal
	{
		 get { } //Length: 3
	}

	public ElfinCreate() { }

	[CompilerGenerated]
	private void <OnBattleStart>b__4_0() { }

	[CompilerGenerated]
	private void <OnBattleStart>b__4_1() { }

	public override bool get_IsGlobal() { }

	private void OnBattleStart(object sender, object rev, Object[] pars) { }

	public override void Pause(bool pauseCorountine) { }

	public override void PreWarm(int slice) { }

	public override void Resume() { }

}


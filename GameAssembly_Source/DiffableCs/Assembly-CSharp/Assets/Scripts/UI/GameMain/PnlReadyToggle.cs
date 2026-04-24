namespace Assets.Scripts.UI.GameMain;

public class PnlReadyToggle : MonoBehaviour, IPreWarm
{
	public GameObject[] touhouTitle; //Field offset: 0x18
	public PnlReadyComps[] pnlReadyComps; //Field offset: 0x20
	private PnlReadyComps m_CurReadyComp; //Field offset: 0x28
	private AudioClip m_ReadyClip; //Field offset: 0x30
	[SerializeField]
	private RectTransform m_TouhouTransform; //Field offset: 0x38
	private GameObject m_TouhouTitleGo; //Field offset: 0x40

	public PnlReadyToggle() { }

	[CompilerGenerated]
	private void <OnStageStart>b__7_0() { }

	private void OnStageStart(object sender, object rev, Object[] pars) { }

	public override void PreWarm(int slice) { }

	private void TitleToggle() { }

	private void TouhouTitleLogic(string musicUid) { }

}


//Type is in global namespace

public class PnlPreparation : MonoBehaviour, IPreWarm
{
	public Text stageAchievementValue; //Field offset: 0x18
	public Button startButton; //Field offset: 0x20
	public PnlRank[] pnlRanks; //Field offset: 0x28
	public ButtonToggle buttonToggle; //Field offset: 0x30
	public PnlRecord pnlRecord; //Field offset: 0x38
	public PnlPreparationLayAchv pnlPreparationLayAchv; //Field offset: 0x40
	private StringBuilder m_Sb; //Field offset: 0x48

	public PnlPreparation() { }

	private void Awake() { }

	protected override void OnAwake() { }

	protected override void OnBattleStart() { }

	private void OnDiffTglChanged() { }

	protected override void OnEnable() { }

	public override void PreWarm(int slice) { }

	public void RefreshUi() { }

}


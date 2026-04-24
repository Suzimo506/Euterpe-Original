//Type is in global namespace

public class GameMainUI2D : MonoBehaviour, IPause
{
	[SerializeField]
	private Animator m_ZombieSkill; //Field offset: 0x18
	[SerializeField]
	private PnlFail m_PnlFail; //Field offset: 0x20
	[SerializeField]
	private CanvasScaler m_CanvasScaler; //Field offset: 0x28

	public override bool IsGlobal
	{
		 get { } //Length: 3
	}

	public GameMainUI2D() { }

	private void Awake() { }

	public override bool get_IsGlobal() { }

	private void OnBattleFail() { }

	private void OnDestroy() { }

	public override void Pause(bool pauseCorountine) { }

	public override void Resume() { }

}


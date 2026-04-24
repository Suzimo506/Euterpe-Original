namespace Assets.Scripts.UI.GameMain;

public class HitPointSubControl : MonoBehaviour, IPause
{
	[SerializeField]
	private Animator m_Animator; //Field offset: 0x18

	public override bool IsGlobal
	{
		 get { } //Length: 3
	}

	public HitPointSubControl() { }

	private void Awake() { }

	public override bool get_IsGlobal() { }

	public override void Pause(bool pauseCorountine) { }

	public override void Resume() { }

}


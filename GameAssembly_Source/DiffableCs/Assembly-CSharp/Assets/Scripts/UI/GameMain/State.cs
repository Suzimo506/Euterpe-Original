namespace Assets.Scripts.UI.GameMain;

public class State : IPause
{
	private const int count_in = 0; //Field offset: 0x0
	private const int count_standby = 1; //Field offset: 0x0
	private const int count_end = 2; //Field offset: 0x0
	private const int count_off = 3; //Field offset: 0x0
	public TxtAnimatorType txtType; //Field offset: 0x10
	public Text text; //Field offset: 0x18
	public TextMeshPro textMeshPro; //Field offset: 0x20
	public TextMeshProUGUI textMeshProUgui; //Field offset: 0x28
	public int rangeMin; //Field offset: 0x30
	public int rangeMax; //Field offset: 0x34
	public StateAnim txtAnim; //Field offset: 0x38
	public StateAnim otherAnim; //Field offset: 0x40
	public bool resetStandby; //Field offset: 0x48
	private int prevCount; //Field offset: 0x4C
	private bool invokeAnimator; //Field offset: 0x50

	public override bool IsGlobal
	{
		 get { } //Length: 3
	}

	public State() { }

	public void Execute(int count) { }

	public override bool get_IsGlobal() { }

	public void Init() { }

	public override void Pause(bool pauseCorountine) { }

	public override void Resume() { }

	private void SetText(int count) { }

}


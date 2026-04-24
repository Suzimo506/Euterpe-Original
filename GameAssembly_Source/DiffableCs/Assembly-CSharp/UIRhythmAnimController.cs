//Type is in global namespace

public class UIRhythmAnimController : SingletonMonoBehaviour<UIRhythmAnimController>, IPause
{
	public GameObject rdStopAim; //Field offset: 0x18
	public GameObject rdPhoneTipsAim; //Field offset: 0x20
	public GameObject rdMistakeAim; //Field offset: 0x28
	private bool isOnStopAim; //Field offset: 0x30
	private bool isOnPhoneTipsAim; //Field offset: 0x31

	public override bool IsGlobal
	{
		 get { } //Length: 3
	}

	public UIRhythmAnimController() { }

	public override bool get_IsGlobal() { }

	public override void Pause(bool pauseCorountine) { }

	public void PlayMistakeAim() { }

	public void PlayPhoneTipsAim() { }

	public void PlayStopAnim() { }

	public override void Resume() { }

	public void SetPause(bool isRun = true) { }

	private void Start() { }

}


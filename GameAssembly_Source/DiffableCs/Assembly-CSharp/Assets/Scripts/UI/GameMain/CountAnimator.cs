namespace Assets.Scripts.UI.GameMain;

public class CountAnimator : MonoBehaviour, IRelease, IPause
{
	public CountType countType; //Field offset: 0x18
	public State[] states; //Field offset: 0x20

	public override bool IsGlobal
	{
		 get { } //Length: 3
	}

	public CountAnimator() { }

	public override bool get_IsGlobal() { }

	private uint GetEventType() { }

	public void Init() { }

	private void OnCountChanged(int count) { }

	public override void Pause(bool pauseCorountine) { }

	public override void Release(bool isEditor) { }

	public override void Resume() { }

}


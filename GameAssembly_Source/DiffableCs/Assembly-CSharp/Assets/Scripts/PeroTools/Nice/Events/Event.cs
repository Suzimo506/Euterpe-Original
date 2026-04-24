namespace Assets.Scripts.PeroTools.Nice.Events;

public abstract class Event : SerializedMonoBehaviour, IPlayable, IPreWarm
{
	[SerializeField]
	private Group m_Group; //Field offset: 0x58
	private bool m_HasEnter; //Field offset: 0x60
	protected EventInvoker m_Invoker; //Field offset: 0x68

	public override float duration
	{
		 get { } //Length: 39
	}

	public List<IPlayable> playables
	{
		 get { } //Length: 27
	}

	protected Event() { }

	private void Awake() { }

	public override void Enter() { }

	public override void Execute() { }

	public override void Exit() { }

	public override float get_duration() { }

	public List<IPlayable> get_playables() { }

	public List<T> GetPlayables() { }

	private void OnDestroy() { }

	protected override void OnEnter() { }

	public static EventInvoker OnEvent(GameObject gameObject, Type eventType) { }

	protected override void OnExecute() { }

	protected override void OnExit() { }

	public override void Pause() { }

	public override void PreWarm(int slice) { }

	public override void Resume() { }

}


namespace Assets.Scripts.PeroTools.Nice.Events;

[DisallowMultipleComponent]
public class OnClick : Event
{
	[SerializeField]
	private Button m_Button; //Field offset: 0x70

	public OnClick() { }

	protected virtual void OnEnter() { }

	protected virtual void OnExecute() { }

	protected virtual void OnExit() { }

	protected void Run() { }

}


namespace Assets.Scripts.PeroTools.Nice.Events;

[DisallowMultipleComponent]
public class OnTap : Event
{
	private float m_HardTime; //Field offset: 0x70
	private float m_TapTime; //Field offset: 0x74

	public OnTap() { }

	[CompilerGenerated]
	private void <OnEnter>b__2_0(float arg0) { }

	private void Do() { }

	protected virtual void OnEnter() { }

	protected virtual void OnExit() { }

}


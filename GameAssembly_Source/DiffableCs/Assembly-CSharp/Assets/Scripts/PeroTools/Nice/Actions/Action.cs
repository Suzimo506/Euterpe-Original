namespace Assets.Scripts.PeroTools.Nice.Actions;

public abstract class Action : IPlayable
{

	public override float duration
	{
		 get { } //Length: 4
	}

	protected Action() { }

	public override void Enter() { }

	public override void Execute() { }

	public override void Exit() { }

	public override float get_duration() { }

	public override void OnGUISelected() { }

	public override void Pause() { }

	public override void Resume() { }

}


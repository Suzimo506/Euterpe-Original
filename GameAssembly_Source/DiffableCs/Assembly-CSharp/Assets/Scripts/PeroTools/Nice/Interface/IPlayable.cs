namespace Assets.Scripts.PeroTools.Nice.Interface;

public interface IPlayable
{

	public float duration
	{
		 get { } //Length: 0
	}

	public void Enter() { }

	public void Execute() { }

	public void Exit() { }

	public float get_duration() { }

	public void Pause() { }

	public void Resume() { }

}


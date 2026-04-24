namespace Assets.Scripts.PeroTools.Nice.Actions;

public class Random : Group
{
	private IPlayable m_Playable; //Field offset: 0x28

	public virtual float duration
	{
		 get { } //Length: 131
	}

	public Random() { }

	public virtual void Execute() { }

	public virtual float get_duration() { }

}


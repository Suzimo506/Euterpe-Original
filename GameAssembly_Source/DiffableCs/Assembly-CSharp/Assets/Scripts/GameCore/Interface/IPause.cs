namespace Assets.Scripts.GameCore.Interface;

public interface IPause
{

	public bool IsGlobal
	{
		 get { } //Length: 0
	}

	public bool get_IsGlobal() { }

	public void Pause(bool pauseCorountine) { }

	public void Resume() { }

}


namespace Assets.Scripts.GameCore.Interface;

public interface IUpdate
{

	public LoopType LoopType
	{
		 get { } //Length: 0
	}

	public LoopType get_LoopType() { }

	public void OnUpdate() { }

}


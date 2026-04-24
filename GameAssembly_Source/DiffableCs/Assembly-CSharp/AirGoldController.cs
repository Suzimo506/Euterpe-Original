//Type is in global namespace

public class AirGoldController : BaseEnemyObjectController
{
	private bool isBeAttacked; //Field offset: 0x1F0

	public AirGoldController() { }

	public virtual void OnControllerAttacked(int result, bool isDeaded) { }

	public virtual bool OnControllerMiss(int idx) { }

}


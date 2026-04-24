namespace Assets.Scripts.GameCore.Managers;

public abstract class BaseManager
{

	protected BaseManager() { }

	public abstract void AwakeInit() { }

	public abstract void Release() { }

	public override void StartInit() { }

}


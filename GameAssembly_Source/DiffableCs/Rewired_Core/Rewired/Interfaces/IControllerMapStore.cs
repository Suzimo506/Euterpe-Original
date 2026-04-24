namespace Rewired.Interfaces;

public interface IControllerMapStore
{

	public ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) { }

	public void SaveControllerMap(int playerId, ControllerMap controllerMap) { }

}


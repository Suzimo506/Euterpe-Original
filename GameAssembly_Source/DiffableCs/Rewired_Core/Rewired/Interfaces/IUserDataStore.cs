namespace Rewired.Interfaces;

public interface IUserDataStore
{

	public void Load() { }

	public void LoadControllerData(int playerId, ControllerType controllerType, int controllerId) { }

	public void LoadControllerData(ControllerType controllerType, int controllerId) { }

	public void LoadInputBehavior(int playerId, int behaviorId) { }

	public void LoadPlayerData(int playerId) { }

	public void Save() { }

	public void SaveControllerData(int playerId, ControllerType controllerType, int controllerId) { }

	public void SaveControllerData(ControllerType controllerType, int controllerId) { }

	public void SaveInputBehavior(int playerId, int behaviorId) { }

	public void SavePlayerData(int playerId) { }

}


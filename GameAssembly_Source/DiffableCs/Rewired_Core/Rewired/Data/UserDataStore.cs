namespace Rewired.Data;

[CustomClassObfuscation]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class UserDataStore : MonoBehaviour, IUserDataStore, IControllerMapStore
{

	protected UserDataStore() { }

	internal void Initialize() { }

	public abstract void Load() { }

	public abstract void LoadControllerData(int playerId, ControllerType controllerType, int controllerId) { }

	public abstract void LoadControllerData(ControllerType controllerType, int controllerId) { }

	public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) { }

	public abstract void LoadInputBehavior(int playerId, int behaviorId) { }

	public abstract void LoadPlayerData(int playerId) { }

	protected abstract void OnControllerConnected(ControllerStatusChangedEventArgs args) { }

	protected abstract void OnControllerDisconnected(ControllerStatusChangedEventArgs args) { }

	[Obsolete]
	protected override void OnControllerPreDiscconnect(ControllerStatusChangedEventArgs args) { }

	protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args) { }

	private void OnDestroy() { }

	protected abstract void OnInitialize() { }

	public abstract void Save() { }

	public abstract void SaveControllerData(int playerId, ControllerType controllerType, int controllerId) { }

	public abstract void SaveControllerData(ControllerType controllerType, int controllerId) { }

	public override void SaveControllerMap(int playerId, ControllerMap controllerMap) { }

	public abstract void SaveInputBehavior(int playerId, int behaviorId) { }

	public abstract void SavePlayerData(int playerId) { }

}


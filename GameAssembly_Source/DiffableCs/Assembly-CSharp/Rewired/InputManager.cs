namespace Rewired;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class InputManager : InputManager_Base
{
	private bool ignoreRecompile; //Field offset: 0x50

	public InputManager() { }

	private bool CheckDeviceName(string searchPattern, string deviceName, string deviceModel) { }

	protected virtual void CheckRecompile() { }

	protected virtual void DetectPlatform() { }

	protected virtual IExternalTools GetExternalTools() { }

	protected virtual void OnDeinitialized() { }

	protected virtual void OnInitialized() { }

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	private void SubscribeEvents() { }

	private void UnsubscribeEvents() { }

}


namespace Rewired.Interfaces;

[CustomClassObfuscation]
[CustomObfuscation]
internal interface ISteamControllerInternal
{

	public bool IsConnected
	{
		 get { } //Length: 0
	}

	public int MaxActionSourceCount
	{
		 get { } //Length: 0
	}

	public bool get_IsConnected() { }

	public int get_MaxActionSourceCount() { }

	public ulong GetActionSetHandle(ref string actionSetName) { }

	public string GetActionSetName(ulong handle) { }

	public ulong GetActiveActionSetHandle() { }

	public string GetActiveActionSetName() { }

	public ulong GetAnalogActionHandle(ref string actionName) { }

	public string GetAnalogActionName(ulong handle) { }

	public IList<SteamControllerActionOrigin> GetAnalogActionOrigins(ref string actionSetName, ref string actionName) { }

	public IList<SteamControllerActionOrigin> GetAnalogActionOrigins(ulong actionSetHandle, ulong actionHandle) { }

	public Vector2 GetAnalogActionValue(ulong actionHandle) { }

	public Vector2 GetAnalogActionValue(ref string actionName) { }

	public ulong GetDigitalActionHandle(ref string actionName) { }

	public string GetDigitalActionName(ulong handle) { }

	public IList<SteamControllerActionOrigin> GetDigitalActionOrigins(ref string actionSetName, ref string actionName) { }

	public IList<SteamControllerActionOrigin> GetDigitalActionOrigins(ulong actionSetHandle, ulong actionHandle) { }

	public bool GetDigitalActionValue(ulong actionHandle) { }

	public bool GetDigitalActionValue(ref string actionName) { }

	public bool SetActiveActionSet(ulong actionSetHandle) { }

	public bool SetActiveActionSet(ref string actionSetName) { }

	public void SetHapticPulse(SteamControllerPadType targetPad, float durationSeconds) { }

	public void SetHapticPulse(SteamControllerPadType targetPad, ushort durationMicroSeconds) { }

	public void ShowBindingPanel() { }

}


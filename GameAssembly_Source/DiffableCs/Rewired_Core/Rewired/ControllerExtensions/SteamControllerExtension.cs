namespace Rewired.ControllerExtensions;

[CustomClassObfuscation]
[CustomObfuscation]
internal class SteamControllerExtension : Extension
{
	private class yXMtktsMWMeFpIINHzrHYjFOYSYh : IControllerExtensionSource
	{
		public readonly ISteamControllerInternal nyBIAnmhcGOAnatFcjZEsGoIGQFW; //Field offset: 0x10

		public yXMtktsMWMeFpIINHzrHYjFOYSYh(ISteamControllerInternal unnamed_param_0) { }

	}

	private yXMtktsMWMeFpIINHzrHYjFOYSYh sGQvzdoiXDPQjVYqDeByKrgVBTaQ; //Field offset: 0x28

	internal ISteamControllerInternal internalController
	{
		internal get { } //Length: 27
	}

	private Joystick joystick
	{
		private get { } //Length: 56
	}

	internal SteamControllerExtension(ISteamControllerInternal unnamed_param_0) { }

	private SteamControllerExtension(SteamControllerExtension unnamed_param_0) { }

	internal virtual Extension Clone() { }

	private void cnKeHmkQcxuiGFzzSHmDurQFUSeaA() { }

	internal ISteamControllerInternal get_internalController() { }

	public ulong GetActionSetHandle(string actionSetName) { }

	public string GetActionSetName(ulong actionSetHandle) { }

	public ulong GetActiveActionSetHandle() { }

	public string GetActiveActionSetName() { }

	public ulong GetAnalogActionHandle(string actionName) { }

	public string GetAnalogActionName(ulong actionHandle) { }

	public IList<SteamControllerActionOrigin> GetAnalogActionOrigins(string actionSetName, string actionName) { }

	public IList<SteamControllerActionOrigin> GetAnalogActionOrigins(ulong actionSetHandle, ulong actionHandle) { }

	public Vector2 GetAnalogActionValue(string actionName) { }

	public Vector2 GetAnalogActionValue(ulong actionHandle) { }

	public ulong GetDigitalActionHandle(string actionName) { }

	public string GetDigitalActionName(ulong actionHandle) { }

	public IList<SteamControllerActionOrigin> GetDigitalActionOrigins(ulong actionSetHandle, ulong actionHandle) { }

	public IList<SteamControllerActionOrigin> GetDigitalActionOrigins(string actionSetName, string actionName) { }

	public bool GetDigitalActionValue(string actionName) { }

	public bool GetDigitalActionValue(ulong actionHandle) { }

	private Joystick IONRbDEnqkRDkSvFFLhMWbXoyTGE() { }

	public bool SetActiveActionSet(string actionSetName) { }

	public bool SetActiveActionSet(ulong actionSetHandle) { }

	public void SetHapticPulse(SteamControllerPadType targePad, float durationSeconds) { }

	public void SetHapticPulse(SteamControllerPadType targePad, ushort durationMicroSeconds) { }

	public void ShowBindingPanel() { }

	internal virtual void SourceUpdated(IControllerExtensionSource source) { }

	internal virtual void UpdateData(UpdateLoopType updateLoop) { }

}


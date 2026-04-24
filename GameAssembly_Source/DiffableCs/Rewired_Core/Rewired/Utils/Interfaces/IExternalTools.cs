namespace Rewired.Utils.Interfaces;

public interface IExternalTools
{

	public event Action<Boolean> EditorPausedStateChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<UInt32, Boolean> XboxOneInput_OnGamepadStateChange
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public bool isEditorPaused
	{
		 get { } //Length: 0
	}

	public bool UnityInput_IsTouchPressureSupported
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_EditorPausedStateChangedEvent(Action<Boolean> value) { }

	[CompilerGenerated]
	public void add_XboxOneInput_OnGamepadStateChange(Action<UInt32, Boolean> value) { }

	public IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload) { }

	public void Destroy() { }

	public bool get_isEditorPaused() { }

	public bool get_UnityInput_IsTouchPressureSupported() { }

	public int GetAndroidAPILevel() { }

	public Type[] GetControllerTemplateInterfaceTypes() { }

	public Type[] GetControllerTemplateTypes() { }

	public void GetDeviceVIDPIDs(out List<Int32>& vids, out List<Int32>& pids) { }

	public string GetFocusedEditorWindowTitle() { }

	public object GetPlatformInitializer() { }

	public bool IsEditorSceneViewFocused() { }

	public bool LinuxInput_IsJoystickPreconfigured(string name) { }

	[CompilerGenerated]
	public void remove_EditorPausedStateChangedEvent(Action<Boolean> value) { }

	[CompilerGenerated]
	public void remove_XboxOneInput_OnGamepadStateChange(Action<UInt32, Boolean> value) { }

	public float UnityInput_GetTouchMaximumPossiblePressure(ref Touch touch) { }

	public float UnityInput_GetTouchPressure(ref Touch touch) { }

	public bool UnityUI_Graphic_GetRaycastTarget(object graphic) { }

	public void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value) { }

	public void XboxOne_Gamepad_PulseVibrateMotor(ulong xboxOneJoystickId, int motor, float startLevel, float endLevel, ulong durationMS) { }

	public bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel) { }

	public void XboxOne_Gamepad_UpdatePlugin() { }

	public ulong XboxOneInput_GetControllerId(uint unityJoystickId) { }

	public string XboxOneInput_GetControllerType(ulong xboxControllerId) { }

	public uint XboxOneInput_GetJoystickId(ulong xboxControllerId) { }

	public int XboxOneInput_GetUserIdForGamepad(uint id) { }

	public bool XboxOneInput_IsGamepadActive(uint unityJoystickId) { }

}


namespace Rewired.Utils;

[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ExternalTools : IExternalTools
{
	private static Func<Object> _getPlatformInitializerDelegate; //Field offset: 0x0
	private bool _isEditorPaused; //Field offset: 0x10
	private Action<Boolean> _EditorPausedStateChangedEvent; //Field offset: 0x18
	[CompilerGenerated]
	private Action<UInt32, Boolean> XboxOneInput_OnGamepadStateChange; //Field offset: 0x20

	public override event Action<Boolean> EditorPausedStateChangedEvent
	{
		 add { } //Length: 118
		 remove { } //Length: 118
	}

	public override event Action<UInt32, Boolean> XboxOneInput_OnGamepadStateChange
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public static Func<Object> getPlatformInitializerDelegate
	{
		 get { } //Length: 53
		 set { } //Length: 133
	}

	public override bool isEditorPaused
	{
		 get { } //Length: 5
	}

	public override bool UnityInput_IsTouchPressureSupported
	{
		 get { } //Length: 7
	}

	public ExternalTools() { }

	public override void add_EditorPausedStateChangedEvent(Action<Boolean> value) { }

	[CompilerGenerated]
	public override void add_XboxOneInput_OnGamepadStateChange(Action<UInt32, Boolean> value) { }

	public override IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload) { }

	public override void Destroy() { }

	public static Func<Object> get_getPlatformInitializerDelegate() { }

	public override bool get_isEditorPaused() { }

	public override bool get_UnityInput_IsTouchPressureSupported() { }

	public override int GetAndroidAPILevel() { }

	public override Type[] GetControllerTemplateInterfaceTypes() { }

	public override Type[] GetControllerTemplateTypes() { }

	public override void GetDeviceVIDPIDs(out List<Int32>& vids, out List<Int32>& pids) { }

	public override string GetFocusedEditorWindowTitle() { }

	public override object GetPlatformInitializer() { }

	public override bool IsEditorSceneViewFocused() { }

	public override bool LinuxInput_IsJoystickPreconfigured(string name) { }

	public override void remove_EditorPausedStateChangedEvent(Action<Boolean> value) { }

	[CompilerGenerated]
	public override void remove_XboxOneInput_OnGamepadStateChange(Action<UInt32, Boolean> value) { }

	public static void set_getPlatformInitializerDelegate(Func<Object> value) { }

	public override float UnityInput_GetTouchMaximumPossiblePressure(ref Touch touch) { }

	public override float UnityInput_GetTouchPressure(ref Touch touch) { }

	public override bool UnityUI_Graphic_GetRaycastTarget(object graphic) { }

	public override void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value) { }

	public override void XboxOne_Gamepad_PulseVibrateMotor(ulong xboxOneJoystickId, int motorInt, float startLevel, float endLevel, ulong durationMS) { }

	public override bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel) { }

	public override void XboxOne_Gamepad_UpdatePlugin() { }

	public override ulong XboxOneInput_GetControllerId(uint unityJoystickId) { }

	public override string XboxOneInput_GetControllerType(ulong xboxControllerId) { }

	public override uint XboxOneInput_GetJoystickId(ulong xboxControllerId) { }

	public override int XboxOneInput_GetUserIdForGamepad(uint id) { }

	public override bool XboxOneInput_IsGamepadActive(uint unityJoystickId) { }

}


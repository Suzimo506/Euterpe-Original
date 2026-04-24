namespace Steamworks;

public static class SteamInput
{

	public static void ActivateActionSet(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle) { }

	public static void ActivateActionSetLayer(InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle) { }

	public static bool BNewDataAvailable() { }

	public static bool BWaitForData(bool bWaitForever, uint unTimeout) { }

	public static void DeactivateActionSetLayer(InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle) { }

	public static void DeactivateAllActionSetLayers(InputHandle_t inputHandle) { }

	public static void EnableActionEventCallbacks(SteamInputActionEventCallbackPointer pCallback) { }

	public static void EnableDeviceCallbacks() { }

	public static EInputActionOrigin GetActionOriginFromXboxOrigin(InputHandle_t inputHandle, EXboxOrigin eOrigin) { }

	public static InputActionSetHandle_t GetActionSetHandle(string pszActionSetName) { }

	public static int GetActiveActionSetLayers(InputHandle_t inputHandle, InputActionSetHandle_t[] handlesOut) { }

	public static InputAnalogActionData_t GetAnalogActionData(InputHandle_t inputHandle, InputAnalogActionHandle_t analogActionHandle) { }

	public static InputAnalogActionHandle_t GetAnalogActionHandle(string pszActionName) { }

	public static int GetAnalogActionOrigins(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputAnalogActionHandle_t analogActionHandle, EInputActionOrigin[] originsOut) { }

	public static int GetConnectedControllers(InputHandle_t[] handlesOut) { }

	public static InputHandle_t GetControllerForGamepadIndex(int nIndex) { }

	public static InputActionSetHandle_t GetCurrentActionSet(InputHandle_t inputHandle) { }

	public static bool GetDeviceBindingRevision(InputHandle_t inputHandle, out int pMajor, out int pMinor) { }

	public static InputDigitalActionData_t GetDigitalActionData(InputHandle_t inputHandle, InputDigitalActionHandle_t digitalActionHandle) { }

	public static InputDigitalActionHandle_t GetDigitalActionHandle(string pszActionName) { }

	public static int GetDigitalActionOrigins(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputDigitalActionHandle_t digitalActionHandle, EInputActionOrigin[] originsOut) { }

	public static int GetGamepadIndexForController(InputHandle_t ulinputHandle) { }

	public static string GetGlyphForActionOrigin_Legacy(EInputActionOrigin eOrigin) { }

	public static string GetGlyphForXboxOrigin(EXboxOrigin eOrigin) { }

	public static string GetGlyphPNGForActionOrigin(EInputActionOrigin eOrigin, ESteamInputGlyphSize eSize, uint unFlags) { }

	public static string GetGlyphSVGForActionOrigin(EInputActionOrigin eOrigin, uint unFlags) { }

	public static ESteamInputType GetInputTypeForHandle(InputHandle_t inputHandle) { }

	public static InputMotionData_t GetMotionData(InputHandle_t inputHandle) { }

	public static uint GetRemotePlaySessionID(InputHandle_t inputHandle) { }

	public static ushort GetSessionInputConfigurationSettings() { }

	public static string GetStringForActionOrigin(EInputActionOrigin eOrigin) { }

	public static string GetStringForAnalogActionName(InputAnalogActionHandle_t eActionHandle) { }

	public static string GetStringForDigitalActionName(InputDigitalActionHandle_t eActionHandle) { }

	public static string GetStringForXboxOrigin(EXboxOrigin eOrigin) { }

	public static bool Init(bool bExplicitlyCallRunFrame) { }

	public static void Legacy_TriggerHapticPulse(InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec) { }

	public static void Legacy_TriggerRepeatedHapticPulse(InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags) { }

	public static void RunFrame(bool bReservedValue = true) { }

	public static bool SetInputActionManifestFilePath(string pchInputActionManifestAbsolutePath) { }

	public static void SetLEDColor(InputHandle_t inputHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags) { }

	public static bool ShowBindingPanel(InputHandle_t inputHandle) { }

	public static bool Shutdown() { }

	public static void StopAnalogActionMomentum(InputHandle_t inputHandle, InputAnalogActionHandle_t eAction) { }

	public static EInputActionOrigin TranslateActionOrigin(ESteamInputType eDestinationInputType, EInputActionOrigin eSourceOrigin) { }

	public static void TriggerSimpleHapticEvent(InputHandle_t inputHandle, EControllerHapticLocation eHapticLocation, byte nIntensity, char nGainDB, byte nOtherIntensity, char nOtherGainDB) { }

	public static void TriggerVibration(InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed) { }

	public static void TriggerVibrationExtended(InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed, ushort usLeftTriggerSpeed, ushort usRightTriggerSpeed) { }

}


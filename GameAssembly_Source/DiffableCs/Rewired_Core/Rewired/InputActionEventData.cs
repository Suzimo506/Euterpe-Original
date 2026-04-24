namespace Rewired;

public struct InputActionEventData
{
	private FpebmSZGdWqBmLHfJyHvhNXRQKDT wYoQAMLHeQAluOFMVApyQKDpoKvj; //Field offset: 0x0
	private InputActionEventType qQROynsLLAwbtBLidJEZDxKhEyhc; //Field offset: 0x8
	public readonly int playerId; //Field offset: 0xC
	public readonly int actionId; //Field offset: 0x10
	public readonly UpdateLoopType updateLoop; //Field offset: 0x14

	public string actionDescriptiveName
	{
		 get { } //Length: 250
	}

	public string actionName
	{
		 get { } //Length: 250
	}

	public internal InputActionEventType eventType
	{
		 get { } //Length: 4
		internal set { } //Length: 4
	}

	public Player player
	{
		 get { } //Length: 217
	}

	internal InputActionEventData(FpebmSZGdWqBmLHfJyHvhNXRQKDT unnamed_param_0, int unnamed_param_1, int unnamed_param_2, UpdateLoopType unnamed_param_3) { }

	public string get_actionDescriptiveName() { }

	public string get_actionName() { }

	public InputActionEventType get_eventType() { }

	public Player get_player() { }

	public float GetAxis() { }

	public AxisCoordinateMode GetAxisCoordinateMode() { }

	public AxisCoordinateMode GetAxisCoordinateModePrev() { }

	public float GetAxisDelta() { }

	public float GetAxisPrev() { }

	public float GetAxisRaw() { }

	public AxisCoordinateMode GetAxisRawCoordinateMode() { }

	public AxisCoordinateMode GetAxisRawCoordinateModePrev() { }

	public float GetAxisRawDelta() { }

	public float GetAxisRawPrev() { }

	public double GetAxisRawTimeActive() { }

	public double GetAxisRawTimeInactive() { }

	public double GetAxisTimeActive() { }

	public double GetAxisTimeInactive() { }

	public bool GetButton() { }

	public bool GetButtonDoublePressDown(float speed) { }

	public bool GetButtonDoublePressDown() { }

	public bool GetButtonDoublePressHold(float speed) { }

	public bool GetButtonDoublePressHold() { }

	public bool GetButtonDoublePressUp(float speed) { }

	public bool GetButtonDoublePressUp() { }

	public bool GetButtonDown() { }

	public bool GetButtonLongPress() { }

	public bool GetButtonLongPressDown() { }

	public bool GetButtonLongPressUp() { }

	public bool GetButtonPrev() { }

	public bool GetButtonRepeating() { }

	public bool GetButtonShortPress() { }

	public bool GetButtonShortPressDown() { }

	public bool GetButtonShortPressUp() { }

	public bool GetButtonSinglePressDown() { }

	public bool GetButtonSinglePressHold() { }

	public bool GetButtonSinglePressUp() { }

	public bool GetButtonTimedPress(float time, float expireIn) { }

	public bool GetButtonTimedPress(float time) { }

	public bool GetButtonTimedPressDown(float time) { }

	public bool GetButtonTimedPressUp(float time, float expireIn) { }

	public bool GetButtonTimedPressUp(float time) { }

	public double GetButtonTimePressed() { }

	public double GetButtonTimeUnpressed() { }

	public bool GetButtonUp() { }

	public IList<InputActionSourceData> GetCurrentInputSources() { }

	public bool GetNegativeButton() { }

	public bool GetNegativeButtonDoublePressDown(float speed) { }

	public bool GetNegativeButtonDoublePressDown() { }

	public bool GetNegativeButtonDoublePressHold(float speed) { }

	public bool GetNegativeButtonDoublePressHold() { }

	public bool GetNegativeButtonDoublePressUp() { }

	public bool GetNegativeButtonDoublePressUp(float speed) { }

	public bool GetNegativeButtonDown() { }

	public bool GetNegativeButtonLongPress() { }

	public bool GetNegativeButtonLongPressDown() { }

	public bool GetNegativeButtonLongPressUp() { }

	public bool GetNegativeButtonPrev() { }

	public bool GetNegativeButtonRepeating() { }

	public bool GetNegativeButtonShortPress() { }

	public bool GetNegativeButtonShortPressDown() { }

	public bool GetNegativeButtonShortPressUp() { }

	public bool GetNegativeButtonSinglePressDown() { }

	public bool GetNegativeButtonSinglePressHold() { }

	public bool GetNegativeButtonSinglePressUp() { }

	public bool GetNegativeButtonTimedPress(float time, float expireIn) { }

	public bool GetNegativeButtonTimedPress(float time) { }

	public bool GetNegativeButtonTimedPressDown(float time) { }

	public bool GetNegativeButtonTimedPressUp(float time) { }

	public bool GetNegativeButtonTimedPressUp(float time, float expireIn) { }

	public double GetNegativeButtonTimePressed() { }

	public double GetNegativeButtonTimeUnpressed() { }

	public bool GetNegativeButtonUp() { }

	public bool IsCurrentInputSource(Controller controller) { }

	public bool IsCurrentInputSource(ControllerType controllerType) { }

	public bool IsCurrentInputSource(ControllerType controllerType, int controllerId) { }

	internal void pXRnYzEZrKPyZDLTDxsPmEFaGdxS(InputActionEventType unnamed_param_0) { }

}


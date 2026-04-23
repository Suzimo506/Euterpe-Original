using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Rewired.Integration.UnityUI;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper;

[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6530", Offset = "0x5930")]
[Token(Token = "0x20001F7")]
public class CalibrationWindow : Window
{
	[Token(Token = "0x2000A79")]
	public enum ButtonIdentifier
	{
		[Token(Token = "0x400371A")]
		Done,
		[Token(Token = "0x400371B")]
		Cancel,
		[Token(Token = "0x400371C")]
		Default,
		[Token(Token = "0x400371D")]
		Calibrate
	}

	[Token(Token = "0x4000DC5")]
	private const float minSensitivityOtherAxes = 0.1f;

	[Token(Token = "0x4000DC6")]
	private const float maxDeadzone = 0.8f;

	[Token(Token = "0x4000DC7")]
	[SerializeField]
	[FieldOffset(Offset = "0x80")]
	private RectTransform rightContentContainer;

	[Token(Token = "0x4000DC8")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private RectTransform valueDisplayGroup;

	[SerializeField]
	[Token(Token = "0x4000DC9")]
	[FieldOffset(Offset = "0x90")]
	private RectTransform calibratedValueMarker;

	[SerializeField]
	[Token(Token = "0x4000DCA")]
	[FieldOffset(Offset = "0x98")]
	private RectTransform rawValueMarker;

	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000DCB")]
	[SerializeField]
	private RectTransform calibratedZeroMarker;

	[SerializeField]
	[Token(Token = "0x4000DCC")]
	[FieldOffset(Offset = "0xA8")]
	private RectTransform deadzoneArea;

	[SerializeField]
	[Token(Token = "0x4000DCD")]
	[FieldOffset(Offset = "0xB0")]
	private Slider deadzoneSlider;

	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000DCE")]
	[SerializeField]
	private Slider zeroSlider;

	[SerializeField]
	[Token(Token = "0x4000DCF")]
	[FieldOffset(Offset = "0xC0")]
	private Slider sensitivitySlider;

	[Token(Token = "0x4000DD0")]
	[SerializeField]
	[FieldOffset(Offset = "0xC8")]
	private Toggle invertToggle;

	[SerializeField]
	[Token(Token = "0x4000DD1")]
	[FieldOffset(Offset = "0xD0")]
	private RectTransform axisScrollAreaContent;

	[SerializeField]
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000DD2")]
	private Button doneButton;

	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000DD3")]
	[SerializeField]
	private Button calibrateButton;

	[Token(Token = "0x4000DD4")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private Text doneButtonLabel;

	[SerializeField]
	[Token(Token = "0x4000DD5")]
	[FieldOffset(Offset = "0xF0")]
	private Text cancelButtonLabel;

	[Token(Token = "0x4000DD6")]
	[SerializeField]
	[FieldOffset(Offset = "0xF8")]
	private Text defaultButtonLabel;

	[SerializeField]
	[Token(Token = "0x4000DD7")]
	[FieldOffset(Offset = "0x100")]
	private Text deadzoneSliderLabel;

	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	[Token(Token = "0x4000DD8")]
	private Text zeroSliderLabel;

	[SerializeField]
	[Token(Token = "0x4000DD9")]
	[FieldOffset(Offset = "0x110")]
	private Text sensitivitySliderLabel;

	[SerializeField]
	[Token(Token = "0x4000DDA")]
	[FieldOffset(Offset = "0x118")]
	private Text invertToggleLabel;

	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[Token(Token = "0x4000DDB")]
	private Text calibrateButtonLabel;

	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000DDC")]
	[SerializeField]
	private GameObject axisButtonPrefab;

	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000DDD")]
	private Joystick joystick;

	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000DDE")]
	private string origCalibrationData;

	[Token(Token = "0x4000DDF")]
	[FieldOffset(Offset = "0x140")]
	private int selectedAxis;

	[Token(Token = "0x4000DE0")]
	[FieldOffset(Offset = "0x148")]
	private AxisCalibrationData origSelectedAxisCalibrationData;

	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x4000DE1")]
	private float displayAreaWidth;

	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x4000DE2")]
	private List<Button> axisButtons;

	[Token(Token = "0x4000DE3")]
	[FieldOffset(Offset = "0x190")]
	private Dictionary<int, Action<int>> buttonCallbacks;

	[Token(Token = "0x4000DE4")]
	[FieldOffset(Offset = "0x198")]
	private int playerId;

	[Token(Token = "0x4000DE5")]
	[FieldOffset(Offset = "0x1A0")]
	private RewiredStandaloneInputModule rewiredStandaloneInputModule;

	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4000DE6")]
	private int menuHorizActionId;

	[Token(Token = "0x4000DE7")]
	[FieldOffset(Offset = "0x1AC")]
	private int menuVertActionId;

	[Token(Token = "0x4000DE8")]
	[FieldOffset(Offset = "0x1B0")]
	private float minSensitivity;

	[Token(Token = "0x1700033D")]
	private bool axisSelected
	{
		[Token(Token = "0x60010CF")]
		[Address(RVA = "0x884D40", Offset = "0x883540", Length = "0x4E")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700033E")]
	private AxisCalibration axisCalibration
	{
		[Address(RVA = "0x884CB0", Offset = "0x8834B0", Length = "0x82")]
		[Token(Token = "0x60010D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60010D1")]
	[Address(RVA = "0x882530", Offset = "0x880D30", Length = "0x83F")]
	public override void Initialize(int id, Func<int, bool> isFocusedCallback)
	{
	}

	[Token(Token = "0x60010D2")]
	[Address(RVA = "0x884330", Offset = "0x882B30", Length = "0x64B")]
	public void SetJoystick(int playerId, Joystick joystick)
	{
	}

	[Token(Token = "0x60010D3")]
	[Address(RVA = "0x884270", Offset = "0x882A70", Length = "0xB2")]
	public void SetButtonCallback(ButtonIdentifier buttonIdentifier, Action<int> callback)
	{
	}

	[Token(Token = "0x60010D4")]
	[Address(RVA = "0x882350", Offset = "0x880B50", Length = "0xAE")]
	public override void Cancel()
	{
	}

	[Token(Token = "0x60010D5")]
	[Address(RVA = "0x884C60", Offset = "0x883460", Length = "0x2B")]
	protected override void Update()
	{
	}

	[Token(Token = "0x60010D6")]
	[Address(RVA = "0x883260", Offset = "0x881A60", Length = "0x7A")]
	public void OnDone()
	{
	}

	[Token(Token = "0x60010D7")]
	[Address(RVA = "0x883090", Offset = "0x881890", Length = "0x11")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x60010D8")]
	[Address(RVA = "0x883360", Offset = "0x881B60", Length = "0x5F")]
	public void OnRestoreDefault()
	{
	}

	[Address(RVA = "0x883000", Offset = "0x881800", Length = "0x80")]
	[Token(Token = "0x60010D9")]
	public void OnCalibrate()
	{
	}

	[Address(RVA = "0x8832E0", Offset = "0x881AE0", Length = "0x73")]
	[Token(Token = "0x60010DA")]
	public void OnInvert(bool state)
	{
	}

	[Address(RVA = "0x883640", Offset = "0x881E40", Length = "0x7F")]
	[Token(Token = "0x60010DB")]
	public void OnZeroValueChange(float value)
	{
	}

	[Address(RVA = "0x8835B0", Offset = "0x881DB0", Length = "0x80")]
	[Token(Token = "0x60010DC")]
	public void OnZeroCancel()
	{
	}

	[Address(RVA = "0x883140", Offset = "0x881940", Length = "0x11B")]
	[Token(Token = "0x60010DD")]
	public void OnDeadzoneValueChange(float value)
	{
	}

	[Token(Token = "0x60010DE")]
	[Address(RVA = "0x8830B0", Offset = "0x8818B0", Length = "0x8A")]
	public void OnDeadzoneCancel()
	{
	}

	[Token(Token = "0x60010DF")]
	[Address(RVA = "0x883440", Offset = "0x881C40", Length = "0x16E")]
	public void OnSensitivityValueChange(float value)
	{
	}

	[Token(Token = "0x60010E0")]
	[Address(RVA = "0x8833C0", Offset = "0x881BC0", Length = "0x76")]
	public void OnSensitivityCancel(float value)
	{
	}

	[Token(Token = "0x60010E1")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void OnAxisScrollRectScroll(Vector2 pos)
	{
	}

	[Token(Token = "0x60010E2")]
	[Address(RVA = "0x882FB0", Offset = "0x8817B0", Length = "0x4A")]
	private void OnAxisSelected(int axisIndex, Button button)
	{
	}

	[Address(RVA = "0x884C50", Offset = "0x883450", Length = "0x7")]
	[Token(Token = "0x60010E3")]
	private void UpdateDisplay()
	{
	}

	[Address(RVA = "0x883CE0", Offset = "0x8824E0", Length = "0x1F")]
	[Token(Token = "0x60010E4")]
	private void Redraw()
	{
	}

	[Address(RVA = "0x883D00", Offset = "0x882500", Length = "0x1F8")]
	[Token(Token = "0x60010E5")]
	private void RefreshControls()
	{
	}

	[Address(RVA = "0x8838C0", Offset = "0x8820C0", Length = "0x18C")]
	[Token(Token = "0x60010E6")]
	private void RedrawDeadzone()
	{
	}

	[Token(Token = "0x60010E7")]
	[Address(RVA = "0x883790", Offset = "0x881F90", Length = "0x12A")]
	private void RedrawCalibratedZero()
	{
	}

	[Token(Token = "0x60010E8")]
	[Address(RVA = "0x883A50", Offset = "0x882250", Length = "0x284")]
	private void RedrawValueMarkers()
	{
	}

	[Token(Token = "0x60010E9")]
	[Address(RVA = "0x883F00", Offset = "0x882700", Length = "0x36D")]
	private void SelectAxis(int index)
	{
	}

	[Token(Token = "0x60010EA")]
	[Address(RVA = "0x884C00", Offset = "0x883400", Length = "0x48")]
	public override void TakeInputFocus()
	{
	}

	[Token(Token = "0x60010EB")]
	[Address(RVA = "0x884980", Offset = "0x883180", Length = "0x14D")]
	private void SetMinSensitivity()
	{
	}

	[Token(Token = "0x60010EC")]
	[Address(RVA = "0x882D70", Offset = "0x881570", Length = "0x23E")]
	private bool IsMenuAxis(int actionId, int axisIndex)
	{
		return default(bool);
	}

	[Address(RVA = "0x882400", Offset = "0x880C00", Length = "0xD6")]
	[Token(Token = "0x60010ED")]
	private void GetAxisButtonDeadZone(int playerId, int actionId, ref float value)
	{
	}

	[Token(Token = "0x60010EE")]
	[Address(RVA = "0x8824E0", Offset = "0x880CE0", Length = "0x47")]
	private float GetSliderSensitivity(AxisCalibration axisCalibration)
	{
		return default(float);
	}

	[Address(RVA = "0x884AD0", Offset = "0x8832D0", Length = "0x125")]
	[Token(Token = "0x60010EF")]
	public void SetSensitivity(AxisCalibration axisCalibration, float sliderValue)
	{
	}

	[Address(RVA = "0x8836C0", Offset = "0x881EC0", Length = "0xCD")]
	[Token(Token = "0x60010F0")]
	private static float ProcessPowerValue(float value, float minValue, float maxValue)
	{
		return default(float);
	}

	[Address(RVA = "0x884C90", Offset = "0x883490", Length = "0x1C")]
	[Token(Token = "0x60010F1")]
	public CalibrationWindow()
	{
	}
}

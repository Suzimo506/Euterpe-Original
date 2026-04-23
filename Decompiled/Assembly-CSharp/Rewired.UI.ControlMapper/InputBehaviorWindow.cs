using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper;

[Token(Token = "0x20001FF")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6530", Offset = "0x5930")]
public class InputBehaviorWindow : Window
{
	[Token(Token = "0x2000A96")]
	private class InputBehaviorInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40037BF")]
		private InputBehavior _inputBehavior;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40037C0")]
		private UIControlSet _controlSet;

		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40037C1")]
		private Dictionary<int, PropertyType> idToProperty;

		[Token(Token = "0x40037C2")]
		[FieldOffset(Offset = "0x28")]
		private InputBehavior copyOfOriginal;

		[Token(Token = "0x17000A03")]
		public InputBehavior inputBehavior
		{
			[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
			[Token(Token = "0x6005B24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A04")]
		public UIControlSet controlSet
		{
			[Token(Token = "0x6005B25")]
			[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B26")]
		[Address(RVA = "0xDC24D0", Offset = "0xDC0CD0", Length = "0xB2")]
		public InputBehaviorInfo(InputBehavior inputBehavior, UIControlSet controlSet, Dictionary<int, PropertyType> idToProperty)
		{
		}

		[Token(Token = "0x6005B27")]
		[Address(RVA = "0xDC24A0", Offset = "0xDC0CA0", Length = "0x25")]
		public void RestorePreviousData()
		{
		}

		[Token(Token = "0x6005B28")]
		[Address(RVA = "0xDC2470", Offset = "0xDC0C70", Length = "0x2D")]
		public void RestoreDefaultData()
		{
		}

		[Token(Token = "0x6005B29")]
		[Address(RVA = "0xDC2350", Offset = "0xDC0B50", Length = "0x11E")]
		public void RestoreData(PropertyType propertyType, int controlId)
		{
		}

		[Address(RVA = "0xDC2130", Offset = "0xDC0930", Length = "0x21A")]
		[Token(Token = "0x6005B2A")]
		public void RefreshControls()
		{
		}
	}

	[Token(Token = "0x2000A97")]
	public enum ButtonIdentifier
	{
		[Token(Token = "0x40037C4")]
		Done,
		[Token(Token = "0x40037C5")]
		Cancel,
		[Token(Token = "0x40037C6")]
		Default
	}

	[Token(Token = "0x2000A98")]
	private enum PropertyType
	{
		[Token(Token = "0x40037C8")]
		JoystickAxisSensitivity,
		[Token(Token = "0x40037C9")]
		MouseXYAxisSensitivity
	}

	[Token(Token = "0x4000E71")]
	private const float minSensitivity = 0.1f;

	[SerializeField]
	[Token(Token = "0x4000E72")]
	[FieldOffset(Offset = "0x80")]
	private RectTransform spawnTransform;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000E73")]
	[SerializeField]
	private Button doneButton;

	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	[Token(Token = "0x4000E74")]
	private Button cancelButton;

	[SerializeField]
	[Token(Token = "0x4000E75")]
	[FieldOffset(Offset = "0x98")]
	private Button defaultButton;

	[SerializeField]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000E76")]
	private Text doneButtonLabel;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000E77")]
	[SerializeField]
	private Text cancelButtonLabel;

	[SerializeField]
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000E78")]
	private Text defaultButtonLabel;

	[SerializeField]
	[Token(Token = "0x4000E79")]
	[FieldOffset(Offset = "0xB8")]
	private GameObject uiControlSetPrefab;

	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000E7A")]
	[SerializeField]
	private GameObject uiSliderControlPrefab;

	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000E7B")]
	private List<InputBehaviorInfo> inputBehaviorInfo;

	[Token(Token = "0x4000E7C")]
	[FieldOffset(Offset = "0xD0")]
	private Dictionary<int, Action<int>> buttonCallbacks;

	[Token(Token = "0x4000E7D")]
	[FieldOffset(Offset = "0xD8")]
	private int playerId;

	[Address(RVA = "0xDC2C70", Offset = "0xDC1470", Length = "0x3D6")]
	[Token(Token = "0x600128D")]
	public override void Initialize(int id, Func<int, bool> isFocusedCallback)
	{
	}

	[Token(Token = "0x600128E")]
	[Address(RVA = "0xDC3510", Offset = "0xDC1D10", Length = "0x562")]
	public void SetData(int playerId, ControlMapper.InputBehaviorSettings[] data)
	{
	}

	[Token(Token = "0x600128F")]
	[Address(RVA = "0xDC3450", Offset = "0xDC1C50", Length = "0xB2")]
	public void SetButtonCallback(ButtonIdentifier buttonIdentifier, Action<int> callback)
	{
	}

	[Token(Token = "0x6001290")]
	[Address(RVA = "0xDC2670", Offset = "0xDC0E70", Length = "0x172")]
	public override void Cancel()
	{
	}

	[Address(RVA = "0xDC32B0", Offset = "0xDC1AB0", Length = "0x7A")]
	[Token(Token = "0x6001291")]
	public void OnDone()
	{
	}

	[Address(RVA = "0x883090", Offset = "0x881890", Length = "0x11")]
	[Token(Token = "0x6001292")]
	public void OnCancel()
	{
	}

	[Address(RVA = "0xDC3330", Offset = "0xDC1B30", Length = "0x118")]
	[Token(Token = "0x6001293")]
	public void OnRestoreDefault()
	{
	}

	[Address(RVA = "0xDC3140", Offset = "0xDC1940", Length = "0x35")]
	[Token(Token = "0x6001294")]
	private void JoystickAxisSensitivityValueChanged(int inputBehaviorId, int controlId, float value)
	{
	}

	[Token(Token = "0x6001295")]
	[Address(RVA = "0xDC3270", Offset = "0xDC1A70", Length = "0x35")]
	private void MouseXYAxisSensitivityValueChanged(int inputBehaviorId, int controlId, float value)
	{
	}

	[Token(Token = "0x6001296")]
	[Address(RVA = "0xDC3050", Offset = "0xDC1850", Length = "0xEA")]
	private void JoystickAxisSensitivityCanceled(int inputBehaviorId, int controlId)
	{
	}

	[Address(RVA = "0xDC3180", Offset = "0xDC1980", Length = "0xEA")]
	[Token(Token = "0x6001297")]
	private void MouseXYAxisSensitivityCanceled(int inputBehaviorId, int controlId)
	{
	}

	[Address(RVA = "0xDC3A80", Offset = "0xDC2280", Length = "0x7")]
	[Token(Token = "0x6001298")]
	public override void TakeInputFocus()
	{
	}

	[Token(Token = "0x6001299")]
	[Address(RVA = "0xDC27F0", Offset = "0xDC0FF0", Length = "0xA6")]
	private UIControlSet CreateControlSet()
	{
		return null;
	}

	[Address(RVA = "0xDC28A0", Offset = "0xDC10A0", Length = "0x258")]
	[Token(Token = "0x600129A")]
	private UISliderControl CreateSlider(UIControlSet set, int inputBehaviorId, string defaultTitle, string overrideTitle, Sprite icon, float minValue, float maxValue, Action<int, int, float> valueChangedCallback, Action<int, int> cancelCallback)
	{
		return null;
	}

	[Address(RVA = "0xDC2BF0", Offset = "0xDC13F0", Length = "0x77")]
	[Token(Token = "0x600129B")]
	private InputBehavior GetInputBehavior(int id)
	{
		return null;
	}

	[Address(RVA = "0xDC2B00", Offset = "0xDC1300", Length = "0xE9")]
	[Token(Token = "0x600129C")]
	private InputBehaviorInfo GetInputBehaviorInfo(int inputBehaviorId)
	{
		return null;
	}

	[Token(Token = "0x600129D")]
	[Address(RVA = "0xDC3A90", Offset = "0xDC2290", Length = "0x7")]
	public InputBehaviorWindow()
	{
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper;

[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6530", Offset = "0x5930")]
[Token(Token = "0x20001FA")]
public class ControlMapper : MonoBehaviour
{
	[Token(Token = "0x2000A7C")]
	private abstract class GUIElement
	{
		[Token(Token = "0x4003724")]
		[FieldOffset(Offset = "0x10")]
		public readonly GameObject gameObject;

		[Token(Token = "0x4003725")]
		[FieldOffset(Offset = "0x18")]
		protected readonly Text text;

		[Token(Token = "0x4003726")]
		[FieldOffset(Offset = "0x20")]
		public readonly Selectable selectable;

		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4003727")]
		protected readonly UIElementInfo uiElementInfo;

		[Token(Token = "0x4003728")]
		[FieldOffset(Offset = "0x30")]
		protected bool permanentStateSet;

		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003729")]
		protected readonly List<GUIElement> children;

		[Token(Token = "0x1700099A")]
		public RectTransform rectTransform
		{
			[CompilerGenerated]
			[Token(Token = "0x60059FD")]
			[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[Address(RVA = "0x4434D0", Offset = "0x441CD0", Length = "0xC")]
			[Token(Token = "0x60059FE")]
			private set
			{
			}
		}

		[Address(RVA = "0xDC07F0", Offset = "0xDBEFF0", Length = "0x205")]
		[Token(Token = "0x60059FF")]
		public GUIElement(GameObject gameObject)
		{
		}

		[Address(RVA = "0xDC0A00", Offset = "0xDBF200", Length = "0x17D")]
		[Token(Token = "0x6005A00")]
		public GUIElement(Selectable selectable, Text label)
		{
		}

		[Address(RVA = "0xDC0610", Offset = "0xDBEE10", Length = "0x22")]
		[Token(Token = "0x6005A01")]
		public virtual void SetInteractible(bool state, bool playTransition)
		{
		}

		[Address(RVA = "0xDC04A0", Offset = "0xDBECA0", Length = "0x165")]
		[Token(Token = "0x6005A02")]
		public virtual void SetInteractible(bool state, bool playTransition, bool permanent)
		{
		}

		[Token(Token = "0x6005A03")]
		[Address(RVA = "0xDC06E0", Offset = "0xDBEEE0", Length = "0x10C")]
		public virtual void SetTextWidth(int value)
		{
		}

		[Address(RVA = "0xDC0330", Offset = "0xDBEB30", Length = "0x164")]
		[Token(Token = "0x6005A04")]
		public virtual void SetFirstChildObjectWidth(LayoutElementSizeType type, int value)
		{
		}

		[Address(RVA = "0xDC0640", Offset = "0xDBEE40", Length = "0x94")]
		[Token(Token = "0x6005A05")]
		public virtual void SetLabel(string label)
		{
		}

		[Token(Token = "0x6005A06")]
		[Address(RVA = "0xDBFF20", Offset = "0xDBE720", Length = "0xA0")]
		public virtual string GetLabel()
		{
			return null;
		}

		[Token(Token = "0x6005A07")]
		[Address(RVA = "0xDBFEC0", Offset = "0xDBE6C0", Length = "0x52")]
		public virtual void AddChild(GUIElement child)
		{
		}

		[Token(Token = "0x6005A08")]
		[Address(RVA = "0xDC0280", Offset = "0xDBEA80", Length = "0xA9")]
		public void SetElementInfoData(string identifier, int intData)
		{
		}

		[Address(RVA = "0xDC01F0", Offset = "0xDBE9F0", Length = "0x8D")]
		[Token(Token = "0x6005A09")]
		public virtual void SetActive(bool state)
		{
		}

		[Address(RVA = "0xDBFFD0", Offset = "0xDBE7D0", Length = "0x21E")]
		[Token(Token = "0x6005A0A")]
		protected virtual bool Init()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000A7D")]
	private class GUIButton : GUIElement
	{
		[Token(Token = "0x1700099B")]
		protected Button button
		{
			[Address(RVA = "0xDBFE40", Offset = "0xDBE640", Length = "0x7D")]
			[Token(Token = "0x6005A0B")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700099C")]
		public ButtonInfo buttonInfo
		{
			[Address(RVA = "0xDBFDC0", Offset = "0xDBE5C0", Length = "0x7D")]
			[Token(Token = "0x6005A0C")]
			get
			{
				return null;
			}
		}

		[Address(RVA = "0xDBFD60", Offset = "0xDBE560", Length = "0x2A")]
		[Token(Token = "0x6005A0D")]
		public GUIButton(GameObject gameObject)
			: base(null)
		{
		}

		[Token(Token = "0x6005A0E")]
		[Address(RVA = "0xDBFD90", Offset = "0xDBE590", Length = "0x2A")]
		public GUIButton(Button button, Text label)
			: base(null)
		{
		}

		[Token(Token = "0x6005A0F")]
		[Address(RVA = "0xDBFC40", Offset = "0xDBE440", Length = "0x8")]
		public void SetButtonInfoData(string identifier, int intData)
		{
		}

		[Token(Token = "0x6005A10")]
		[Address(RVA = "0xDBFC50", Offset = "0xDBE450", Length = "0x10E")]
		public void SetOnClickCallback(Action<ButtonInfo> callback)
		{
		}
	}

	[Token(Token = "0x2000A7E")]
	private class GUIInputField : GUIElement
	{
		[Token(Token = "0x1700099D")]
		protected Button button
		{
			[Token(Token = "0x6005A11")]
			[Address(RVA = "0xDC0FF0", Offset = "0xDBF7F0", Length = "0x7D")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700099E")]
		public InputFieldInfo fieldInfo
		{
			[Token(Token = "0x6005A12")]
			[Address(RVA = "0xDC1110", Offset = "0xDBF910", Length = "0x7D")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700099F")]
		public bool hasToggle
		{
			[Address(RVA = "0xDC1190", Offset = "0xDBF990", Length = "0x9")]
			[Token(Token = "0x6005A13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170009A0")]
		public GUIToggle toggle
		{
			[Token(Token = "0x6005A14")]
			[CompilerGenerated]
			[Address(RVA = "0x46EF30", Offset = "0x46D730", Length = "0x5")]
			get
			{
				return null;
			}
			[Address(RVA = "0x637D40", Offset = "0x636540", Length = "0xC")]
			[Token(Token = "0x6005A15")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170009A1")]
		public int actionElementMapId
		{
			[Address(RVA = "0xDC0F50", Offset = "0xDBF750", Length = "0x96")]
			[Token(Token = "0x6005A16")]
			get
			{
				return default(int);
			}
			[Address(RVA = "0xDC11A0", Offset = "0xDBF9A0", Length = "0x92")]
			[Token(Token = "0x6005A17")]
			set
			{
			}
		}

		[Token(Token = "0x170009A2")]
		public int controllerId
		{
			[Token(Token = "0x6005A18")]
			[Address(RVA = "0xDC1070", Offset = "0xDBF870", Length = "0x96")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6005A19")]
			[Address(RVA = "0xDC1240", Offset = "0xDBFA40", Length = "0x92")]
			set
			{
			}
		}

		[Token(Token = "0x6005A1A")]
		[Address(RVA = "0xDBFD60", Offset = "0xDBE560", Length = "0x2A")]
		public GUIInputField(GameObject gameObject)
			: base(null)
		{
		}

		[Token(Token = "0x6005A1B")]
		[Address(RVA = "0xDBFD90", Offset = "0xDBE590", Length = "0x2A")]
		public GUIInputField(Button button, Text label)
			: base(null)
		{
		}

		[Token(Token = "0x6005A1C")]
		[Address(RVA = "0xDC0BA0", Offset = "0xDBF3A0", Length = "0xF3")]
		public void SetFieldInfoData(int actionId, AxisRange axisRange, ControllerType controllerType, int intData)
		{
		}

		[Address(RVA = "0xDC0E40", Offset = "0xDBF640", Length = "0x10E")]
		[Token(Token = "0x6005A1D")]
		public void SetOnClickCallback(Action<InputFieldInfo> callback)
		{
		}

		[Address(RVA = "0xDC0CA0", Offset = "0xDBF4A0", Length = "0x195")]
		[Token(Token = "0x6005A1E")]
		public virtual void SetInteractable(bool state, bool playTransition, bool permanent)
		{
		}

		[Address(RVA = "0xDC0B80", Offset = "0xDBF380", Length = "0x12")]
		[Token(Token = "0x6005A1F")]
		public void AddToggle(GUIToggle toggle)
		{
		}
	}

	[Token(Token = "0x2000A7F")]
	private class GUIToggle : GUIElement
	{
		[Token(Token = "0x170009A3")]
		protected Toggle toggle
		{
			[Address(RVA = "0xDC1EE0", Offset = "0xDC06E0", Length = "0x7D")]
			[Token(Token = "0x6005A20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009A4")]
		public ToggleInfo toggleInfo
		{
			[Token(Token = "0x6005A21")]
			[Address(RVA = "0xDC1E60", Offset = "0xDC0660", Length = "0x7D")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009A5")]
		public int actionElementMapId
		{
			[Address(RVA = "0xDC1DC0", Offset = "0xDC05C0", Length = "0x96")]
			[Token(Token = "0x6005A22")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6005A23")]
			[Address(RVA = "0xDC1F60", Offset = "0xDC0760", Length = "0x92")]
			set
			{
			}
		}

		[Token(Token = "0x6005A24")]
		[Address(RVA = "0xDBFD60", Offset = "0xDBE560", Length = "0x2A")]
		public GUIToggle(GameObject gameObject)
			: base(null)
		{
		}

		[Token(Token = "0x6005A25")]
		[Address(RVA = "0xDBFD90", Offset = "0xDBE590", Length = "0x2A")]
		public GUIToggle(Toggle toggle, Text label)
			: base(null)
		{
		}

		[Token(Token = "0x6005A26")]
		[Address(RVA = "0xDC1C20", Offset = "0xDC0420", Length = "0xF3")]
		public void SetToggleInfoData(int actionId, AxisRange axisRange, ControllerType controllerType, int intData)
		{
		}

		[Token(Token = "0x6005A27")]
		[Address(RVA = "0xDC1950", Offset = "0xDC0150", Length = "0x2CE")]
		public void SetOnSubmitCallback(Action<ToggleInfo, bool> callback)
		{
		}

		[Token(Token = "0x6005A28")]
		[Address(RVA = "0xDC1D20", Offset = "0xDC0520", Length = "0x9F")]
		public void SetToggleState(bool state)
		{
		}
	}

	[Token(Token = "0x2000A80")]
	private class GUILabel
	{
		[Token(Token = "0x170009A6")]
		public GameObject gameObject
		{
			[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
			[Token(Token = "0x6005A29")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Address(RVA = "0x4894E0", Offset = "0x487CE0", Length = "0xC")]
			[Token(Token = "0x6005A2A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170009A7")]
		private Text text
		{
			[Token(Token = "0x6005A2B")]
			[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[Token(Token = "0x6005A2C")]
			[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
			set
			{
			}
		}

		[Token(Token = "0x170009A8")]
		public RectTransform rectTransform
		{
			[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
			[Token(Token = "0x6005A2D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Address(RVA = "0x483E40", Offset = "0x482640", Length = "0xC")]
			[Token(Token = "0x6005A2E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Address(RVA = "0xDC1860", Offset = "0xDC0060", Length = "0xEA")]
		[Token(Token = "0x6005A2F")]
		public GUILabel(GameObject gameObject)
		{
		}

		[Address(RVA = "0xDC1820", Offset = "0xDC0020", Length = "0x3A")]
		[Token(Token = "0x6005A30")]
		public GUILabel(Text label)
		{
		}

		[Address(RVA = "0xDC1630", Offset = "0xDBFE30", Length = "0xBA")]
		[Token(Token = "0x6005A31")]
		public void SetSize(int width, int height)
		{
		}

		[Token(Token = "0x6005A32")]
		[Address(RVA = "0xDC1780", Offset = "0xDBFF80", Length = "0x91")]
		public void SetWidth(int width)
		{
		}

		[Address(RVA = "0xDC14F0", Offset = "0xDBFCF0", Length = "0x93")]
		[Token(Token = "0x6005A33")]
		public void SetHeight(int height)
		{
		}

		[Token(Token = "0x6005A34")]
		[Address(RVA = "0xDC1590", Offset = "0xDBFD90", Length = "0x94")]
		public void SetLabel(string label)
		{
		}

		[Token(Token = "0x6005A35")]
		[Address(RVA = "0xDC1460", Offset = "0xDBFC60", Length = "0x8A")]
		public void SetFontStyle(FontStyle style)
		{
		}

		[Token(Token = "0x6005A36")]
		[Address(RVA = "0xDC16F0", Offset = "0xDBFEF0", Length = "0x8A")]
		public void SetTextAlignment(TextAnchor alignment)
		{
		}

		[Token(Token = "0x6005A37")]
		[Address(RVA = "0xDC13D0", Offset = "0xDBFBD0", Length = "0x8D")]
		public void SetActive(bool state)
		{
		}

		[Token(Token = "0x6005A38")]
		[Address(RVA = "0xDC12E0", Offset = "0xDBFAE0", Length = "0xEE")]
		private bool Check()
		{
			return default(bool);
		}
	}

	[Serializable]
	[Token(Token = "0x2000A81")]
	public class MappingSet
	{
		[Token(Token = "0x2000DFF")]
		public enum ActionListMode
		{
			[Token(Token = "0x4004143")]
			ActionCategory,
			[Token(Token = "0x4004144")]
			Action
		}

		[Token(Token = "0x400372F")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E00", Offset = "0x87200")]
		[SerializeField]
		private int _mapCategoryId;

		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4003730")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E40", Offset = "0x87240")]
		[SerializeField]
		private ActionListMode _actionListMode;

		[Token(Token = "0x4003731")]
		[SerializeField]
		[FieldOffset(Offset = "0x18")]
		private int[] _actionCategoryIds;

		[Token(Token = "0x4003732")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int[] _actionIds;

		[Token(Token = "0x4003733")]
		[FieldOffset(Offset = "0x28")]
		private IList<int> _actionCategoryIdsReadOnly;

		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003734")]
		private IList<int> _actionIdsReadOnly;

		[Token(Token = "0x170009A9")]
		public int mapCategoryId
		{
			[Address(RVA = "0x42CB40", Offset = "0x42B340", Length = "0x4")]
			[Token(Token = "0x6005A39")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170009AA")]
		public ActionListMode actionListMode
		{
			[Address(RVA = "0x50A7E0", Offset = "0x508FE0", Length = "0x4")]
			[Token(Token = "0x6005A3A")]
			get
			{
				return default(ActionListMode);
			}
		}

		[Token(Token = "0x170009AB")]
		public IList<int> actionCategoryIds
		{
			[Address(RVA = "0xDC88B0", Offset = "0xDC70B0", Length = "0x8F")]
			[Token(Token = "0x6005A3B")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009AC")]
		public IList<int> actionIds
		{
			[Token(Token = "0x6005A3C")]
			[Address(RVA = "0xDC8940", Offset = "0xDC7140", Length = "0x99")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009AD")]
		public bool isValid
		{
			[Address(RVA = "0xDC89E0", Offset = "0xDC71E0", Length = "0x82")]
			[Token(Token = "0x6005A3D")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170009AE")]
		public static MappingSet Default
		{
			[Token(Token = "0x6005A40")]
			[Address(RVA = "0xDC8810", Offset = "0xDC7010", Length = "0xA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005A3E")]
		[Address(RVA = "0xDC8790", Offset = "0xDC6F90", Length = "0x7C")]
		public MappingSet()
		{
		}

		[Token(Token = "0x6005A3F")]
		[Address(RVA = "0xDC8730", Offset = "0xDC6F30", Length = "0x60")]
		private MappingSet(int mapCategoryId, ActionListMode actionListMode, int[] actionCategoryIds, int[] actionIds)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000A82")]
	public class InputBehaviorSettings
	{
		[Token(Token = "0x4003735")]
		[SerializeField]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F00", Offset = "0x87300")]
		private int _inputBehaviorId;

		[Token(Token = "0x4003736")]
		[FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880B0", Offset = "0x874B0")]
		[SerializeField]
		private bool _showJoystickAxisSensitivity;

		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880B0", Offset = "0x874B0")]
		[Token(Token = "0x4003737")]
		[FieldOffset(Offset = "0x15")]
		private bool _showMouseXYAxisSensitivity;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003738")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883B0", Offset = "0x877B0")]
		[SerializeField]
		private string _labelLanguageKey;

		[SerializeField]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885E0", Offset = "0x879E0")]
		[Token(Token = "0x4003739")]
		private string _joystickAxisSensitivityLabelLanguageKey;

		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x888E0", Offset = "0x87CE0")]
		[Token(Token = "0x400373A")]
		[FieldOffset(Offset = "0x28")]
		private string _mouseXYAxisSensitivityLabelLanguageKey;

		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89D10", Offset = "0x89110")]
		[Token(Token = "0x400373B")]
		[FieldOffset(Offset = "0x30")]
		private Sprite _joystickAxisSensitivityIcon;

		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89D10", Offset = "0x89110")]
		[Token(Token = "0x400373C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite _mouseXYAxisSensitivityIcon;

		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89FA0", Offset = "0x893A0")]
		[SerializeField]
		[Token(Token = "0x400373D")]
		private float _joystickAxisSensitivityMin;

		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8A240", Offset = "0x89640")]
		[Token(Token = "0x400373E")]
		[FieldOffset(Offset = "0x44")]
		private float _joystickAxisSensitivityMax;

		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89FA0", Offset = "0x893A0")]
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400373F")]
		[SerializeField]
		private float _mouseXYAxisSensitivityMin;

		[SerializeField]
		[FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8A240", Offset = "0x89640")]
		[Token(Token = "0x4003740")]
		private float _mouseXYAxisSensitivityMax;

		[Token(Token = "0x170009AF")]
		public int inputBehaviorId
		{
			[Token(Token = "0x6005A41")]
			[Address(RVA = "0x42CB40", Offset = "0x42B340", Length = "0x4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170009B0")]
		public bool showJoystickAxisSensitivity
		{
			[Token(Token = "0x6005A42")]
			[Address(RVA = "0x44C9C0", Offset = "0x44B1C0", Length = "0x5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170009B1")]
		public bool showMouseXYAxisSensitivity
		{
			[Address(RVA = "0xDC2660", Offset = "0xDC0E60", Length = "0x5")]
			[Token(Token = "0x6005A43")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170009B2")]
		public string labelLanguageKey
		{
			[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
			[Token(Token = "0x6005A44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009B3")]
		public string joystickAxisSensitivityLabelLanguageKey
		{
			[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
			[Token(Token = "0x6005A45")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009B4")]
		public string mouseXYAxisSensitivityLabelLanguageKey
		{
			[Address(RVA = "0x46EF20", Offset = "0x46D720", Length = "0x5")]
			[Token(Token = "0x6005A46")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009B5")]
		public Sprite joystickAxisSensitivityIcon
		{
			[Address(RVA = "0x45EEE0", Offset = "0x45D6E0", Length = "0x5")]
			[Token(Token = "0x6005A47")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009B6")]
		public Sprite mouseXYAxisSensitivityIcon
		{
			[Token(Token = "0x6005A48")]
			[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009B7")]
		public float joystickAxisSensitivityMin
		{
			[Address(RVA = "0x9BCDB0", Offset = "0x9BB5B0", Length = "0x6")]
			[Token(Token = "0x6005A49")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170009B8")]
		public float joystickAxisSensitivityMax
		{
			[Address(RVA = "0x7044A0", Offset = "0x702CA0", Length = "0x6")]
			[Token(Token = "0x6005A4A")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170009B9")]
		public float mouseXYAxisSensitivityMin
		{
			[Token(Token = "0x6005A4B")]
			[Address(RVA = "0x746380", Offset = "0x744B80", Length = "0x6")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170009BA")]
		public float mouseXYAxisSensitivityMax
		{
			[Token(Token = "0x6005A4C")]
			[Address(RVA = "0x7FE810", Offset = "0x7FD010", Length = "0x6")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170009BB")]
		public bool isValid
		{
			[Token(Token = "0x6005A4D")]
			[Address(RVA = "0xDC2640", Offset = "0xDC0E40", Length = "0x16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6005A4E")]
		[Address(RVA = "0xDC2590", Offset = "0xDC0D90", Length = "0xA5")]
		public InputBehaviorSettings()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000A83")]
	private class Prefabs
	{
		[SerializeField]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003741")]
		private GameObject _button;

		[Token(Token = "0x4003742")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _fitButton;

		[SerializeField]
		[Token(Token = "0x4003743")]
		[FieldOffset(Offset = "0x20")]
		private GameObject _inputGridLabel;

		[SerializeField]
		[Token(Token = "0x4003744")]
		[FieldOffset(Offset = "0x28")]
		private GameObject _inputGridHeaderLabel;

		[Token(Token = "0x4003745")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _inputGridFieldButton;

		[SerializeField]
		[Token(Token = "0x4003746")]
		[FieldOffset(Offset = "0x38")]
		private GameObject _inputGridFieldInvertToggle;

		[Token(Token = "0x4003747")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _window;

		[Token(Token = "0x4003748")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _windowTitleText;

		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003749")]
		[SerializeField]
		private GameObject _windowContentText;

		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Token(Token = "0x400374A")]
		private GameObject _fader;

		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400374B")]
		[SerializeField]
		private GameObject _calibrationWindow;

		[SerializeField]
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400374C")]
		private GameObject _inputBehaviorsWindow;

		[SerializeField]
		[Token(Token = "0x400374D")]
		[FieldOffset(Offset = "0x70")]
		private GameObject _centerStickGraphic;

		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x400374E")]
		[SerializeField]
		private GameObject _moveStickGraphic;

		[Token(Token = "0x170009BC")]
		public GameObject button
		{
			[Token(Token = "0x6005A4F")]
			[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009BD")]
		public GameObject fitButton
		{
			[Token(Token = "0x6005A50")]
			[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009BE")]
		public GameObject inputGridLabel
		{
			[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
			[Token(Token = "0x6005A51")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009BF")]
		public GameObject inputGridHeaderLabel
		{
			[Token(Token = "0x6005A52")]
			[Address(RVA = "0x46EF20", Offset = "0x46D720", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009C0")]
		public GameObject inputGridFieldButton
		{
			[Token(Token = "0x6005A53")]
			[Address(RVA = "0x45EEE0", Offset = "0x45D6E0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009C1")]
		public GameObject inputGridFieldInvertToggle
		{
			[Token(Token = "0x6005A54")]
			[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009C2")]
		public GameObject window
		{
			[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
			[Token(Token = "0x6005A55")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009C3")]
		public GameObject windowTitleText
		{
			[Token(Token = "0x6005A56")]
			[Address(RVA = "0x46EF30", Offset = "0x46D730", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009C4")]
		public GameObject windowContentText
		{
			[Token(Token = "0x6005A57")]
			[Address(RVA = "0x46EF80", Offset = "0x46D780", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009C5")]
		public GameObject fader
		{
			[Token(Token = "0x6005A58")]
			[Address(RVA = "0x429C40", Offset = "0x428440", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009C6")]
		public GameObject calibrationWindow
		{
			[Token(Token = "0x6005A59")]
			[Address(RVA = "0x4293D0", Offset = "0x427BD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009C7")]
		public GameObject inputBehaviorsWindow
		{
			[Token(Token = "0x6005A5A")]
			[Address(RVA = "0x4293C0", Offset = "0x427BC0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009C8")]
		public GameObject centerStickGraphic
		{
			[Token(Token = "0x6005A5B")]
			[Address(RVA = "0x462D00", Offset = "0x461500", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009C9")]
		public GameObject moveStickGraphic
		{
			[Token(Token = "0x6005A5C")]
			[Address(RVA = "0x5C1440", Offset = "0x5BFC40", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Address(RVA = "0xDC8B10", Offset = "0xDC7310", Length = "0x2C9")]
		[Token(Token = "0x6005A5D")]
		public bool Check()
		{
			return default(bool);
		}

		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		[Token(Token = "0x6005A5E")]
		public Prefabs()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000A84")]
	private class References
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400374F")]
		[SerializeField]
		private Canvas _canvas;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003750")]
		[SerializeField]
		private CanvasGroup _mainCanvasGroup;

		[SerializeField]
		[Token(Token = "0x4003751")]
		[FieldOffset(Offset = "0x20")]
		private Transform _mainContent;

		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4003752")]
		[SerializeField]
		private Transform _mainContentInner;

		[Token(Token = "0x4003753")]
		[SerializeField]
		[FieldOffset(Offset = "0x30")]
		private UIGroup _playersGroup;

		[Token(Token = "0x4003754")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _controllerGroup;

		[SerializeField]
		[Token(Token = "0x4003755")]
		[FieldOffset(Offset = "0x40")]
		private Transform _controllerGroupLabelGroup;

		[SerializeField]
		[Token(Token = "0x4003756")]
		[FieldOffset(Offset = "0x48")]
		private UIGroup _controllerSettingsGroup;

		[SerializeField]
		[Token(Token = "0x4003757")]
		[FieldOffset(Offset = "0x50")]
		private UIGroup _assignedControllersGroup;

		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4003758")]
		[SerializeField]
		private Transform _settingsAndMapCategoriesGroup;

		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4003759")]
		[SerializeField]
		private UIGroup _settingsGroup;

		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400375A")]
		[SerializeField]
		private UIGroup _mapCategoriesGroup;

		[Token(Token = "0x400375B")]
		[SerializeField]
		[FieldOffset(Offset = "0x70")]
		private Transform _inputGridGroup;

		[Token(Token = "0x400375C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _inputGridContainer;

		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x400375D")]
		[SerializeField]
		private Transform _inputGridHeadersGroup;

		[Token(Token = "0x400375E")]
		[SerializeField]
		[FieldOffset(Offset = "0x88")]
		private Scrollbar _inputGridVScrollbar;

		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x400375F")]
		[SerializeField]
		private ScrollRect _inputGridScrollRect;

		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Token(Token = "0x4003760")]
		private Transform _inputGridInnerGroup;

		[SerializeField]
		[Token(Token = "0x4003761")]
		[FieldOffset(Offset = "0xA0")]
		private Text _controllerNameLabel;

		[SerializeField]
		[Token(Token = "0x4003762")]
		[FieldOffset(Offset = "0xA8")]
		private Button _removeControllerButton;

		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4003763")]
		[SerializeField]
		private Button _assignControllerButton;

		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Token(Token = "0x4003764")]
		private Button _calibrateControllerButton;

		[SerializeField]
		[Token(Token = "0x4003765")]
		[FieldOffset(Offset = "0xC0")]
		private Button _doneButton;

		[Token(Token = "0x4003766")]
		[SerializeField]
		[FieldOffset(Offset = "0xC8")]
		private Button _restoreDefaultsButton;

		[Token(Token = "0x4003767")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Selectable _defaultSelection;

		[FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x4003768")]
		[SerializeField]
		private GameObject[] _fixedSelectableUIElements;

		[Token(Token = "0x4003769")]
		[SerializeField]
		[FieldOffset(Offset = "0xE0")]
		private Image _mainBackgroundImage;

		[Token(Token = "0x170009CA")]
		public Canvas canvas
		{
			[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
			[Token(Token = "0x6005A5F")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009CB")]
		public CanvasGroup mainCanvasGroup
		{
			[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
			[Token(Token = "0x6005A60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009CC")]
		public Transform mainContent
		{
			[Token(Token = "0x6005A61")]
			[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009CD")]
		public Transform mainContentInner
		{
			[Token(Token = "0x6005A62")]
			[Address(RVA = "0x46EF20", Offset = "0x46D720", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009CE")]
		public UIGroup playersGroup
		{
			[Token(Token = "0x6005A63")]
			[Address(RVA = "0x45EEE0", Offset = "0x45D6E0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009CF")]
		public Transform controllerGroup
		{
			[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
			[Token(Token = "0x6005A64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009D0")]
		public Transform controllerGroupLabelGroup
		{
			[Token(Token = "0x6005A65")]
			[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009D1")]
		public UIGroup controllerSettingsGroup
		{
			[Token(Token = "0x6005A66")]
			[Address(RVA = "0x46EF30", Offset = "0x46D730", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009D2")]
		public UIGroup assignedControllersGroup
		{
			[Token(Token = "0x6005A67")]
			[Address(RVA = "0x46EF80", Offset = "0x46D780", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009D3")]
		public Transform settingsAndMapCategoriesGroup
		{
			[Address(RVA = "0x429C40", Offset = "0x428440", Length = "0x5")]
			[Token(Token = "0x6005A68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009D4")]
		public UIGroup settingsGroup
		{
			[Address(RVA = "0x4293D0", Offset = "0x427BD0", Length = "0x5")]
			[Token(Token = "0x6005A69")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009D5")]
		public UIGroup mapCategoriesGroup
		{
			[Address(RVA = "0x4293C0", Offset = "0x427BC0", Length = "0x5")]
			[Token(Token = "0x6005A6A")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009D6")]
		public Transform inputGridGroup
		{
			[Address(RVA = "0x462D00", Offset = "0x461500", Length = "0x5")]
			[Token(Token = "0x6005A6B")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009D7")]
		public Transform inputGridContainer
		{
			[Address(RVA = "0x5C1440", Offset = "0x5BFC40", Length = "0x5")]
			[Token(Token = "0x6005A6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009D8")]
		public Transform inputGridHeadersGroup
		{
			[Token(Token = "0x6005A6D")]
			[Address(RVA = "0x4865C0", Offset = "0x484DC0", Length = "0x8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009D9")]
		public Scrollbar inputGridVScrollbar
		{
			[Address(RVA = "0x5C1450", Offset = "0x5BFC50", Length = "0x8")]
			[Token(Token = "0x6005A6E")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009DA")]
		public ScrollRect inputGridScrollRect
		{
			[Address(RVA = "0x46D010", Offset = "0x46B810", Length = "0x8")]
			[Token(Token = "0x6005A6F")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009DB")]
		public Transform inputGridInnerGroup
		{
			[Address(RVA = "0x49A8B0", Offset = "0x4990B0", Length = "0x8")]
			[Token(Token = "0x6005A70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009DC")]
		public Text controllerNameLabel
		{
			[Address(RVA = "0x48E690", Offset = "0x48CE90", Length = "0x8")]
			[Token(Token = "0x6005A71")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009DD")]
		public Button removeControllerButton
		{
			[Token(Token = "0x6005A72")]
			[Address(RVA = "0x460250", Offset = "0x45EA50", Length = "0x8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009DE")]
		public Button assignControllerButton
		{
			[Token(Token = "0x6005A73")]
			[Address(RVA = "0x49A8E0", Offset = "0x4990E0", Length = "0x8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009DF")]
		public Button calibrateControllerButton
		{
			[Address(RVA = "0x49A890", Offset = "0x499090", Length = "0x8")]
			[Token(Token = "0x6005A74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009E0")]
		public Button doneButton
		{
			[Token(Token = "0x6005A75")]
			[Address(RVA = "0x49A8D0", Offset = "0x4990D0", Length = "0x8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009E1")]
		public Button restoreDefaultsButton
		{
			[Token(Token = "0x6005A76")]
			[Address(RVA = "0x460220", Offset = "0x45EA20", Length = "0x8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009E2")]
		public Selectable defaultSelection
		{
			[Token(Token = "0x6005A77")]
			[Address(RVA = "0x49A8C0", Offset = "0x4990C0", Length = "0x8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009E3")]
		public GameObject[] fixedSelectableUIElements
		{
			[Token(Token = "0x6005A78")]
			[Address(RVA = "0x49A8A0", Offset = "0x4990A0", Length = "0x8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009E4")]
		public Image mainBackgroundImage
		{
			[Token(Token = "0x6005A79")]
			[Address(RVA = "0x48E510", Offset = "0x48CD10", Length = "0x8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009E5")]
		public LayoutElement inputGridLayoutElement
		{
			[Address(RVA = "0x4870D0", Offset = "0x4858D0", Length = "0x8")]
			[Token(Token = "0x6005A7A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Address(RVA = "0x722260", Offset = "0x720A60", Length = "0xF")]
			[Token(Token = "0x6005A7B")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170009E6")]
		public Transform inputGridActionColumn
		{
			[CompilerGenerated]
			[Token(Token = "0x6005A7C")]
			[Address(RVA = "0x4CFBF0", Offset = "0x4CE3F0", Length = "0x8")]
			get
			{
				return null;
			}
			[Address(RVA = "0x7FD3B0", Offset = "0x7FBBB0", Length = "0xF")]
			[CompilerGenerated]
			[Token(Token = "0x6005A7D")]
			set
			{
			}
		}

		[Token(Token = "0x170009E7")]
		public Transform inputGridKeyboardColumn
		{
			[CompilerGenerated]
			[Token(Token = "0x6005A7E")]
			[Address(RVA = "0x4E8C50", Offset = "0x4E7450", Length = "0x8")]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[Token(Token = "0x6005A7F")]
			[Address(RVA = "0x6CE320", Offset = "0x6CCB20", Length = "0xF")]
			set
			{
			}
		}

		[Token(Token = "0x170009E8")]
		public Transform inputGridMouseColumn
		{
			[Address(RVA = "0x4E8C20", Offset = "0x4E7420", Length = "0x8")]
			[Token(Token = "0x6005A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Address(RVA = "0x4E7B30", Offset = "0x4E6330", Length = "0xF")]
			[Token(Token = "0x6005A81")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170009E9")]
		public Transform inputGridControllerColumn
		{
			[Token(Token = "0x6005A82")]
			[Address(RVA = "0xA5DC40", Offset = "0xA5C440", Length = "0x8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[Token(Token = "0x6005A83")]
			[Address(RVA = "0xA60E00", Offset = "0xA5F600", Length = "0xF")]
			set
			{
			}
		}

		[Token(Token = "0x170009EA")]
		public Transform inputGridHeader1
		{
			[Address(RVA = "0xA5FD90", Offset = "0xA5E590", Length = "0x8")]
			[Token(Token = "0x6005A84")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A85")]
			[CompilerGenerated]
			[Address(RVA = "0x4601A0", Offset = "0x45E9A0", Length = "0xF")]
			set
			{
			}
		}

		[Token(Token = "0x170009EB")]
		public Transform inputGridHeader2
		{
			[CompilerGenerated]
			[Address(RVA = "0x427D10", Offset = "0x426510", Length = "0x8")]
			[Token(Token = "0x6005A86")]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[Address(RVA = "0xDBDA40", Offset = "0xDBC240", Length = "0xF")]
			[Token(Token = "0x6005A87")]
			set
			{
			}
		}

		[Token(Token = "0x170009EC")]
		public Transform inputGridHeader3
		{
			[Address(RVA = "0x51FEB0", Offset = "0x51E6B0", Length = "0x8")]
			[Token(Token = "0x6005A88")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Address(RVA = "0x604650", Offset = "0x602E50", Length = "0xF")]
			[CompilerGenerated]
			[Token(Token = "0x6005A89")]
			set
			{
			}
		}

		[Token(Token = "0x170009ED")]
		public Transform inputGridHeader4
		{
			[Token(Token = "0x6005A8A")]
			[CompilerGenerated]
			[Address(RVA = "0x561290", Offset = "0x55FA90", Length = "0x8")]
			get
			{
				return null;
			}
			[Address(RVA = "0x604660", Offset = "0x602E60", Length = "0xF")]
			[Token(Token = "0x6005A8B")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Address(RVA = "0xDC8DE0", Offset = "0xDC75E0", Length = "0x5B5")]
		[Token(Token = "0x6005A8C")]
		public bool Check()
		{
			return default(bool);
		}

		[Token(Token = "0x6005A8D")]
		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		public References()
		{
		}
	}

	[Token(Token = "0x2000A85")]
	private class InputActionSet
	{
		[Token(Token = "0x4003773")]
		[FieldOffset(Offset = "0x10")]
		private int _actionId;

		[Token(Token = "0x4003774")]
		[FieldOffset(Offset = "0x14")]
		private AxisRange _axisRange;

		[Token(Token = "0x170009EE")]
		public int actionId
		{
			[Token(Token = "0x6005A8E")]
			[Address(RVA = "0x42CB40", Offset = "0x42B340", Length = "0x4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170009EF")]
		public AxisRange axisRange
		{
			[Token(Token = "0x6005A8F")]
			[Address(RVA = "0x50A7E0", Offset = "0x508FE0", Length = "0x4")]
			get
			{
				return default(AxisRange);
			}
		}

		[Address(RVA = "0xA6E490", Offset = "0xA6CC90", Length = "0x34")]
		[Token(Token = "0x6005A90")]
		public InputActionSet(int actionId, AxisRange axisRange)
		{
		}
	}

	[Token(Token = "0x2000A86")]
	private class InputMapping
	{
		[Token(Token = "0x170009F0")]
		public string actionName
		{
			[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
			[Token(Token = "0x6005A91")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Address(RVA = "0x4894E0", Offset = "0x487CE0", Length = "0xC")]
			[CompilerGenerated]
			[Token(Token = "0x6005A92")]
			private set
			{
			}
		}

		[Token(Token = "0x170009F1")]
		public InputFieldInfo fieldInfo
		{
			[Token(Token = "0x6005A93")]
			[CompilerGenerated]
			[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
			get
			{
				return null;
			}
			[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
			[Token(Token = "0x6005A94")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170009F2")]
		public ControllerMap map
		{
			[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
			[Token(Token = "0x6005A95")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A96")]
			[CompilerGenerated]
			[Address(RVA = "0x483E40", Offset = "0x482640", Length = "0xC")]
			private set
			{
			}
		}

		[Token(Token = "0x170009F3")]
		public ActionElementMap aem
		{
			[CompilerGenerated]
			[Token(Token = "0x6005A97")]
			[Address(RVA = "0x46EF20", Offset = "0x46D720", Length = "0x5")]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[Token(Token = "0x6005A98")]
			[Address(RVA = "0x48F110", Offset = "0x48D910", Length = "0xC")]
			private set
			{
			}
		}

		[Token(Token = "0x170009F4")]
		public ControllerType controllerType
		{
			[CompilerGenerated]
			[Token(Token = "0x6005A99")]
			[Address(RVA = "0x597020", Offset = "0x595820", Length = "0x4")]
			get
			{
				return default(ControllerType);
			}
			[CompilerGenerated]
			[Token(Token = "0x6005A9A")]
			[Address(RVA = "0x487A80", Offset = "0x486280", Length = "0x4")]
			private set
			{
			}
		}

		[Token(Token = "0x170009F5")]
		public int controllerId
		{
			[CompilerGenerated]
			[Address(RVA = "0x597000", Offset = "0x595800", Length = "0x4")]
			[Token(Token = "0x6005A9B")]
			get
			{
				return default(int);
			}
			[Address(RVA = "0x597060", Offset = "0x595860", Length = "0x4")]
			[Token(Token = "0x6005A9C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170009F6")]
		public ControllerPollingInfo pollingInfo
		{
			[Token(Token = "0x6005A9D")]
			[CompilerGenerated]
			[Address(RVA = "0xDC6AE0", Offset = "0xDC52E0", Length = "0x25")]
			get
			{
				return default(ControllerPollingInfo);
			}
			[Address(RVA = "0xDC6B10", Offset = "0xDC5310", Length = "0x2C")]
			[CompilerGenerated]
			[Token(Token = "0x6005A9E")]
			set
			{
			}
		}

		[Token(Token = "0x170009F7")]
		public ModifierKeyFlags modifierKeyFlags
		{
			[CompilerGenerated]
			[Token(Token = "0x6005A9F")]
			[Address(RVA = "0x4D0B40", Offset = "0x4CF340", Length = "0x4")]
			get
			{
				return default(ModifierKeyFlags);
			}
			[Address(RVA = "0x7044D0", Offset = "0x702CD0", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6005AA0")]
			set
			{
			}
		}

		[Token(Token = "0x170009F8")]
		public AxisRange axisRange
		{
			[Token(Token = "0x6005AA1")]
			[Address(RVA = "0xDC6940", Offset = "0xDC5140", Length = "0x45")]
			get
			{
				return default(AxisRange);
			}
		}

		[Token(Token = "0x170009F9")]
		public string elementName
		{
			[Token(Token = "0x6005AA2")]
			[Address(RVA = "0xDC6990", Offset = "0xDC5190", Length = "0x14A")]
			get
			{
				return null;
			}
		}

		[Address(RVA = "0xDC68B0", Offset = "0xDC50B0", Length = "0x88")]
		[Token(Token = "0x6005AA3")]
		public InputMapping(string actionName, InputFieldInfo fieldInfo, ControllerMap map, ActionElementMap aem, ControllerType controllerType, int controllerId)
		{
		}

		[Address(RVA = "0xDC6830", Offset = "0xDC5030", Length = "0x72")]
		[Token(Token = "0x6005AA4")]
		public ElementAssignment ToElementAssignment(ControllerPollingInfo pollingInfo)
		{
			return default(ElementAssignment);
		}

		[Address(RVA = "0xDC67A0", Offset = "0xDC4FA0", Length = "0x82")]
		[Token(Token = "0x6005AA5")]
		public ElementAssignment ToElementAssignment(ControllerPollingInfo pollingInfo, ModifierKeyFlags modifierKeyFlags)
		{
			return default(ElementAssignment);
		}

		[Address(RVA = "0xDC6690", Offset = "0xDC4E90", Length = "0x10A")]
		[Token(Token = "0x6005AA6")]
		public ElementAssignment ToElementAssignment()
		{
			return default(ElementAssignment);
		}
	}

	[Token(Token = "0x2000A87")]
	private class AxisCalibrator
	{
		[Token(Token = "0x400377D")]
		[FieldOffset(Offset = "0x10")]
		public AxisCalibrationData data;

		[Token(Token = "0x400377E")]
		[FieldOffset(Offset = "0x48")]
		public readonly Joystick joystick;

		[Token(Token = "0x400377F")]
		[FieldOffset(Offset = "0x50")]
		public readonly int axisIndex;

		[Token(Token = "0x4003780")]
		[FieldOffset(Offset = "0x58")]
		private Controller.Axis axis;

		[Token(Token = "0x4003781")]
		[FieldOffset(Offset = "0x60")]
		private bool firstRun;

		[Token(Token = "0x170009FA")]
		public bool isValid
		{
			[Address(RVA = "0xDBC730", Offset = "0xDBAF30", Length = "0x9")]
			[Token(Token = "0x6005AA7")]
			get
			{
				return default(bool);
			}
		}

		[Address(RVA = "0xDBC580", Offset = "0xDBAD80", Length = "0x1A4")]
		[Token(Token = "0x6005AA8")]
		public AxisCalibrator(Joystick joystick, int axisIndex)
		{
		}

		[Token(Token = "0x6005AA9")]
		[Address(RVA = "0xDBC4F0", Offset = "0xDBACF0", Length = "0x59")]
		public void RecordMinMax()
		{
		}

		[Token(Token = "0x6005AAA")]
		[Address(RVA = "0xDBC550", Offset = "0xDBAD50", Length = "0x24")]
		public void RecordZero()
		{
		}

		[Token(Token = "0x6005AAB")]
		[Address(RVA = "0xDBC3D0", Offset = "0xDBABD0", Length = "0x115")]
		public void Commit()
		{
		}
	}

	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x2060", Offset = "0x1460")]
	[Token(Token = "0x2000A88")]
	private class IndexedDictionary<TKey, TValue>
	{
		[Token(Token = "0x2000E00")]
		private class Entry
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4004145")]
			public TKey key;

			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4004146")]
			public TValue value;

			[Address(RVA = "0x159D4A0", Offset = "0x159BCA0", Length = "0x49")]
			[Token(Token = "0x60066BD")]
			public Entry(TKey key, TValue value)
			{
			}
		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4003782")]
		private List<Entry> list;

		[Token(Token = "0x170009FB")]
		public int Count
		{
			[Address(RVA = "0x15961A0", Offset = "0x15949A0", Length = "0x2A")]
			[Token(Token = "0x6005AAC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170009FC")]
		public TValue Item
		{
			[Token(Token = "0x6005AAE")]
			[Address(RVA = "0x159DA30", Offset = "0x159C230", Length = "0x34")]
			get
			{
				return (TValue)null;
			}
		}

		[Token(Token = "0x6005AAD")]
		[Address(RVA = "0x159D9A0", Offset = "0x159C1A0", Length = "0x87")]
		public IndexedDictionary()
		{
		}

		[Token(Token = "0x6005AAF")]
		[Address(RVA = "0x159D750", Offset = "0x159BF50", Length = "0xC3")]
		public TValue Get(TKey key)
		{
			return (TValue)null;
		}

		[Address(RVA = "0x159D900", Offset = "0x159C100", Length = "0x97")]
		[Token(Token = "0x6005AB0")]
		public bool TryGet(TKey key, out TValue value)
		{
			System.Runtime.CompilerServices.Unsafe.As<TValue, @null>(ref value) = null;
			return default(bool);
		}

		[Address(RVA = "0x159D4F0", Offset = "0x159BCF0", Length = "0x143")]
		[Token(Token = "0x6005AB1")]
		public void Add(TKey key, TValue value)
		{
		}

		[Address(RVA = "0x159D820", Offset = "0x159C020", Length = "0xDD")]
		[Token(Token = "0x6005AB2")]
		public int IndexOfKey(TKey key)
		{
			return default(int);
		}

		[Address(RVA = "0x159D670", Offset = "0x159BE70", Length = "0xDA")]
		[Token(Token = "0x6005AB3")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Address(RVA = "0x159D640", Offset = "0x159BE40", Length = "0x2B")]
		[Token(Token = "0x6005AB4")]
		public void Clear()
		{
		}
	}

	[Token(Token = "0x2000A89")]
	private enum LayoutElementSizeType
	{
		[Token(Token = "0x4003784")]
		MinSize,
		[Token(Token = "0x4003785")]
		PreferredSize
	}

	[Token(Token = "0x2000A8A")]
	private enum WindowType
	{
		[Token(Token = "0x4003787")]
		None,
		[Token(Token = "0x4003788")]
		ChooseJoystick,
		[Token(Token = "0x4003789")]
		JoystickAssignmentConflict,
		[Token(Token = "0x400378A")]
		ElementAssignment,
		[Token(Token = "0x400378B")]
		ElementAssignmentPrePolling,
		[Token(Token = "0x400378C")]
		ElementAssignmentPolling,
		[Token(Token = "0x400378D")]
		ElementAssignmentResult,
		[Token(Token = "0x400378E")]
		ElementAssignmentConflict,
		[Token(Token = "0x400378F")]
		Calibration,
		[Token(Token = "0x4003790")]
		CalibrateStep1,
		[Token(Token = "0x4003791")]
		CalibrateStep2
	}

	[Token(Token = "0x2000A8B")]
	private class InputGrid
	{
		[Token(Token = "0x4003792")]
		[FieldOffset(Offset = "0x10")]
		private InputGridEntryList list;

		[Token(Token = "0x4003793")]
		[FieldOffset(Offset = "0x18")]
		private List<GameObject> groups;

		[Token(Token = "0x6005AB5")]
		[Address(RVA = "0xDC65A0", Offset = "0xDC4DA0", Length = "0xE3")]
		public InputGrid()
		{
		}

		[Token(Token = "0x6005AB6")]
		[Address(RVA = "0xDC5950", Offset = "0xDC4150", Length = "0x12E")]
		public void AddMapCategory(int mapCategoryId)
		{
		}

		[Token(Token = "0x6005AB7")]
		[Address(RVA = "0xDC56B0", Offset = "0xDC3EB0", Length = "0x24")]
		public void AddAction(int mapCategoryId, InputAction action, AxisRange axisRange)
		{
		}

		[Address(RVA = "0xDC54C0", Offset = "0xDC3CC0", Length = "0x12A")]
		[Token(Token = "0x6005AB8")]
		public void AddActionCategory(int mapCategoryId, int actionCategoryId)
		{
		}

		[Address(RVA = "0xDC5740", Offset = "0xDC3F40", Length = "0x123")]
		[Token(Token = "0x6005AB9")]
		public void AddInputFieldSet(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, GameObject fieldSetContainer)
		{
		}

		[Address(RVA = "0xDC5870", Offset = "0xDC4070", Length = "0xD8")]
		[Token(Token = "0x6005ABA")]
		public void AddInputField(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, int fieldIndex, GUIInputField inputField)
		{
		}

		[Token(Token = "0x6005ABB")]
		[Address(RVA = "0xDC56E0", Offset = "0xDC3EE0", Length = "0x52")]
		public void AddGroup(GameObject group)
		{
		}

		[Address(RVA = "0xDC55F0", Offset = "0xDC3DF0", Length = "0xBA")]
		[Token(Token = "0x6005ABC")]
		public void AddActionLabel(int mapCategoryId, int actionId, AxisRange axisRange, GUILabel label)
		{
		}

		[Address(RVA = "0xDC53C0", Offset = "0xDC3BC0", Length = "0xFA")]
		[Token(Token = "0x6005ABD")]
		public void AddActionCategoryLabel(int mapCategoryId, int actionCategoryId, GUILabel label)
		{
		}

		[Token(Token = "0x6005ABE")]
		[Address(RVA = "0xDC5D20", Offset = "0xDC4520", Length = "0xB0")]
		public bool Contains(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6005ABF")]
		[Address(RVA = "0xDC5F00", Offset = "0xDC4700", Length = "0xF2")]
		public GUIInputField GetGUIInputField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
		{
			return null;
		}

		[Address(RVA = "0xDC5DE0", Offset = "0xDC45E0", Length = "0x89")]
		[Token(Token = "0x6005AC0")]
		public IEnumerable<InputActionSet> GetActionSets(int mapCategoryId)
		{
			return null;
		}

		[Token(Token = "0x6005AC1")]
		[Address(RVA = "0xDC61B0", Offset = "0xDC49B0", Length = "0x8B")]
		public void SetColumnHeight(int mapCategoryId, float height)
		{
		}

		[Token(Token = "0x6005AC2")]
		[Address(RVA = "0xDC5E70", Offset = "0xDC4670", Length = "0x8C")]
		public float GetColumnHeight(int mapCategoryId)
		{
			return default(float);
		}

		[Token(Token = "0x6005AC3")]
		[Address(RVA = "0xDC6360", Offset = "0xDC4B60", Length = "0x1E")]
		public void SetFieldsActive(int mapCategoryId, bool state)
		{
		}

		[Address(RVA = "0xDC6240", Offset = "0xDC4A40", Length = "0x111")]
		[Token(Token = "0x6005AC4")]
		public void SetFieldLabel(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int index, string label)
		{
		}

		[Address(RVA = "0xDC6130", Offset = "0xDC4930", Length = "0x70")]
		[Token(Token = "0x6005AC5")]
		public void PopulateField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId, int index, int actionElementMapId, string label, bool invert)
		{
		}

		[Address(RVA = "0xDC6380", Offset = "0xDC4B80", Length = "0x18A")]
		[Token(Token = "0x6005AC6")]
		public void SetFixedFieldData(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId)
		{
		}

		[Token(Token = "0x6005AC7")]
		[Address(RVA = "0xDC6020", Offset = "0xDC4820", Length = "0x109")]
		public void InitializeFields(int mapCategoryId)
		{
		}

		[Address(RVA = "0xDC6510", Offset = "0xDC4D10", Length = "0x83")]
		[Token(Token = "0x6005AC8")]
		public void Show(int mapCategoryId)
		{
		}

		[Token(Token = "0x6005AC9")]
		[Address(RVA = "0xDC6000", Offset = "0xDC4800", Length = "0x1D")]
		public void HideAll()
		{
		}

		[Token(Token = "0x6005ACA")]
		[Address(RVA = "0xDC5D00", Offset = "0xDC4500", Length = "0x1E")]
		public void ClearLabels(int mapCategoryId)
		{
		}

		[Token(Token = "0x6005ACB")]
		[Address(RVA = "0xDC5BE0", Offset = "0xDC43E0", Length = "0x11A")]
		private void ClearGroups()
		{
		}

		[Token(Token = "0x6005ACC")]
		[Address(RVA = "0xDC5A80", Offset = "0xDC4280", Length = "0x156")]
		public void ClearAll()
		{
		}
	}

	[Token(Token = "0x2000A8C")]
	private class InputGridEntryList
	{
		[Token(Token = "0x2000E01")]
		private class MapCategoryEntry
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4004147")]
			private List<ActionEntry> _actionList;

			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4004148")]
			private IndexedDictionary<int, ActionCategoryEntry> _actionCategoryList;

			[Token(Token = "0x4004149")]
			[FieldOffset(Offset = "0x20")]
			private float _columnHeight;

			[Token(Token = "0x17000B3F")]
			public List<ActionEntry> actionList
			{
				[Token(Token = "0x60066BE")]
				[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000B40")]
			public IndexedDictionary<int, ActionCategoryEntry> actionCategoryList
			{
				[Token(Token = "0x60066BF")]
				[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000B41")]
			public float columnHeight
			{
				[Token(Token = "0x60066C0")]
				[Address(RVA = "0x44A090", Offset = "0x448890", Length = "0x6")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60066C1")]
				[Address(RVA = "0xDC8720", Offset = "0xDC6F20", Length = "0x6")]
				set
				{
				}
			}

			[Address(RVA = "0xDC8680", Offset = "0xDC6E80", Length = "0x96")]
			[Token(Token = "0x60066C2")]
			public MapCategoryEntry()
			{
			}

			[Address(RVA = "0xDC8340", Offset = "0xDC6B40", Length = "0x8E")]
			[Token(Token = "0x60066C3")]
			public ActionEntry GetActionEntry(int actionId, AxisRange axisRange)
			{
				return null;
			}

			[Address(RVA = "0xDC83D0", Offset = "0xDC6BD0", Length = "0xDC")]
			[Token(Token = "0x60066C4")]
			public int IndexOfActionEntry(int actionId, AxisRange axisRange)
			{
				return default(int);
			}

			[Token(Token = "0x60066C5")]
			[Address(RVA = "0xDC82A0", Offset = "0xDC6AA0", Length = "0x16")]
			public bool ContainsActionEntry(int actionId, AxisRange axisRange)
			{
				return default(bool);
			}

			[Token(Token = "0x60066C6")]
			[Address(RVA = "0xDC8130", Offset = "0xDC6930", Length = "0x16B")]
			public ActionEntry AddAction(InputAction action, AxisRange axisRange)
			{
				return null;
			}

			[Address(RVA = "0xDC82C0", Offset = "0xDC6AC0", Length = "0x78")]
			[Token(Token = "0x60066C7")]
			public ActionCategoryEntry GetActionCategoryEntry(int actionCategoryId)
			{
				return null;
			}

			[Address(RVA = "0xDC8060", Offset = "0xDC6860", Length = "0xC1")]
			[Token(Token = "0x60066C8")]
			public ActionCategoryEntry AddActionCategory(int actionCategoryId)
			{
				return null;
			}

			[Token(Token = "0x60066C9")]
			[Address(RVA = "0xDC84B0", Offset = "0xDC6CB0", Length = "0x1C4")]
			public void SetAllActive(bool state)
			{
			}
		}

		[Token(Token = "0x2000E02")]
		private class ActionEntry
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400414A")]
			private IndexedDictionary<int, FieldSet> fieldSets;

			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400414B")]
			public GUILabel label;

			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x400414C")]
			public readonly InputAction action;

			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x400414D")]
			public readonly AxisRange axisRange;

			[Token(Token = "0x400414E")]
			[FieldOffset(Offset = "0x30")]
			public readonly InputActionSet actionSet;

			[Token(Token = "0x60066CA")]
			[Address(RVA = "0xDBC2F0", Offset = "0xDBAAF0", Length = "0xD0")]
			public ActionEntry(InputAction action, AxisRange axisRange)
			{
			}

			[Token(Token = "0x60066CB")]
			[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
			public void SetLabel(GUILabel label)
			{
			}

			[Address(RVA = "0xDBBC70", Offset = "0xDBA470", Length = "0x2B")]
			[Token(Token = "0x60066CC")]
			public bool Matches(int actionId, AxisRange axisRange)
			{
				return default(bool);
			}

			[Address(RVA = "0xDBB620", Offset = "0xDB9E20", Length = "0x10D")]
			[Token(Token = "0x60066CD")]
			public void AddInputFieldSet(ControllerType controllerType, GameObject fieldSetContainer)
			{
			}

			[Token(Token = "0x60066CE")]
			[Address(RVA = "0xDBB730", Offset = "0xDB9F30", Length = "0xC3")]
			public void AddInputField(ControllerType controllerType, int fieldIndex, GUIInputField inputField)
			{
			}

			[Address(RVA = "0xDBB9D0", Offset = "0xDBA1D0", Length = "0xE5")]
			[Token(Token = "0x60066CF")]
			public GUIInputField GetGUIInputField(ControllerType controllerType, int fieldIndex)
			{
				return null;
			}

			[Token(Token = "0x60066D0")]
			[Address(RVA = "0xDBB920", Offset = "0xDBA120", Length = "0xAD")]
			public bool Contains(ControllerType controllerType, int fieldId)
			{
				return default(bool);
			}

			[Token(Token = "0x60066D1")]
			[Address(RVA = "0xDBBEF0", Offset = "0xDBA6F0", Length = "0x101")]
			public void SetFieldLabel(ControllerType controllerType, int index, string label)
			{
			}

			[Token(Token = "0x60066D2")]
			[Address(RVA = "0xDBBCA0", Offset = "0xDBA4A0", Length = "0x187")]
			public void PopulateField(ControllerType controllerType, int controllerId, int index, int actionElementMapId, string label, bool invert)
			{
			}

			[Address(RVA = "0xDBC180", Offset = "0xDBA980", Length = "0x169")]
			[Token(Token = "0x60066D3")]
			public void SetFixedFieldData(ControllerType controllerType, int controllerId)
			{
			}

			[Token(Token = "0x60066D4")]
			[Address(RVA = "0xDBBAC0", Offset = "0xDBA2C0", Length = "0x1A3")]
			public void Initialize()
			{
			}

			[Token(Token = "0x60066D5")]
			[Address(RVA = "0xDBBE30", Offset = "0xDBA630", Length = "0xB8")]
			public void SetActive(bool state)
			{
			}

			[Token(Token = "0x60066D6")]
			[Address(RVA = "0xDBB800", Offset = "0xDBA000", Length = "0x11F")]
			public void ClearLabels()
			{
			}

			[Token(Token = "0x60066D7")]
			[Address(RVA = "0xDBC000", Offset = "0xDBA800", Length = "0x17D")]
			public void SetFieldsActive(bool state)
			{
			}
		}

		[Token(Token = "0x2000E03")]
		private class FieldSet
		{
			[Token(Token = "0x400414F")]
			[FieldOffset(Offset = "0x10")]
			public readonly GameObject groupContainer;

			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4004150")]
			public readonly IndexedDictionary<int, GUIInputField> fields;

			[Token(Token = "0x60066D8")]
			[Address(RVA = "0xDBFBC0", Offset = "0xDBE3C0", Length = "0x7B")]
			public FieldSet(GameObject groupContainer)
			{
			}
		}

		[Token(Token = "0x2000E04")]
		private class ActionCategoryEntry
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4004151")]
			public readonly int actionCategoryId;

			[Token(Token = "0x4004152")]
			[FieldOffset(Offset = "0x18")]
			public GUILabel label;

			[Token(Token = "0x60066D9")]
			[Address(RVA = "0x43F660", Offset = "0x43DE60", Length = "0x24")]
			public ActionCategoryEntry(int actionCategoryId)
			{
			}

			[Token(Token = "0x60066DA")]
			[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
			public void SetLabel(GUILabel label)
			{
			}

			[Token(Token = "0x60066DB")]
			[Address(RVA = "0xDBB600", Offset = "0xDB9E00", Length = "0x12")]
			public void SetActive(bool state)
			{
			}
		}

		[Token(Token = "0x4003794")]
		[FieldOffset(Offset = "0x10")]
		private IndexedDictionary<int, MapCategoryEntry> entries;

		[Token(Token = "0x6005ACD")]
		[Address(RVA = "0xDC5350", Offset = "0xDC3B50", Length = "0x69")]
		public InputGridEntryList()
		{
		}

		[Address(RVA = "0xDC4250", Offset = "0xDC2A50", Length = "0x124")]
		[Token(Token = "0x6005ACE")]
		public void AddMapCategory(int mapCategoryId)
		{
		}

		[Address(RVA = "0xDC4050", Offset = "0xDC2850", Length = "0xE")]
		[Token(Token = "0x6005ACF")]
		public void AddAction(int mapCategoryId, InputAction action, AxisRange axisRange)
		{
		}

		[Address(RVA = "0xDC3DE0", Offset = "0xDC25E0", Length = "0x1BE")]
		[Token(Token = "0x6005AD0")]
		private ActionEntry AddActionEntry(int mapCategoryId, InputAction action, AxisRange axisRange)
		{
			return null;
		}

		[Address(RVA = "0xDC3FA0", Offset = "0xDC27A0", Length = "0xAA")]
		[Token(Token = "0x6005AD1")]
		public void AddActionLabel(int mapCategoryId, int actionId, AxisRange axisRange, GUILabel label)
		{
		}

		[Address(RVA = "0xDC3CC0", Offset = "0xDC24C0", Length = "0x11A")]
		[Token(Token = "0x6005AD2")]
		public void AddActionCategory(int mapCategoryId, int actionCategoryId)
		{
		}

		[Token(Token = "0x6005AD3")]
		[Address(RVA = "0xDC3AA0", Offset = "0xDC22A0", Length = "0x125")]
		private ActionCategoryEntry AddActionCategoryEntry(int mapCategoryId, int actionCategoryId)
		{
			return null;
		}

		[Address(RVA = "0xDC3BD0", Offset = "0xDC23D0", Length = "0xEA")]
		[Token(Token = "0x6005AD4")]
		public void AddActionCategoryLabel(int mapCategoryId, int actionCategoryId, GUILabel label)
		{
		}

		[Address(RVA = "0xDC4060", Offset = "0xDC2860", Length = "0x117")]
		[Token(Token = "0x6005AD5")]
		public void AddInputFieldSet(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, GameObject fieldSetContainer)
		{
		}

		[Token(Token = "0x6005AD6")]
		[Address(RVA = "0xDC4180", Offset = "0xDC2980", Length = "0xCB")]
		public void AddInputField(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, int fieldIndex, GUIInputField inputField)
		{
		}

		[Token(Token = "0x6005AD7")]
		[Address(RVA = "0xDC45F0", Offset = "0xDC2DF0", Length = "0x1D")]
		public bool Contains(int mapCategoryId, int actionId, AxisRange axisRange)
		{
			return default(bool);
		}

		[Token(Token = "0x6005AD8")]
		[Address(RVA = "0xDC4610", Offset = "0xDC2E10", Length = "0xA3")]
		public bool Contains(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6005AD9")]
		[Address(RVA = "0xDC4D10", Offset = "0xDC3510", Length = "0x7F")]
		public void SetColumnHeight(int mapCategoryId, float height)
		{
		}

		[Token(Token = "0x6005ADA")]
		[Address(RVA = "0xDC4800", Offset = "0xDC3000", Length = "0x80")]
		public float GetColumnHeight(int mapCategoryId)
		{
			return default(float);
		}

		[Token(Token = "0x6005ADB")]
		[Address(RVA = "0xDC4890", Offset = "0xDC3090", Length = "0xF4")]
		public GUIInputField GetGUIInputField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
		{
			return null;
		}

		[Address(RVA = "0xDC46E0", Offset = "0xDC2EE0", Length = "0x9C")]
		[Token(Token = "0x6005ADC")]
		private ActionEntry GetActionEntry(int mapCategoryId, int actionId, AxisRange axisRange)
		{
			return null;
		}

		[Token(Token = "0x6005ADD")]
		[Address(RVA = "0xDC46C0", Offset = "0xDC2EC0", Length = "0x1A")]
		private ActionEntry GetActionEntry(int mapCategoryId, InputAction action, AxisRange axisRange)
		{
			return null;
		}

		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x91A80", Offset = "0x90E80")]
		[Address(RVA = "0xDC4780", Offset = "0xDC2F80", Length = "0x7E")]
		[Token(Token = "0x6005ADE")]
		public IEnumerable<InputActionSet> GetActionSets(int mapCategoryId)
		{
			return null;
		}

		[Address(RVA = "0xDC4D90", Offset = "0xDC3590", Length = "0x296")]
		[Token(Token = "0x6005ADF")]
		public void SetFieldsActive(int mapCategoryId, bool state)
		{
		}

		[Address(RVA = "0xDC51C0", Offset = "0xDC39C0", Length = "0x104")]
		[Token(Token = "0x6005AE0")]
		public void SetLabel(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int index, string label)
		{
		}

		[Token(Token = "0x6005AE1")]
		[Address(RVA = "0xDC4CA0", Offset = "0xDC34A0", Length = "0x62")]
		public void PopulateField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId, int index, int actionElementMapId, string label, bool invert)
		{
		}

		[Token(Token = "0x6005AE2")]
		[Address(RVA = "0xDC5030", Offset = "0xDC3830", Length = "0x18C")]
		public void SetFixedFieldData(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId)
		{
		}

		[Token(Token = "0x6005AE3")]
		[Address(RVA = "0xDC4BB0", Offset = "0xDC33B0", Length = "0xEF")]
		public void InitializeFields(int mapCategoryId)
		{
		}

		[Address(RVA = "0xDC52D0", Offset = "0xDC3AD0", Length = "0x77")]
		[Token(Token = "0x6005AE4")]
		public void Show(int mapCategoryId)
		{
		}

		[Token(Token = "0x6005AE5")]
		[Address(RVA = "0xDC4990", Offset = "0xDC3190", Length = "0x21C")]
		public void HideAll()
		{
		}

		[Token(Token = "0x6005AE6")]
		[Address(RVA = "0xDC4380", Offset = "0xDC2B80", Length = "0x21C")]
		public void ClearLabels(int mapCategoryId)
		{
		}

		[Token(Token = "0x6005AE7")]
		[Address(RVA = "0xDC45A0", Offset = "0xDC2DA0", Length = "0x43")]
		public void Clear()
		{
		}
	}

	[Token(Token = "0x2000A8D")]
	private class WindowManager
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003795")]
		private List<Window> windows;

		[Token(Token = "0x4003796")]
		[FieldOffset(Offset = "0x18")]
		private GameObject windowPrefab;

		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003797")]
		private Transform parent;

		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4003798")]
		private GameObject fader;

		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003799")]
		private int idCounter;

		[Token(Token = "0x170009FD")]
		public bool isWindowOpen
		{
			[Address(RVA = "0xDCF8C0", Offset = "0xDCE0C0", Length = "0xC7")]
			[Token(Token = "0x6005AE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170009FE")]
		public Window topWindow
		{
			[Address(RVA = "0xDCF990", Offset = "0xDCE190", Length = "0xDC")]
			[Token(Token = "0x6005AE9")]
			get
			{
				return null;
			}
		}

		[Address(RVA = "0xDCF720", Offset = "0xDCDF20", Length = "0x19D")]
		[Token(Token = "0x6005AEA")]
		public WindowManager(GameObject windowPrefab, GameObject faderPrefab, Transform parent)
		{
		}

		[Address(RVA = "0xDCF400", Offset = "0xDCDC00", Length = "0x191")]
		[Token(Token = "0x6005AEB")]
		public Window OpenWindow(string name, int width, int height)
		{
			return null;
		}

		[Token(Token = "0x6005AEC")]
		[Address(RVA = "0xDCF320", Offset = "0xDCDB20", Length = "0xD1")]
		public Window OpenWindow(GameObject windowPrefab, string name)
		{
			return null;
		}

		[Address(RVA = "0xDCE5D0", Offset = "0xDCCDD0", Length = "0x12D")]
		[Token(Token = "0x6005AED")]
		public void CloseTop()
		{
		}

		[Token(Token = "0x6005AEE")]
		[Address(RVA = "0xDCE700", Offset = "0xDCCF00", Length = "0x24")]
		public void CloseWindow(int windowId)
		{
		}

		[Token(Token = "0x6005AEF")]
		[Address(RVA = "0xDCE730", Offset = "0xDCCF30", Length = "0x243")]
		public void CloseWindow(Window window)
		{
		}

		[Address(RVA = "0xDCE4A0", Offset = "0xDCCCA0", Length = "0x12C")]
		[Token(Token = "0x6005AF0")]
		public void CloseAll()
		{
		}

		[Token(Token = "0x6005AF1")]
		[Address(RVA = "0xDCE2D0", Offset = "0xDCCAD0", Length = "0x121")]
		public void CancelAll()
		{
		}

		[Token(Token = "0x6005AF2")]
		[Address(RVA = "0xDCEDF0", Offset = "0xDCD5F0", Length = "0x126")]
		public Window GetWindow(int windowId)
		{
			return null;
		}

		[Address(RVA = "0xDCF270", Offset = "0xDCDA70", Length = "0xA6")]
		[Token(Token = "0x6005AF3")]
		public bool IsFocused(int windowId)
		{
			return default(bool);
		}

		[Address(RVA = "0xDCEC00", Offset = "0xDCD400", Length = "0x24")]
		[Token(Token = "0x6005AF4")]
		public void Focus(int windowId)
		{
		}

		[Address(RVA = "0xDCEC30", Offset = "0xDCD430", Length = "0x1A0")]
		[Token(Token = "0x6005AF5")]
		public void Focus(Window window)
		{
		}

		[Address(RVA = "0xDCE980", Offset = "0xDCD180", Length = "0x13D")]
		[Token(Token = "0x6005AF6")]
		private void DefocusOtherWindows(int focusedWindowId)
		{
		}

		[Address(RVA = "0xDCF5C0", Offset = "0xDCDDC0", Length = "0x154")]
		[Token(Token = "0x6005AF7")]
		private void UpdateFader()
		{
		}

		[Token(Token = "0x6005AF8")]
		[Address(RVA = "0xDCEB60", Offset = "0xDCD360", Length = "0x97")]
		private void FocusTopWindow()
		{
		}

		[Address(RVA = "0xDCF5A0", Offset = "0xDCDDA0", Length = "0x1E")]
		[Token(Token = "0x6005AF9")]
		private void SetFaderActive(bool state)
		{
		}

		[Address(RVA = "0xDCF0D0", Offset = "0xDCD8D0", Length = "0x194")]
		[Token(Token = "0x6005AFA")]
		private Window InstantiateWindow(string name, int width, int height)
		{
			return null;
		}

		[Address(RVA = "0xDCEF20", Offset = "0xDCD720", Length = "0x1AB")]
		[Token(Token = "0x6005AFB")]
		private Window InstantiateWindow(string name, GameObject windowPrefab)
		{
			return null;
		}

		[Address(RVA = "0xDCEAC0", Offset = "0xDCD2C0", Length = "0x9D")]
		[Token(Token = "0x6005AFC")]
		private void DestroyWindow(Window window)
		{
		}

		[Address(RVA = "0xDCEDE0", Offset = "0xDCD5E0", Length = "0xA")]
		[Token(Token = "0x6005AFD")]
		private int GetNewId()
		{
			return default(int);
		}

		[Address(RVA = "0xDCE400", Offset = "0xDCCC00", Length = "0x9C")]
		[Token(Token = "0x6005AFE")]
		public void ClearCompletely()
		{
		}
	}

	[Token(Token = "0x4000DEE")]
	public const int versionMajor = 1;

	[Token(Token = "0x4000DEF")]
	public const int versionMinor = 1;

	[Token(Token = "0x4000DF0")]
	public const bool usesTMPro = false;

	[Token(Token = "0x4000DF1")]
	private const float blockInputOnFocusTimeout = 0.1f;

	[Token(Token = "0x4000DF2")]
	private const string buttonIdentifier_playerSelection = "PlayerSelection";

	[Token(Token = "0x4000DF3")]
	private const string buttonIdentifier_removeController = "RemoveController";

	[Token(Token = "0x4000DF4")]
	private const string buttonIdentifier_assignController = "AssignController";

	[Token(Token = "0x4000DF5")]
	private const string buttonIdentifier_calibrateController = "CalibrateController";

	[Token(Token = "0x4000DF6")]
	private const string buttonIdentifier_editInputBehaviors = "EditInputBehaviors";

	[Token(Token = "0x4000DF7")]
	private const string buttonIdentifier_mapCategorySelection = "MapCategorySelection";

	[Token(Token = "0x4000DF8")]
	private const string buttonIdentifier_assignedControllerSelection = "AssignedControllerSelection";

	[Token(Token = "0x4000DF9")]
	private const string buttonIdentifier_done = "Done";

	[Token(Token = "0x4000DFA")]
	private const string buttonIdentifier_restoreDefaults = "RestoreDefaults";

	[Token(Token = "0x4000DFB")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795D0", Offset = "0x789D0")]
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	private InputManager _rewiredInputManager;

	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798C0", Offset = "0x78CC0")]
	[Token(Token = "0x4000DFC")]
	[FieldOffset(Offset = "0x20")]
	private bool _dontDestroyOnLoad;

	[FieldOffset(Offset = "0x21")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79BB0", Offset = "0x78FB0")]
	[Token(Token = "0x4000DFD")]
	private bool _openOnStart;

	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000DFE")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79DC0", Offset = "0x791C0")]
	[SerializeField]
	private int _keyboardMapDefaultLayout;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000DFF")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79F80", Offset = "0x79380")]
	[SerializeField]
	private int _mouseMapDefaultLayout;

	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79F80", Offset = "0x79380")]
	[Token(Token = "0x4000E00")]
	[FieldOffset(Offset = "0x2C")]
	private int _joystickMapDefaultLayout;

	[Token(Token = "0x4000E01")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private MappingSet[] _mappingSets;

	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6F0", Offset = "0x79AF0")]
	[Token(Token = "0x4000E02")]
	[FieldOffset(Offset = "0x38")]
	private bool _showPlayers;

	[FieldOffset(Offset = "0x39")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7B100", Offset = "0x7A500")]
	[SerializeField]
	[Token(Token = "0x4000E03")]
	private bool _showControllers;

	[FieldOffset(Offset = "0x3A")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7B350", Offset = "0x7A750")]
	[SerializeField]
	[Token(Token = "0x4000E04")]
	private bool _showKeyboard;

	[SerializeField]
	[FieldOffset(Offset = "0x3B")]
	[Token(Token = "0x4000E05")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7B570", Offset = "0x7A970")]
	private bool _showMouse;

	[Token(Token = "0x4000E06")]
	[SerializeField]
	[FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7B7E0", Offset = "0x7ABE0")]
	private int _maxControllersPerPlayer;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000E07")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7BA20", Offset = "0x7AE20")]
	[SerializeField]
	private bool _showActionCategoryLabels;

	[FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7BD70", Offset = "0x7B170")]
	[Token(Token = "0x4000E08")]
	[SerializeField]
	private int _keyboardInputFieldCount;

	[Token(Token = "0x4000E09")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7BFA0", Offset = "0x7B3A0")]
	[SerializeField]
	private int _mouseInputFieldCount;

	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7C280", Offset = "0x7B680")]
	[Token(Token = "0x4000E0A")]
	private int _controllerInputFieldCount;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7C470", Offset = "0x7B870")]
	[SerializeField]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000E0B")]
	private bool _showFullAxisInputFields;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D960", Offset = "0x7CD60")]
	[SerializeField]
	[Token(Token = "0x4000E0C")]
	[FieldOffset(Offset = "0x51")]
	private bool _showSplitAxisInputFields;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7DB10", Offset = "0x7CF10")]
	[FieldOffset(Offset = "0x52")]
	[SerializeField]
	[Token(Token = "0x4000E0D")]
	private bool _allowElementAssignmentConflicts;

	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7DC60", Offset = "0x7D060")]
	[FieldOffset(Offset = "0x53")]
	[Token(Token = "0x4000E0E")]
	private bool _allowElementAssignmentSwap;

	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7DEC0", Offset = "0x7D2C0")]
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000E0F")]
	private int _actionLabelWidth;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E140", Offset = "0x7D540")]
	[Token(Token = "0x4000E10")]
	[SerializeField]
	[FieldOffset(Offset = "0x58")]
	private int _keyboardColMaxWidth;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E2E0", Offset = "0x7D6E0")]
	[Token(Token = "0x4000E11")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private int _mouseColMaxWidth;

	[Token(Token = "0x4000E12")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E500", Offset = "0x7D900")]
	private int _controllerColMaxWidth;

	[Token(Token = "0x4000E13")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E770", Offset = "0x7DB70")]
	[FieldOffset(Offset = "0x64")]
	private int _inputRowHeight;

	[FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E980", Offset = "0x7DD80")]
	[Token(Token = "0x4000E14")]
	[SerializeField]
	private RectOffset _inputRowPadding;

	[Token(Token = "0x4000E15")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB00", Offset = "0x7DF00")]
	[SerializeField]
	[FieldOffset(Offset = "0x70")]
	private int _inputRowFieldSpacing;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC00", Offset = "0x7E000")]
	[Token(Token = "0x4000E16")]
	[SerializeField]
	[FieldOffset(Offset = "0x74")]
	private int _inputColumnSpacing;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000E17")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED60", Offset = "0x7E160")]
	[SerializeField]
	private int _inputRowCategorySpacing;

	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EEF0", Offset = "0x7E2F0")]
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000E18")]
	private int _invertToggleWidth;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F070", Offset = "0x7E470")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x4000E19")]
	private int _defaultWindowWidth;

	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	[Token(Token = "0x4000E1A")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1E0", Offset = "0x7E5E0")]
	private int _defaultWindowHeight;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F360", Offset = "0x7E760")]
	[Token(Token = "0x4000E1B")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private float _controllerAssignmentTimeout;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F620", Offset = "0x7EA20")]
	[SerializeField]
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x4000E1C")]
	private float _preInputAssignmentTimeout;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000E1D")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F8E0", Offset = "0x7ECE0")]
	[SerializeField]
	private float _inputAssignmentTimeout;

	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA80", Offset = "0x7EE80")]
	[Token(Token = "0x4000E1E")]
	[FieldOffset(Offset = "0x94")]
	private float _axisCalibrationTimeout;

	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FB70", Offset = "0x7EF70")]
	[Token(Token = "0x4000E1F")]
	private bool _ignoreMouseXAxisAssignment;

	[Token(Token = "0x4000E20")]
	[FieldOffset(Offset = "0x99")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC00", Offset = "0x7F000")]
	[SerializeField]
	private bool _ignoreMouseYAxisAssignment;

	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FEB0", Offset = "0x7F2B0")]
	[Token(Token = "0x4000E21")]
	[FieldOffset(Offset = "0x9C")]
	private int _screenToggleAction;

	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80190", Offset = "0x7F590")]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000E22")]
	private int _screenOpenAction;

	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000E23")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80390", Offset = "0x7F790")]
	[SerializeField]
	private int _screenCloseAction;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000E24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80400", Offset = "0x7F800")]
	[SerializeField]
	private int _universalCancelAction;

	[SerializeField]
	[Token(Token = "0x4000E25")]
	[FieldOffset(Offset = "0xAC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80700", Offset = "0x7FB00")]
	private bool _universalCancelClosesScreen;

	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80800", Offset = "0x7FC00")]
	[Token(Token = "0x4000E26")]
	[FieldOffset(Offset = "0xAD")]
	private bool _showInputBehaviorSettings;

	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80A00", Offset = "0x7FE00")]
	[Token(Token = "0x4000E27")]
	[FieldOffset(Offset = "0xB0")]
	private InputBehaviorSettings[] _inputBehaviorSettings;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C80", Offset = "0x80080")]
	[Token(Token = "0x4000E28")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private bool _useThemeSettings;

	[Token(Token = "0x4000E29")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80D40", Offset = "0x80140")]
	[SerializeField]
	[FieldOffset(Offset = "0xC0")]
	private ThemeSettings _themeSettings;

	[FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80E60", Offset = "0x80260")]
	[SerializeField]
	[Token(Token = "0x4000E2A")]
	private LanguageDataBase _language;

	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82350", Offset = "0x81750")]
	[Token(Token = "0x4000E2B")]
	[FieldOffset(Offset = "0xD0")]
	private Prefabs prefabs;

	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82530", Offset = "0x81930")]
	[Token(Token = "0x4000E2C")]
	[FieldOffset(Offset = "0xD8")]
	private References references;

	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x825C0", Offset = "0x819C0")]
	[Token(Token = "0x4000E2D")]
	[FieldOffset(Offset = "0xE0")]
	private bool _showPlayersGroupLabel;

	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x827F0", Offset = "0x81BF0")]
	[FieldOffset(Offset = "0xE1")]
	[Token(Token = "0x4000E2E")]
	private bool _showControllerGroupLabel;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82900", Offset = "0x81D00")]
	[Token(Token = "0x4000E2F")]
	[FieldOffset(Offset = "0xE2")]
	[SerializeField]
	private bool _showAssignedControllersGroupLabel;

	[Token(Token = "0x4000E30")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82A40", Offset = "0x81E40")]
	[FieldOffset(Offset = "0xE3")]
	private bool _showSettingsGroupLabel;

	[FieldOffset(Offset = "0xE4")]
	[SerializeField]
	[Token(Token = "0x4000E31")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82CE0", Offset = "0x820E0")]
	private bool _showMapCategoriesGroupLabel;

	[FieldOffset(Offset = "0xE5")]
	[Token(Token = "0x4000E32")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82EF0", Offset = "0x822F0")]
	[SerializeField]
	private bool _showControllerNameLabel;

	[FieldOffset(Offset = "0xE6")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83060", Offset = "0x82460")]
	[Token(Token = "0x4000E33")]
	private bool _showAssignedControllers;

	[Token(Token = "0x4000E34")]
	[FieldOffset(Offset = "0xE8")]
	private Action _ScreenClosedEvent;

	[Token(Token = "0x4000E35")]
	[FieldOffset(Offset = "0xF0")]
	private Action _ScreenOpenedEvent;

	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000E36")]
	private Action _PopupWindowOpenedEvent;

	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000E37")]
	private Action _PopupWindowClosedEvent;

	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000E38")]
	private Action _InputPollingStartedEvent;

	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000E39")]
	private Action _InputPollingEndedEvent;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83200", Offset = "0x82600")]
	[Token(Token = "0x4000E3A")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	private UnityEvent _onScreenClosed;

	[Token(Token = "0x4000E3B")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83440", Offset = "0x82840")]
	private UnityEvent _onScreenOpened;

	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000E3C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837B0", Offset = "0x82BB0")]
	[SerializeField]
	private UnityEvent _onPopupWindowClosed;

	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83900", Offset = "0x82D00")]
	[Token(Token = "0x4000E3D")]
	[FieldOffset(Offset = "0x130")]
	private UnityEvent _onPopupWindowOpened;

	[FieldOffset(Offset = "0x138")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83A30", Offset = "0x82E30")]
	[SerializeField]
	[Token(Token = "0x4000E3E")]
	private UnityEvent _onInputPollingStarted;

	[SerializeField]
	[Token(Token = "0x4000E3F")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83AC0", Offset = "0x82EC0")]
	[FieldOffset(Offset = "0x140")]
	private UnityEvent _onInputPollingEnded;

	[Token(Token = "0x4000E40")]
	private static ControlMapper Instance;

	[Token(Token = "0x4000E41")]
	[FieldOffset(Offset = "0x148")]
	private bool initialized;

	[Token(Token = "0x4000E42")]
	[FieldOffset(Offset = "0x14C")]
	private int playerCount;

	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000E43")]
	private InputGrid inputGrid;

	[Token(Token = "0x4000E44")]
	[FieldOffset(Offset = "0x158")]
	private WindowManager windowManager;

	[Token(Token = "0x4000E45")]
	[FieldOffset(Offset = "0x160")]
	private int currentPlayerId;

	[FieldOffset(Offset = "0x164")]
	[Token(Token = "0x4000E46")]
	private int currentMapCategoryId;

	[Token(Token = "0x4000E47")]
	[FieldOffset(Offset = "0x168")]
	private List<GUIButton> playerButtons;

	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x4000E48")]
	private List<GUIButton> mapCategoryButtons;

	[Token(Token = "0x4000E49")]
	[FieldOffset(Offset = "0x178")]
	private List<GUIButton> assignedControllerButtons;

	[Token(Token = "0x4000E4A")]
	[FieldOffset(Offset = "0x180")]
	private GUIButton assignedControllerButtonsPlaceholder;

	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x4000E4B")]
	private List<GameObject> miscInstantiatedObjects;

	[Token(Token = "0x4000E4C")]
	[FieldOffset(Offset = "0x190")]
	private GameObject canvas;

	[Token(Token = "0x4000E4D")]
	[FieldOffset(Offset = "0x198")]
	private GameObject lastUISelection;

	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4000E4E")]
	private int currentJoystickId;

	[FieldOffset(Offset = "0x1A4")]
	[Token(Token = "0x4000E4F")]
	private float blockInputOnFocusEndTime;

	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4000E50")]
	private bool isPollingForInput;

	[Token(Token = "0x4000E51")]
	[FieldOffset(Offset = "0x1B0")]
	private InputMapping pendingInputMapping;

	[Token(Token = "0x4000E52")]
	[FieldOffset(Offset = "0x1B8")]
	private AxisCalibrator pendingAxisCalibration;

	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4000E53")]
	private Action<InputFieldInfo> inputFieldActivatedDelegate;

	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4000E54")]
	private Action<ToggleInfo, bool> inputFieldInvertToggleStateChangedDelegate;

	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4000E55")]
	private Action _restoreDefaultsDelegate;

	[Token(Token = "0x1700033F")]
	public InputManager rewiredInputManager
	{
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		[Token(Token = "0x6001110")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001111")]
		[Address(RVA = "0x89A3C0", Offset = "0x898BC0", Length = "0x26")]
		set
		{
		}
	}

	[Token(Token = "0x17000340")]
	public bool dontDestroyOnLoad
	{
		[Token(Token = "0x6001112")]
		[Address(RVA = "0x45D430", Offset = "0x45BC30", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x89A090", Offset = "0x898890", Length = "0x95")]
		[Token(Token = "0x6001113")]
		set
		{
		}
	}

	[Token(Token = "0x17000341")]
	public int keyboardMapDefaultLayout
	{
		[Address(RVA = "0x42D1F0", Offset = "0x42B9F0", Length = "0x4")]
		[Token(Token = "0x6001114")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x89A240", Offset = "0x898A40", Length = "0x13")]
		[Token(Token = "0x6001115")]
		set
		{
		}
	}

	[Token(Token = "0x17000342")]
	public int mouseMapDefaultLayout
	{
		[Address(RVA = "0x49EAA0", Offset = "0x49D2A0", Length = "0x4")]
		[Token(Token = "0x6001116")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x89A380", Offset = "0x898B80", Length = "0x13")]
		[Token(Token = "0x6001117")]
		set
		{
		}
	}

	[Token(Token = "0x17000343")]
	public int joystickMapDefaultLayout
	{
		[Address(RVA = "0x597010", Offset = "0x595810", Length = "0x4")]
		[Token(Token = "0x6001118")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001119")]
		[Address(RVA = "0x89A1E0", Offset = "0x8989E0", Length = "0x13")]
		set
		{
		}
	}

	[Token(Token = "0x17000344")]
	public bool showPlayers
	{
		[Token(Token = "0x600111A")]
		[Address(RVA = "0x899AA0", Offset = "0x8982A0", Length = "0x77")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x89A570", Offset = "0x898D70", Length = "0x13")]
		[Token(Token = "0x600111B")]
		set
		{
		}
	}

	[Token(Token = "0x17000345")]
	public bool showControllers
	{
		[Token(Token = "0x600111C")]
		[Address(RVA = "0x899A40", Offset = "0x898240", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x89A490", Offset = "0x898C90", Length = "0x13")]
		[Token(Token = "0x600111D")]
		set
		{
		}
	}

	[Token(Token = "0x17000346")]
	public bool showKeyboard
	{
		[Address(RVA = "0x49B590", Offset = "0x499D90", Length = "0x5")]
		[Token(Token = "0x600111E")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x89A4F0", Offset = "0x898CF0", Length = "0x13")]
		[Token(Token = "0x600111F")]
		set
		{
		}
	}

	[Token(Token = "0x17000347")]
	public bool showMouse
	{
		[Address(RVA = "0x899A90", Offset = "0x898290", Length = "0x5")]
		[Token(Token = "0x6001120")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x89A530", Offset = "0x898D30", Length = "0x13")]
		[Token(Token = "0x6001121")]
		set
		{
		}
	}

	[Token(Token = "0x17000348")]
	public int maxControllersPerPlayer
	{
		[Token(Token = "0x6001122")]
		[Address(RVA = "0x45A8F0", Offset = "0x4590F0", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001123")]
		[Address(RVA = "0x89A320", Offset = "0x898B20", Length = "0x13")]
		set
		{
		}
	}

	[Token(Token = "0x17000349")]
	public bool showActionCategoryLabels
	{
		[Token(Token = "0x6001124")]
		[Address(RVA = "0x47F9B0", Offset = "0x47E1B0", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001125")]
		[Address(RVA = "0x89A3F0", Offset = "0x898BF0", Length = "0x13")]
		set
		{
		}
	}

	[Token(Token = "0x1700034A")]
	public int keyboardInputFieldCount
	{
		[Address(RVA = "0x782D10", Offset = "0x781510", Length = "0x4")]
		[Token(Token = "0x6001126")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001127")]
		[Address(RVA = "0x89A220", Offset = "0x898A20", Length = "0x13")]
		set
		{
		}
	}

	[Token(Token = "0x1700034B")]
	public int mouseInputFieldCount
	{
		[Token(Token = "0x6001128")]
		[Address(RVA = "0x6F3B00", Offset = "0x6F2300", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x89A360", Offset = "0x898B60", Length = "0x13")]
		[Token(Token = "0x6001129")]
		set
		{
		}
	}

	[Token(Token = "0x1700034C")]
	public int controllerInputFieldCount
	{
		[Token(Token = "0x600112A")]
		[Address(RVA = "0x6F50D0", Offset = "0x6F38D0", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600112B")]
		[Address(RVA = "0x89A030", Offset = "0x898830", Length = "0x13")]
		set
		{
		}
	}

	[Token(Token = "0x1700034D")]
	public bool showFullAxisInputFields
	{
		[Address(RVA = "0x50B3E0", Offset = "0x509BE0", Length = "0x5")]
		[Token(Token = "0x600112C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600112D")]
		[Address(RVA = "0x89A4B0", Offset = "0x898CB0", Length = "0x13")]
		set
		{
		}
	}

	[Token(Token = "0x1700034E")]
	public bool showSplitAxisInputFields
	{
		[Token(Token = "0x600112E")]
		[Address(RVA = "0x642810", Offset = "0x641010", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600112F")]
		[Address(RVA = "0x89A5B0", Offset = "0x898DB0", Length = "0x13")]
		set
		{
		}
	}

	[Token(Token = "0x1700034F")]
	public bool allowElementAssignmentConflicts
	{
		[Token(Token = "0x6001130")]
		[Address(RVA = "0x8994F0", Offset = "0x897CF0", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001131")]
		[Address(RVA = "0x899FD0", Offset = "0x8987D0", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x17000350")]
	public bool allowElementAssignmentSwap
	{
		[Token(Token = "0x6001132")]
		[Address(RVA = "0x899500", Offset = "0x897D00", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001133")]
		[Address(RVA = "0x899FE0", Offset = "0x8987E0", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x17000351")]
	public int actionLabelWidth
	{
		[Address(RVA = "0x6F50E0", Offset = "0x6F38E0", Length = "0x4")]
		[Token(Token = "0x6001134")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001135")]
		[Address(RVA = "0x899FB0", Offset = "0x8987B0", Length = "0x13")]
		set
		{
		}
	}

	[Token(Token = "0x17000352")]
	public int keyboardColMaxWidth
	{
		[Token(Token = "0x6001136")]
		[Address(RVA = "0x4E8C60", Offset = "0x4E7460", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x89A200", Offset = "0x898A00", Length = "0x13")]
		[Token(Token = "0x6001137")]
		set
		{
		}
	}

	[Token(Token = "0x17000353")]
	public int mouseColMaxWidth
	{
		[Token(Token = "0x6001138")]
		[Address(RVA = "0x4E8C70", Offset = "0x4E7470", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x89A340", Offset = "0x898B40", Length = "0x13")]
		[Token(Token = "0x6001139")]
		set
		{
		}
	}

	[Token(Token = "0x17000354")]
	public int controllerColMaxWidth
	{
		[Token(Token = "0x600113A")]
		[Address(RVA = "0x429C30", Offset = "0x428430", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600113B")]
		[Address(RVA = "0x89A010", Offset = "0x898810", Length = "0x13")]
		set
		{
		}
	}

	[Token(Token = "0x17000355")]
	public int inputRowHeight
	{
		[Address(RVA = "0x5D3330", Offset = "0x5D1B30", Length = "0x4")]
		[Token(Token = "0x600113C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600113D")]
		[Address(RVA = "0x89A1A0", Offset = "0x8989A0", Length = "0x13")]
		set
		{
		}
	}

	[Token(Token = "0x17000356")]
	public int inputColumnSpacing
	{
		[Token(Token = "0x600113E")]
		[Address(RVA = "0x42C7D0", Offset = "0x42AFD0", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600113F")]
		[Address(RVA = "0x89A160", Offset = "0x898960", Length = "0x13")]
		set
		{
		}
	}

	[Token(Token = "0x17000357")]
	public int inputRowCategorySpacing
	{
		[Token(Token = "0x6001140")]
		[Address(RVA = "0x486430", Offset = "0x484C30", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001141")]
		[Address(RVA = "0x89A180", Offset = "0x898980", Length = "0x13")]
		set
		{
		}
	}

	[Token(Token = "0x17000358")]
	public int invertToggleWidth
	{
		[Token(Token = "0x6001142")]
		[Address(RVA = "0x4865E0", Offset = "0x484DE0", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x89A1C0", Offset = "0x8989C0", Length = "0x13")]
		[Token(Token = "0x6001143")]
		set
		{
		}
	}

	[Token(Token = "0x17000359")]
	public int defaultWindowWidth
	{
		[Address(RVA = "0x8997B0", Offset = "0x897FB0", Length = "0x7")]
		[Token(Token = "0x6001144")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x89A070", Offset = "0x898870", Length = "0x16")]
		[Token(Token = "0x6001145")]
		set
		{
		}
	}

	[Token(Token = "0x1700035A")]
	public int defaultWindowHeight
	{
		[Token(Token = "0x6001146")]
		[Address(RVA = "0x8997A0", Offset = "0x897FA0", Length = "0x7")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001147")]
		[Address(RVA = "0x89A050", Offset = "0x898850", Length = "0x16")]
		set
		{
		}
	}

	[Token(Token = "0x1700035B")]
	public float controllerAssignmentTimeout
	{
		[Token(Token = "0x6001148")]
		[Address(RVA = "0x899520", Offset = "0x897D20", Length = "0x9")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001149")]
		[Address(RVA = "0x89A000", Offset = "0x898800", Length = "0x9")]
		set
		{
		}
	}

	[Token(Token = "0x1700035C")]
	public float preInputAssignmentTimeout
	{
		[Address(RVA = "0x8999E0", Offset = "0x8981E0", Length = "0x9")]
		[Token(Token = "0x600114A")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600114B")]
		[Address(RVA = "0x89A3A0", Offset = "0x898BA0", Length = "0x9")]
		set
		{
		}
	}

	[Token(Token = "0x1700035D")]
	public float inputAssignmentTimeout
	{
		[Token(Token = "0x600114C")]
		[Address(RVA = "0x899800", Offset = "0x898000", Length = "0x9")]
		get
		{
			return default(float);
		}
		[Address(RVA = "0x89A150", Offset = "0x898950", Length = "0x9")]
		[Token(Token = "0x600114D")]
		set
		{
		}
	}

	[Token(Token = "0x1700035E")]
	public float axisCalibrationTimeout
	{
		[Address(RVA = "0x899510", Offset = "0x897D10", Length = "0x9")]
		[Token(Token = "0x600114E")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600114F")]
		[Address(RVA = "0x899FF0", Offset = "0x8987F0", Length = "0x9")]
		set
		{
		}
	}

	[Token(Token = "0x1700035F")]
	public bool ignoreMouseXAxisAssignment
	{
		[Address(RVA = "0x432400", Offset = "0x430C00", Length = "0x8")]
		[Token(Token = "0x6001150")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x89A130", Offset = "0x898930", Length = "0x7")]
		[Token(Token = "0x6001151")]
		set
		{
		}
	}

	[Token(Token = "0x17000360")]
	public bool ignoreMouseYAxisAssignment
	{
		[Token(Token = "0x6001152")]
		[Address(RVA = "0x8997C0", Offset = "0x897FC0", Length = "0x8")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x89A140", Offset = "0x898940", Length = "0x7")]
		[Token(Token = "0x6001153")]
		set
		{
		}
	}

	[Token(Token = "0x17000361")]
	public bool universalCancelClosesScreen
	{
		[Address(RVA = "0x899B70", Offset = "0x898370", Length = "0x8")]
		[Token(Token = "0x6001154")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x89A5D0", Offset = "0x898DD0", Length = "0x7")]
		[Token(Token = "0x6001155")]
		set
		{
		}
	}

	[Token(Token = "0x17000362")]
	public bool showInputBehaviorSettings
	{
		[Address(RVA = "0x899A50", Offset = "0x898250", Length = "0x8")]
		[Token(Token = "0x6001156")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001157")]
		[Address(RVA = "0x89A4D0", Offset = "0x898CD0", Length = "0x16")]
		set
		{
		}
	}

	[Token(Token = "0x17000363")]
	public bool useThemeSettings
	{
		[Token(Token = "0x6001158")]
		[Address(RVA = "0x899B80", Offset = "0x898380", Length = "0x8")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x89A5E0", Offset = "0x898DE0", Length = "0x16")]
		[Token(Token = "0x6001159")]
		set
		{
		}
	}

	[Token(Token = "0x17000364")]
	public LanguageDataBase language
	{
		[Token(Token = "0x600115A")]
		[Address(RVA = "0x460220", Offset = "0x45EA20", Length = "0x8")]
		get
		{
			return null;
		}
		[Address(RVA = "0x89A260", Offset = "0x898A60", Length = "0xB7")]
		[Token(Token = "0x600115B")]
		set
		{
		}
	}

	[Token(Token = "0x17000365")]
	public bool showPlayersGroupLabel
	{
		[Token(Token = "0x600115C")]
		[Address(RVA = "0x81D1D0", Offset = "0x81B9D0", Length = "0x8")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x89A550", Offset = "0x898D50", Length = "0x16")]
		[Token(Token = "0x600115D")]
		set
		{
		}
	}

	[Token(Token = "0x17000366")]
	public bool showControllerGroupLabel
	{
		[Address(RVA = "0x899A20", Offset = "0x898220", Length = "0x8")]
		[Token(Token = "0x600115E")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600115F")]
		[Address(RVA = "0x89A450", Offset = "0x898C50", Length = "0x16")]
		set
		{
		}
	}

	[Token(Token = "0x17000367")]
	public bool showAssignedControllersGroupLabel
	{
		[Token(Token = "0x6001160")]
		[Address(RVA = "0x899A00", Offset = "0x898200", Length = "0x8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001161")]
		[Address(RVA = "0x89A410", Offset = "0x898C10", Length = "0x16")]
		set
		{
		}
	}

	[Token(Token = "0x17000368")]
	public bool showSettingsGroupLabel
	{
		[Token(Token = "0x6001162")]
		[Address(RVA = "0x899B20", Offset = "0x898320", Length = "0x8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001163")]
		[Address(RVA = "0x89A590", Offset = "0x898D90", Length = "0x16")]
		set
		{
		}
	}

	[Token(Token = "0x17000369")]
	public bool showMapCategoriesGroupLabel
	{
		[Address(RVA = "0x899A60", Offset = "0x898260", Length = "0x8")]
		[Token(Token = "0x6001164")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x89A510", Offset = "0x898D10", Length = "0x16")]
		[Token(Token = "0x6001165")]
		set
		{
		}
	}

	[Token(Token = "0x1700036A")]
	public bool showControllerNameLabel
	{
		[Address(RVA = "0x899A30", Offset = "0x898230", Length = "0x8")]
		[Token(Token = "0x6001166")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x89A470", Offset = "0x898C70", Length = "0x16")]
		[Token(Token = "0x6001167")]
		set
		{
		}
	}

	[Token(Token = "0x1700036B")]
	public bool showAssignedControllers
	{
		[Token(Token = "0x6001168")]
		[Address(RVA = "0x899A10", Offset = "0x898210", Length = "0x8")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x89A430", Offset = "0x898C30", Length = "0x16")]
		[Token(Token = "0x6001169")]
		set
		{
		}
	}

	[Token(Token = "0x1700036C")]
	public Action restoreDefaultsDelegate
	{
		[Token(Token = "0x600116A")]
		[Address(RVA = "0x8999F0", Offset = "0x8981F0", Length = "0x8")]
		get
		{
			return null;
		}
		[Address(RVA = "0x89A3B0", Offset = "0x898BB0", Length = "0xF")]
		[Token(Token = "0x600116B")]
		set
		{
		}
	}

	[Token(Token = "0x1700036D")]
	public bool isOpen
	{
		[Token(Token = "0x600116C")]
		[Address(RVA = "0x899910", Offset = "0x898110", Length = "0xCF")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700036E")]
	private bool isFocused
	{
		[Token(Token = "0x600116D")]
		[Address(RVA = "0x8998C0", Offset = "0x8980C0", Length = "0x33")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700036F")]
	private bool inputAllowed
	{
		[Address(RVA = "0x8997D0", Offset = "0x897FD0", Length = "0x28")]
		[Token(Token = "0x600116E")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000370")]
	private int inputGridColumnCount
	{
		[Address(RVA = "0x899810", Offset = "0x898010", Length = "0x21")]
		[Token(Token = "0x600116F")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000371")]
	private int inputGridWidth
	{
		[Token(Token = "0x6001170")]
		[Address(RVA = "0x899840", Offset = "0x898040", Length = "0x75")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000372")]
	private Player currentPlayer
	{
		[Token(Token = "0x6001171")]
		[Address(RVA = "0x899670", Offset = "0x897E70", Length = "0x69")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000373")]
	private InputCategory currentMapCategory
	{
		[Address(RVA = "0x8995A0", Offset = "0x897DA0", Length = "0x69")]
		[Token(Token = "0x6001172")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000374")]
	private MappingSet currentMappingSet
	{
		[Address(RVA = "0x899610", Offset = "0x897E10", Length = "0x5E")]
		[Token(Token = "0x6001173")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000375")]
	private Joystick currentJoystick
	{
		[Token(Token = "0x6001174")]
		[Address(RVA = "0x899530", Offset = "0x897D30", Length = "0x69")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000376")]
	private bool isJoystickSelected
	{
		[Address(RVA = "0x899900", Offset = "0x898100", Length = "0xC")]
		[Token(Token = "0x6001175")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000377")]
	private GameObject currentUISelection
	{
		[Address(RVA = "0x8996E0", Offset = "0x897EE0", Length = "0xB9")]
		[Token(Token = "0x6001176")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000378")]
	private bool showSettings
	{
		[Address(RVA = "0x899B30", Offset = "0x898330", Length = "0x31")]
		[Token(Token = "0x6001177")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000379")]
	private bool showMapCategories
	{
		[Token(Token = "0x6001178")]
		[Address(RVA = "0x899A70", Offset = "0x898270", Length = "0x15")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000017")]
	public event Action ScreenClosedEvent
	{
		[Token(Token = "0x60010F8")]
		[Address(RVA = "0x8992D0", Offset = "0x897AD0", Length = "0x7F")]
		add
		{
		}
		[Token(Token = "0x60010F9")]
		[Address(RVA = "0x899D90", Offset = "0x898590", Length = "0x7F")]
		remove
		{
		}
	}

	[Token(Token = "0x14000018")]
	public event Action ScreenOpenedEvent
	{
		[Address(RVA = "0x899350", Offset = "0x897B50", Length = "0x7F")]
		[Token(Token = "0x60010FA")]
		add
		{
		}
		[Token(Token = "0x60010FB")]
		[Address(RVA = "0x899E10", Offset = "0x898610", Length = "0x7F")]
		remove
		{
		}
	}

	[Token(Token = "0x14000019")]
	public event Action PopupWindowClosedEvent
	{
		[Token(Token = "0x60010FC")]
		[Address(RVA = "0x8991D0", Offset = "0x8979D0", Length = "0x7F")]
		add
		{
		}
		[Token(Token = "0x60010FD")]
		[Address(RVA = "0x899C90", Offset = "0x898490", Length = "0x7F")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001A")]
	public event Action PopupWindowOpenedEvent
	{
		[Token(Token = "0x60010FE")]
		[Address(RVA = "0x899250", Offset = "0x897A50", Length = "0x7F")]
		add
		{
		}
		[Token(Token = "0x60010FF")]
		[Address(RVA = "0x899D10", Offset = "0x898510", Length = "0x7F")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001B")]
	public event Action InputPollingStartedEvent
	{
		[Token(Token = "0x6001100")]
		[Address(RVA = "0x899150", Offset = "0x897950", Length = "0x7F")]
		add
		{
		}
		[Token(Token = "0x6001101")]
		[Address(RVA = "0x899C10", Offset = "0x898410", Length = "0x7F")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001C")]
	public event Action InputPollingEndedEvent
	{
		[Address(RVA = "0x8990D0", Offset = "0x8978D0", Length = "0x7F")]
		[Token(Token = "0x6001102")]
		add
		{
		}
		[Address(RVA = "0x899B90", Offset = "0x898390", Length = "0x7F")]
		[Token(Token = "0x6001103")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001D")]
	public event UnityAction onScreenClosed
	{
		[Token(Token = "0x6001104")]
		[Address(RVA = "0x899490", Offset = "0x897C90", Length = "0x21")]
		add
		{
		}
		[Token(Token = "0x6001105")]
		[Address(RVA = "0x899F50", Offset = "0x898750", Length = "0x21")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001E")]
	public event UnityAction onScreenOpened
	{
		[Token(Token = "0x6001106")]
		[Address(RVA = "0x8994C0", Offset = "0x897CC0", Length = "0x21")]
		add
		{
		}
		[Address(RVA = "0x899F80", Offset = "0x898780", Length = "0x21")]
		[Token(Token = "0x6001107")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001F")]
	public event UnityAction onPopupWindowClosed
	{
		[Address(RVA = "0x899430", Offset = "0x897C30", Length = "0x21")]
		[Token(Token = "0x6001108")]
		add
		{
		}
		[Token(Token = "0x6001109")]
		[Address(RVA = "0x899EF0", Offset = "0x8986F0", Length = "0x21")]
		remove
		{
		}
	}

	[Token(Token = "0x14000020")]
	public event UnityAction onPopupWindowOpened
	{
		[Token(Token = "0x600110A")]
		[Address(RVA = "0x899460", Offset = "0x897C60", Length = "0x21")]
		add
		{
		}
		[Token(Token = "0x600110B")]
		[Address(RVA = "0x899F20", Offset = "0x898720", Length = "0x21")]
		remove
		{
		}
	}

	[Token(Token = "0x14000021")]
	public event UnityAction onInputPollingStarted
	{
		[Token(Token = "0x600110C")]
		[Address(RVA = "0x899400", Offset = "0x897C00", Length = "0x21")]
		add
		{
		}
		[Address(RVA = "0x899EC0", Offset = "0x8986C0", Length = "0x21")]
		[Token(Token = "0x600110D")]
		remove
		{
		}
	}

	[Token(Token = "0x14000022")]
	public event UnityAction onInputPollingEnded
	{
		[Token(Token = "0x600110E")]
		[Address(RVA = "0x8993D0", Offset = "0x897BD0", Length = "0x21")]
		add
		{
		}
		[Token(Token = "0x600110F")]
		[Address(RVA = "0x899E90", Offset = "0x898690", Length = "0x21")]
		remove
		{
		}
	}

	[Address(RVA = "0x885610", Offset = "0x883E10", Length = "0xB7")]
	[Token(Token = "0x6001179")]
	private void Awake()
	{
	}

	[Token(Token = "0x600117A")]
	[Address(RVA = "0x898530", Offset = "0x896D30", Length = "0x11")]
	private void Start()
	{
	}

	[Token(Token = "0x600117B")]
	[Address(RVA = "0x898E10", Offset = "0x897610", Length = "0xC0")]
	private void Update()
	{
	}

	[Address(RVA = "0x88DD70", Offset = "0x88C570", Length = "0x203")]
	[Token(Token = "0x600117C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600117D")]
	[Address(RVA = "0x891AF0", Offset = "0x8902F0", Length = "0x1FD")]
	private void PreInitialize()
	{
	}

	[Token(Token = "0x600117E")]
	[Address(RVA = "0x88BCE0", Offset = "0x88A4E0", Length = "0xBB3")]
	private void Initialize()
	{
	}

	[Address(RVA = "0x88EEF0", Offset = "0x88D6F0", Length = "0x65")]
	[Token(Token = "0x600117F")]
	private void OnJoystickConnected(ControllerStatusChangedEventArgs args)
	{
	}

	[Token(Token = "0x6001180")]
	[Address(RVA = "0x88EEF0", Offset = "0x88D6F0", Length = "0x65")]
	private void OnJoystickDisconnected(ControllerStatusChangedEventArgs args)
	{
	}

	[Token(Token = "0x6001181")]
	[Address(RVA = "0x678080", Offset = "0x676880", Length = "0x3")]
	private void OnJoystickPreDisconnect(ControllerStatusChangedEventArgs args)
	{
	}

	[Token(Token = "0x6001182")]
	[Address(RVA = "0x88D4E0", Offset = "0x88BCE0", Length = "0x383")]
	public void OnButtonActivated(ButtonInfo buttonInfo)
	{
	}

	[Token(Token = "0x6001183")]
	[Address(RVA = "0x88EAA0", Offset = "0x88D2A0", Length = "0x2E4")]
	public void OnInputFieldActivated(InputFieldInfo fieldInfo)
	{
	}

	[Address(RVA = "0x88ED90", Offset = "0x88D590", Length = "0x15A")]
	[Token(Token = "0x6001184")]
	public void OnInputFieldInvertToggleStateChanged(ToggleInfo toggleInfo, bool newState)
	{
	}

	[Address(RVA = "0x88FEC0", Offset = "0x88E6C0", Length = "0x2E")]
	[Token(Token = "0x6001185")]
	private void OnPlayerSelected(int playerId, bool redraw)
	{
	}

	[Address(RVA = "0x88DD50", Offset = "0x88C550", Length = "0x1F")]
	[Token(Token = "0x6001186")]
	private void OnControllerSelected(int joystickId)
	{
	}

	[Token(Token = "0x6001187")]
	[Address(RVA = "0x88FEF0", Offset = "0x88E6F0", Length = "0xB6")]
	private void OnRemoveCurrentController()
	{
	}

	[Token(Token = "0x6001188")]
	[Address(RVA = "0x88F6E0", Offset = "0x88DEE0", Length = "0x24")]
	private void OnMapCategorySelected(int id, bool redraw)
	{
	}

	[Token(Token = "0x6001189")]
	[Address(RVA = "0x8902E0", Offset = "0x88EAE0", Length = "0x11")]
	private void OnRestoreDefaults()
	{
	}

	[Token(Token = "0x600118A")]
	[Address(RVA = "0x890370", Offset = "0x88EB70", Length = "0x63")]
	private void OnScreenToggleActionPressed(InputActionEventData data)
	{
	}

	[Token(Token = "0x600118B")]
	[Address(RVA = "0x890360", Offset = "0x88EB60", Length = "0xA")]
	private void OnScreenOpenActionPressed(InputActionEventData data)
	{
	}

	[Token(Token = "0x600118C")]
	[Address(RVA = "0x890300", Offset = "0x88EB00", Length = "0x5A")]
	private void OnScreenCloseActionPressed(InputActionEventData data)
	{
	}

	[Token(Token = "0x600118D")]
	[Address(RVA = "0x8903F0", Offset = "0x88EBF0", Length = "0x82")]
	private void OnUniversalCancelActionPressed(InputActionEventData data)
	{
	}

	[Address(RVA = "0x890480", Offset = "0x88EC80", Length = "0x63")]
	[Token(Token = "0x600118E")]
	private void OnWindowCancel(int windowId)
	{
	}

	[Address(RVA = "0x88FFB0", Offset = "0x88E7B0", Length = "0x7A")]
	[Token(Token = "0x600118F")]
	private void OnRemoveElementAssignment(int windowId, ControllerMap map, ActionElementMap aem)
	{
	}

	[Address(RVA = "0x88D380", Offset = "0x88BB80", Length = "0x151")]
	[Token(Token = "0x6001190")]
	private void OnBeginElementAssignment(InputFieldInfo fieldInfo, ControllerMap map, ActionElementMap aem, string actionName)
	{
	}

	[Token(Token = "0x6001191")]
	[Address(RVA = "0x88DD00", Offset = "0x88C500", Length = "0x48")]
	private void OnControllerAssignmentConfirmed(int windowId, Player player, int controllerId)
	{
	}

	[Token(Token = "0x6001192")]
	[Address(RVA = "0x88F710", Offset = "0x88DF10", Length = "0x235")]
	private void OnMouseAssignmentConfirmed(int windowId, Player player)
	{
	}

	[Token(Token = "0x6001193")]
	[Address(RVA = "0x88E090", Offset = "0x88C890", Length = "0x719")]
	private void OnElementAssignmentConflictReplaceConfirmed(int windowId, InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers, bool allowSwap)
	{
	}

	[Token(Token = "0x6001194")]
	[Address(RVA = "0x88DF80", Offset = "0x88C780", Length = "0x102")]
	private void OnElementAssignmentAddConfirmed(int windowId, InputMapping mapping, ElementAssignment assignment)
	{
	}

	[Token(Token = "0x6001195")]
	[Address(RVA = "0x890030", Offset = "0x88E830", Length = "0x2A1")]
	private void OnRestoreDefaultsConfirmed(int windowId)
	{
	}

	[Token(Token = "0x6001196")]
	[Address(RVA = "0x88D090", Offset = "0x88B890", Length = "0x2E1")]
	private void OnAssignControllerWindowUpdate(int windowId)
	{
	}

	[Token(Token = "0x6001197")]
	[Address(RVA = "0x88E7B0", Offset = "0x88CFB0", Length = "0x2ED")]
	private void OnElementAssignmentPrePollingWindowUpdate(int windowId)
	{
	}

	[Token(Token = "0x6001198")]
	[Address(RVA = "0x88EF60", Offset = "0x88D760", Length = "0x3C5")]
	private void OnJoystickElementAssignmentPollingWindowUpdate(int windowId)
	{
	}

	[Token(Token = "0x6001199")]
	[Address(RVA = "0x88F330", Offset = "0x88DB30", Length = "0x3A2")]
	private void OnKeyboardElementAssignmentPollingWindowUpdate(int windowId)
	{
	}

	[Token(Token = "0x600119A")]
	[Address(RVA = "0x88F950", Offset = "0x88E150", Length = "0x56D")]
	private void OnMouseElementAssignmentPollingWindowUpdate(int windowId)
	{
	}

	[Token(Token = "0x600119B")]
	[Address(RVA = "0x88D870", Offset = "0x88C070", Length = "0x22C")]
	private void OnCalibrateAxisStep1WindowUpdate(int windowId)
	{
	}

	[Token(Token = "0x600119C")]
	[Address(RVA = "0x88DAA0", Offset = "0x88C2A0", Length = "0x255")]
	private void OnCalibrateAxisStep2WindowUpdate(int windowId)
	{
	}

	[Token(Token = "0x600119D")]
	[Address(RVA = "0x893D10", Offset = "0x892510", Length = "0x355")]
	private void ShowAssignControllerWindow()
	{
	}

	[Token(Token = "0x600119E")]
	[Address(RVA = "0x895330", Offset = "0x893B30", Length = "0x715")]
	private void ShowControllerAssignmentConflictWindow(int controllerId)
	{
	}

	[Address(RVA = "0x8940D0", Offset = "0x8928D0", Length = "0x569")]
	[Token(Token = "0x600119F")]
	private void ShowBeginElementAssignmentReplacementWindow(InputFieldInfo fieldInfo, InputAction action, ControllerMap map, ActionElementMap aem, string actionName)
	{
	}

	[Token(Token = "0x60011A0")]
	[Address(RVA = "0x895A50", Offset = "0x894250", Length = "0x1A2")]
	private void ShowCreateNewElementAssignmentWindow(InputFieldInfo fieldInfo, InputAction action, ControllerMap map, string actionName)
	{
	}

	[Token(Token = "0x60011A1")]
	[Address(RVA = "0x896710", Offset = "0x894F10", Length = "0x39C")]
	private void ShowElementAssignmentPrePollingWindow()
	{
	}

	[Token(Token = "0x60011A2")]
	[Address(RVA = "0x896640", Offset = "0x894E40", Length = "0xCF")]
	private void ShowElementAssignmentPollingWindow()
	{
	}

	[Token(Token = "0x60011A3")]
	[Address(RVA = "0x896AB0", Offset = "0x8952B0", Length = "0x32C")]
	private void ShowJoystickElementAssignmentPollingWindow()
	{
	}

	[Address(RVA = "0x896DE0", Offset = "0x8955E0", Length = "0x35E")]
	[Token(Token = "0x60011A4")]
	private void ShowKeyboardElementAssignmentPollingWindow()
	{
	}

	[Token(Token = "0x60011A5")]
	[Address(RVA = "0x8977B0", Offset = "0x895FB0", Length = "0x32C")]
	private void ShowMouseElementAssignmentPollingWindow()
	{
	}

	[Token(Token = "0x60011A6")]
	[Address(RVA = "0x895EA0", Offset = "0x8946A0", Length = "0x79A")]
	private void ShowElementAssignmentConflictWindow(ElementAssignment assignment, bool skipOtherPlayers)
	{
	}

	[Address(RVA = "0x897140", Offset = "0x895940", Length = "0x663")]
	[Token(Token = "0x60011A7")]
	private void ShowMouseAssignmentConflictWindow()
	{
	}

	[Token(Token = "0x60011A8")]
	[Address(RVA = "0x895020", Offset = "0x893820", Length = "0x30D")]
	private void ShowCalibrateControllerWindow()
	{
	}

	[Token(Token = "0x60011A9")]
	[Address(RVA = "0x894640", Offset = "0x892E40", Length = "0x4ED")]
	private void ShowCalibrateAxisStep1Window()
	{
	}

	[Token(Token = "0x60011AA")]
	[Address(RVA = "0x894B30", Offset = "0x893330", Length = "0x4ED")]
	private void ShowCalibrateAxisStep2Window()
	{
	}

	[Token(Token = "0x60011AB")]
	[Address(RVA = "0x895C00", Offset = "0x894400", Length = "0x29F")]
	private void ShowEditInputBehaviorsWindow()
	{
	}

	[Address(RVA = "0x897AE0", Offset = "0x8962E0", Length = "0x1E7")]
	[Token(Token = "0x60011AC")]
	private void ShowRestoreDefaultsWindow()
	{
	}

	[Token(Token = "0x60011AD")]
	[Address(RVA = "0x8889D0", Offset = "0x8871D0", Length = "0x39E")]
	private void CreateInputGrid()
	{
	}

	[Address(RVA = "0x88B450", Offset = "0x889C50", Length = "0x6DC")]
	[Token(Token = "0x60011AE")]
	private void InitializeInputGrid()
	{
	}

	[Token(Token = "0x60011AF")]
	[Address(RVA = "0x892E80", Offset = "0x891680", Length = "0x1F1")]
	private void RefreshInputGridStructure()
	{
	}

	[Address(RVA = "0x886780", Offset = "0x884F80", Length = "0x43F")]
	[Token(Token = "0x60011B0")]
	private void CreateHeaderLabels()
	{
	}

	[Address(RVA = "0x8863A0", Offset = "0x884BA0", Length = "0x8A")]
	[Token(Token = "0x60011B1")]
	private void CreateActionLabelColumn()
	{
	}

	[Address(RVA = "0x888D70", Offset = "0x887570", Length = "0xC9")]
	[Token(Token = "0x60011B2")]
	private void CreateKeyboardInputFieldColumn()
	{
	}

	[Token(Token = "0x60011B3")]
	[Address(RVA = "0x889210", Offset = "0x887A10", Length = "0xC9")]
	private void CreateMouseInputFieldColumn()
	{
	}

	[Token(Token = "0x60011B4")]
	[Address(RVA = "0x8865F0", Offset = "0x884DF0", Length = "0xC9")]
	private void CreateControllerInputFieldColumn()
	{
	}

	[Token(Token = "0x60011B5")]
	[Address(RVA = "0x887A10", Offset = "0x886210", Length = "0x110")]
	private void CreateInputFieldColumn(string name, ControllerType controllerType, int maxWidth, int cols, bool disableFullAxis)
	{
	}

	[Address(RVA = "0x886BC0", Offset = "0x8853C0", Length = "0xD6F")]
	[Token(Token = "0x60011B6")]
	private void CreateInputActionLabels()
	{
	}

	[Address(RVA = "0x8888F0", Offset = "0x8870F0", Length = "0xDB")]
	[Token(Token = "0x60011B7")]
	private void CreateInputFields()
	{
	}

	[Address(RVA = "0x8881C0", Offset = "0x8869C0", Length = "0x723")]
	[Token(Token = "0x60011B8")]
	private void CreateInputFields(Transform columnXform, ControllerType controllerType, int maxWidth, int cols, bool disableFullAxis)
	{
	}

	[Address(RVA = "0x887B30", Offset = "0x886330", Length = "0x473")]
	[Token(Token = "0x60011B9")]
	private void CreateInputFieldSet(Transform parent, int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, int cols, int fieldWidth, ref int yPos, bool disableFullAxis)
	{
	}

	[Address(RVA = "0x8916F0", Offset = "0x88FEF0", Length = "0x3F6")]
	[Token(Token = "0x60011BA")]
	private void PopulateInputFields()
	{
	}

	[Address(RVA = "0x891230", Offset = "0x88FA30", Length = "0x4B9")]
	[Token(Token = "0x60011BB")]
	private void PopulateInputFieldGroup(InputActionSet actionSet, ControllerMap controllerMap, ControllerType controllerType, int controllerId, int maxFields)
	{
	}

	[Address(RVA = "0x8896F0", Offset = "0x887EF0", Length = "0xA7")]
	[Token(Token = "0x60011BC")]
	private void DisableInputFieldGroup(InputActionSet actionSet, ControllerType controllerType, int fieldCount)
	{
	}

	[Token(Token = "0x60011BD")]
	[Address(RVA = "0x8932B0", Offset = "0x891AB0", Length = "0xEB")]
	private void ResetInputGridScrollBar()
	{
	}

	[Token(Token = "0x60011BE")]
	[Address(RVA = "0x888FC0", Offset = "0x8877C0", Length = "0x249")]
	private void CreateLayout()
	{
	}

	[Token(Token = "0x60011BF")]
	[Address(RVA = "0x88A550", Offset = "0x888D50", Length = "0x13B")]
	private void Draw()
	{
	}

	[Address(RVA = "0x889F10", Offset = "0x888710", Length = "0x2EA")]
	[Token(Token = "0x60011C0")]
	private void DrawPlayersGroup()
	{
	}

	[Token(Token = "0x60011C1")]
	[Address(RVA = "0x8897A0", Offset = "0x887FA0", Length = "0x44B")]
	private void DrawControllersGroup()
	{
	}

	[Token(Token = "0x60011C2")]
	[Address(RVA = "0x88A200", Offset = "0x888A00", Length = "0x22D")]
	private void DrawSettingsGroup()
	{
	}

	[Address(RVA = "0x889BF0", Offset = "0x8883F0", Length = "0x31A")]
	[Token(Token = "0x60011C3")]
	private void DrawMapCategoriesGroup()
	{
	}

	[Address(RVA = "0x88A430", Offset = "0x888C30", Length = "0x116")]
	[Token(Token = "0x60011C4")]
	private void DrawWindowButtonsGroup()
	{
	}

	[Address(RVA = "0x892B70", Offset = "0x891370", Length = "0x301")]
	[Token(Token = "0x60011C5")]
	private void Redraw(bool listsChanged, bool playTransitions)
	{
	}

	[Address(RVA = "0x892A30", Offset = "0x891230", Length = "0x132")]
	[Token(Token = "0x60011C6")]
	private void RedrawPlayerGroup(bool playTransitions)
	{
	}

	[Address(RVA = "0x891CF0", Offset = "0x8904F0", Length = "0xBBF")]
	[Token(Token = "0x60011C7")]
	private void RedrawControllerGroup()
	{
	}

	[Address(RVA = "0x8928F0", Offset = "0x8910F0", Length = "0x132")]
	[Token(Token = "0x60011C8")]
	private void RedrawMapCategoriesGroup(bool playTransitions)
	{
	}

	[Address(RVA = "0x8928B0", Offset = "0x8910B0", Length = "0x3F")]
	[Token(Token = "0x60011C9")]
	private void RedrawInputGrid(bool listsChanged)
	{
	}

	[Address(RVA = "0x88A7B0", Offset = "0x888FB0", Length = "0x46")]
	[Token(Token = "0x60011CA")]
	private void ForceRefresh()
	{
	}

	[Token(Token = "0x60011CB")]
	[Address(RVA = "0x887930", Offset = "0x886130", Length = "0xDB")]
	private void CreateInputCategoryRow(ref int rowCount, InputCategory category)
	{
	}

	[Token(Token = "0x60011CC")]
	[Address(RVA = "0x888F80", Offset = "0x887780", Length = "0x3A")]
	private GUILabel CreateLabel(string labelText, Transform parent, Vector2 offset)
	{
		return null;
	}

	[Token(Token = "0x60011CD")]
	[Address(RVA = "0x888E40", Offset = "0x887640", Length = "0x13E")]
	private GUILabel CreateLabel(GameObject prefab, string labelText, Transform parent, Vector2 offset)
	{
		return null;
	}

	[Token(Token = "0x60011CE")]
	[Address(RVA = "0x886430", Offset = "0x884C30", Length = "0xBF")]
	private GUIButton CreateButton(string labelText, Transform parent, Vector2 offset)
	{
		return null;
	}

	[Token(Token = "0x60011CF")]
	[Address(RVA = "0x8866C0", Offset = "0x884EC0", Length = "0xBF")]
	private GUIButton CreateFitButton(string labelText, Transform parent, Vector2 offset)
	{
		return null;
	}

	[Token(Token = "0x60011D0")]
	[Address(RVA = "0x887FB0", Offset = "0x8867B0", Length = "0x16E")]
	private GUIInputField CreateInputField(Transform parent, Vector2 offset, string label, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
	{
		return null;
	}

	[Token(Token = "0x60011D1")]
	[Address(RVA = "0x888120", Offset = "0x886920", Length = "0x96")]
	private GUIInputField CreateInputField(Transform parent, Vector2 offset)
	{
		return null;
	}

	[Token(Token = "0x60011D2")]
	[Address(RVA = "0x889500", Offset = "0x887D00", Length = "0x148")]
	private GUIToggle CreateToggle(GameObject prefab, Transform parent, Vector2 offset, string label, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
	{
		return null;
	}

	[Address(RVA = "0x889650", Offset = "0x887E50", Length = "0x91")]
	[Token(Token = "0x60011D3")]
	private GUIToggle CreateToggle(GameObject prefab, Transform parent, Vector2 offset)
	{
		return null;
	}

	[Address(RVA = "0x88C950", Offset = "0x88B150", Length = "0xFA")]
	[Token(Token = "0x60011D4")]
	private GameObject InstantiateGUIObject(GameObject prefab, Transform parent, Vector2 offset)
	{
		return null;
	}

	[Address(RVA = "0x889440", Offset = "0x887C40", Length = "0xB7")]
	[Token(Token = "0x60011D5")]
	private GameObject CreateNewGUIObject(string name, Transform parent, Vector2 offset)
	{
		return null;
	}

	[Address(RVA = "0x88BB30", Offset = "0x88A330", Length = "0x1A2")]
	[Token(Token = "0x60011D6")]
	private GameObject InitializeNewGUIGameObject(GameObject gameObject, Transform parent, Vector2 offset)
	{
		return null;
	}

	[Token(Token = "0x60011D7")]
	[Address(RVA = "0x8892E0", Offset = "0x887AE0", Length = "0x15A")]
	private GameObject CreateNewColumnGroup(string name, Transform parent, int maxWidth)
	{
		return null;
	}

	[Token(Token = "0x60011D8")]
	[Address(RVA = "0x8908B0", Offset = "0x88F0B0", Length = "0x10F")]
	private Window OpenWindow(bool closeOthers)
	{
		return null;
	}

	[Address(RVA = "0x890A90", Offset = "0x88F290", Length = "0xE5")]
	[Token(Token = "0x60011D9")]
	private Window OpenWindow(string name, bool closeOthers)
	{
		return null;
	}

	[Token(Token = "0x60011DA")]
	[Address(RVA = "0x890B80", Offset = "0x88F380", Length = "0x6D")]
	private Window OpenWindow(GameObject windowPrefab, bool closeOthers)
	{
		return null;
	}

	[Token(Token = "0x60011DB")]
	[Address(RVA = "0x8909C0", Offset = "0x88F1C0", Length = "0xCB")]
	private Window OpenWindow(GameObject windowPrefab, string name, bool closeOthers)
	{
		return null;
	}

	[Token(Token = "0x60011DC")]
	[Address(RVA = "0x8904F0", Offset = "0x88ECF0", Length = "0x3B5")]
	private void OpenModal(string title, string message, string confirmText, Action<int> confirmAction, string cancelText, Action<int> cancelAction, bool closeOthers)
	{
	}

	[Token(Token = "0x60011DD")]
	[Address(RVA = "0x886220", Offset = "0x884A20", Length = "0x56")]
	private void CloseWindow(int windowId)
	{
	}

	[Address(RVA = "0x8861D0", Offset = "0x8849D0", Length = "0x4D")]
	[Token(Token = "0x60011DE")]
	private void CloseTopWindow()
	{
	}

	[Address(RVA = "0x886140", Offset = "0x884940", Length = "0x85")]
	[Token(Token = "0x60011DF")]
	private void CloseAllWindows()
	{
	}

	[Address(RVA = "0x885830", Offset = "0x884030", Length = "0x75")]
	[Token(Token = "0x60011E0")]
	private void ChildWindowOpened()
	{
	}

	[Address(RVA = "0x885780", Offset = "0x883F80", Length = "0xAA")]
	[Token(Token = "0x60011E1")]
	private void ChildWindowClosed()
	{
	}

	[Address(RVA = "0x88B1C0", Offset = "0x8899C0", Length = "0x284")]
	[Token(Token = "0x60011E2")]
	private bool HasElementAssignmentConflicts(Player player, InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers)
	{
		return default(bool);
	}

	[Address(RVA = "0x88CAA0", Offset = "0x88B2A0", Length = "0x5EC")]
	[Token(Token = "0x60011E3")]
	private bool IsBlockingAssignmentConflict(InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers)
	{
		return default(bool);
	}

	[Address(RVA = "0x88A690", Offset = "0x888E90", Length = "0xDD")]
	[Token(Token = "0x60011E4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x840F0", Offset = "0x834F0")]
	private IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(Player player, InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers)
	{
		return null;
	}

	[Token(Token = "0x60011E5")]
	[Address(RVA = "0x8864F0", Offset = "0x884CF0", Length = "0xFB")]
	private bool CreateConflictCheck(InputMapping mapping, ElementAssignment assignment, out ElementAssignmentConflictCheck conflictCheck)
	{
		System.Runtime.CompilerServices.Unsafe.As<ElementAssignmentConflictCheck, @null>(ref conflictCheck) = null;
		return default(bool);
	}

	[Address(RVA = "0x890CD0", Offset = "0x88F4D0", Length = "0x55C")]
	[Token(Token = "0x60011E6")]
	private void PollKeyboardForAssignment(out ControllerPollingInfo pollingInfo, out bool modifierKeyPressed, out ModifierKeyFlags modifierFlags, out string label)
	{
		System.Runtime.CompilerServices.Unsafe.As<ControllerPollingInfo, @null>(ref pollingInfo) = null;
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref modifierKeyPressed) = null;
		System.Runtime.CompilerServices.Unsafe.As<ModifierKeyFlags, @null>(ref modifierFlags) = null;
		label = null;
	}

	[Token(Token = "0x60011E7")]
	[Address(RVA = "0x88AE00", Offset = "0x889600", Length = "0x2CF")]
	private bool GetFirstElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, out ElementAssignmentConflictInfo conflict, bool skipOtherPlayers)
	{
		System.Runtime.CompilerServices.Unsafe.As<ElementAssignmentConflictInfo, @null>(ref conflict) = null;
		return default(bool);
	}

	[Token(Token = "0x60011E8")]
	[Address(RVA = "0x88AC00", Offset = "0x889400", Length = "0x1F0")]
	private bool GetFirstElementAssignmentConflict(Player player, ElementAssignmentConflictCheck conflictCheck, out ElementAssignmentConflictInfo conflict)
	{
		System.Runtime.CompilerServices.Unsafe.As<ElementAssignmentConflictInfo, @null>(ref conflict) = null;
		return default(bool);
	}

	[Address(RVA = "0x8983F0", Offset = "0x896BF0", Length = "0x13C")]
	[Token(Token = "0x60011E9")]
	private void StartAxisCalibration(int axisIndex)
	{
	}

	[Token(Token = "0x60011EA")]
	[Address(RVA = "0x88A770", Offset = "0x888F70", Length = "0x38")]
	private void EndAxisCalibration()
	{
	}

	[Address(RVA = "0x893C40", Offset = "0x892440", Length = "0xC7")]
	[Token(Token = "0x60011EB")]
	private void SetUISelection(GameObject selection)
	{
	}

	[Address(RVA = "0x8935D0", Offset = "0x891DD0", Length = "0xAA")]
	[Token(Token = "0x60011EC")]
	private void RestoreLastUISelection()
	{
	}

	[Address(RVA = "0x893AE0", Offset = "0x8922E0", Length = "0xD5")]
	[Token(Token = "0x60011ED")]
	private void SetDefaultUISelection()
	{
	}

	[Address(RVA = "0x893680", Offset = "0x891E80", Length = "0x339")]
	[Token(Token = "0x60011EE")]
	private void SelectDefaultMapCategory(bool redraw)
	{
	}

	[Address(RVA = "0x8856D0", Offset = "0x883ED0", Length = "0xA4")]
	[Token(Token = "0x60011EF")]
	private void CheckUISelection()
	{
	}

	[Address(RVA = "0x8903E0", Offset = "0x88EBE0", Length = "0xF")]
	[Token(Token = "0x60011F0")]
	private void OnUIElementSelected(GameObject selectedObject)
	{
	}

	[Address(RVA = "0x893BC0", Offset = "0x8923C0", Length = "0x73")]
	[Token(Token = "0x60011F1")]
	private void SetIsFocused(bool state)
	{
	}

	[Token(Token = "0x60011F2")]
	[Address(RVA = "0x898A50", Offset = "0x897250", Length = "0x32")]
	public void Toggle()
	{
	}

	[Token(Token = "0x60011F3")]
	[Address(RVA = "0x890360", Offset = "0x88EB60", Length = "0xA")]
	public void Open()
	{
	}

	[Address(RVA = "0x890BF0", Offset = "0x88F3F0", Length = "0xDE")]
	[Token(Token = "0x60011F4")]
	private void Open(bool force)
	{
	}

	[Token(Token = "0x60011F5")]
	[Address(RVA = "0x886280", Offset = "0x884A80", Length = "0x117")]
	public void Close(bool save)
	{
	}

	[Token(Token = "0x60011F6")]
	[Address(RVA = "0x8860A0", Offset = "0x8848A0", Length = "0x92")]
	private void Clear()
	{
	}

	[Token(Token = "0x60011F7")]
	[Address(RVA = "0x8859F0", Offset = "0x8841F0", Length = "0x142")]
	private void ClearCompletely()
	{
	}

	[Token(Token = "0x60011F8")]
	[Address(RVA = "0x885B40", Offset = "0x884340", Length = "0x544")]
	private void ClearSpawnedObjects()
	{
	}

	[Address(RVA = "0x886090", Offset = "0x884890", Length = "0xB")]
	[Token(Token = "0x60011F9")]
	private void ClearVarsOnPlayerChange()
	{
	}

	[Token(Token = "0x60011FA")]
	[Address(RVA = "0x886090", Offset = "0x884890", Length = "0xB")]
	private void ClearVarsOnJoystickChange()
	{
	}

	[Token(Token = "0x60011FB")]
	[Address(RVA = "0x8858B0", Offset = "0x8840B0", Length = "0x131")]
	private void ClearAllVars()
	{
	}

	[Token(Token = "0x60011FC")]
	[Address(RVA = "0x8933A0", Offset = "0x891BA0", Length = "0x229")]
	public void Reset()
	{
	}

	[Token(Token = "0x60011FD")]
	[Address(RVA = "0x8939C0", Offset = "0x8921C0", Length = "0x11E")]
	private void SetActionAxisInverted(bool state, ControllerType controllerType, int actionElementMapId)
	{
	}

	[Address(RVA = "0x88A960", Offset = "0x889160", Length = "0x16C")]
	[Token(Token = "0x60011FE")]
	private ControllerMap GetControllerMap(ControllerType type)
	{
		return null;
	}

	[Address(RVA = "0x88A890", Offset = "0x889090", Length = "0xCC")]
	[Token(Token = "0x60011FF")]
	private ControllerMap GetControllerMapOrCreateNew(ControllerType controllerType, int controllerId, int layoutId)
	{
		return null;
	}

	[Address(RVA = "0xF345A0", Offset = "0xF32DA0", Length = "0xF7")]
	[Token(Token = "0x6001200")]
	private int CountIEnumerable<T>(IEnumerable<T> enumerable)
	{
		return default(int);
	}

	[Token(Token = "0x6001201")]
	[Address(RVA = "0x88AAD0", Offset = "0x8892D0", Length = "0x128")]
	private int GetDefaultMapCategoryId()
	{
		return default(int);
	}

	[Token(Token = "0x6001202")]
	[Address(RVA = "0x898550", Offset = "0x896D50", Length = "0x14C")]
	private void SubscribeFixedUISelectionEvents()
	{
	}

	[Token(Token = "0x6001203")]
	[Address(RVA = "0x8986A0", Offset = "0x896EA0", Length = "0x134")]
	private void SubscribeMenuControlInputEvents()
	{
	}

	[Address(RVA = "0x898A90", Offset = "0x897290", Length = "0x134")]
	[Token(Token = "0x6001204")]
	private void UnsubscribeMenuControlInputEvents()
	{
	}

	[Token(Token = "0x6001205")]
	[Address(RVA = "0x8987E0", Offset = "0x896FE0", Length = "0x211")]
	private void SubscribeRewiredInputEventAllPlayers(int actionId, Action<InputActionEventData> callback)
	{
	}

	[Token(Token = "0x6001206")]
	[Address(RVA = "0x898BD0", Offset = "0x8973D0", Length = "0x235")]
	private void UnsubscribeRewiredInputEventAllPlayers(int actionId, Action<InputActionEventData> callback)
	{
	}

	[Address(RVA = "0x88B170", Offset = "0x889970", Length = "0x40")]
	[Token(Token = "0x6001207")]
	private int GetMaxControllersPerPlayer()
	{
		return default(int);
	}

	[Address(RVA = "0x894070", Offset = "0x892870", Length = "0x5A")]
	[Token(Token = "0x6001208")]
	private bool ShowAssignedControllers()
	{
		return default(bool);
	}

	[Address(RVA = "0x88C940", Offset = "0x88B140", Length = "0xC")]
	[Token(Token = "0x6001209")]
	private void InspectorPropertyChanged(bool reset = false)
	{
	}

	[Token(Token = "0x600120A")]
	[Address(RVA = "0x885210", Offset = "0x883A10", Length = "0x3F4")]
	private void AssignController(Player player, int controllerId)
	{
	}

	[Address(RVA = "0x893080", Offset = "0x891880", Length = "0x11E")]
	[Token(Token = "0x600120B")]
	private void RemoveAllControllers(Player player)
	{
	}

	[Address(RVA = "0x8931A0", Offset = "0x8919A0", Length = "0x10E")]
	[Token(Token = "0x600120C")]
	private void RemoveController(Player player, int controllerId)
	{
	}

	[Token(Token = "0x600120D")]
	[Address(RVA = "0x88CA50", Offset = "0x88B250", Length = "0x4B")]
	private bool IsAllowedAssignment(InputMapping pendingInputMapping, ControllerPollingInfo pollingInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x600120E")]
	[Address(RVA = "0x88C8A0", Offset = "0x88B0A0", Length = "0x4C")]
	private void InputPollingStarted()
	{
	}

	[Token(Token = "0x600120F")]
	[Address(RVA = "0x88C8F0", Offset = "0x88B0F0", Length = "0x4C")]
	private void InputPollingStopped()
	{
	}

	[Address(RVA = "0x88A800", Offset = "0x889000", Length = "0x8A")]
	[Token(Token = "0x6001210")]
	private int GetControllerInputFieldCount(ControllerType controllerType)
	{
		return default(int);
	}

	[Token(Token = "0x6001211")]
	[Address(RVA = "0x897CD0", Offset = "0x8964D0", Length = "0x71F")]
	private bool ShowSwapButton(int windowId, InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers)
	{
		return default(bool);
	}

	[Token(Token = "0x6001212")]
	[Address(RVA = "0x898A00", Offset = "0x897200", Length = "0x41")]
	private bool SwapIsSameInputRange(ControllerElementType origElementType, AxisRange origAxisRange, Pole origAxisContribution, ControllerElementType conflictElementType, AxisRange conflictAxisRange, Pole conflictAxisContribution)
	{
		return default(bool);
	}

	[Token(Token = "0x6001213")]
	[Address(RVA = "0x885110", Offset = "0x883910", Length = "0xFE")]
	public static void ApplyTheme(ThemedElement.ElementInfo[] elementInfo)
	{
	}

	[Address(RVA = "0x88B0D0", Offset = "0x8898D0", Length = "0x91")]
	[Token(Token = "0x6001214")]
	public static LanguageDataBase GetLanguage()
	{
		return null;
	}

	[Address(RVA = "0x898EE0", Offset = "0x8976E0", Length = "0x1ED")]
	[Token(Token = "0x6001215")]
	public ControlMapper()
	{
	}
}

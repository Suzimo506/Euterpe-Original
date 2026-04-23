using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Demos.GamepadTemplateUI;

[Token(Token = "0x2000229")]
public class GamepadTemplateUI : MonoBehaviour
{
	[Token(Token = "0x2000AC2")]
	private class Stick
	{
		[Token(Token = "0x400386D")]
		[FieldOffset(Offset = "0x10")]
		private RectTransform _transform;

		[Token(Token = "0x400386E")]
		[FieldOffset(Offset = "0x18")]
		private Vector2 _origPosition;

		[Token(Token = "0x400386F")]
		[FieldOffset(Offset = "0x20")]
		private int _xAxisElementId;

		[Token(Token = "0x4003870")]
		[FieldOffset(Offset = "0x24")]
		private int _yAxisElementId;

		[Token(Token = "0x17000A57")]
		public Vector2 position
		{
			[Token(Token = "0x6005C02")]
			[Address(RVA = "0xFA5060", Offset = "0xFA3860", Length = "0x10D")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6005C03")]
			[Address(RVA = "0xFA5170", Offset = "0xFA3970", Length = "0xE4")]
			set
			{
			}
		}

		[Address(RVA = "0xFA4F80", Offset = "0xFA3780", Length = "0xD4")]
		[Token(Token = "0x6005C04")]
		public Stick(RectTransform transform, int xAxisElementId, int yAxisElementId)
		{
		}

		[Address(RVA = "0xFA4CA0", Offset = "0xFA34A0", Length = "0x8E")]
		[Token(Token = "0x6005C05")]
		public void Reset()
		{
		}

		[Address(RVA = "0xFA4BF0", Offset = "0xFA33F0", Length = "0xA1")]
		[Token(Token = "0x6005C06")]
		public bool ContainsElement(int elementId)
		{
			return default(bool);
		}

		[Token(Token = "0x6005C07")]
		[Address(RVA = "0xFA4D30", Offset = "0xFA3530", Length = "0x247")]
		public void SetAxisPosition(int elementId, float value)
		{
		}
	}

	[Token(Token = "0x2000AC3")]
	private class UIElement
	{
		[Token(Token = "0x4003871")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003872")]
		public ControllerUIElement element;

		[Token(Token = "0x6005C08")]
		[Address(RVA = "0x9EC390", Offset = "0x9EAB90", Length = "0x3F")]
		public UIElement(int id, ControllerUIElement element)
		{
		}
	}

	[Token(Token = "0x4000FA9")]
	private const float stickRadius = 20f;

	[Token(Token = "0x4000FAA")]
	[FieldOffset(Offset = "0x18")]
	public int playerId;

	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000FAB")]
	private RectTransform leftStick;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000FAC")]
	[SerializeField]
	private RectTransform rightStick;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000FAD")]
	[SerializeField]
	private ControllerUIElement leftStickX;

	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000FAE")]
	private ControllerUIElement leftStickY;

	[Token(Token = "0x4000FAF")]
	[SerializeField]
	[FieldOffset(Offset = "0x40")]
	private ControllerUIElement leftStickButton;

	[SerializeField]
	[Token(Token = "0x4000FB0")]
	[FieldOffset(Offset = "0x48")]
	private ControllerUIElement rightStickX;

	[SerializeField]
	[Token(Token = "0x4000FB1")]
	[FieldOffset(Offset = "0x50")]
	private ControllerUIElement rightStickY;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000FB2")]
	[SerializeField]
	private ControllerUIElement rightStickButton;

	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000FB3")]
	private ControllerUIElement actionBottomRow1;

	[Token(Token = "0x4000FB4")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private ControllerUIElement actionBottomRow2;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000FB5")]
	[SerializeField]
	private ControllerUIElement actionBottomRow3;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000FB6")]
	[SerializeField]
	private ControllerUIElement actionTopRow1;

	[Token(Token = "0x4000FB7")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private ControllerUIElement actionTopRow2;

	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x4000FB8")]
	private ControllerUIElement actionTopRow3;

	[SerializeField]
	[Token(Token = "0x4000FB9")]
	[FieldOffset(Offset = "0x90")]
	private ControllerUIElement leftShoulder;

	[SerializeField]
	[Token(Token = "0x4000FBA")]
	[FieldOffset(Offset = "0x98")]
	private ControllerUIElement leftTrigger;

	[Token(Token = "0x4000FBB")]
	[SerializeField]
	[FieldOffset(Offset = "0xA0")]
	private ControllerUIElement rightShoulder;

	[SerializeField]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000FBC")]
	private ControllerUIElement rightTrigger;

	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000FBD")]
	[SerializeField]
	private ControllerUIElement center1;

	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000FBE")]
	[SerializeField]
	private ControllerUIElement center2;

	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000FBF")]
	[SerializeField]
	private ControllerUIElement center3;

	[Token(Token = "0x4000FC0")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private ControllerUIElement dPadUp;

	[Token(Token = "0x4000FC1")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private ControllerUIElement dPadRight;

	[SerializeField]
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000FC2")]
	private ControllerUIElement dPadDown;

	[SerializeField]
	[Token(Token = "0x4000FC3")]
	[FieldOffset(Offset = "0xE0")]
	private ControllerUIElement dPadLeft;

	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000FC4")]
	private UIElement[] _uiElementsArray;

	[Token(Token = "0x4000FC5")]
	[FieldOffset(Offset = "0xF0")]
	private Dictionary<int, ControllerUIElement> _uiElements;

	[Token(Token = "0x4000FC6")]
	[FieldOffset(Offset = "0xF8")]
	private IList<ControllerTemplateElementTarget> _tempTargetList;

	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000FC7")]
	private Stick[] _sticks;

	[Token(Token = "0x17000416")]
	private Player player
	{
		[Token(Token = "0x6001492")]
		[Address(RVA = "0xF97640", Offset = "0xF95E40", Length = "0x66")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001493")]
	[Address(RVA = "0xF95790", Offset = "0xF93F90", Length = "0xEF5")]
	private void Awake()
	{
	}

	[Address(RVA = "0xF97410", Offset = "0xF95C10", Length = "0xB1")]
	[Token(Token = "0x6001494")]
	private void Start()
	{
	}

	[Token(Token = "0x6001495")]
	[Address(RVA = "0xF97350", Offset = "0xF95B50", Length = "0xB4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001496")]
	[Address(RVA = "0xF974D0", Offset = "0xF95CD0", Length = "0xB1")]
	private void Update()
	{
	}

	[Address(RVA = "0xF96690", Offset = "0xF94E90", Length = "0x375")]
	[Token(Token = "0x6001497")]
	private void DrawActiveElements()
	{
	}

	[Address(RVA = "0xF95420", Offset = "0xF93C20", Length = "0x361")]
	[Token(Token = "0x6001498")]
	private void ActivateElements(Player player, int actionId)
	{
	}

	[Token(Token = "0x6001499")]
	[Address(RVA = "0xF96D70", Offset = "0xF95570", Length = "0x28F")]
	private void DrawLabels()
	{
	}

	[Token(Token = "0x600149A")]
	[Address(RVA = "0xF97000", Offset = "0xF95800", Length = "0x1FD")]
	private void DrawLabels(Player player, InputAction action)
	{
	}

	[Token(Token = "0x600149B")]
	[Address(RVA = "0xF96A10", Offset = "0xF95210", Length = "0x35A")]
	private void DrawLabel(ControllerUIElement uiElement, InputAction action, ControllerMap controllerMap, IControllerTemplate template, IControllerTemplateElement element)
	{
	}

	[Token(Token = "0x600149C")]
	[Address(RVA = "0xF97200", Offset = "0xF95A00", Length = "0x138")]
	private Stick GetStick(int elementId)
	{
		return null;
	}

	[Token(Token = "0x600149D")]
	[Address(RVA = "0xF97340", Offset = "0xF95B40", Length = "0x7")]
	private void OnControllerConnected(ControllerStatusChangedEventArgs args)
	{
	}

	[Address(RVA = "0xF97340", Offset = "0xF95B40", Length = "0x7")]
	[Token(Token = "0x600149E")]
	private void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
	{
	}

	[Address(RVA = "0xF97590", Offset = "0xF95D90", Length = "0xA1")]
	[Token(Token = "0x600149F")]
	public GamepadTemplateUI()
	{
	}
}

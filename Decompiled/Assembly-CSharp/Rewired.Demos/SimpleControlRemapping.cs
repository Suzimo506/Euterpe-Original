using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Demos;

[Token(Token = "0x2000224")]
[Attribute(Name = "AddComponentMenu", RVA = "0x6530", Offset = "0x5930")]
public class SimpleControlRemapping : MonoBehaviour
{
	[Token(Token = "0x2000ABE")]
	private class Row
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400385E")]
		public InputAction action;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400385F")]
		public AxisRange actionRange;

		[Token(Token = "0x4003860")]
		[FieldOffset(Offset = "0x20")]
		public Button button;

		[Token(Token = "0x4003861")]
		[FieldOffset(Offset = "0x28")]
		public Text text;

		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		[Token(Token = "0x6005BF3")]
		public Row()
		{
		}
	}

	[Token(Token = "0x4000F84")]
	private const string category = "Default";

	[Token(Token = "0x4000F85")]
	private const string layout = "Default";

	[Token(Token = "0x4000F86")]
	private const string uiCategory = "UI";

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F87")]
	private InputMapper inputMapper;

	[Token(Token = "0x4000F88")]
	[FieldOffset(Offset = "0x20")]
	public GameObject buttonPrefab;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000F89")]
	public GameObject textPrefab;

	[Token(Token = "0x4000F8A")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform fieldGroupTransform;

	[Token(Token = "0x4000F8B")]
	[FieldOffset(Offset = "0x38")]
	public RectTransform actionGroupTransform;

	[Token(Token = "0x4000F8C")]
	[FieldOffset(Offset = "0x40")]
	public Text controllerNameUIText;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000F8D")]
	public Text statusUIText;

	[Token(Token = "0x4000F8E")]
	[FieldOffset(Offset = "0x50")]
	private ControllerType selectedControllerType;

	[Token(Token = "0x4000F8F")]
	[FieldOffset(Offset = "0x54")]
	private int selectedControllerId;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000F90")]
	private List<Row> rows;

	[Token(Token = "0x17000412")]
	private Player player
	{
		[Address(RVA = "0xFA4B90", Offset = "0xFA3390", Length = "0x5F")]
		[Token(Token = "0x6001460")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000413")]
	private ControllerMap controllerMap
	{
		[Token(Token = "0x6001461")]
		[Address(RVA = "0xFA49E0", Offset = "0xFA31E0", Length = "0x116")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000414")]
	private Controller controller
	{
		[Token(Token = "0x6001462")]
		[Address(RVA = "0xFA4B00", Offset = "0xFA3300", Length = "0x82")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0xFA3E50", Offset = "0xFA2650", Length = "0x23B")]
	[Token(Token = "0x6001463")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0xFA3D60", Offset = "0xFA2560", Length = "0xE2")]
	[Token(Token = "0x6001464")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0xFA4260", Offset = "0xFA2A60", Length = "0x4F0")]
	[Token(Token = "0x6001465")]
	private void RedrawUI()
	{
	}

	[Address(RVA = "0xFA3450", Offset = "0xFA1C50", Length = "0x11F")]
	[Token(Token = "0x6001466")]
	private void ClearUI()
	{
	}

	[Address(RVA = "0xFA3770", Offset = "0xFA1F70", Length = "0x5CD")]
	[Token(Token = "0x6001467")]
	private void InitializeUI()
	{
	}

	[Address(RVA = "0xFA3570", Offset = "0xFA1D70", Length = "0x1F2")]
	[Token(Token = "0x6001468")]
	private void CreateUIRow(InputAction action, AxisRange actionRange, string label)
	{
	}

	[Address(RVA = "0xFA4760", Offset = "0xFA2F60", Length = "0x149")]
	[Token(Token = "0x6001469")]
	private void SetSelectedController(ControllerType controllerType)
	{
	}

	[Address(RVA = "0xFA3D50", Offset = "0xFA2550", Length = "0x8")]
	[Token(Token = "0x600146A")]
	public void OnControllerSelected(int controllerType)
	{
	}

	[Address(RVA = "0xFA4090", Offset = "0xFA2890", Length = "0xD8")]
	[Token(Token = "0x600146B")]
	private void OnInputFieldClicked(int index, int actionElementMapToReplaceId)
	{
	}

	[Token(Token = "0x600146C")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x143B0", Offset = "0x137B0")]
	[Address(RVA = "0xFA48B0", Offset = "0xFA30B0", Length = "0x84")]
	private IEnumerator StartListeningDelayed(int index, int actionElementMapToReplaceId)
	{
		return null;
	}

	[Address(RVA = "0xFA3D40", Offset = "0xFA2540", Length = "0xB")]
	[Token(Token = "0x600146D")]
	private void OnControllerChanged(ControllerStatusChangedEventArgs args)
	{
	}

	[Token(Token = "0x600146E")]
	[Address(RVA = "0xFA4170", Offset = "0xFA2970", Length = "0x7")]
	private void OnInputMapped(InputMapper.InputMappedEventData data)
	{
	}

	[Address(RVA = "0xFA4180", Offset = "0xFA2980", Length = "0xD7")]
	[Token(Token = "0x600146F")]
	private void OnStopped(InputMapper.StoppedEventData data)
	{
	}

	[Address(RVA = "0xFA4940", Offset = "0xFA3140", Length = "0x91")]
	[Token(Token = "0x6001470")]
	public SimpleControlRemapping()
	{
	}
}

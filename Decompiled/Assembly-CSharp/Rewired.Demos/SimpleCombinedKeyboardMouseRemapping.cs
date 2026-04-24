using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Demos;

[Attribute(Name = "AddComponentMenu", RVA = "0x6530", Offset = "0x5930")]
[Token(Token = "0x2000223")]
public class SimpleCombinedKeyboardMouseRemapping : MonoBehaviour
{
	[Token(Token = "0x2000ABA")]
	private class Row
	{
		[Token(Token = "0x400384E")]
		[FieldOffset(Offset = "0x10")]
		public InputAction action;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400384F")]
		public AxisRange actionRange;

		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003850")]
		public Button button;

		[Token(Token = "0x4003851")]
		[FieldOffset(Offset = "0x28")]
		public Text text;

		[Token(Token = "0x6005BEA")]
		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		public Row()
		{
		}
	}

	[Token(Token = "0x2000ABB")]
	private struct TargetMapping
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4003852")]
		public ControllerMap controllerMap;

		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4003853")]
		public int actionElementMapId;
	}

	[Token(Token = "0x4000F77")]
	private const string category = "Default";

	[Token(Token = "0x4000F78")]
	private const string layout = "Default";

	[Token(Token = "0x4000F79")]
	private const string uiCategory = "UI";

	[Token(Token = "0x4000F7A")]
	[FieldOffset(Offset = "0x18")]
	private InputMapper inputMapper_keyboard;

	[Token(Token = "0x4000F7B")]
	[FieldOffset(Offset = "0x20")]
	private InputMapper inputMapper_mouse;

	[Token(Token = "0x4000F7C")]
	[FieldOffset(Offset = "0x28")]
	public GameObject buttonPrefab;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000F7D")]
	public GameObject textPrefab;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000F7E")]
	public RectTransform fieldGroupTransform;

	[Token(Token = "0x4000F7F")]
	[FieldOffset(Offset = "0x40")]
	public RectTransform actionGroupTransform;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000F80")]
	public Text controllerNameUIText;

	[Token(Token = "0x4000F81")]
	[FieldOffset(Offset = "0x50")]
	public Text statusUIText;

	[Token(Token = "0x4000F82")]
	[FieldOffset(Offset = "0x58")]
	private List<Row> rows;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000F83")]
	private TargetMapping _replaceTargetMapping;

	[Token(Token = "0x17000411")]
	private Player player
	{
		[Token(Token = "0x6001454")]
		[Address(RVA = "0xFA33F0", Offset = "0xFA1BF0", Length = "0x5F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001455")]
	[Address(RVA = "0xFA2810", Offset = "0xFA1010", Length = "0x2B1")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001456")]
	[Address(RVA = "0xFA27B0", Offset = "0xFA0FB0", Length = "0x53")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001457")]
	[Address(RVA = "0xFA2E40", Offset = "0xFA1640", Length = "0x429")]
	private void RedrawUI()
	{
	}

	[Address(RVA = "0xFA1EE0", Offset = "0xFA06E0", Length = "0xF3")]
	[Token(Token = "0x6001458")]
	private void ClearUI()
	{
	}

	[Address(RVA = "0xFA21E0", Offset = "0xFA09E0", Length = "0x5CD")]
	[Token(Token = "0x6001459")]
	private void InitializeUI()
	{
	}

	[Token(Token = "0x600145A")]
	[Address(RVA = "0xFA1FE0", Offset = "0xFA07E0", Length = "0x1F2")]
	private void CreateUIRow(InputAction action, AxisRange actionRange, string label)
	{
	}

	[Address(RVA = "0xFA2AD0", Offset = "0xFA12D0", Length = "0x208")]
	[Token(Token = "0x600145B")]
	private void OnInputFieldClicked(int index, int actionElementMapToReplaceId)
	{
	}

	[Token(Token = "0x600145C")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x125A0", Offset = "0x119A0")]
	[Address(RVA = "0xFA3270", Offset = "0xFA1A70", Length = "0xB7")]
	private IEnumerator StartListeningDelayed(int index, ControllerMap keyboardMap, ControllerMap mouseMap, int actionElementMapToReplaceId)
	{
		return null;
	}

	[Address(RVA = "0xFA2CE0", Offset = "0xFA14E0", Length = "0x79")]
	[Token(Token = "0x600145D")]
	private void OnInputMapped(InputMapper.InputMappedEventData data)
	{
	}

	[Address(RVA = "0xFA2D60", Offset = "0xFA1560", Length = "0xD7")]
	[Token(Token = "0x600145E")]
	private void OnStopped(InputMapper.StoppedEventData data)
	{
	}

	[Address(RVA = "0xFA3330", Offset = "0xFA1B30", Length = "0xB9")]
	[Token(Token = "0x600145F")]
	public SimpleCombinedKeyboardMouseRemapping()
	{
	}
}

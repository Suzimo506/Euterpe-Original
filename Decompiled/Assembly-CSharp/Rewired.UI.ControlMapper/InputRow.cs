using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper;

[Token(Token = "0x2000201")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6530", Offset = "0x5930")]
public class InputRow : MonoBehaviour
{
	[Token(Token = "0x4000E83")]
	[FieldOffset(Offset = "0x18")]
	public Text label;

	[Token(Token = "0x4000E85")]
	[FieldOffset(Offset = "0x28")]
	private int rowIndex;

	[Token(Token = "0x4000E86")]
	[FieldOffset(Offset = "0x30")]
	private Action<int, ButtonInfo> inputFieldActivatedCallback;

	[Token(Token = "0x1700039E")]
	public ButtonInfo[] buttons
	{
		[Token(Token = "0x60012A9")]
		[CompilerGenerated]
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x60012AA")]
		[Address(RVA = "0x483E40", Offset = "0x482640", Length = "0xC")]
		private set
		{
		}
	}

	[Token(Token = "0x60012AB")]
	[Address(RVA = "0xDC6B40", Offset = "0xDC5340", Length = "0xB0")]
	public void Initialize(int rowIndex, string label, Action<int, ButtonInfo> inputFieldActivatedCallback)
	{
	}

	[Token(Token = "0x60012AC")]
	[Address(RVA = "0xDC6C00", Offset = "0xDC5400", Length = "0x51")]
	public void OnButtonActivated(ButtonInfo buttonInfo)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x60012AD")]
	public InputRow()
	{
	}
}

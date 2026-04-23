using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper;

[Token(Token = "0x200020A")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6530", Offset = "0x5930")]
public class UIControlSet : MonoBehaviour
{
	[Token(Token = "0x4000EE0")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text title;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000EE1")]
	private Dictionary<int, UIControl> _controls;

	[Token(Token = "0x170003FA")]
	private Dictionary<int, UIControl> controls
	{
		[Address(RVA = "0xDCCCE0", Offset = "0xDCB4E0", Length = "0x6E")]
		[Token(Token = "0x6001351")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001352")]
	[Address(RVA = "0xDCCC40", Offset = "0xDCB440", Length = "0x94")]
	public void SetTitle(string text)
	{
	}

	[Token(Token = "0x6001353")]
	[Address(RVA = "0x867BB0", Offset = "0x8663B0", Length = "0xEE")]
	public T GetControl<T>(int uniqueId) where T : UIControl
	{
		return null;
	}

	[Address(RVA = "0xDCC860", Offset = "0xDCB060", Length = "0x3D8")]
	[Token(Token = "0x6001354")]
	public UISliderControl CreateSlider(GameObject prefab, Sprite icon, float minValue, float maxValue, Action<int, float> valueChangedCallback, Action<int> cancelCallback)
	{
		return null;
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6001355")]
	public UIControlSet()
	{
	}
}

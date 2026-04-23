using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper;

[Attribute(Name = "RequireComponent", RVA = "0xA11C0", Offset = "0xA05C0")]
[Token(Token = "0x2000204")]
[Attribute(Name = "AddComponentMenu", RVA = "0xA11C0", Offset = "0xA05C0")]
public class ScrollRectSelectableChild : MonoBehaviour, ISelectHandler, IEventSystemHandler
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000EC3")]
	public bool useCustomEdgePadding;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000EC4")]
	public float customEdgePadding;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000EC5")]
	private ScrollRect parentScrollRect;

	[Token(Token = "0x4000EC6")]
	[FieldOffset(Offset = "0x28")]
	private Selectable _selectable;

	[Token(Token = "0x170003F5")]
	private RectTransform parentScrollRectContentTransform
	{
		[Token(Token = "0x6001338")]
		[Address(RVA = "0xDC9880", Offset = "0xDC8080", Length = "0x1B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003F6")]
	private Selectable selectable
	{
		[Token(Token = "0x6001339")]
		[Address(RVA = "0xDC9900", Offset = "0xDC8100", Length = "0x63")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003F7")]
	private RectTransform rectTransform
	{
		[Token(Token = "0x600133A")]
		[Address(RVA = "0xDC98A0", Offset = "0xDC80A0", Length = "0x52")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0xDC97A0", Offset = "0xDC7FA0", Length = "0xC5")]
	[Token(Token = "0x600133B")]
	private void Start()
	{
	}

	[Token(Token = "0x600133C")]
	[Address(RVA = "0xDC93A0", Offset = "0xDC7BA0", Length = "0x3F3")]
	public void OnSelect(BaseEventData eventData)
	{
	}

	[Address(RVA = "0xDC9870", Offset = "0xDC8070", Length = "0xE")]
	[Token(Token = "0x600133D")]
	public ScrollRectSelectableChild()
	{
	}
}

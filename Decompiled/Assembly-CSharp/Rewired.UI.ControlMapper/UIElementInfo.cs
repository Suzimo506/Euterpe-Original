using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper;

[Token(Token = "0x200020B")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6530", Offset = "0x5930")]
public abstract class UIElementInfo : MonoBehaviour, ISelectHandler, IEventSystemHandler
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000EE2")]
	public string identifier;

	[Token(Token = "0x4000EE3")]
	[FieldOffset(Offset = "0x20")]
	public int intData;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000EE4")]
	public Text text;

	[Token(Token = "0x1400002A")]
	public event Action<GameObject> OnSelectedEvent
	{
		[CompilerGenerated]
		[Address(RVA = "0xDCCF20", Offset = "0xDCB720", Length = "0x9E")]
		[Token(Token = "0x6001356")]
		add
		{
		}
		[Token(Token = "0x6001357")]
		[Address(RVA = "0xDCCFC0", Offset = "0xDCB7C0", Length = "0x9E")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6001358")]
	[Address(RVA = "0xDCCEC0", Offset = "0xDCB6C0", Length = "0x58")]
	public void OnSelect(BaseEventData eventData)
	{
	}

	[Token(Token = "0x6001359")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	protected UIElementInfo()
	{
	}
}

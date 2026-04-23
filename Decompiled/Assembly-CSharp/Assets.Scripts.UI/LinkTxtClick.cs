using System;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.UI;

[Token(Token = "0x200081E")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x14D20", Offset = "0x14120")]
public class LinkTxtClick : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[Token(Token = "0x4002A64")]
	[FieldOffset(Offset = "0x18")]
	private Camera m_Camera;

	[Token(Token = "0x4002A65")]
	[FieldOffset(Offset = "0x20")]
	private TextMeshProUGUI m_TextMeshProUGUI;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002A66")]
	public Action onClick;

	[Token(Token = "0x17000837")]
	public TextMeshProUGUI textMeshProUGUI
	{
		[Token(Token = "0x6004AEE")]
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x6C1FD0", Offset = "0x6C07D0", Length = "0x62")]
	[Token(Token = "0x6004AEF")]
	public void Init(Camera camera)
	{
	}

	[Token(Token = "0x6004AF0")]
	[Address(RVA = "0x6C2040", Offset = "0x6C0840", Length = "0x10E")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6004AF1")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public LinkTxtClick()
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Scripts.UI;

[Token(Token = "0x2000824")]
public class ToggleWithClickEvent : Toggle
{
	[Token(Token = "0x1700083A")]
	public Action OnClick
	{
		[CompilerGenerated]
		[Token(Token = "0x6004B0F")]
		[Address(RVA = "0x51FEB0", Offset = "0x51E6B0", Length = "0x8")]
		private get
		{
			return null;
		}
		[Token(Token = "0x6004B10")]
		[CompilerGenerated]
		[Address(RVA = "0x604650", Offset = "0x602E50", Length = "0xF")]
		set
		{
		}
	}

	[Token(Token = "0x1700083B")]
	public Action<bool> OnSelected
	{
		[CompilerGenerated]
		[Token(Token = "0x6004B11")]
		[Address(RVA = "0x561290", Offset = "0x55FA90", Length = "0x8")]
		private get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6004B12")]
		[Address(RVA = "0x604660", Offset = "0x602E60", Length = "0xF")]
		set
		{
		}
	}

	[Token(Token = "0x6004B13")]
	[Address(RVA = "0x604580", Offset = "0x602D80", Length = "0x25")]
	public override void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6004B14")]
	[Address(RVA = "0x604610", Offset = "0x602E10", Length = "0x25")]
	public override void OnSubmit(BaseEventData eventData)
	{
	}

	[Token(Token = "0x6004B15")]
	[Address(RVA = "0x6045B0", Offset = "0x602DB0", Length = "0x5E")]
	public override void OnSelect(BaseEventData eventData)
	{
	}

	[Address(RVA = "0x604520", Offset = "0x602D20", Length = "0x5E")]
	[Token(Token = "0x6004B16")]
	public override void OnDeselect(BaseEventData eventData)
	{
	}

	[Token(Token = "0x6004B17")]
	[Address(RVA = "0x604640", Offset = "0x602E40", Length = "0x7")]
	public ToggleWithClickEvent()
	{
	}
}

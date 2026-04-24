using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper;

[Attribute(Name = "AddComponentMenu", RVA = "0x6530", Offset = "0x5930")]
[Token(Token = "0x20001FD")]
public class CustomToggle : Toggle, ICustomSelectable, ICancelHandler, IEventSystemHandler
{
	[Token(Token = "0x4000E68")]
	[SerializeField]
	[FieldOffset(Offset = "0x120")]
	private Sprite _disabledHighlightedSprite;

	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	[Token(Token = "0x4000E69")]
	private Color _disabledHighlightedColor;

	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000E6A")]
	[SerializeField]
	private string _disabledHighlightedTrigger;

	[SerializeField]
	[Token(Token = "0x4000E6B")]
	[FieldOffset(Offset = "0x140")]
	private bool _autoNavUp;

	[Token(Token = "0x4000E6C")]
	[FieldOffset(Offset = "0x141")]
	[SerializeField]
	private bool _autoNavDown;

	[SerializeField]
	[Token(Token = "0x4000E6D")]
	[FieldOffset(Offset = "0x142")]
	private bool _autoNavLeft;

	[FieldOffset(Offset = "0x143")]
	[SerializeField]
	[Token(Token = "0x4000E6E")]
	private bool _autoNavRight;

	[Token(Token = "0x4000E6F")]
	[FieldOffset(Offset = "0x144")]
	private bool isHighlightDisabled;

	[Token(Token = "0x1700038A")]
	public Sprite disabledHighlightedSprite
	{
		[Token(Token = "0x600125C")]
		[Address(RVA = "0x51FEB0", Offset = "0x51E6B0", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600125D")]
		[Address(RVA = "0x604650", Offset = "0x602E50", Length = "0xF")]
		set
		{
		}
	}

	[Token(Token = "0x1700038B")]
	public Color disabledHighlightedColor
	{
		[Address(RVA = "0xDBFAC0", Offset = "0xDBE2C0", Length = "0xE")]
		[Token(Token = "0x600125E")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x600125F")]
		[Address(RVA = "0xDBFBB0", Offset = "0xDBE3B0", Length = "0xB")]
		set
		{
		}
	}

	[Token(Token = "0x1700038C")]
	public string disabledHighlightedTrigger
	{
		[Token(Token = "0x6001260")]
		[Address(RVA = "0x6BE720", Offset = "0x6BCF20", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001261")]
		[Address(RVA = "0xBD5A40", Offset = "0xBD4240", Length = "0xF")]
		set
		{
		}
	}

	[Token(Token = "0x1700038D")]
	public bool autoNavUp
	{
		[Token(Token = "0x6001262")]
		[Address(RVA = "0xDBFAB0", Offset = "0xDBE2B0", Length = "0x8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001263")]
		[Address(RVA = "0xDBFBA0", Offset = "0xDBE3A0", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x1700038E")]
	public bool autoNavDown
	{
		[Address(RVA = "0xDBFA80", Offset = "0xDBE280", Length = "0x8")]
		[Token(Token = "0x6001264")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001265")]
		[Address(RVA = "0xDBFB70", Offset = "0xDBE370", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x1700038F")]
	public bool autoNavLeft
	{
		[Token(Token = "0x6001266")]
		[Address(RVA = "0xDBFA90", Offset = "0xDBE290", Length = "0x8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001267")]
		[Address(RVA = "0xDBFB80", Offset = "0xDBE380", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x17000390")]
	public bool autoNavRight
	{
		[Address(RVA = "0xDBFAA0", Offset = "0xDBE2A0", Length = "0x8")]
		[Token(Token = "0x6001268")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0xDBFB90", Offset = "0xDBE390", Length = "0x7")]
		[Token(Token = "0x6001269")]
		set
		{
		}
	}

	[Token(Token = "0x17000391")]
	private bool isDisabled
	{
		[Address(RVA = "0xDBD960", Offset = "0xDBC160", Length = "0x1E")]
		[Token(Token = "0x600126A")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000027")]
	private event UnityAction _CancelEvent
	{
		[Address(RVA = "0xDBF9E0", Offset = "0xDBE1E0", Length = "0x9E")]
		[Token(Token = "0x600126B")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600126C")]
		[CompilerGenerated]
		[Address(RVA = "0xDBFAD0", Offset = "0xDBE2D0", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x14000028")]
	public event UnityAction CancelEvent
	{
		[Address(RVA = "0xDBF9E0", Offset = "0xDBE1E0", Length = "0x9E")]
		[Token(Token = "0x600126D")]
		add
		{
		}
		[Address(RVA = "0xDBFAD0", Offset = "0xDBE2D0", Length = "0x9E")]
		[Token(Token = "0x600126E")]
		remove
		{
		}
	}

	[Token(Token = "0x600126F")]
	[Address(RVA = "0xDBF290", Offset = "0xDBDA90", Length = "0xE8")]
	public override Selectable FindSelectableOnLeft()
	{
		return null;
	}

	[Address(RVA = "0xDBF380", Offset = "0xDBDB80", Length = "0xE8")]
	[Token(Token = "0x6001270")]
	public override Selectable FindSelectableOnRight()
	{
		return null;
	}

	[Address(RVA = "0xDBF470", Offset = "0xDBDC70", Length = "0xE8")]
	[Token(Token = "0x6001271")]
	public override Selectable FindSelectableOnUp()
	{
		return null;
	}

	[Address(RVA = "0xDBF1A0", Offset = "0xDBD9A0", Length = "0xE8")]
	[Token(Token = "0x6001272")]
	public override Selectable FindSelectableOnDown()
	{
		return null;
	}

	[Token(Token = "0x6001273")]
	[Address(RVA = "0xDBF580", Offset = "0xDBDD80", Length = "0x118")]
	protected override void OnCanvasGroupChanged()
	{
	}

	[Token(Token = "0x6001274")]
	[Address(RVA = "0xDBED90", Offset = "0xDBD590", Length = "0x35D")]
	protected override void DoStateTransition(SelectionState state, bool instant)
	{
	}

	[Token(Token = "0x6001275")]
	[Address(RVA = "0xDBF770", Offset = "0xDBDF70", Length = "0xDE")]
	private void StartColorTween(Color targetColor, bool instant)
	{
	}

	[Token(Token = "0x6001276")]
	[Address(RVA = "0xDBECF0", Offset = "0xDBD4F0", Length = "0x9E")]
	private void DoSpriteSwap(Sprite newSprite)
	{
	}

	[Address(RVA = "0xDBF850", Offset = "0xDBE050", Length = "0x16A")]
	[Token(Token = "0x6001277")]
	private void TriggerAnimation(string triggername)
	{
	}

	[Token(Token = "0x6001278")]
	[Address(RVA = "0xDBF710", Offset = "0xDBDF10", Length = "0x55")]
	public override void OnSelect(BaseEventData eventData)
	{
	}

	[Token(Token = "0x6001279")]
	[Address(RVA = "0xDBF6A0", Offset = "0xDBDEA0", Length = "0x6D")]
	public override void OnDeselect(BaseEventData eventData)
	{
	}

	[Token(Token = "0x600127A")]
	[Address(RVA = "0xDBF0F0", Offset = "0xDBD8F0", Length = "0xA1")]
	private void EvaluateHightlightDisabled(bool isSelected)
	{
	}

	[Token(Token = "0x600127B")]
	[Address(RVA = "0xDBF560", Offset = "0xDBDD60", Length = "0x14")]
	public void OnCancel(BaseEventData eventData)
	{
	}

	[Address(RVA = "0xDBF9C0", Offset = "0xDBE1C0", Length = "0x11")]
	[Token(Token = "0x600127C")]
	public CustomToggle()
	{
	}
}

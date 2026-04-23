using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper;

[Attribute(Name = "AddComponentMenu", RVA = "0x6530", Offset = "0x5930")]
[Token(Token = "0x20001FC")]
public class CustomSlider : Slider, ICustomSelectable, ICancelHandler, IEventSystemHandler
{
	[SerializeField]
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000E5F")]
	private Sprite _disabledHighlightedSprite;

	[Token(Token = "0x4000E60")]
	[FieldOffset(Offset = "0x168")]
	[SerializeField]
	private Color _disabledHighlightedColor;

	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x4000E61")]
	[SerializeField]
	private string _disabledHighlightedTrigger;

	[Token(Token = "0x4000E62")]
	[SerializeField]
	[FieldOffset(Offset = "0x180")]
	private bool _autoNavUp;

	[FieldOffset(Offset = "0x181")]
	[Token(Token = "0x4000E63")]
	[SerializeField]
	private bool _autoNavDown;

	[FieldOffset(Offset = "0x182")]
	[Token(Token = "0x4000E64")]
	[SerializeField]
	private bool _autoNavLeft;

	[SerializeField]
	[Token(Token = "0x4000E65")]
	[FieldOffset(Offset = "0x183")]
	private bool _autoNavRight;

	[Token(Token = "0x4000E66")]
	[FieldOffset(Offset = "0x184")]
	private bool isHighlightDisabled;

	[Token(Token = "0x17000382")]
	public Sprite disabledHighlightedSprite
	{
		[Token(Token = "0x600123B")]
		[Address(RVA = "0xCE3140", Offset = "0xCE1940", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600123C")]
		[Address(RVA = "0xCE31C0", Offset = "0xCE19C0", Length = "0xF")]
		set
		{
		}
	}

	[Token(Token = "0x17000383")]
	public Color disabledHighlightedColor
	{
		[Address(RVA = "0xDBEB70", Offset = "0xDBD370", Length = "0xE")]
		[Token(Token = "0x600123D")]
		get
		{
			return default(Color);
		}
		[Address(RVA = "0xDBEC60", Offset = "0xDBD460", Length = "0xB")]
		[Token(Token = "0x600123E")]
		set
		{
		}
	}

	[Token(Token = "0x17000384")]
	public string disabledHighlightedTrigger
	{
		[Address(RVA = "0xCE3190", Offset = "0xCE1990", Length = "0x8")]
		[Token(Token = "0x600123F")]
		get
		{
			return null;
		}
		[Address(RVA = "0xAFF220", Offset = "0xAFDA20", Length = "0xF")]
		[Token(Token = "0x6001240")]
		set
		{
		}
	}

	[Token(Token = "0x17000385")]
	public bool autoNavUp
	{
		[Token(Token = "0x6001241")]
		[Address(RVA = "0xDBEB60", Offset = "0xDBD360", Length = "0x8")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0xDBEC50", Offset = "0xDBD450", Length = "0x7")]
		[Token(Token = "0x6001242")]
		set
		{
		}
	}

	[Token(Token = "0x17000386")]
	public bool autoNavDown
	{
		[Token(Token = "0x6001243")]
		[Address(RVA = "0xDBEB30", Offset = "0xDBD330", Length = "0x8")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0xDBEC20", Offset = "0xDBD420", Length = "0x7")]
		[Token(Token = "0x6001244")]
		set
		{
		}
	}

	[Token(Token = "0x17000387")]
	public bool autoNavLeft
	{
		[Address(RVA = "0xDBEB40", Offset = "0xDBD340", Length = "0x8")]
		[Token(Token = "0x6001245")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001246")]
		[Address(RVA = "0xDBEC30", Offset = "0xDBD430", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x17000388")]
	public bool autoNavRight
	{
		[Token(Token = "0x6001247")]
		[Address(RVA = "0xDBEB50", Offset = "0xDBD350", Length = "0x8")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0xDBEC40", Offset = "0xDBD440", Length = "0x7")]
		[Token(Token = "0x6001248")]
		set
		{
		}
	}

	[Token(Token = "0x17000389")]
	private bool isDisabled
	{
		[Address(RVA = "0xDBD960", Offset = "0xDBC160", Length = "0x1E")]
		[Token(Token = "0x6001249")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000025")]
	private event UnityAction _CancelEvent
	{
		[CompilerGenerated]
		[Token(Token = "0x600124A")]
		[Address(RVA = "0xDBEA90", Offset = "0xDBD290", Length = "0x9E")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x600124B")]
		[Address(RVA = "0xDBEB80", Offset = "0xDBD380", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x14000026")]
	public event UnityAction CancelEvent
	{
		[Token(Token = "0x600124C")]
		[Address(RVA = "0xDBEA90", Offset = "0xDBD290", Length = "0x9E")]
		add
		{
		}
		[Address(RVA = "0xDBEB80", Offset = "0xDBD380", Length = "0x9E")]
		[Token(Token = "0x600124D")]
		remove
		{
		}
	}

	[Address(RVA = "0xDBE340", Offset = "0xDBCB40", Length = "0xE8")]
	[Token(Token = "0x600124E")]
	public override Selectable FindSelectableOnLeft()
	{
		return null;
	}

	[Address(RVA = "0xDBE430", Offset = "0xDBCC30", Length = "0xE8")]
	[Token(Token = "0x600124F")]
	public override Selectable FindSelectableOnRight()
	{
		return null;
	}

	[Token(Token = "0x6001250")]
	[Address(RVA = "0xDBE520", Offset = "0xDBCD20", Length = "0xE8")]
	public override Selectable FindSelectableOnUp()
	{
		return null;
	}

	[Token(Token = "0x6001251")]
	[Address(RVA = "0xDBE250", Offset = "0xDBCA50", Length = "0xE8")]
	public override Selectable FindSelectableOnDown()
	{
		return null;
	}

	[Token(Token = "0x6001252")]
	[Address(RVA = "0xDBE630", Offset = "0xDBCE30", Length = "0x118")]
	protected override void OnCanvasGroupChanged()
	{
	}

	[Address(RVA = "0xDBDE40", Offset = "0xDBC640", Length = "0x35D")]
	[Token(Token = "0x6001253")]
	protected override void DoStateTransition(SelectionState state, bool instant)
	{
	}

	[Address(RVA = "0xDBE820", Offset = "0xDBD020", Length = "0xDE")]
	[Token(Token = "0x6001254")]
	private void StartColorTween(Color targetColor, bool instant)
	{
	}

	[Token(Token = "0x6001255")]
	[Address(RVA = "0xDBDDA0", Offset = "0xDBC5A0", Length = "0x9E")]
	private void DoSpriteSwap(Sprite newSprite)
	{
	}

	[Address(RVA = "0xDBE900", Offset = "0xDBD100", Length = "0x16A")]
	[Token(Token = "0x6001256")]
	private void TriggerAnimation(string triggername)
	{
	}

	[Token(Token = "0x6001257")]
	[Address(RVA = "0xDBE7C0", Offset = "0xDBCFC0", Length = "0x55")]
	public override void OnSelect(BaseEventData eventData)
	{
	}

	[Address(RVA = "0xDBE750", Offset = "0xDBCF50", Length = "0x6D")]
	[Token(Token = "0x6001258")]
	public override void OnDeselect(BaseEventData eventData)
	{
	}

	[Token(Token = "0x6001259")]
	[Address(RVA = "0xDBE1A0", Offset = "0xDBC9A0", Length = "0xA1")]
	private void EvaluateHightlightDisabled(bool isSelected)
	{
	}

	[Token(Token = "0x600125A")]
	[Address(RVA = "0xDBE610", Offset = "0xDBCE10", Length = "0x14")]
	public void OnCancel(BaseEventData eventData)
	{
	}

	[Token(Token = "0x600125B")]
	[Address(RVA = "0xDBEA70", Offset = "0xDBD270", Length = "0x11")]
	public CustomSlider()
	{
	}
}

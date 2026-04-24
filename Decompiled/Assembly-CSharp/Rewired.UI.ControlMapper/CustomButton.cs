using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper;

[Attribute(Name = "AddComponentMenu", RVA = "0x6530", Offset = "0x5930")]
[Token(Token = "0x20001FB")]
public class CustomButton : Button, ICustomSelectable, ICancelHandler, IEventSystemHandler
{
	[SerializeField]
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000E56")]
	private Sprite _disabledHighlightedSprite;

	[Token(Token = "0x4000E57")]
	[SerializeField]
	[FieldOffset(Offset = "0x108")]
	private Color _disabledHighlightedColor;

	[SerializeField]
	[Token(Token = "0x4000E58")]
	[FieldOffset(Offset = "0x118")]
	private string _disabledHighlightedTrigger;

	[SerializeField]
	[Token(Token = "0x4000E59")]
	[FieldOffset(Offset = "0x120")]
	private bool _autoNavUp;

	[Token(Token = "0x4000E5A")]
	[SerializeField]
	[FieldOffset(Offset = "0x121")]
	private bool _autoNavDown;

	[FieldOffset(Offset = "0x122")]
	[SerializeField]
	[Token(Token = "0x4000E5B")]
	private bool _autoNavLeft;

	[SerializeField]
	[Token(Token = "0x4000E5C")]
	[FieldOffset(Offset = "0x123")]
	private bool _autoNavRight;

	[Token(Token = "0x4000E5D")]
	[FieldOffset(Offset = "0x124")]
	private bool isHighlightDisabled;

	[Token(Token = "0x1700037A")]
	public Sprite disabledHighlightedSprite
	{
		[Address(RVA = "0x4E8C20", Offset = "0x4E7420", Length = "0x8")]
		[Token(Token = "0x6001216")]
		get
		{
			return null;
		}
		[Address(RVA = "0x4E7B30", Offset = "0x4E6330", Length = "0xF")]
		[Token(Token = "0x6001217")]
		set
		{
		}
	}

	[Token(Token = "0x1700037B")]
	public Color disabledHighlightedColor
	{
		[Token(Token = "0x6001218")]
		[Address(RVA = "0xBA6B30", Offset = "0xBA5330", Length = "0xE")]
		get
		{
			return default(Color);
		}
		[Address(RVA = "0xBA7860", Offset = "0xBA6060", Length = "0xB")]
		[Token(Token = "0x6001219")]
		set
		{
		}
	}

	[Token(Token = "0x1700037C")]
	public string disabledHighlightedTrigger
	{
		[Token(Token = "0x600121A")]
		[Address(RVA = "0x427D10", Offset = "0x426510", Length = "0x8")]
		get
		{
			return null;
		}
		[Address(RVA = "0xDBDA40", Offset = "0xDBC240", Length = "0xF")]
		[Token(Token = "0x600121B")]
		set
		{
		}
	}

	[Token(Token = "0x1700037D")]
	public bool autoNavUp
	{
		[Address(RVA = "0xA5FD80", Offset = "0xA5E580", Length = "0x8")]
		[Token(Token = "0x600121C")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x7A17C0", Offset = "0x79FFC0", Length = "0x7")]
		[Token(Token = "0x600121D")]
		set
		{
		}
	}

	[Token(Token = "0x1700037E")]
	public bool autoNavDown
	{
		[Token(Token = "0x600121E")]
		[Address(RVA = "0xDBD930", Offset = "0xDBC130", Length = "0x8")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0xDBDA20", Offset = "0xDBC220", Length = "0x7")]
		[Token(Token = "0x600121F")]
		set
		{
		}
	}

	[Token(Token = "0x1700037F")]
	public bool autoNavLeft
	{
		[Address(RVA = "0xDBD940", Offset = "0xDBC140", Length = "0x8")]
		[Token(Token = "0x6001220")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x7A17B0", Offset = "0x79FFB0", Length = "0x7")]
		[Token(Token = "0x6001221")]
		set
		{
		}
	}

	[Token(Token = "0x17000380")]
	public bool autoNavRight
	{
		[Address(RVA = "0xDBD950", Offset = "0xDBC150", Length = "0x8")]
		[Token(Token = "0x6001222")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0xDBDA30", Offset = "0xDBC230", Length = "0x7")]
		[Token(Token = "0x6001223")]
		set
		{
		}
	}

	[Token(Token = "0x17000381")]
	private bool isDisabled
	{
		[Token(Token = "0x6001224")]
		[Address(RVA = "0xDBD960", Offset = "0xDBC160", Length = "0x1E")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000023")]
	private event UnityAction _CancelEvent
	{
		[Address(RVA = "0xDBD890", Offset = "0xDBC090", Length = "0x9E")]
		[Token(Token = "0x6001225")]
		[CompilerGenerated]
		add
		{
		}
		[Address(RVA = "0xDBD980", Offset = "0xDBC180", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6001226")]
		remove
		{
		}
	}

	[Token(Token = "0x14000024")]
	public event UnityAction CancelEvent
	{
		[Address(RVA = "0xDBD890", Offset = "0xDBC090", Length = "0x9E")]
		[Token(Token = "0x6001227")]
		add
		{
		}
		[Address(RVA = "0xDBD980", Offset = "0xDBC180", Length = "0x9E")]
		[Token(Token = "0x6001228")]
		remove
		{
		}
	}

	[Address(RVA = "0xDBCE80", Offset = "0xDBB680", Length = "0xE8")]
	[Token(Token = "0x6001229")]
	public override Selectable FindSelectableOnLeft()
	{
		return null;
	}

	[Address(RVA = "0xDBCF70", Offset = "0xDBB770", Length = "0xE8")]
	[Token(Token = "0x600122A")]
	public override Selectable FindSelectableOnRight()
	{
		return null;
	}

	[Address(RVA = "0xDBD060", Offset = "0xDBB860", Length = "0xE8")]
	[Token(Token = "0x600122B")]
	public override Selectable FindSelectableOnUp()
	{
		return null;
	}

	[Address(RVA = "0xDBCD90", Offset = "0xDBB590", Length = "0xE8")]
	[Token(Token = "0x600122C")]
	public override Selectable FindSelectableOnDown()
	{
		return null;
	}

	[Token(Token = "0x600122D")]
	[Address(RVA = "0xDBD170", Offset = "0xDBB970", Length = "0x118")]
	protected override void OnCanvasGroupChanged()
	{
	}

	[Token(Token = "0x600122E")]
	[Address(RVA = "0xDBC980", Offset = "0xDBB180", Length = "0x35D")]
	protected override void DoStateTransition(SelectionState state, bool instant)
	{
	}

	[Token(Token = "0x600122F")]
	[Address(RVA = "0xDBD620", Offset = "0xDBBE20", Length = "0xDE")]
	private void StartColorTween(Color targetColor, bool instant)
	{
	}

	[Address(RVA = "0xDBC8E0", Offset = "0xDBB0E0", Length = "0x9E")]
	[Token(Token = "0x6001230")]
	private void DoSpriteSwap(Sprite newSprite)
	{
	}

	[Address(RVA = "0xDBD700", Offset = "0xDBBF00", Length = "0x16A")]
	[Token(Token = "0x6001231")]
	private void TriggerAnimation(string triggername)
	{
	}

	[Token(Token = "0x6001232")]
	[Address(RVA = "0xDBD430", Offset = "0xDBBC30", Length = "0x55")]
	public override void OnSelect(BaseEventData eventData)
	{
	}

	[Address(RVA = "0xDBD290", Offset = "0xDBBA90", Length = "0x6D")]
	[Token(Token = "0x6001233")]
	public override void OnDeselect(BaseEventData eventData)
	{
	}

	[Address(RVA = "0xDBD5C0", Offset = "0xDBBDC0", Length = "0x57")]
	[Token(Token = "0x6001234")]
	private void Press()
	{
	}

	[Token(Token = "0x6001235")]
	[Address(RVA = "0xDBD370", Offset = "0xDBBB70", Length = "0xB2")]
	public override void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6001236")]
	[Address(RVA = "0xDBD490", Offset = "0xDBBC90", Length = "0x12E")]
	public override void OnSubmit(BaseEventData eventData)
	{
	}

	[Token(Token = "0x6001237")]
	[Address(RVA = "0xDBD300", Offset = "0xDBBB00", Length = "0x65")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x94A60", Offset = "0x93E60")]
	private IEnumerator OnFinishSubmit()
	{
		return null;
	}

	[Token(Token = "0x6001238")]
	[Address(RVA = "0xDBCCE0", Offset = "0xDBB4E0", Length = "0xA1")]
	private void EvaluateHightlightDisabled(bool isSelected)
	{
	}

	[Address(RVA = "0xDBD150", Offset = "0xDBB950", Length = "0x14")]
	[Token(Token = "0x6001239")]
	public void OnCancel(BaseEventData eventData)
	{
	}

	[Address(RVA = "0xDBD870", Offset = "0xDBC070", Length = "0x11")]
	[Token(Token = "0x600123A")]
	public CustomButton()
	{
	}
}

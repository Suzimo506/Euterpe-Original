using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace Rewired.UI.ControlMapper;

[Token(Token = "0x20001FE")]
public interface ICustomSelectable : ICancelHandler, IEventSystemHandler
{
	[Token(Token = "0x17000392")]
	Sprite disabledHighlightedSprite
	{
		[Token(Token = "0x600127D")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x600127E")]
		set;
	}

	[Token(Token = "0x17000393")]
	Color disabledHighlightedColor
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x600127F")]
		get;
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6001280")]
		set;
	}

	[Token(Token = "0x17000394")]
	string disabledHighlightedTrigger
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6001281")]
		get;
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6001282")]
		set;
	}

	[Token(Token = "0x17000395")]
	bool autoNavUp
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6001283")]
		get;
		[Token(Token = "0x6001284")]
		[Address(RVA = "0x0", Length = "0x0")]
		set;
	}

	[Token(Token = "0x17000396")]
	bool autoNavDown
	{
		[Token(Token = "0x6001285")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
		[Token(Token = "0x6001286")]
		[Address(RVA = "0x0", Length = "0x0")]
		set;
	}

	[Token(Token = "0x17000397")]
	bool autoNavLeft
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6001287")]
		get;
		[Token(Token = "0x6001288")]
		[Address(RVA = "0x0", Length = "0x0")]
		set;
	}

	[Token(Token = "0x17000398")]
	bool autoNavRight
	{
		[Token(Token = "0x6001289")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
		[Token(Token = "0x600128A")]
		[Address(RVA = "0x0", Length = "0x0")]
		set;
	}

	[Token(Token = "0x14000029")]
	event UnityAction CancelEvent;
}

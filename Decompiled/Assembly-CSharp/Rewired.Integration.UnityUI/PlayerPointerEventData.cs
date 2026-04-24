using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Rewired.UI;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI;

[Token(Token = "0x20001F1")]
public class PlayerPointerEventData : PointerEventData
{
	[Token(Token = "0x17000317")]
	public int playerId
	{
		[Token(Token = "0x6001042")]
		[Address(RVA = "0xF9A4C0", Offset = "0xF98CC0", Length = "0x7")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001043")]
		[Address(RVA = "0xF9A4F0", Offset = "0xF98CF0", Length = "0x7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000318")]
	public int inputSourceIndex
	{
		[Address(RVA = "0xF9A4B0", Offset = "0xF98CB0", Length = "0x7")]
		[Token(Token = "0x6001044")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Address(RVA = "0xF9A4E0", Offset = "0xF98CE0", Length = "0x7")]
		[Token(Token = "0x6001045")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000319")]
	public IMouseInputSource mouseSource
	{
		[Token(Token = "0x6001046")]
		[Address(RVA = "0x6BE720", Offset = "0x6BCF20", Length = "0x8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Address(RVA = "0xBD5A40", Offset = "0xBD4240", Length = "0xF")]
		[Token(Token = "0x6001047")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700031A")]
	public ITouchInputSource touchSource
	{
		[Address(RVA = "0xCD8150", Offset = "0xCD6950", Length = "0x8")]
		[Token(Token = "0x6001048")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Address(RVA = "0xF9A500", Offset = "0xF98D00", Length = "0xF")]
		[Token(Token = "0x6001049")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700031B")]
	public PointerEventType sourceType
	{
		[CompilerGenerated]
		[Token(Token = "0x600104A")]
		[Address(RVA = "0xD35750", Offset = "0xD33F50", Length = "0x7")]
		get
		{
			return default(PointerEventType);
		}
		[CompilerGenerated]
		[Address(RVA = "0xD357B0", Offset = "0xD33FB0", Length = "0x7")]
		[Token(Token = "0x600104B")]
		set
		{
		}
	}

	[Token(Token = "0x1700031C")]
	public int buttonIndex
	{
		[Address(RVA = "0xF9A4A0", Offset = "0xF98CA0", Length = "0x7")]
		[Token(Token = "0x600104C")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600104D")]
		[Address(RVA = "0xF9A4D0", Offset = "0xF98CD0", Length = "0x7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600104E")]
	[Address(RVA = "0xF9A470", Offset = "0xF98C70", Length = "0x2C")]
	public PlayerPointerEventData(EventSystem eventSystem)
		: base(null)
	{
	}

	[Address(RVA = "0xF9A2B0", Offset = "0xF98AB0", Length = "0x1B9")]
	[Token(Token = "0x600104F")]
	public override string ToString()
	{
		return null;
	}
}

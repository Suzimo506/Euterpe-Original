using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x2000628")]
public class PlayPopuper
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40022B7")]
	private readonly System.Action m_EndCallback;

	[Token(Token = "0x1700058E")]
	public Popup popup
	{
		[CompilerGenerated]
		[Token(Token = "0x6003BB0")]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003BAF")]
		[Address(RVA = "0x4894E0", Offset = "0x487CE0", Length = "0xC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6003BB1")]
	[Address(RVA = "0x746990", Offset = "0x745190", Length = "0x4C")]
	public PlayPopuper(Popup p, System.Action callback = null)
	{
	}

	[Token(Token = "0x6003BB2")]
	[Address(RVA = "0x7468D0", Offset = "0x7450D0", Length = "0xBB")]
	public void Exit(System.Action callback = null)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Nice.Actions;
using Cpp2ILInjected;

namespace Assets.Scripts.UI.Components.NiceReplacement;

[Token(Token = "0x20008C1")]
public class PeroPlayPopuper : PlayPopuper
{
	[Token(Token = "0x4002DBF")]
	[FieldOffset(Offset = "0x28")]
	private readonly System.Action m_EndCallback;

	[Token(Token = "0x17000888")]
	public ReplacedPopup peroPopup
	{
		[Token(Token = "0x6004EFF")]
		[CompilerGenerated]
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6004EFE")]
		[Address(RVA = "0x483E40", Offset = "0x482640", Length = "0xC")]
		private set
		{
		}
	}

	[Token(Token = "0x6004F00")]
	[Address(RVA = "0x5B1470", Offset = "0x5AFC70", Length = "0x33")]
	public PeroPlayPopuper(ReplacedPopup p, System.Action callback = null)
		: base(null)
	{
	}
}

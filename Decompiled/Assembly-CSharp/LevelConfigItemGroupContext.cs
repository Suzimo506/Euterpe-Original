using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.Database;
using Assets.Scripts.UI.Panels;
using Cpp2ILInjected;
using FancyScrollView;

[Token(Token = "0x2000149")]
public class LevelConfigItemGroupContext : FancyGridViewContext
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40007FB")]
	public PnlLevelConfig pnlLevelConfig;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40007FC")]
	private DBConfigElfin m_ConfigElfin;

	[Token(Token = "0x40007FD")]
	[FieldOffset(Offset = "0x50")]
	public Action<int> onCellClicked;

	[Token(Token = "0x40007FE")]
	[FieldOffset(Offset = "0x58")]
	public Action<int> onCellSelect;

	[Token(Token = "0x170000B9")]
	public int CurrentSelectedRoleIndex
	{
		[CompilerGenerated]
		[Token(Token = "0x6000941")]
		[Address(RVA = "0x429C30", Offset = "0x428430", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000942")]
		[CompilerGenerated]
		[Address(RVA = "0x5D3350", Offset = "0x5D1B50", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x170000BA")]
	public int CurrentSelectedElfinIndex
	{
		[Address(RVA = "0x5D3330", Offset = "0x5D1B30", Length = "0x4")]
		[Token(Token = "0x6000943")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[Address(RVA = "0x5D3340", Offset = "0x5D1B40", Length = "0x4")]
		[Token(Token = "0x6000944")]
		set
		{
		}
	}

	[Token(Token = "0x6000945")]
	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	public LevelConfigItemGroupContext()
	{
	}
}

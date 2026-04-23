using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using GameCore.GameObjectLogics.GameObjectManager._2024FoolActivity;

namespace GameCore.GameObjectLogics.GameObjectManager;

[Token(Token = "0x2000470")]
public class FoolActivityManager
{
	[Token(Token = "0x400180E")]
	private static FoolActivityManager s_Instance;

	[Token(Token = "0x400180F")]
	[FieldOffset(Offset = "0x10")]
	private FoolActivityRoleManager m_RoleManager;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001810")]
	private FoolActivityUIManager m_UIManager;

	[Token(Token = "0x17000495")]
	public static FoolActivityManager Instance
	{
		[Address(RVA = "0x83F900", Offset = "0x83E100", Length = "0x1AE")]
		[Token(Token = "0x600331F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000496")]
	public FoolActivityRoleManager RoleManager
	{
		[Token(Token = "0x6003320")]
		[Address(RVA = "0x83FAB0", Offset = "0x83E2B0", Length = "0x69")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000497")]
	public FoolActivityUIManager UIManager
	{
		[Token(Token = "0x6003321")]
		[Address(RVA = "0x83FB20", Offset = "0x83E320", Length = "0x69")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000498")]
	public FoolActivityGirlManager GirlManager
	{
		[Token(Token = "0x6003322")]
		[CompilerGenerated]
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003323")]
		[Address(RVA = "0x483E40", Offset = "0x482640", Length = "0xC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000499")]
	public FoolActivityGameManager GameManager
	{
		[Address(RVA = "0x46EF20", Offset = "0x46D720", Length = "0x5")]
		[Token(Token = "0x6003324")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Address(RVA = "0x48F110", Offset = "0x48D910", Length = "0xC")]
		[Token(Token = "0x6003325")]
		private set
		{
		}
	}

	[Address(RVA = "0x83F630", Offset = "0x83DE30", Length = "0x13F")]
	[Token(Token = "0x6003326")]
	public static bool CheckIsSelectFoolEggMusic()
	{
		return default(bool);
	}

	[Token(Token = "0x6003327")]
	[Address(RVA = "0x83F890", Offset = "0x83E090", Length = "0x68")]
	public static void Release()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003328")]
	private FoolActivityManager()
	{
	}

	[Token(Token = "0x6003329")]
	[Address(RVA = "0x83F770", Offset = "0x83DF70", Length = "0x11A")]
	private void Init()
	{
	}

	[Token(Token = "0x600332A")]
	[Address(RVA = "0x83F770", Offset = "0x83DF70", Length = "0x11A")]
	private void CreateManagerInstances()
	{
	}
}

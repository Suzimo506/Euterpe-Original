using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Assets.Scripts.Managers;

[Token(Token = "0x2000975")]
public abstract class SteamAchievementManager
{
	[Token(Token = "0x40033D5")]
	[FieldOffset(Offset = "0x10")]
	protected Dictionary<int, SteamAchievementState> m_UnlockState;

	[Token(Token = "0x40033D7")]
	protected static SteamAchievementManager s_Instance;

	[Token(Token = "0x17000902")]
	public bool initialized
	{
		[CompilerGenerated]
		[Token(Token = "0x6005640")]
		[Address(RVA = "0x470810", Offset = "0x46F010", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Token(Token = "0x6005641")]
		[Address(RVA = "0x470820", Offset = "0x46F020", Length = "0x4")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000903")]
	public static SteamAchievementManager instance
	{
		[Token(Token = "0x6005642")]
		[Address(RVA = "0x933450", Offset = "0x931C50", Length = "0x35")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000904")]
	protected bool check_steam_initialized
	{
		[Address(RVA = "0x9333B0", Offset = "0x931BB0", Length = "0x94")]
		[Token(Token = "0x6005645")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6005643")]
	[Address(RVA = "0x91EA10", Offset = "0x91D210", Length = "0xAC")]
	public static T GetInstance<T>() where T : SteamAchievementManager
	{
		return null;
	}

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6005644")]
	public abstract void Init();

	[Address(RVA = "0x932F80", Offset = "0x931780", Length = "0x7E")]
	[Token(Token = "0x6005646")]
	protected bool IsHidden(string apiName)
	{
		return default(bool);
	}

	[Address(RVA = "0x933070", Offset = "0x931870", Length = "0x9E")]
	[Token(Token = "0x6005647")]
	public void SaveUserStat()
	{
	}

	[Token(Token = "0x6005648")]
	[Address(RVA = "0x0", Length = "0x0")]
	protected abstract void RefreshState();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6005649")]
	protected abstract string GetApiNameById(int id);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x600564A")]
	protected abstract string GetStateNameById(int id);

	[Address(RVA = "0x933220", Offset = "0x931A20", Length = "0x11A")]
	[Token(Token = "0x600564B")]
	public virtual bool SetSteamAchievement(int id, bool enable, bool force = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600564C")]
	[Address(RVA = "0x933110", Offset = "0x931910", Length = "0xDC")]
	public virtual void SetSteamAchievementValue(int id, int value)
	{
	}

	[Address(RVA = "0x933000", Offset = "0x931800", Length = "0x64")]
	[Token(Token = "0x600564D")]
	public bool ResetUserStatsData(bool clearAllAchievement)
	{
		return default(bool);
	}

	[Address(RVA = "0x9331F0", Offset = "0x9319F0", Length = "0x25")]
	[Token(Token = "0x600564E")]
	public void SetSteamAchievement(int id)
	{
	}

	[Address(RVA = "0x933070", Offset = "0x931870", Length = "0x9E")]
	[Token(Token = "0x600564F")]
	public void Save()
	{
	}

	[Address(RVA = "0x933340", Offset = "0x931B40", Length = "0x69")]
	[Token(Token = "0x6005650")]
	protected SteamAchievementManager()
	{
	}
}

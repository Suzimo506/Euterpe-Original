using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007F3")]
internal class DBConfigSteamAchievement : BaseDBConfigObject
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400298F")]
	private List<SteamAchievementInfo> m_Items;

	[Token(Token = "0x4002990")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<int, SteamAchievementInfo> m_Buffer;

	[Token(Token = "0x17000737")]
	protected List<SteamAchievementInfo> list
	{
		[Token(Token = "0x6004852")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004853")]
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		private set
		{
		}
	}

	[Token(Token = "0x6004854")]
	[Address(RVA = "0x6FF3E0", Offset = "0x6FDBE0", Length = "0x7A")]
	public DBConfigSteamAchievement()
	{
	}

	[Token(Token = "0x6004855")]
	[Address(RVA = "0x6FEF30", Offset = "0x6FD730", Length = "0x1BD")]
	public override void Deserialize(string str)
	{
	}

	[Token(Token = "0x6004856")]
	[Address(RVA = "0x6FF180", Offset = "0x6FD980", Length = "0x7E")]
	private bool GetAchievementInfo(int id, out SteamAchievementInfo result)
	{
		result = null;
		return default(bool);
	}

	[Address(RVA = "0x6FF0F0", Offset = "0x6FD8F0", Length = "0x8A")]
	[Token(Token = "0x6004857")]
	public string GetAPINameById(int id)
	{
		return null;
	}

	[Token(Token = "0x6004858")]
	[Address(RVA = "0x6FF2B0", Offset = "0x6FDAB0", Length = "0x8A")]
	public string GetStateNameById(int id)
	{
		return null;
	}

	[Token(Token = "0x6004859")]
	[Address(RVA = "0x6FF340", Offset = "0x6FDB40", Length = "0x9F")]
	public bool SetExInfo(int id, SteamAchievementExInfo info)
	{
		return default(bool);
	}

	[Token(Token = "0x600485A")]
	[Address(RVA = "0x6FF200", Offset = "0x6FDA00", Length = "0xA4")]
	public bool GetExInfo(int id, out SteamAchievementExInfo info)
	{
		System.Runtime.CompilerServices.Unsafe.As<SteamAchievementExInfo, @null>(ref info) = null;
		return default(bool);
	}
}

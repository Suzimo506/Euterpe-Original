using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200024B")]
public class IRailPlayerAchievementImpl : RailObject, IRailPlayerAchievement, IRailComponent
{
	[Token(Token = "0x60028B3")]
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	internal IRailPlayerAchievementImpl(IntPtr cPtr)
	{
	}

	[Token(Token = "0x60028B4")]
	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	~IRailPlayerAchievementImpl()
	{
	}

	[Address(RVA = "0x367EB0", Offset = "0x3666B0", Length = "0xEB")]
	[Token(Token = "0x60028B5")]
	public virtual RailID GetRailID()
	{
		return null;
	}

	[Token(Token = "0x60028B6")]
	[Address(RVA = "0x367490", Offset = "0x365C90", Length = "0xDD")]
	public virtual RailResult AsyncRequestAchievement(string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x367FA0", Offset = "0x3667A0", Length = "0x101")]
	[Token(Token = "0x60028B7")]
	public virtual RailResult HasAchieved(string name, out bool achieved)
	{
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref achieved) = null;
		return default(RailResult);
	}

	[Address(RVA = "0x367AB0", Offset = "0x3662B0", Length = "0x206")]
	[Token(Token = "0x60028B8")]
	public virtual RailResult GetAchievementInfo(string name, out string achievement_info)
	{
		achievement_info = null;
		return default(RailResult);
	}

	[Address(RVA = "0x367840", Offset = "0x366040", Length = "0x126")]
	[Token(Token = "0x60028B9")]
	public virtual RailResult AsyncTriggerAchievementProgress(string name, uint current_value, uint max_value, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60028BA")]
	[Address(RVA = "0x367650", Offset = "0x365E50", Length = "0xFD")]
	public virtual RailResult AsyncTriggerAchievementProgress(string name, uint current_value, uint max_value)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60028BB")]
	[Address(RVA = "0x367750", Offset = "0x365F50", Length = "0xED")]
	public virtual RailResult AsyncTriggerAchievementProgress(string name, uint current_value)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60028BC")]
	[Address(RVA = "0x3680B0", Offset = "0x3668B0", Length = "0xDD")]
	public virtual RailResult MakeAchievement(string name)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60028BD")]
	[Address(RVA = "0x367970", Offset = "0x366170", Length = "0xDD")]
	public virtual RailResult CancelAchievement(string name)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x367570", Offset = "0x365D70", Length = "0xDD")]
	[Token(Token = "0x60028BE")]
	public virtual RailResult AsyncStoreAchievement(string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x3681F0", Offset = "0x3669F0", Length = "0xB5")]
	[Token(Token = "0x60028BF")]
	public virtual RailResult ResetAllAchievements()
	{
		return default(RailResult);
	}

	[Address(RVA = "0x367CC0", Offset = "0x3664C0", Length = "0x18B")]
	[Token(Token = "0x60028C0")]
	public virtual RailResult GetAllAchievementsName(List<string> names)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60028C1")]
	[Address(RVA = "0x367E50", Offset = "0x366650", Length = "0x55")]
	public virtual ulong GetComponentVersion()
	{
		return default(ulong);
	}

	[Token(Token = "0x60028C2")]
	[Address(RVA = "0x368190", Offset = "0x366990", Length = "0x55")]
	public virtual void Release()
	{
	}
}

using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007EC")]
public class DBConfigStageAchievement : BaseDBConfigLocalObject<DBConfigLocalStageAchievement, LocalStageAchievementInfo>
{
	[Token(Token = "0x4002978")]
	[FieldOffset(Offset = "0x40")]
	private List<StageAchievementInfo> m_Items;

	[Token(Token = "0x17000724")]
	private List<StageAchievementInfo> m_List
	{
		[Token(Token = "0x6004830")]
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004831")]
		[Address(RVA = "0x6F4390", Offset = "0x6F2B90", Length = "0x36")]
		set
		{
		}
	}

	[Address(RVA = "0x6FEB90", Offset = "0x6FD390", Length = "0x9C")]
	[Token(Token = "0x600482F")]
	public DBConfigStageAchievement()
	{
		((BaseDBConfigLocalObject<, >)(object)this)._002Ector();
	}

	[Token(Token = "0x6004832")]
	[Address(RVA = "0x6FE8B0", Offset = "0x6FD0B0", Length = "0x100")]
	public override void Deserialize(string str)
	{
	}

	[Token(Token = "0x6004833")]
	[Address(RVA = "0x6FE9C0", Offset = "0x6FD1C0", Length = "0x46")]
	public StageAchievementInfo GetAchievementInfoByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x6004834")]
	[Address(RVA = "0x6FEA10", Offset = "0x6FD210", Length = "0x172")]
	public StageAchievementInfo GetAchievementInfoByMusicUid(string musicUid)
	{
		return null;
	}

	[Token(Token = "0x6004835")]
	[Address(RVA = "0x6FE880", Offset = "0x6FD080", Length = "0x2D")]
	public bool CheckHaveHideAchievement(string musicUid)
	{
		return default(bool);
	}
}

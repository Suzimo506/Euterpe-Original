using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007E9")]
public class DBConfigLocalStageAchievement : BaseDBConfigObject
{
	[Token(Token = "0x400296F")]
	[FieldOffset(Offset = "0x38")]
	private List<LocalStageAchievementInfo> m_Items;

	[Token(Token = "0x17000721")]
	private List<LocalStageAchievementInfo> m_List
	{
		[Token(Token = "0x6004823")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004824")]
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		set
		{
		}
	}

	[Token(Token = "0x6004825")]
	[Address(RVA = "0x6FD450", Offset = "0x6FBC50", Length = "0x100")]
	public override void Deserialize(string str)
	{
	}

	[Address(RVA = "0x6FD560", Offset = "0x6FBD60", Length = "0x5A")]
	[Token(Token = "0x6004826")]
	public LocalStageAchievementInfo GetLocalStageAchievementInfoByIndex(int index)
	{
		return null;
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6004827")]
	public DBConfigLocalStageAchievement()
	{
	}
}

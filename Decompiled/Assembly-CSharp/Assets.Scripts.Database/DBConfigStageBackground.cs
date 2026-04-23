using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007F0")]
public class DBConfigStageBackground : BaseDBConfigLocalObject<DBLocalizationConfigStageBackground, StageBackgroundLocalizationData>
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002988")]
	private List<StageBackgroundData> m_Items;

	[Token(Token = "0x17000735")]
	public List<StageBackgroundData> BgDatas
	{
		[Token(Token = "0x600484B")]
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000736")]
	protected List<StageBackgroundData> list
	{
		[Token(Token = "0x600484C")]
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x600484D")]
		[Address(RVA = "0x6F4390", Offset = "0x6F2B90", Length = "0x36")]
		set
		{
		}
	}

	[Token(Token = "0x600484E")]
	[Address(RVA = "0x6FED40", Offset = "0x6FD540", Length = "0x16E")]
	public StageBackgroundData GetStageBackgroundDataById(int bgId)
	{
		return null;
	}

	[Token(Token = "0x600484F")]
	[Address(RVA = "0x6FEEB0", Offset = "0x6FD6B0", Length = "0x7F")]
	public DBConfigStageBackground()
	{
		((BaseDBConfigLocalObject<, >)(object)this)._002Ector();
	}

	[Token(Token = "0x6004850")]
	[Address(RVA = "0x6FEC30", Offset = "0x6FD430", Length = "0x100")]
	public override void Deserialize(string str)
	{
	}
}

using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007EF")]
public class DBLocalizationConfigStageBackground : BaseDBConfigObject
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002987")]
	private List<StageBackgroundLocalizationData> m_Items;

	[Token(Token = "0x17000733")]
	public List<StageBackgroundLocalizationData> BgLocalDatas
	{
		[Token(Token = "0x6004846")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000734")]
	protected List<StageBackgroundLocalizationData> list
	{
		[Token(Token = "0x6004847")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		[Token(Token = "0x6004848")]
		set
		{
		}
	}

	[Address(RVA = "0x1028560", Offset = "0x1026D60", Length = "0x7A")]
	[Token(Token = "0x6004849")]
	public DBLocalizationConfigStageBackground()
	{
	}

	[Token(Token = "0x600484A")]
	[Address(RVA = "0x1028450", Offset = "0x1026C50", Length = "0x100")]
	public override void Deserialize(string str)
	{
	}
}

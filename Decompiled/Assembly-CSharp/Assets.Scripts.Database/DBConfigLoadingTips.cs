using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007E0")]
public class DBConfigLoadingTips : BaseDBConfigLocalObject<DBConfigLocalLoadingTips, LocalLoadingTipsInfo>
{
	[Token(Token = "0x400295B")]
	[FieldOffset(Offset = "0x40")]
	private List<LoadingTipsInfo> m_Items;

	[Token(Token = "0x1700071A")]
	protected List<LoadingTipsInfo> list
	{
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		[Token(Token = "0x6004802")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004803")]
		[Address(RVA = "0x6F4390", Offset = "0x6F2B90", Length = "0x36")]
		set
		{
		}
	}

	[Address(RVA = "0x6FAA50", Offset = "0x6F9250", Length = "0x9C")]
	[Token(Token = "0x6004804")]
	public DBConfigLoadingTips()
	{
		((BaseDBConfigLocalObject<, >)(object)this)._002Ector();
	}

	[Token(Token = "0x6004805")]
	[Address(RVA = "0x6FA940", Offset = "0x6F9140", Length = "0x100")]
	public override void Deserialize(string str)
	{
	}
}

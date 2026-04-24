using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007D8")]
public class DBConfigHideMusicTip : BaseDBConfigLocalObject<DBConfigLocalHideMusicTip, KeyValuePair<string, string>>
{
	[Token(Token = "0x60047DF")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public override void Deserialize(string str)
	{
	}

	[Token(Token = "0x60047E0")]
	[Address(RVA = "0x6FA700", Offset = "0x6F8F00", Length = "0x38")]
	public DBConfigHideMusicTip()
	{
		((BaseDBConfigLocalObject<, >)(object)this)._002Ector();
	}
}

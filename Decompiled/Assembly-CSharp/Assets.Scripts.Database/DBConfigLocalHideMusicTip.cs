using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007D7")]
public class DBConfigLocalHideMusicTip : BaseDBConfigObject
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002939")]
	private Dictionary<string, string> m_HideTips;

	[Token(Token = "0x60047DC")]
	[Address(RVA = "0x6FCEF0", Offset = "0x6FB6F0", Length = "0x66")]
	public string GetHideTipsByMusicUid(string musicUid)
	{
		return null;
	}

	[Token(Token = "0x60047DD")]
	[Address(RVA = "0x6FCE70", Offset = "0x6FB670", Length = "0x71")]
	public override void Deserialize(string str)
	{
	}

	[Token(Token = "0x60047DE")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public DBConfigLocalHideMusicTip()
	{
	}
}

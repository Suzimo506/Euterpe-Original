using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007FC")]
public class DBConfigUILocalization : BaseDBConfigLocalObject<DBConfigLocalUILocalization, LocalUILocalizationInfo>
{
	[Token(Token = "0x40029A2")]
	[FieldOffset(Offset = "0x40")]
	private StringBuilder m_StringBuilder;

	[Address(RVA = "0x6FFBE0", Offset = "0x6FE3E0", Length = "0x7F")]
	[Token(Token = "0x6004875")]
	public static string GetLocalization(string key, List<string> args = null)
	{
		return null;
	}

	[Address(RVA = "0x6FF9F0", Offset = "0x6FE1F0", Length = "0x1E0")]
	[Token(Token = "0x6004876")]
	public string GetLocalization(string key, int langIndex, List<string> args = null)
	{
		return null;
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6004877")]
	public override void Deserialize(string str)
	{
	}

	[Address(RVA = "0x6FFC60", Offset = "0x6FE460", Length = "0x69")]
	[Token(Token = "0x6004878")]
	public DBConfigUILocalization()
	{
		((BaseDBConfigLocalObject<, >)(object)this)._002Ector();
	}
}

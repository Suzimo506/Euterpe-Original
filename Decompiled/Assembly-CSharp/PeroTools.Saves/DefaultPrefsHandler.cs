using Cpp2ILInjected;

namespace PeroTools.Saves;

[Token(Token = "0x2000442")]
public class DefaultPrefsHandler : PrefsHandler
{
	[Address(RVA = "0x4F3970", Offset = "0x4F2170", Length = "0x11")]
	[Token(Token = "0x6003255")]
	public override void SaveString(string key, string s)
	{
	}

	[Address(RVA = "0x4F3960", Offset = "0x4F2160", Length = "0xA")]
	[Token(Token = "0x6003256")]
	public override string GetString(string key)
	{
		return null;
	}

	[Token(Token = "0x6003257")]
	[Address(RVA = "0x4F3950", Offset = "0x4F2150", Length = "0xA")]
	public override void Delete(string key)
	{
	}

	[Address(RVA = "0x4F3990", Offset = "0x4F2190", Length = "0x7")]
	[Token(Token = "0x6003258")]
	public override void Save()
	{
	}

	[Token(Token = "0x6003259")]
	[Address(RVA = "0x4F3940", Offset = "0x4F2140", Length = "0x7")]
	public override void ClearAllPrefs()
	{
	}

	[Token(Token = "0x600325A")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public DefaultPrefsHandler()
	{
	}
}

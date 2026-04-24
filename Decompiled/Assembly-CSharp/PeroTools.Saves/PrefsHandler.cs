using Cpp2ILInjected;

namespace PeroTools.Saves;

[Token(Token = "0x2000441")]
public abstract class PrefsHandler
{
	[Token(Token = "0x600324F")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract void SaveString(string key, string s);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6003250")]
	public abstract string GetString(string key);

	[Token(Token = "0x6003251")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract void Delete(string key);

	[Token(Token = "0x6003252")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract void Save();

	[Token(Token = "0x6003253")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract void ClearAllPrefs();

	[Token(Token = "0x6003254")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	protected PrefsHandler()
	{
	}
}

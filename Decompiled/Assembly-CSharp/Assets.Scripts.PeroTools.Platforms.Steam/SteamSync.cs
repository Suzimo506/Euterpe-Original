using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Platforms.Steam;

[Token(Token = "0x20005BE")]
public class SteamSync : ISync
{
	[Token(Token = "0x4002175")]
	[FieldOffset(Offset = "0x10")]
	private string m_FolderPath;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002176")]
	private string m_FileName;

	[Token(Token = "0x4002177")]
	[FieldOffset(Offset = "0x20")]
	private string m_FilePath;

	[Token(Token = "0x600397D")]
	[Address(RVA = "0x985130", Offset = "0x983930", Length = "0xD8")]
	public SteamSync()
	{
	}

	[Token(Token = "0x600397E")]
	[Address(RVA = "0x984D50", Offset = "0x983550", Length = "0xBA")]
	public void LoadLocal()
	{
	}

	[Token(Token = "0x600397F")]
	[Address(RVA = "0x984F50", Offset = "0x983750", Length = "0x1D5")]
	public void SaveLocal()
	{
	}

	[Address(RVA = "0x984E10", Offset = "0x983610", Length = "0x135")]
	[Token(Token = "0x6003980")]
	private void RemoveFile()
	{
	}

	[Token(Token = "0x6003981")]
	[Address(RVA = "0x984C50", Offset = "0x983450", Length = "0xFF")]
	private void DeleteRegedit()
	{
	}
}

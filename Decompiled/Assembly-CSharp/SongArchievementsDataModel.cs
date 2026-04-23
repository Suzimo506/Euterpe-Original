using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000023")]
public class SongArchievementsDataModel : DataModel
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000A1")]
	private Dictionary<string, List<string>> m_CompleteArchiDic;

	[Token(Token = "0x1700001F")]
	public Dictionary<string, List<string>> CompleteArchiDic
	{
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x62FCA0", Offset = "0x62E4A0", Length = "0x264")]
	public void RefreshArchievementsData()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	public SongArchievementsDataModel()
	{
	}
}

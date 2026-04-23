using Cpp2ILInjected;
using Newtonsoft.Json;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007EE")]
public class StageBackgroundLocalizationData : BaseDataObject
{
	[JsonProperty]
	[Token(Token = "0x4002984")]
	[FieldOffset(Offset = "0x20")]
	private string m_ID;

	[JsonProperty]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002985")]
	private string m_BgName;

	[FieldOffset(Offset = "0x30")]
	[JsonProperty]
	[Token(Token = "0x4002986")]
	private string m_BgDescription;

	[Token(Token = "0x17000730")]
	public int Id
	{
		[Token(Token = "0x6004842")]
		[Address(RVA = "0x4A4F70", Offset = "0x4A3770", Length = "0xB")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000731")]
	public string BgName
	{
		[Address(RVA = "0x46EF20", Offset = "0x46D720", Length = "0x5")]
		[Token(Token = "0x6004843")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000732")]
	public string BgDescription
	{
		[Token(Token = "0x6004844")]
		[Address(RVA = "0x45EEE0", Offset = "0x45D6E0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004845")]
	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	public StageBackgroundLocalizationData()
	{
	}
}

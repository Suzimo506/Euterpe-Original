using Cpp2ILInjected;
using Newtonsoft.Json;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007B4")]
public class DaveFishLocalizationData : BaseDataObject
{
	[Token(Token = "0x40028AA")]
	[JsonProperty]
	[FieldOffset(Offset = "0x20")]
	private int m_Uid;

	[Token(Token = "0x40028AB")]
	[JsonProperty]
	[FieldOffset(Offset = "0x28")]
	private string m_Name;

	[FieldOffset(Offset = "0x30")]
	[JsonProperty]
	[Token(Token = "0x40028AC")]
	private string m_Tips;

	[Token(Token = "0x170006D6")]
	public int Uid
	{
		[Token(Token = "0x6004743")]
		[Address(RVA = "0x42D1E0", Offset = "0x42B9E0", Length = "0x4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006D7")]
	public string Name
	{
		[Token(Token = "0x6004744")]
		[Address(RVA = "0x46EF20", Offset = "0x46D720", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006D8")]
	public string Tips
	{
		[Token(Token = "0x6004745")]
		[Address(RVA = "0x45EEE0", Offset = "0x45D6E0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	[Token(Token = "0x6004746")]
	public DaveFishLocalizationData()
	{
	}
}

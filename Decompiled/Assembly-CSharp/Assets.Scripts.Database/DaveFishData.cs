using Cpp2ILInjected;
using Newtonsoft.Json;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007B2")]
public class DaveFishData : BaseDataObject
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40028A4")]
	[JsonProperty]
	private int m_Uid;

	[FieldOffset(Offset = "0x24")]
	[JsonProperty]
	[Token(Token = "0x40028A5")]
	private int m_Quality;

	[Token(Token = "0x40028A6")]
	[JsonProperty]
	[FieldOffset(Offset = "0x28")]
	private float m_Probability;

	[JsonProperty]
	[Token(Token = "0x40028A7")]
	[FieldOffset(Offset = "0x30")]
	private string m_ChipName;

	[JsonProperty]
	[Token(Token = "0x40028A8")]
	[FieldOffset(Offset = "0x38")]
	private int m_Exp;

	[Token(Token = "0x170006CF")]
	public int Uid
	{
		[Address(RVA = "0x42D1E0", Offset = "0x42B9E0", Length = "0x4")]
		[Token(Token = "0x6004738")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006D0")]
	public DaveFishQuality Quality
	{
		[Token(Token = "0x6004739")]
		[Address(RVA = "0x42D1F0", Offset = "0x42B9F0", Length = "0x4")]
		get
		{
			return default(DaveFishQuality);
		}
	}

	[Token(Token = "0x170006D1")]
	public float Probability
	{
		[Token(Token = "0x600473A")]
		[Address(RVA = "0x73BB00", Offset = "0x73A300", Length = "0x6")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170006D2")]
	public string ChipName
	{
		[Token(Token = "0x600473B")]
		[Address(RVA = "0x45EEE0", Offset = "0x45D6E0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006D3")]
	public int Exp
	{
		[Token(Token = "0x600473C")]
		[Address(RVA = "0x596FF0", Offset = "0x5957F0", Length = "0x4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600473D")]
	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	public DaveFishData()
	{
	}
}

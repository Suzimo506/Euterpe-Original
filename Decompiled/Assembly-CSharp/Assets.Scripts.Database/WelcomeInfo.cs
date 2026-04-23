using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000804")]
public class WelcomeInfo : BaseDataObject
{
	[Token(Token = "0x40029C1")]
	[FieldOffset(Offset = "0x20")]
	public string chipImage;

	[Token(Token = "0x40029C2")]
	[FieldOffset(Offset = "0x28")]
	public string chipName;

	[Token(Token = "0x40029C3")]
	[FieldOffset(Offset = "0x30")]
	public string image;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40029C4")]
	public int chipAmount;

	[Token(Token = "0x40029C5")]
	[FieldOffset(Offset = "0x40")]
	public string chipDescription;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40029C6")]
	public string artist1;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40029C7")]
	public string homepage1;

	[Token(Token = "0x40029C8")]
	[FieldOffset(Offset = "0x58")]
	public string artist2;

	[Token(Token = "0x40029C9")]
	[FieldOffset(Offset = "0x60")]
	public string homepage2;

	[Token(Token = "0x40029CA")]
	[FieldOffset(Offset = "0x68")]
	public bool free;

	[Token(Token = "0x40029CB")]
	[FieldOffset(Offset = "0x69")]
	public bool hide;

	[Token(Token = "0x40029CC")]
	[FieldOffset(Offset = "0x6A")]
	public bool egg;

	[FieldOffset(Offset = "0x6B")]
	[Token(Token = "0x40029CD")]
	public bool hexie;

	[Token(Token = "0x40029CE")]
	[FieldOffset(Offset = "0x6C")]
	public bool exchange;

	[FieldOffset(Offset = "0x6D")]
	[Token(Token = "0x40029CF")]
	public bool special;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40029D0")]
	public int nsArtShowNum;

	[Token(Token = "0x17000741")]
	public string getArtist1
	{
		[Address(RVA = "0x4AC060", Offset = "0x4AA860", Length = "0xB6")]
		[Token(Token = "0x6004896")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000742")]
	public string getArtist2
	{
		[Token(Token = "0x6004897")]
		[Address(RVA = "0x4AC120", Offset = "0x4AA920", Length = "0xB6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000743")]
	public string getHomepage1
	{
		[Token(Token = "0x6004898")]
		[Address(RVA = "0x4AC1E0", Offset = "0x4AA9E0", Length = "0xB6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000744")]
	public string getHomepage2
	{
		[Address(RVA = "0x4AC2A0", Offset = "0x4AAAA0", Length = "0xB6")]
		[Token(Token = "0x6004899")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600489A")]
	[Address(RVA = "0x4AC050", Offset = "0x4AA850", Length = "0xE")]
	public WelcomeInfo()
	{
	}
}

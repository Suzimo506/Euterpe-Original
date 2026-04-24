using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007D9")]
public class LoadingInfo : BaseDataObject
{
	[Token(Token = "0x400293A")]
	[FieldOffset(Offset = "0x20")]
	public string chipImage;

	[Token(Token = "0x400293B")]
	[FieldOffset(Offset = "0x28")]
	public string chipName;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400293C")]
	public string image;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400293D")]
	public string hexieImage;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400293E")]
	public int chipAmount;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400293F")]
	public string chipDescription;

	[Token(Token = "0x4002940")]
	[FieldOffset(Offset = "0x50")]
	public string artist1;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002941")]
	public string homepage1;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002942")]
	public string artist2;

	[Token(Token = "0x4002943")]
	[FieldOffset(Offset = "0x68")]
	public string homepage2;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4002944")]
	public string artist3;

	[Token(Token = "0x4002945")]
	[FieldOffset(Offset = "0x78")]
	public string homepage3;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4002946")]
	public bool free;

	[FieldOffset(Offset = "0x81")]
	[Token(Token = "0x4002947")]
	public bool hide;

	[Token(Token = "0x4002948")]
	[FieldOffset(Offset = "0x82")]
	public bool egg;

	[FieldOffset(Offset = "0x83")]
	[Token(Token = "0x4002949")]
	public bool exchange;

	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x400294A")]
	public int adaptation;

	[Token(Token = "0x400294B")]
	[FieldOffset(Offset = "0x88")]
	public bool special;

	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x400294C")]
	public int nsArtShowNum;

	[Token(Token = "0x1700070F")]
	public string getImageName
	{
		[Address(RVA = "0x49FDD0", Offset = "0x49E5D0", Length = "0xCD")]
		[Token(Token = "0x60047E1")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000710")]
	public string getArtist1
	{
		[Token(Token = "0x60047E2")]
		[Address(RVA = "0x49F950", Offset = "0x49E150", Length = "0xB6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000711")]
	public string getArtist2
	{
		[Token(Token = "0x60047E3")]
		[Address(RVA = "0x49FA10", Offset = "0x49E210", Length = "0xB6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000712")]
	public string getHomepage1
	{
		[Token(Token = "0x60047E4")]
		[Address(RVA = "0x49FB90", Offset = "0x49E390", Length = "0xB6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000713")]
	public string getHomepage2
	{
		[Token(Token = "0x60047E5")]
		[Address(RVA = "0x49FC50", Offset = "0x49E450", Length = "0xB6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000714")]
	public string getArtist3
	{
		[Address(RVA = "0x49FAD0", Offset = "0x49E2D0", Length = "0xB6")]
		[Token(Token = "0x60047E6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000715")]
	public string getHomepage3
	{
		[Token(Token = "0x60047E7")]
		[Address(RVA = "0x49FD10", Offset = "0x49E510", Length = "0xB6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60047E8")]
	[Address(RVA = "0x49F930", Offset = "0x49E130", Length = "0x11")]
	public LoadingInfo()
	{
	}
}

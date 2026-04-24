using Cpp2ILInjected;
using Newtonsoft.Json;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007ED")]
public class StageBackgroundData : BaseDataObject
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002979")]
	[JsonProperty]
	private string m_ID;

	[JsonProperty]
	[Token(Token = "0x400297A")]
	[FieldOffset(Offset = "0x28")]
	private string m_BgAssetName;

	[JsonProperty]
	[Token(Token = "0x400297B")]
	[FieldOffset(Offset = "0x30")]
	private string m_BgPreviewImgAssetName;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400297C")]
	[JsonProperty]
	private string m_BgBindPackage;

	[JsonProperty]
	[Token(Token = "0x400297D")]
	[FieldOffset(Offset = "0x40")]
	private string m_BgOrder;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400297E")]
	[JsonProperty]
	private string m_IsAllowShow;

	[JsonProperty]
	[Token(Token = "0x400297F")]
	[FieldOffset(Offset = "0x50")]
	private string m_IsExchange;

	[Token(Token = "0x4002980")]
	[JsonProperty]
	[FieldOffset(Offset = "0x58")]
	private string m_IsHexie;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002981")]
	[JsonProperty]
	private string m_BgStageMeshAssetName;

	[Token(Token = "0x4002982")]
	[FieldOffset(Offset = "0x68")]
	[JsonProperty]
	private string m_BgAchCard;

	[JsonProperty]
	[Token(Token = "0x4002983")]
	[FieldOffset(Offset = "0x70")]
	private string m_BgAchBg;

	[Token(Token = "0x17000725")]
	public int Id
	{
		[Token(Token = "0x6004836")]
		[Address(RVA = "0x4A4F70", Offset = "0x4A3770", Length = "0xB")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000726")]
	public string BgAssetName
	{
		[Token(Token = "0x6004837")]
		[Address(RVA = "0x46EF20", Offset = "0x46D720", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000727")]
	public string PreviewImgName
	{
		[Token(Token = "0x6004838")]
		[Address(RVA = "0x45EEE0", Offset = "0x45D6E0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000728")]
	public string BindMusicPackage
	{
		[Token(Token = "0x6004839")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000729")]
	public int BgOrder
	{
		[Token(Token = "0x600483A")]
		[Address(RVA = "0x4A4F60", Offset = "0x4A3760", Length = "0xB")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700072A")]
	public bool IsAllowShow
	{
		[Token(Token = "0x600483B")]
		[Address(RVA = "0x4A4F80", Offset = "0x4A3780", Length = "0x55")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700072B")]
	public bool IsExchange
	{
		[Address(RVA = "0x4A4FE0", Offset = "0x4A37E0", Length = "0x55")]
		[Token(Token = "0x600483C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700072C")]
	public bool IsHexie
	{
		[Address(RVA = "0x4A5040", Offset = "0x4A3840", Length = "0x55")]
		[Token(Token = "0x600483D")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700072D")]
	public string BgStageMeshAssetName
	{
		[Token(Token = "0x600483E")]
		[Address(RVA = "0x4293D0", Offset = "0x427BD0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700072E")]
	public string BgAchCard
	{
		[Token(Token = "0x600483F")]
		[Address(RVA = "0x4293C0", Offset = "0x427BC0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700072F")]
	public string BgAchBg
	{
		[Token(Token = "0x6004840")]
		[Address(RVA = "0x462D00", Offset = "0x461500", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004841")]
	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	public StageBackgroundData()
	{
	}
}

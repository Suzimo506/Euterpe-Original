using System;
using Assets.Scripts.Structs;
using Assets.Scripts.Structs.PnlDlc;
using Cpp2ILInjected;
using Newtonsoft.Json;
using UnityEngine;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007C0")]
public class DlcUIExtensionInfo : BaseDataObject
{
	[Token(Token = "0x40028D1")]
	public static readonly Vector2 default_dlc_cell_size;

	[Token(Token = "0x40028D2")]
	public static readonly Vector2 default_imgbase_size;

	[Token(Token = "0x40028D3")]
	public const string default_dlc_bg_img = "DlcBase";

	[Token(Token = "0x40028D4")]
	public const string default_dlc_song_cell_bg = "CoverBaseFixed";

	[Token(Token = "0x40028D5")]
	public const float default_layout_spacing = 20f;

	[Token(Token = "0x40028D6")]
	[JsonProperty]
	[FieldOffset(Offset = "0x20")]
	private int jsonIndex;

	[Token(Token = "0x40028D7")]
	[JsonProperty]
	[FieldOffset(Offset = "0x28")]
	private string baseDlcImg;

	[Token(Token = "0x40028D8")]
	[JsonProperty]
	[FieldOffset(Offset = "0x30")]
	private Color baseDlcImgColor;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40028D9")]
	[JsonProperty]
	private string baseDlcSongCellBg;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40028DA")]
	[JsonProperty]
	private Color baseDlcSongCellBgColor;

	[JsonProperty]
	[Token(Token = "0x40028DB")]
	[FieldOffset(Offset = "0x58")]
	private string billboardBgImg;

	[Token(Token = "0x40028DC")]
	[JsonProperty]
	[FieldOffset(Offset = "0x60")]
	private Color billboardBgColor;

	[JsonProperty]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40028DD")]
	private string billboard2BgImg;

	[Token(Token = "0x40028DE")]
	[JsonProperty]
	[FieldOffset(Offset = "0x78")]
	private Color billboardBg2Color;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40028DF")]
	[JsonProperty]
	private Vector2 dlcCountdownPosition;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40028E0")]
	[JsonProperty]
	private Vector2 dlcCountDownTxtPadding;

	[JsonProperty]
	[Token(Token = "0x40028E1")]
	[FieldOffset(Offset = "0x98")]
	private string dlcCountDownBaseImg;

	[Token(Token = "0x40028E2")]
	[FieldOffset(Offset = "0xA0")]
	public DateTime dlcEndTime;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40028E3")]
	[JsonProperty]
	private Vector2 baseDlcSize;

	[Token(Token = "0x40028E4")]
	[JsonProperty]
	[FieldOffset(Offset = "0xB0")]
	private LayoutPaddingArgs paddingLRTB;

	[JsonProperty]
	[Token(Token = "0x40028E5")]
	[FieldOffset(Offset = "0xC0")]
	private float layoutSpacing;

	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x40028E6")]
	[JsonProperty]
	private PnlDlcShopArgs normal;

	[JsonProperty]
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40028E7")]
	private PnlDlcShopArgs fourToThree;

	[Token(Token = "0x170006E6")]
	public static Color default_dlc_bg_color
	{
		[Address(RVA = "0x103D400", Offset = "0x103BC00", Length = "0x47")]
		[Token(Token = "0x6004774")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x170006E7")]
	public static Color default_dlc_song_cell_bg_color
	{
		[Token(Token = "0x6004775")]
		[Address(RVA = "0x103D3D0", Offset = "0x103BBD0", Length = "0x24")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x170006E8")]
	public static string default_billboard_bg_img
	{
		[Token(Token = "0x6004776")]
		[Address(RVA = "0x103D3A0", Offset = "0x103BBA0", Length = "0x2B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006E9")]
	public static Color default_billboard_bg_color
	{
		[Token(Token = "0x6004777")]
		[Address(RVA = "0x103D310", Offset = "0x103BB10", Length = "0x8F")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x170006EA")]
	public static Color default_countdown_color
	{
		[Token(Token = "0x6004778")]
		[Address(RVA = "0x103D3D0", Offset = "0x103BBD0", Length = "0x24")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x170006EB")]
	public static Vector2 default_size
	{
		[Token(Token = "0x6004779")]
		[Address(RVA = "0x103D490", Offset = "0x103BC90", Length = "0x32")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x170006EC")]
	public static LayoutPaddingArgs default_padding
	{
		[Token(Token = "0x600477A")]
		[Address(RVA = "0x103D450", Offset = "0x103BC50", Length = "0x31")]
		get
		{
			return default(LayoutPaddingArgs);
		}
	}

	[Token(Token = "0x170006ED")]
	[JsonIgnore]
	public int getJsonIndex
	{
		[Address(RVA = "0x42D1E0", Offset = "0x42B9E0", Length = "0x4")]
		[Token(Token = "0x600477B")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006EE")]
	[JsonIgnore]
	public float mainScale
	{
		[Address(RVA = "0x103DC70", Offset = "0x103C470", Length = "0xB7")]
		[Token(Token = "0x600477C")]
		get
		{
			return default(float);
		}
	}

	[JsonIgnore]
	[Token(Token = "0x170006EF")]
	public Vector2 getDlcCountdownPosition
	{
		[Token(Token = "0x600477D")]
		[Address(RVA = "0x103DB40", Offset = "0x103C340", Length = "0x19")]
		get
		{
			return default(Vector2);
		}
	}

	[JsonIgnore]
	[Token(Token = "0x170006F0")]
	public Vector2 getDlcCountdownTxtPadding
	{
		[Address(RVA = "0x103DB60", Offset = "0x103C360", Length = "0x19")]
		[Token(Token = "0x600477E")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x170006F1")]
	[JsonIgnore]
	public string getDlcCountDownBaseImg
	{
		[Address(RVA = "0x49A8B0", Offset = "0x4990B0", Length = "0x8")]
		[Token(Token = "0x600477F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006F2")]
	[JsonIgnore]
	public DateTime getDlcEndTime
	{
		[Address(RVA = "0x48E690", Offset = "0x48CE90", Length = "0x8")]
		[Token(Token = "0x6004780")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x170006F3")]
	public Vector2 getBaseDlcSize
	{
		[Address(RVA = "0x103D600", Offset = "0x103BE00", Length = "0xDE")]
		[Token(Token = "0x6004781")]
		get
		{
			return default(Vector2);
		}
	}

	[JsonIgnore]
	[Token(Token = "0x170006F4")]
	public string getBaseDlcImg
	{
		[Token(Token = "0x6004782")]
		[Address(RVA = "0x103D5B0", Offset = "0x103BDB0", Length = "0x4A")]
		get
		{
			return null;
		}
	}

	[JsonIgnore]
	[Token(Token = "0x170006F5")]
	public Color getBaseDlcImgColor
	{
		[Token(Token = "0x6004783")]
		[Address(RVA = "0x103D4D0", Offset = "0x103BCD0", Length = "0xD8")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x170006F6")]
	public string getBaseDlcSongCellBg
	{
		[Token(Token = "0x6004784")]
		[Address(RVA = "0x103D790", Offset = "0x103BF90", Length = "0x4A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006F7")]
	public Color getBaseDlcSongCellBgColor
	{
		[Address(RVA = "0x103D6E0", Offset = "0x103BEE0", Length = "0xA6")]
		[Token(Token = "0x6004785")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x170006F8")]
	[JsonIgnore]
	public string getBillboardBgImg
	{
		[Token(Token = "0x6004786")]
		[Address(RVA = "0x103DAB0", Offset = "0x103C2B0", Length = "0x83")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006F9")]
	[JsonIgnore]
	public string getBillboard2BgImg
	{
		[Token(Token = "0x6004787")]
		[Address(RVA = "0x103DA20", Offset = "0x103C220", Length = "0x83")]
		get
		{
			return null;
		}
	}

	[JsonIgnore]
	[Token(Token = "0x170006FA")]
	public Color getBillBoardBgColor
	{
		[Address(RVA = "0x103D900", Offset = "0x103C100", Length = "0x118")]
		[Token(Token = "0x6004788")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x170006FB")]
	[JsonIgnore]
	public Color getBillBoard2BgColor
	{
		[Token(Token = "0x6004789")]
		[Address(RVA = "0x103D7E0", Offset = "0x103BFE0", Length = "0x118")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x170006FC")]
	[JsonIgnore]
	public LayoutPaddingArgs getPaddingLRTB
	{
		[Token(Token = "0x600478A")]
		[Address(RVA = "0x103DBA0", Offset = "0x103C3A0", Length = "0xC8")]
		get
		{
			return default(LayoutPaddingArgs);
		}
	}

	[Token(Token = "0x170006FD")]
	[JsonIgnore]
	public float getLayoutSpacing
	{
		[Token(Token = "0x600478B")]
		[Address(RVA = "0x103DB80", Offset = "0x103C380", Length = "0x1F")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600478C")]
	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	public DlcUIExtensionInfo()
	{
	}
}

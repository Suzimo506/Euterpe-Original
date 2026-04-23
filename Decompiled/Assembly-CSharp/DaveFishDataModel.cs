using System.Collections.Generic;
using Assets.Scripts.Database;
using Cpp2ILInjected;

[Token(Token = "0x20001A4")]
public class DaveFishDataModel : DataModel
{
	[Token(Token = "0x4000A49")]
	private const string cache_key = "DaveFishData";

	[Token(Token = "0x4000A4A")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, DaveFishCachedData> m_PlayerCachedData;

	[Token(Token = "0x4000A4B")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<int, DaveFishData> m_Config;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A4C")]
	private Dictionary<int, DaveFishLocalizationData> m_LocalizationData;

	[Token(Token = "0x170000E4")]
	public Dictionary<int, DaveFishCachedData> PlayerCachedData
	{
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		[Token(Token = "0x6000BDD")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000E5")]
	public Dictionary<int, DaveFishData> Config
	{
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		[Token(Token = "0x6000BDE")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000E6")]
	public Dictionary<int, DaveFishLocalizationData> LocalizationData
	{
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		[Token(Token = "0x6000BDF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000BE0")]
	[Address(RVA = "0x46D440", Offset = "0x46BC40", Length = "0x18E")]
	public override void Init()
	{
	}

	[Address(RVA = "0x46D8D0", Offset = "0x46C0D0", Length = "0x197")]
	[Token(Token = "0x6000BE1")]
	public void RefreshLocalizedData()
	{
	}

	[Address(RVA = "0x46D6B0", Offset = "0x46BEB0", Length = "0x217")]
	[Token(Token = "0x6000BE2")]
	public void LoadFishCacheData()
	{
	}

	[Address(RVA = "0x46DA70", Offset = "0x46C270", Length = "0x138")]
	[Token(Token = "0x6000BE3")]
	public void SaveFishCacheData()
	{
	}

	[Token(Token = "0x6000BE4")]
	[Address(RVA = "0x46D3E0", Offset = "0x46BBE0", Length = "0x5F")]
	public void ClearFishCacheData()
	{
	}

	[Address(RVA = "0x46D2D0", Offset = "0x46BAD0", Length = "0x101")]
	[Token(Token = "0x6000BE5")]
	public void ChangeFishItemCount(int fishUid, int fishCount)
	{
	}

	[Token(Token = "0x6000BE6")]
	[Address(RVA = "0x46D650", Offset = "0x46BE50", Length = "0x50")]
	public bool IsUnlockFish(int fishUid)
	{
		return default(bool);
	}

	[Address(RVA = "0x46D5D0", Offset = "0x46BDD0", Length = "0x74")]
	[Token(Token = "0x6000BE7")]
	public bool IsUnlockFishAll()
	{
		return default(bool);
	}

	[Token(Token = "0x6000BE8")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public DaveFishDataModel()
	{
	}
}

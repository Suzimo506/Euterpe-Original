using System;
using System.Collections.Generic;
using Assets.Scripts.Database;
using Cpp2ILInjected;

namespace Assets.Scripts.UI.StageBackground;

[Token(Token = "0x2000835")]
public class StageBackgroundDataManager
{
	[Token(Token = "0x4002ABE")]
	public static readonly int default_bg_id;

	[Token(Token = "0x4002ABF")]
	private static List<StageBackgroundData> m_BgDatas;

	[Token(Token = "0x4002AC0")]
	private static List<StageBackgroundData> m_SortedBgDatas;

	[Token(Token = "0x4002AC1")]
	private static int m_selectedBgIndex;

	[Token(Token = "0x4002AC2")]
	private static Dictionary<int, StageBackgroundData> m_SelectableBackgrounds;

	[Token(Token = "0x4002AC3")]
	private static StageBackgroundCachedDataManager m_BgCachedDataManager;

	[Token(Token = "0x17000842")]
	public static List<StageBackgroundData> BgDatas
	{
		[Address(RVA = "0x601F30", Offset = "0x600730", Length = "0x114")]
		[Token(Token = "0x6004B8C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000843")]
	public static List<StageBackgroundLocalizationData> BgLocalizationDatas
	{
		[Address(RVA = "0x602050", Offset = "0x600850", Length = "0x72")]
		[Token(Token = "0x6004B8D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000844")]
	public static int SelectedBgId
	{
		[Address(RVA = "0x6020D0", Offset = "0x6008D0", Length = "0x1A7")]
		[Token(Token = "0x6004B8E")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000845")]
	public static int SelectedBgIndex
	{
		[Address(RVA = "0x602280", Offset = "0x600A80", Length = "0x71")]
		[Token(Token = "0x6004B8F")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004B90")]
		[Address(RVA = "0x602300", Offset = "0x600B00", Length = "0xB3")]
		set
		{
		}
	}

	[Token(Token = "0x17000846")]
	public static StageBackgroundCachedDataManager BgCachedDataManager
	{
		[Token(Token = "0x6004B91")]
		[Address(RVA = "0x601D70", Offset = "0x600570", Length = "0x1BF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004B92")]
	[Address(RVA = "0x601680", Offset = "0x5FFE80", Length = "0x23F")]
	public static Dictionary<int, StageBackgroundData> GetSelectableBackgrounds()
	{
		return null;
	}

	[Token(Token = "0x6004B93")]
	[Address(RVA = "0x6018C0", Offset = "0x6000C0", Length = "0x264")]
	public static List<StageBackgroundData> GetSortedBackgroundsData()
	{
		return null;
	}

	[Token(Token = "0x6004B94")]
	[Address(RVA = "0x601B30", Offset = "0x600330", Length = "0x10C")]
	public static bool IsBackgroundUnlocked(int bgId)
	{
		return default(bool);
	}

	[Token(Token = "0x6004B95")]
	[Address(RVA = "0x601C40", Offset = "0x600440", Length = "0x12A")]
	public static bool IsBackgroundUnlocked(StageBackgroundData bgData)
	{
		return default(bool);
	}

	[Address(RVA = "0x601430", Offset = "0x5FFC30", Length = "0x112")]
	[Token(Token = "0x6004B96")]
	public static StageBackgroundData GetBackgroundById(int bgId)
	{
		return null;
	}

	[Token(Token = "0x6004B97")]
	[Address(RVA = "0x601550", Offset = "0x5FFD50", Length = "0x12E")]
	public static StageBackgroundLocalizationData GetBackgroundLocalizedDataById(int bgId)
	{
		return null;
	}

	[Address(RVA = "0x6013B0", Offset = "0x5FFBB0", Length = "0x72")]
	[Token(Token = "0x6004B98")]
	[Obsolete]
	public static bool CheckIsWeeklyFree(StageBackgroundData bgData)
	{
		return default(bool);
	}

	[Token(Token = "0x6004B99")]
	[Address(RVA = "0x601300", Offset = "0x5FFB00", Length = "0xAC")]
	public static bool CheckIsLimitedFree(StageBackgroundData bgData)
	{
		return default(bool);
	}

	[Token(Token = "0x6004B9A")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public StageBackgroundDataManager()
	{
	}
}

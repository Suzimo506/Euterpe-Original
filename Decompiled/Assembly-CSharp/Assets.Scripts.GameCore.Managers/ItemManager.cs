using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Commons;
using Assets.Scripts.PeroTools.Nice.Interface;
using Assets.Scripts.Structs;
using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x2000743")]
public class ItemManager : Singleton<ItemManager>
{
	[Token(Token = "0x2000CA8")]
	private struct ConfigCacheInfo
	{
		[Token(Token = "0x4003DAD")]
		[FieldOffset(Offset = "0x0")]
		public int totalCount;

		[Token(Token = "0x4003DAE")]
		[FieldOffset(Offset = "0x8")]
		public Dictionary<string, List<int>> rarityIndices;

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003DAF")]
		public Dictionary<string, int> rarityCounts;
	}

	[Token(Token = "0x2000CA9")]
	private class ItemStats
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003DB0")]
		public Dictionary<string, int> rarityCounts;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003DB1")]
		public int unlockedSkinCount;

		[Token(Token = "0x4003DB2")]
		[FieldOffset(Offset = "0x1C")]
		public int elfinUnlockCount;

		[Token(Token = "0x4003DB3")]
		[FieldOffset(Offset = "0x20")]
		public int characterUnlockCount;

		[Token(Token = "0x4003DB4")]
		[FieldOffset(Offset = "0x24")]
		public int welcomeUnlockCount;

		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4003DB5")]
		public int loadingUnlockCount;

		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4003DB6")]
		public bool isUnlockBuro;

		[Token(Token = "0x600623D")]
		[Address(RVA = "0x6D3A90", Offset = "0x6D2290", Length = "0x54")]
		public void Clear()
		{
		}

		[Address(RVA = "0x6D3AF0", Offset = "0x6D22F0", Length = "0x69")]
		[Token(Token = "0x600623E")]
		public ItemStats()
		{
		}
	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002647")]
	private List<IData> m_RewardItems;

	[Token(Token = "0x4002648")]
	public const string character = "character";

	[Token(Token = "0x4002649")]
	public const string elfin = "elfin";

	[Token(Token = "0x400264A")]
	public const string loading = "loading";

	[Token(Token = "0x400264B")]
	public const string welcome = "welcome";

	[Token(Token = "0x400264C")]
	public const string song = "song";

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400264D")]
	private int m_TotalCount;

	[Token(Token = "0x4002656")]
	private static readonly string STR_TYPE;

	[Token(Token = "0x4002657")]
	private static readonly string STR_INDEX;

	[Token(Token = "0x4002658")]
	private static readonly string STR_IS_SKIN;

	[Token(Token = "0x4002659")]
	private static readonly string STR_IS_UNLOCK;

	[Token(Token = "0x400265A")]
	private static readonly string STR_FREE;

	[Token(Token = "0x400265B")]
	private static readonly string STR_HIDE;

	[Token(Token = "0x400265C")]
	private static readonly string STR_RARITY;

	[Token(Token = "0x400265D")]
	private static readonly string STR_COUNT;

	[Token(Token = "0x400265E")]
	private static readonly string STR_CHIP_AMOUNT;

	[Token(Token = "0x400265F")]
	private static readonly string STR_NEW;

	[Token(Token = "0x4002660")]
	private static readonly string STR_LOCK_NEW;

	[Token(Token = "0x4002661")]
	private static readonly string STR_EXCHANGE;

	[Token(Token = "0x4002662")]
	private static readonly string RARITY_A;

	[Token(Token = "0x4002663")]
	private static readonly string RARITY_C;

	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4002664")]
	private bool m_StatsDirty;

	[Token(Token = "0x4002665")]
	[FieldOffset(Offset = "0x48")]
	private ItemStats m_CachedStats;

	[Token(Token = "0x4002666")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<string, Dictionary<int, int>> m_ItemIndexLookup;

	[Token(Token = "0x4002667")]
	[FieldOffset(Offset = "0x58")]
	private bool m_LookupDirty;

	[Token(Token = "0x4002668")]
	[FieldOffset(Offset = "0x59")]
	private bool m_CantGetAwardItem;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002669")]
	private Dictionary<string, ConfigCacheInfo> m_ConfigCache;

	[Token(Token = "0x1700065A")]
	public List<IData> items
	{
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		[Token(Token = "0x6004397")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Address(RVA = "0x4894E0", Offset = "0x487CE0", Length = "0xC")]
		[Token(Token = "0x6004396")]
		private set
		{
		}
	}

	[Token(Token = "0x1700065B")]
	public int totalCharacterCount
	{
		[Token(Token = "0x6004399")]
		[CompilerGenerated]
		[Address(RVA = "0x42D1F0", Offset = "0x42B9F0", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x42D210", Offset = "0x42BA10", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6004398")]
		private set
		{
		}
	}

	[Token(Token = "0x1700065C")]
	public int totalElfinCount
	{
		[Token(Token = "0x600439B")]
		[CompilerGenerated]
		[Address(RVA = "0x49EAA0", Offset = "0x49D2A0", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x4879F0", Offset = "0x4861F0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600439A")]
		private set
		{
		}
	}

	[Token(Token = "0x1700065D")]
	public int totalLoadingCount
	{
		[Token(Token = "0x600439D")]
		[CompilerGenerated]
		[Address(RVA = "0x597010", Offset = "0x595810", Length = "0x4")]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[Token(Token = "0x600439C")]
		[Address(RVA = "0x487A90", Offset = "0x486290", Length = "0x4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700065E")]
	public int totalWelcomeCount
	{
		[CompilerGenerated]
		[Token(Token = "0x600439F")]
		[Address(RVA = "0x597020", Offset = "0x595820", Length = "0x4")]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[Token(Token = "0x600439E")]
		[Address(RVA = "0x487A80", Offset = "0x486280", Length = "0x4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700065F")]
	public int unlockRoleCount
	{
		[Token(Token = "0x60043A1")]
		[Address(RVA = "0x597000", Offset = "0x595800", Length = "0x4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[Token(Token = "0x60043A0")]
		[Address(RVA = "0x597060", Offset = "0x595860", Length = "0x4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000660")]
	public int unlockElfinCount
	{
		[CompilerGenerated]
		[Token(Token = "0x60043A3")]
		[Address(RVA = "0x596FF0", Offset = "0x5957F0", Length = "0x4")]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[Token(Token = "0x60043A2")]
		[Address(RVA = "0x597050", Offset = "0x595850", Length = "0x4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000661")]
	public int unlockLoadingCount
	{
		[Address(RVA = "0x45A8F0", Offset = "0x4590F0", Length = "0x4")]
		[Token(Token = "0x60043A5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x45AB50", Offset = "0x459350", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60043A4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000662")]
	public int unlockWelcomeCount
	{
		[CompilerGenerated]
		[Address(RVA = "0x597030", Offset = "0x595830", Length = "0x4")]
		[Token(Token = "0x60043A7")]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[Token(Token = "0x60043A6")]
		[Address(RVA = "0x597070", Offset = "0x595870", Length = "0x4")]
		private set
		{
		}
	}

	[Token(Token = "0x60043A8")]
	[Address(RVA = "0x79A730", Offset = "0x798F30", Length = "0x6B")]
	private void RewardItemsInit()
	{
	}

	[Token(Token = "0x60043A9")]
	[Address(RVA = "0x7987E0", Offset = "0x796FE0", Length = "0xFE")]
	private void Init()
	{
	}

	[Token(Token = "0x60043AA")]
	[Address(RVA = "0x7997C0", Offset = "0x797FC0", Length = "0x349")]
	private void RefreshTotalItemCount()
	{
	}

	[Token(Token = "0x60043AB")]
	[Address(RVA = "0x799620", Offset = "0x797E20", Length = "0xCF")]
	private void RefreshTotalCharacterCount()
	{
	}

	[Token(Token = "0x60043AC")]
	[Address(RVA = "0x7996F0", Offset = "0x797EF0", Length = "0xCC")]
	private void RefreshTotalElfinCount()
	{
	}

	[Address(RVA = "0x799B10", Offset = "0x798310", Length = "0x111")]
	[Token(Token = "0x60043AD")]
	private void RefreshTotalLoadingCount()
	{
	}

	[Token(Token = "0x60043AE")]
	[Address(RVA = "0x799C30", Offset = "0x798430", Length = "0x105")]
	private void RefreshTotalWelcomeCount()
	{
	}

	[Token(Token = "0x60043AF")]
	[Address(RVA = "0x79A7A0", Offset = "0x798FA0", Length = "0x304")]
	public bool Reward(int count = 2, bool jumpCheckAchievement = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60043B0")]
	[Address(RVA = "0x79AC60", Offset = "0x799460", Length = "0xFD")]
	private void SortRewardItems()
	{
	}

	[Token(Token = "0x60043B1")]
	[Address(RVA = "0x79A3A0", Offset = "0x798BA0", Length = "0x9D")]
	public void ResetItems()
	{
	}

	[Address(RVA = "0x799D40", Offset = "0x798540", Length = "0x35B")]
	[Token(Token = "0x60043B2")]
	public int RefreshUnlockCount()
	{
		return default(int);
	}

	[Token(Token = "0x60043B3")]
	[Address(RVA = "0x79A440", Offset = "0x798C40", Length = "0x2E7")]
	public void RewardItem(int count)
	{
	}

	[Token(Token = "0x60043B4")]
	[Address(RVA = "0x79AAB0", Offset = "0x7992B0", Length = "0x1A1")]
	private void SendUnlockItemMessage()
	{
	}

	[Token(Token = "0x60043B5")]
	[Address(RVA = "0x7988E0", Offset = "0x7970E0", Length = "0x33E")]
	private void InitializeConfigCache()
	{
	}

	[Token(Token = "0x60043B6")]
	[Address(RVA = "0x795E80", Offset = "0x794680", Length = "0x22F")]
	private void BuildItemLookup()
	{
	}

	[Token(Token = "0x60043B7")]
	[Address(RVA = "0x7974E0", Offset = "0x795CE0", Length = "0xD4")]
	private IData FindItem(string type, int index)
	{
		return null;
	}

	[Token(Token = "0x60043B8")]
	[Address(RVA = "0x796ED0", Offset = "0x7956D0", Length = "0x601")]
	private ItemStats CollectStatistics()
	{
		return null;
	}

	[Token(Token = "0x60043B9")]
	[Address(RVA = "0x7983B0", Offset = "0x796BB0", Length = "0x4C")]
	private ItemStats GetStats()
	{
		return null;
	}

	[Token(Token = "0x60043BA")]
	[Address(RVA = "0x799120", Offset = "0x797920", Length = "0x5")]
	private void MarkStatsDirty()
	{
	}

	[Token(Token = "0x60043BB")]
	[Address(RVA = "0x55DE10", Offset = "0x55C610", Length = "0x5")]
	private void MarkLookupDirty()
	{
	}

	[Address(RVA = "0x797A80", Offset = "0x796280", Length = "0x197")]
	[Token(Token = "0x60043BC")]
	private int GetConfigCount(string type, string rarity)
	{
		return default(int);
	}

	[Token(Token = "0x60043BD")]
	[Address(RVA = "0x7975C0", Offset = "0x795DC0", Length = "0x25B")]
	private int GetCacheInfoForCharacter(ref ConfigCacheInfo cacheInfo, ref string rarity)
	{
		return default(int);
	}

	[Token(Token = "0x60043BE")]
	[Address(RVA = "0x797820", Offset = "0x796020", Length = "0x255")]
	private int GetCacheInfoForElfin(ref ConfigCacheInfo cacheInfo, ref string rarity)
	{
		return default(int);
	}

	[Token(Token = "0x60043BF")]
	[Address(RVA = "0x799130", Offset = "0x797930", Length = "0x4EA")]
	public bool OnStateReward(string rarity, string nextRarity)
	{
		return default(bool);
	}

	[Token(Token = "0x60043C0")]
	[Address(RVA = "0x795AC0", Offset = "0x7942C0", Length = "0x18B")]
	private void AddSkin(string rarity)
	{
	}

	[Token(Token = "0x60043C1")]
	[Address(RVA = "0x796820", Offset = "0x795020", Length = "0x2CC")]
	private bool CheckTypeRarityFull(string type, string rarity)
	{
		return default(bool);
	}

	[Token(Token = "0x60043C2")]
	[Address(RVA = "0x798400", Offset = "0x796C00", Length = "0x3DA")]
	private List<int> GetUnlockableIndices(string type, string rarity)
	{
		return null;
	}

	[Token(Token = "0x60043C3")]
	[Address(RVA = "0x795850", Offset = "0x794050", Length = "0x268")]
	private void AddLoading()
	{
	}

	[Token(Token = "0x60043C4")]
	[Address(RVA = "0x795C50", Offset = "0x794450", Length = "0x225")]
	private void AddWelcome()
	{
	}

	[Token(Token = "0x60043C5")]
	[Address(RVA = "0x795190", Offset = "0x793990", Length = "0x6B3")]
	public void AddItem(string type, int index, int count)
	{
	}

	[Token(Token = "0x60043C6")]
	[Address(RVA = "0x7980B0", Offset = "0x7968B0", Length = "0x2F2")]
	public int GetRemainFreeItemChipCount()
	{
		return default(int);
	}

	[Token(Token = "0x60043C7")]
	[Address(RVA = "0x79A0A0", Offset = "0x7988A0", Length = "0x2FD")]
	public void RemoveItem(string type, int index)
	{
	}

	[Token(Token = "0x60043C8")]
	[Address(RVA = "0x7960B0", Offset = "0x7948B0", Length = "0x26E")]
	private int CalcInsertIndex(string type, int index)
	{
		return default(int);
	}

	[Token(Token = "0x60043C9")]
	[Address(RVA = "0x794540", Offset = "0x792D40", Length = "0x82C")]
	public void AddExtraItem(string type, int index, int count, bool awardTip = true)
	{
	}

	[Token(Token = "0x60043CA")]
	[Address(RVA = "0x797C20", Offset = "0x796420", Length = "0x12B")]
	public int GetItemChipAmount(string itemType, int itemIndex)
	{
		return default(int);
	}

	[Token(Token = "0x60043CB")]
	[Address(RVA = "0x79AD60", Offset = "0x799560", Length = "0xED")]
	public bool TryGetItem(string itemType, int itemIndex, out IData item)
	{
		item = null;
		return default(bool);
	}

	[Address(RVA = "0x794F00", Offset = "0x793700", Length = "0x281")]
	[Token(Token = "0x60043CC")]
	private void AddItemToUsedList(IData it)
	{
	}

	[Token(Token = "0x60043CD")]
	[Address(RVA = "0x794D70", Offset = "0x793570", Length = "0x185")]
	public void AddItemToUsedList(string type, int index)
	{
	}

	[Token(Token = "0x60043CE")]
	[Address(RVA = "0x796320", Offset = "0x794B20", Length = "0x100")]
	public void CheckAndAddWelcome(int index, int count, bool showTips)
	{
	}

	[Token(Token = "0x60043CF")]
	[Address(RVA = "0x796AF0", Offset = "0x7952F0", Length = "0x3D2")]
	public bool ChristmasItemLogic(string itemType)
	{
		return default(bool);
	}

	[Token(Token = "0x60043D0")]
	[Address(RVA = "0x796430", Offset = "0x794C30", Length = "0xEC")]
	public void CheckAndFillTimeoutItem()
	{
	}

	[Token(Token = "0x60043D1")]
	[Address(RVA = "0x796520", Offset = "0x794D20", Length = "0x2F5")]
	private void CheckAndFill(List<TimeLimitedItemArgs> itemArgsList)
	{
	}

	[Token(Token = "0x60043D2")]
	[Address(RVA = "0x798EA0", Offset = "0x7976A0", Length = "0x13F")]
	public bool IsMay()
	{
		return default(bool);
	}

	[Token(Token = "0x60043D3")]
	[Address(RVA = "0x798FE0", Offset = "0x7977E0", Length = "0x13F")]
	public bool IsNanahira()
	{
		return default(bool);
	}

	[Address(RVA = "0x798DC0", Offset = "0x7975C0", Length = "0xDC")]
	[Token(Token = "0x60043D4")]
	public bool IsFestivalCarnival()
	{
		return default(bool);
	}

	[Address(RVA = "0x798C20", Offset = "0x797420", Length = "0xDC")]
	[Token(Token = "0x60043D5")]
	public bool IsAprilFoolsDay()
	{
		return default(bool);
	}

	[Address(RVA = "0x798D00", Offset = "0x797500", Length = "0xB8")]
	[Token(Token = "0x60043D6")]
	public bool IsChirstmasCover3()
	{
		return default(bool);
	}

	[Address(RVA = "0x797D50", Offset = "0x796550", Length = "0x35F")]
	[Token(Token = "0x60043D7")]
	public (string, string) GetItemImgAndLocalName(IData data)
	{
		return default((string, string));
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60043D8")]
	public void ItemReviewHandlersSpecialLogic(bool isReview)
	{
	}

	[Address(RVA = "0x79B100", Offset = "0x799900", Length = "0x76")]
	[Token(Token = "0x60043D9")]
	public ItemManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}

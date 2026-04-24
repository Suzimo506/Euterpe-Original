using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Database;
using Assets.Scripts.GameCore.Managers;
using Assets.Scripts.Structs;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Helpers;

[Token(Token = "0x20006E2")]
public static class IAPHelper
{
	[Token(Token = "0x40024E9")]
	private const string all_unlock_buy_time = "all_unlock_buy_time";

	[Token(Token = "0x40024EB")]
	public static DateTime becomeMusePlusTime;

	[Token(Token = "0x40024EC")]
	public const string name_of_muse_plus = "Muse Plus";

	[Token(Token = "0x40024ED")]
	private const string version_pattern = "^\\d+\\.\\d+\\.\\d+$";

	[Token(Token = "0x40024EE")]
	private const string dlc_on_sale_max_version = "4.7.0";

	[Token(Token = "0x40024EF")]
	private static readonly List<int> m_NeedPucahsedHeadIndexs;

	[Token(Token = "0x40024F0")]
	private static readonly Dictionary<string, SpecialDlcArgs> s_SpecialDlcCheck;

	[Token(Token = "0x40024F1")]
	private static CheckRoleItemParams[] s_CheckPurchaseItems;

	[Token(Token = "0x40024F2")]
	private static readonly CheckRoleItemParams[] s_JustRoles;

	[Token(Token = "0x40024F3")]
	private static readonly HashSet<string> newArchitectureMusicPackage;

	[Token(Token = "0x40024F4")]
	private static readonly Dictionary<string, decimal> m_TapTapOnly_DiscountMap;

	[Token(Token = "0x40024F5")]
	private const int unlock_just_as_planned = 0;

	[Token(Token = "0x40024F6")]
	private const int unlock_muse_plus = -1;

	[Token(Token = "0x40024F7")]
	private const int unlock_base_by_code = 1;

	[Token(Token = "0x40024F8")]
	private const int unlock_all_by_code = 2;

	[Token(Token = "0x40024F9")]
	private static readonly Dictionary<int, bool> s_IAPBuffer;

	[Token(Token = "0x40024FA")]
	private static readonly Dictionary<string, bool> s_IAPBufferProductName;

	[Token(Token = "0x40024FC")]
	private const string unlock_all_jap = "unlockall_jap";

	[Token(Token = "0x40024FD")]
	private static readonly WaitForSeconds s_WaitForVipCheck;

	[Token(Token = "0x40024FE")]
	private static Coroutine s_VipCheckCoroutine;

	[Token(Token = "0x170005FA")]
	public static DateTime default_check_time
	{
		[Address(RVA = "0xC83720", Offset = "0xC81F20", Length = "0xB6")]
		[Token(Token = "0x60040B1")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x170005FB")]
	public static bool isMusePlusTime
	{
		[Address(RVA = "0xC83A00", Offset = "0xC82200", Length = "0xC6")]
		[Token(Token = "0x60040B2")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170005FC")]
	private static bool s_IsOldJustAsPlanned
	{
		[Token(Token = "0x60040B3")]
		[Address(RVA = "0xC83C70", Offset = "0xC82470", Length = "0x48")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170005FD")]
	public static bool needDisplayMusePlus
	{
		[Address(RVA = "0xC83AD0", Offset = "0xC822D0", Length = "0x19C")]
		[Token(Token = "0x60040BA")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170005FE")]
	public static bool hasBuyJustAsPlanned
	{
		[Address(RVA = "0xC837E0", Offset = "0xC81FE0", Length = "0x57")]
		[CompilerGenerated]
		[Token(Token = "0x60040F4")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0xC83CC0", Offset = "0xC824C0", Length = "0x5C")]
		[Token(Token = "0x60040F5")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170005FF")]
	public static bool isAllUnlock
	{
		[Token(Token = "0x6004107")]
		[Address(RVA = "0xC83840", Offset = "0xC82040", Length = "0x1B9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60040B4")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public static void Init()
	{
	}

	[Address(RVA = "0xC79FE0", Offset = "0xC787E0", Length = "0x38C")]
	[Token(Token = "0x60040B5")]
	public static void OpenDlc(int jsonIndex = -2)
	{
	}

	[Address(RVA = "0xC79760", Offset = "0xC77F60", Length = "0xC2")]
	[Token(Token = "0x60040B6")]
	public static bool IsOldJustAsPlanned()
	{
		return default(bool);
	}

	[Address(RVA = "0xC796C0", Offset = "0xC77EC0", Length = "0x92")]
	[Token(Token = "0x60040B7")]
	public static bool IsOldJustAsPlannedTime()
	{
		return default(bool);
	}

	[Token(Token = "0x60040B8")]
	[Address(RVA = "0xC79830", Offset = "0xC78030", Length = "0x1FB")]
	public static bool IsPurchasedDlc()
	{
		return default(bool);
	}

	[Token(Token = "0x60040B9")]
	[Address(RVA = "0xC78AE0", Offset = "0xC772E0", Length = "0x92")]
	private static bool IsMusePlusTime()
	{
		return default(bool);
	}

	[Token(Token = "0x60040BB")]
	[Address(RVA = "0xC75F40", Offset = "0xC74740", Length = "0xF9")]
	private static string GetAlbumsUid()
	{
		return null;
	}

	[Token(Token = "0x60040BC")]
	[Address(RVA = "0xC79E60", Offset = "0xC78660", Length = "0x175")]
	public static void OnRestoreInStandalone(string albumName = null)
	{
	}

	[Obsolete]
	[Token(Token = "0x60040BD")]
	[Address(RVA = "0xC77A70", Offset = "0xC76270", Length = "0x55D")]
	internal static void GetPurchasedUids(List<string> buffer)
	{
	}

	[Token(Token = "0x60040BE")]
	[Address(RVA = "0xC77980", Offset = "0xC76180", Length = "0xE0")]
	internal static void GetPurchasedUidsFromLocalIAPProducts(Action<string[]> callback)
	{
	}

	[Address(RVA = "0xC75AB0", Offset = "0xC742B0", Length = "0x48D")]
	[Token(Token = "0x60040BF")]
	internal static CheckRoleItemParams FindIAPParamsByRoleIndex(int roleIndex, out bool isFind)
	{
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref isFind) = null;
		return default(CheckRoleItemParams);
	}

	[Token(Token = "0x60040C0")]
	[Address(RVA = "0xC74BD0", Offset = "0xC733D0", Length = "0x494")]
	internal static CheckRoleItemParams FindIAPParamsByElfinIndex(int elfinIndex, out bool isFind)
	{
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref isFind) = null;
		return default(CheckRoleItemParams);
	}

	[Address(RVA = "0xC75070", Offset = "0xC73870", Length = "0x46C")]
	[Token(Token = "0x60040C1")]
	internal static CheckRoleItemParams FindIAPParamsByIndexAndType(int itemIndex, string type, out bool isFind)
	{
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref isFind) = null;
		return default(CheckRoleItemParams);
	}

	[Address(RVA = "0xC754E0", Offset = "0xC73CE0", Length = "0x5C2")]
	[Token(Token = "0x60040C2")]
	private static CheckRoleItemParams FindIAPParamsByIndexForGeneral(int index, out bool isFind, Func<CheckRoleItemParams, int, bool> itemCheckFunc)
	{
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref isFind) = null;
		return default(CheckRoleItemParams);
	}

	[Address(RVA = "0xC79640", Offset = "0xC77E40", Length = "0x75")]
	[Token(Token = "0x60040C3")]
	public static bool IsNewArchitectureProduct(string originalProductId)
	{
		return default(bool);
	}

	[Address(RVA = "0xC7E540", Offset = "0xC7CD40", Length = "0xAE")]
	[Token(Token = "0x60040C4")]
	public static bool TryGetTapTapSpecialPrice(string payProductId, out decimal mapPrice)
	{
		System.Runtime.CompilerServices.Unsafe.As<decimal, @null>(ref mapPrice) = null;
		return default(bool);
	}

	[Token(Token = "0x60040C5")]
	[Address(RVA = "0xC7E810", Offset = "0xC7D010", Length = "0xDC")]
	private static void UnlockBaseAlbum()
	{
	}

	[Token(Token = "0x60040C6")]
	[Address(RVA = "0xC77FD0", Offset = "0xC767D0", Length = "0xF8")]
	internal static SpecialDlcArgs GetSpecialDlcArgs(string productId)
	{
		return default(SpecialDlcArgs);
	}

	[Address(RVA = "0xC7AAF0", Offset = "0xC792F0", Length = "0xEE")]
	[Token(Token = "0x60040C7")]
	private static void ReleaseBuffers(ref List<int> characterBuffer, ref List<int> elfinBuffer, ref List<int> loadingBuffer, ref List<int> welcomeBuffer)
	{
	}

	[Address(RVA = "0xC76040", Offset = "0xC74840", Length = "0x337")]
	[Token(Token = "0x60040C8")]
	private static List<int> GetCharacterNeedUnlock(int unlockIndex)
	{
		return null;
	}

	[Token(Token = "0x60040C9")]
	[Address(RVA = "0xC76BA0", Offset = "0xC753A0", Length = "0x337")]
	private static List<int> GetElfinNeedUnlock(int unlockIndex)
	{
		return null;
	}

	[Address(RVA = "0xC772D0", Offset = "0xC75AD0", Length = "0x307")]
	[Token(Token = "0x60040CA")]
	private static List<int> GetLoadingNeedUnlock(int unlockIndex)
	{
		return null;
	}

	[Address(RVA = "0xC780D0", Offset = "0xC768D0", Length = "0x2BD")]
	[Token(Token = "0x60040CB")]
	private static List<int> GetWelcomeNeedUnlock(int unlockIndex)
	{
		return null;
	}

	[Token(Token = "0x60040CC")]
	[Address(RVA = "0xC7C150", Offset = "0xC7A950", Length = "0x38C")]
	private static void SpecialDlcBindingItemFilter(List<int> characterBuffer, List<int> elfinBuffer, List<int> loadingBuffer, List<int> welcomeBuffer)
	{
	}

	[Token(Token = "0x60040CD")]
	[Address(RVA = "0xC7EAD0", Offset = "0xC7D2D0", Length = "0x6DC")]
	private static void UnlockItem(int unlockIndex)
	{
	}

	[Token(Token = "0x60040CE")]
	[Address(RVA = "0xC7E9D0", Offset = "0xC7D1D0", Length = "0xFC")]
	public static void UnlockBaseByType(AllContentUnlock unlockType)
	{
	}

	[Address(RVA = "0xC7E8F0", Offset = "0xC7D0F0", Length = "0xD4")]
	[Token(Token = "0x60040CF")]
	public static void UnlockBaseByCode()
	{
	}

	[Address(RVA = "0xC7E6B0", Offset = "0xC7CEB0", Length = "0x153")]
	[Token(Token = "0x60040D0")]
	public static void UnlockAllByCode()
	{
	}

	[Token(Token = "0x60040D1")]
	[Address(RVA = "0xC7F1B0", Offset = "0xC7D9B0", Length = "0x361")]
	private static void UnlockJustAsPlanned(bool isSynchrnize = false)
	{
	}

	[Address(RVA = "0xC720D0", Offset = "0xC708D0", Length = "0x540")]
	[Token(Token = "0x60040D2")]
	public static void AddPurchaseItem(string productId, DateTime buyTime = default(DateTime), bool isSynchrnize = false)
	{
	}

	[Token(Token = "0x60040D3")]
	[Address(RVA = "0xC71F20", Offset = "0xC70720", Length = "0x1AD")]
	private static void AddIAPItem(ref CheckRoleItemParams par)
	{
	}

	[Address(RVA = "0xC7AE10", Offset = "0xC79610", Length = "0x2D0")]
	[Token(Token = "0x60040D4")]
	private static void RemoveIAPItem(CheckRoleItemParams itemParams)
	{
	}

	[Token(Token = "0x60040D5")]
	[Address(RVA = "0xC7BE60", Offset = "0xC7A660", Length = "0x2EC")]
	private static void SpecialCheckRoleAndElfin()
	{
	}

	[Address(RVA = "0xC728C0", Offset = "0xC710C0", Length = "0x218")]
	[Token(Token = "0x60040D6")]
	private static void CheckDlc()
	{
	}

	[Token(Token = "0x60040D7")]
	[Address(RVA = "0xC76380", Offset = "0xC74B80", Length = "0x1BE")]
	private static List<CheckRoleItemParams> GetCheckRoleItemParamsList()
	{
		return null;
	}

	[Token(Token = "0x60040D8")]
	[Address(RVA = "0xC7A370", Offset = "0xC78B70", Length = "0x4F")]
	public static void RefreshIAPBufferAndRemoveInvalidItem()
	{
	}

	[Token(Token = "0x60040D9")]
	[Address(RVA = "0xC7B340", Offset = "0xC79B40", Length = "0x149")]
	private static void RemoveJustAsPlannedItems()
	{
	}

	[Token(Token = "0x60040DA")]
	[Address(RVA = "0xC7B0F0", Offset = "0xC798F0", Length = "0x247")]
	public static void RemoveInvalidItemsByIAPBuffer()
	{
	}

	[Token(Token = "0x60040DB")]
	[Address(RVA = "0xC7ABE0", Offset = "0xC793E0", Length = "0x226")]
	private static void RemoveBudgetInvalid()
	{
	}

	[Token(Token = "0x60040DC")]
	[Address(RVA = "0xC73340", Offset = "0xC71B40", Length = "0x1A3")]
	public static void CheckSelectedItem()
	{
	}

	[Token(Token = "0x60040DD")]
	[Address(RVA = "0xC734F0", Offset = "0xC71CF0", Length = "0x2B8")]
	public static void CheckSelectedRole()
	{
	}

	[Token(Token = "0x60040DE")]
	[Address(RVA = "0xC73060", Offset = "0xC71860", Length = "0x1A3")]
	private static void CheckSelectedElfin()
	{
	}

	[Token(Token = "0x60040DF")]
	[Address(RVA = "0xC73210", Offset = "0xC71A10", Length = "0x124")]
	private static void CheckSelectedFever()
	{
	}

	[Address(RVA = "0xC72F10", Offset = "0xC71710", Length = "0x14F")]
	[Token(Token = "0x60040E0")]
	private static void CheckSelectedBattleSfx()
	{
	}

	[Token(Token = "0x60040E1")]
	[Address(RVA = "0xC737B0", Offset = "0xC71FB0", Length = "0x2B4")]
	public static void CheckSelectedSkin()
	{
	}

	[Token(Token = "0x60040E2")]
	[Address(RVA = "0xC7A3C0", Offset = "0xC78BC0", Length = "0x722")]
	public static void RefreshIAPBuffer()
	{
	}

	[Token(Token = "0x60040E3")]
	[Address(RVA = "0xC74640", Offset = "0xC72E40", Length = "0x66")]
	public static bool FastCheckUnlock(MusicInfo musicInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x60040E4")]
	[Address(RVA = "0xC745B0", Offset = "0xC72DB0", Length = "0x8F")]
	public static bool FastCheckUnlock(int albumJsonIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x60040E5")]
	[Address(RVA = "0xC746B0", Offset = "0xC72EB0", Length = "0x18D")]
	public static bool FastCheckUnlock(string albumUid)
	{
		return default(bool);
	}

	[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
	[Token(Token = "0x60040E6")]
	public static bool IsShowCollectionBundleUI(string cbProductUid)
	{
		return default(bool);
	}

	[Token(Token = "0x60040E7")]
	[Address(RVA = "0xC72AE0", Offset = "0xC712E0", Length = "0xA5")]
	public static bool CheckFreeProductUnlock(string productId)
	{
		return default(bool);
	}

	[Token(Token = "0x60040E8")]
	[Address(RVA = "0xC74840", Offset = "0xC73040", Length = "0x266")]
	public static bool FastCheckUnlock(DBConfigAlbums.AlbumsInfo album)
	{
		return default(bool);
	}

	[Token(Token = "0x60040E9")]
	[Address(RVA = "0xC79B60", Offset = "0xC78360", Length = "0x1C9")]
	public static bool IsVipOnSale(out ProductVip productVip)
	{
		System.Runtime.CompilerServices.Unsafe.As<ProductVip, @null>(ref productVip) = null;
		return default(bool);
	}

	[Address(RVA = "0xC79D30", Offset = "0xC78530", Length = "0x124")]
	[Token(Token = "0x60040EA")]
	public static bool IsVipUnlisted()
	{
		return default(bool);
	}

	[Token(Token = "0x60040EB")]
	[Address(RVA = "0xC7E400", Offset = "0xC7CC00", Length = "0x13A")]
	private static bool TryGetProductVipByTime(DateTime time, out ProductVip productVip)
	{
		System.Runtime.CompilerServices.Unsafe.As<ProductVip, @null>(ref productVip) = null;
		return default(bool);
	}

	[Address(RVA = "0xC789D0", Offset = "0xC771D0", Length = "0x102")]
	[Token(Token = "0x60040EC")]
	public static bool IsItemUnlockByVip(int itemIndex, string type)
	{
		return default(bool);
	}

	[Address(RVA = "0xC73E50", Offset = "0xC72650", Length = "0x26C")]
	[Token(Token = "0x60040ED")]
	private static bool FastCheckCollectionBuUnlock(string collectionBundleUid)
	{
		return default(bool);
	}

	[Token(Token = "0x60040EE")]
	[Address(RVA = "0xC78670", Offset = "0xC76E70", Length = "0x22F")]
	public static bool IsCollectionBundleHasUserDiscount(string productUid)
	{
		return default(bool);
	}

	[Address(RVA = "0xC788A0", Offset = "0xC770A0", Length = "0x48")]
	[Token(Token = "0x60040EF")]
	public static bool IsCollectionBundle(string uid)
	{
		return default(bool);
	}

	[Address(RVA = "0xC7B5B0", Offset = "0xC79DB0", Length = "0x51")]
	[Token(Token = "0x60040F0")]
	public static bool SafeFastCheck(string productId)
	{
		return default(bool);
	}

	[Address(RVA = "0xC77850", Offset = "0xC76050", Length = "0x128")]
	[Token(Token = "0x60040F1")]
	public static string GetOriginCollectionBundleUid(string cbUid)
	{
		return null;
	}

	[Address(RVA = "0xC740C0", Offset = "0xC728C0", Length = "0x3B1")]
	[Token(Token = "0x60040F2")]
	public static bool FastCheckUnlockCurrentVip()
	{
		return default(bool);
	}

	[Address(RVA = "0xC74480", Offset = "0xC72C80", Length = "0x125")]
	[Token(Token = "0x60040F3")]
	public static bool FastCheckUnlockVip(string productId)
	{
		return default(bool);
	}

	[Address(RVA = "0xC783E0", Offset = "0xC76BE0", Length = "0x49")]
	[Token(Token = "0x60040F6")]
	public static bool HasBuyMusePlus()
	{
		return default(bool);
	}

	[Token(Token = "0x60040F7")]
	[Address(RVA = "0xC78390", Offset = "0xC76B90", Length = "0x49")]
	public static bool HasBuyJustAsPlanned()
	{
		return default(bool);
	}

	[Token(Token = "0x60040F8")]
	[Address(RVA = "0xC7DE80", Offset = "0xC7C680", Length = "0x23C")]
	public static void StartupCheckDlc()
	{
	}

	[Address(RVA = "0xC7C5B0", Offset = "0xC7ADB0", Length = "0x18C8")]
	[Token(Token = "0x60040F9")]
	private static void StartupAddLoadingAndWelcomeItemByTime()
	{
	}

	[Address(RVA = "0xC72620", Offset = "0xC70E20", Length = "0x29C")]
	[Token(Token = "0x60040FA")]
	private static void CheckAlbumPurchaseAndRemoveItem()
	{
	}

	[Token(Token = "0x60040FB")]
	[Address(RVA = "0xC72B90", Offset = "0xC71390", Length = "0x379")]
	public static void CheckHeadDataAndRemove()
	{
	}

	[Token(Token = "0x60040FC")]
	[Address(RVA = "0xC73A70", Offset = "0xC72270", Length = "0x3D8")]
	public static void CheckStickerData()
	{
	}

	[Address(RVA = "0xC7B490", Offset = "0xC79C90", Length = "0x116")]
	[Token(Token = "0x60040FD")]
	public static void ResetUserData()
	{
	}

	[Address(RVA = "0xC791B0", Offset = "0xC779B0", Length = "0x480")]
	[Token(Token = "0x60040FE")]
	public static bool IsNeedAddCheckDlcCanSaleTime()
	{
		return default(bool);
	}

	[Token(Token = "0x60040FF")]
	[Address(RVA = "0xC79B00", Offset = "0xC78300", Length = "0x59")]
	private static bool IsValidVersionFormat(string version)
	{
		return default(bool);
	}

	[Token(Token = "0x6004100")]
	[Address(RVA = "0xC78DE0", Offset = "0xC775E0", Length = "0x3C0")]
	internal static bool IsMusicPackageValidity(string uid)
	{
		return default(bool);
	}

	[Token(Token = "0x6004101")]
	[Address(RVA = "0xC78B80", Offset = "0xC77380", Length = "0x172")]
	public static bool IsMusicPackageInTime(string albumUid)
	{
		return default(bool);
	}

	[Token(Token = "0x6004102")]
	[Address(RVA = "0xC78D00", Offset = "0xC77500", Length = "0xDB")]
	private static bool IsMusicPackageInTime(SpecialDlcArgs dlcArgs)
	{
		return default(bool);
	}

	[Token(Token = "0x6004103")]
	[Address(RVA = "0xC77140", Offset = "0xC75940", Length = "0x18D")]
	public static List<string> GetInvalidMusicPackageUid()
	{
		return null;
	}

	[Token(Token = "0x6004104")]
	[Address(RVA = "0xC788F0", Offset = "0xC770F0", Length = "0xD5")]
	internal static bool IsItemTimeout(string itemType, int itemIndex)
	{
		return default(bool);
	}

	[Address(RVA = "0xC7E190", Offset = "0xC7C990", Length = "0x268")]
	[Token(Token = "0x6004105")]
	internal static void TimeoutItemFilter(string itemType, List<int> itemIndexs)
	{
	}

	[Address(RVA = "0xC76EE0", Offset = "0xC756E0", Length = "0x258")]
	[Token(Token = "0x6004106")]
	private static List<CheckRoleItemParams> GetInvalidMusicPackageIAPItemBinding()
	{
		return null;
	}

	[Token(Token = "0x6004108")]
	[Address(RVA = "0xC785F0", Offset = "0xC76DF0", Length = "0x73")]
	private static bool IsBuyAlbum(string productId)
	{
		return default(bool);
	}

	[Address(RVA = "0xC7E5F0", Offset = "0xC7CDF0", Length = "0xBB")]
	[Token(Token = "0x6004109")]
	public static DateTime UnlockAllBuyTime()
	{
		return default(DateTime);
	}

	[Address(RVA = "0xC7B6A0", Offset = "0xC79EA0", Length = "0x12B")]
	[Token(Token = "0x600410A")]
	public static void SetUnlockBuyTime(DateTime time)
	{
	}

	[Address(RVA = "0xC7B7D0", Offset = "0xC79FD0", Length = "0x279")]
	[Token(Token = "0x600410B")]
	public static void SetVipExpirationTimeByVipUid(string vipUid, DateTime buyTimeUtc)
	{
	}

	[Address(RVA = "0xC7BBD0", Offset = "0xC7A3D0", Length = "0x284")]
	[Token(Token = "0x600410C")]
	private static void SetVip(string vipUid, DateTime buyTimeUtc)
	{
	}

	[Address(RVA = "0xC7BA50", Offset = "0xC7A250", Length = "0x179")]
	[Token(Token = "0x600410D")]
	public static void SetVipExpirationTime(DateTime time)
	{
	}

	[Token(Token = "0x600410E")]
	[Address(RVA = "0xC7B610", Offset = "0xC79E10", Length = "0x8E")]
	private static void SetActivedVipName(string productId)
	{
	}

	[Token(Token = "0x600410F")]
	[Address(RVA = "0xC78540", Offset = "0xC76D40", Length = "0xAF")]
	private static bool HasUnlockAll_JAP()
	{
		return default(bool);
	}

	[Token(Token = "0x6004110")]
	[Address(RVA = "0xC78430", Offset = "0xC76C30", Length = "0x10C")]
	private static bool HasUnlockAllButIsNotJAP()
	{
		return default(bool);
	}

	[Token(Token = "0x6004111")]
	[Address(RVA = "0xC777C0", Offset = "0xC75FC0", Length = "0x8F")]
	public static string GetMatchedCollectionBundle(string collectionBundleName)
	{
		return null;
	}

	[Token(Token = "0x6004112")]
	[Address(RVA = "0xC775E0", Offset = "0xC75DE0", Length = "0x1DE")]
	private static void GetLockedMusicPackageFromCollectionBundle(string collectionBundleUid, List<string> buffer)
	{
	}

	[Address(RVA = "0xC76540", Offset = "0xC74D40", Length = "0x650")]
	[Token(Token = "0x6004113")]
	private static string GetCollectionBundlePayProductId(string collectionBundleUid, List<string> unPurchasedAlbumProductIds)
	{
		return null;
	}

	[Address(RVA = "0xC74AB0", Offset = "0xC732B0", Length = "0x11E")]
	[Token(Token = "0x6004114")]
	private static CollectionBundlePriceGradient FindClosestPrice(List<CollectionBundlePriceGradient> priceGradients, decimal priceLeft)
	{
		return default(CollectionBundlePriceGradient);
	}

	[Address(RVA = "0xC79A30", Offset = "0xC78230", Length = "0xC7")]
	[Token(Token = "0x6004115")]
	public static bool IsUidBelongsCollectionBundle(string uid)
	{
		return default(bool);
	}

	[Token(Token = "0x6004116")]
	[Address(RVA = "0xC7C4E0", Offset = "0xC7ACE0", Length = "0xCC")]
	public static void StartVipTimeOutCheck()
	{
	}

	[Token(Token = "0x6004117")]
	[Address(RVA = "0xC7E0C0", Offset = "0xC7C8C0", Length = "0xC4")]
	public static void StopVipTimeOutCheck()
	{
	}

	[Token(Token = "0x6004118")]
	[Address(RVA = "0xC7F520", Offset = "0xC7DD20", Length = "0x4A")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6A470", Offset = "0x69870")]
	private static IEnumerator VipTimeOutCheck()
	{
		return null;
	}
}

namespace Assets.Scripts.Helpers;

public static class IAPHelper
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<IData, Boolean> <>9__15_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <UnlockJustAsPlanned>b__15_0(IData m) { }

	}

	public struct CheckRoleItemParams
	{
		public string packageUid; //Field offset: 0x0
		public int roleIndex; //Field offset: 0x8
		public int elfinIndex; //Field offset: 0xC
		public Int32[] loadingIndex; //Field offset: 0x10
		public int welcomeIndex; //Field offset: 0x18

		public CheckRoleItemParams(string packUid, int roleIdx = -1, int elfinIdx = -1, Int32[] loadingIdx = null, int welcomeIdx = -1) { }

	}

	private static CheckRoleItemParams[] s_CheckPurchaseItems; //Field offset: 0x0
	private const int unlock_just_as_planned = 0; //Field offset: 0x0
	private const int unlock_base_by_code = 1; //Field offset: 0x0
	private const int unlock_all_by_code = 2; //Field offset: 0x0
	private static CheckRoleItemParams[] s_JustRoles; //Field offset: 0x8

	public static bool isAllUnlock
	{
		 get { } //Length: 246
	}

	private static IAPHelper() { }

	private static void AddItem(ref CheckRoleItemParams par) { }

	public static void AddLoadingAndWelcomeItemByTime() { }

	public static void AddPurchaseItem(string productId) { }

	public static void CheckFeverBuy() { }

	public static void CheckItemFromBuyAlbum() { }

	internal static CheckRoleItemParams FindIAPParamsByElfinIndex(int elfinIndex, out bool isFind) { }

	internal static CheckRoleItemParams FindIAPParamsByRoleIndex(int roleIndex, out bool isFind) { }

	public static bool get_isAllUnlock() { }

	internal static void GetPurchasedUids(List<String> buffer) { }

	public static void Init() { }

	internal static bool IsBuyAlbum(string productId) { }

	internal static bool IsMusicPackage(string uid) { }

	private static void OnRestoreCompleted(object _, object __, Object[] ___) { }

	internal static void OpenDlc(int index) { }

	public static void ResetUserData() { }

	public static void UnlockAllByCode() { }

	private static void UnlockBaseAlbum() { }

	public static void UnlockBaseByCode() { }

	private static void UnlockItem(int unlockIndex) { }

	public static void UnlockJustAsPlanned() { }

}


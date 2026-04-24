namespace Assets.Scripts.GameCore.Managers;

public class ItemManager : Singleton<ItemManager>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<IData, Boolean> <>9__45_0; //Field offset: 0x8
		public static Func<IData, Boolean> <>9__45_1; //Field offset: 0x10
		public static Comparison<IData> <>9__45_2; //Field offset: 0x18
		public static Func<IData, Boolean> <>9__45_3; //Field offset: 0x20
		public static Func<IData, Boolean> <>9__46_0; //Field offset: 0x28
		public static Predicate<IData> <>9__46_16; //Field offset: 0x30
		public static Func<IData, Boolean> <>9__46_8; //Field offset: 0x38
		public static Func<IData, Boolean> <>9__46_9; //Field offset: 0x40
		public static Func<IData, Boolean> <>9__47_4; //Field offset: 0x48
		public static Func<IData, Boolean> <>9__47_5; //Field offset: 0x50
		public static Func<IData, Boolean> <>9__53_1; //Field offset: 0x58
		public static Predicate<IData> <>9__57_0; //Field offset: 0x60

		private static <>c() { }

		public <>c() { }

		internal bool <AddExtraItem>b__53_1(IData m) { }

		internal bool <AddSkin>b__47_4(IData item) { }

		internal bool <AddSkin>b__47_5(IData item) { }

		internal bool <ChristmasItemLogic>b__57_0(IData t) { }

		internal bool <OnStateReward>b__46_0(IData item) { }

		internal bool <OnStateReward>b__46_16(IData item) { }

		internal bool <OnStateReward>b__46_8(IData item) { }

		internal bool <OnStateReward>b__46_9(IData item) { }

		internal bool <Reward>b__45_0(IData i) { }

		internal bool <Reward>b__45_1(IData m) { }

		internal int <Reward>b__45_2(IData l, IData r) { }

		internal bool <Reward>b__45_3(IData m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass46_0
	{
		public ItemManager <>4__this; //Field offset: 0x10
		public string rarity; //Field offset: 0x18
		public string nextRarity; //Field offset: 0x20

		public <>c__DisplayClass46_0() { }

		internal bool <OnStateReward>b__1(JToken t) { }

		internal void <OnStateReward>b__10() { }

		internal void <OnStateReward>b__11() { }

		internal void <OnStateReward>b__12() { }

		internal void <OnStateReward>b__13() { }

		internal void <OnStateReward>b__14() { }

		internal void <OnStateReward>b__15() { }

		internal void <OnStateReward>b__17() { }

		internal void <OnStateReward>b__18() { }

		internal bool <OnStateReward>b__2(JToken t) { }

		internal bool <OnStateReward>b__3(IData item) { }

		internal bool <OnStateReward>b__4(JToken t) { }

		internal bool <OnStateReward>b__5(JToken t) { }

		internal bool <OnStateReward>b__6(IData item) { }

		internal bool <OnStateReward>b__7(IData item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass47_0
	{
		public string type; //Field offset: 0x10
		public ItemManager <>4__this; //Field offset: 0x18
		public string rarity; //Field offset: 0x20

		public <>c__DisplayClass47_0() { }

		internal void <AddSkin>b__0() { }

		internal void <AddSkin>b__1() { }

		internal bool <AddSkin>b__2(IData item) { }

		internal bool <AddSkin>b__3(JToken c) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass47_1
	{
		public int i; //Field offset: 0x10
		public <>c__DisplayClass47_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass47_1() { }

		internal bool <AddSkin>b__6(IData t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass48_0
	{
		public int i; //Field offset: 0x10

		public <>c__DisplayClass48_0() { }

		internal bool <AddLoading>b__0(IData t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass49_0
	{
		public int i; //Field offset: 0x10

		public <>c__DisplayClass49_0() { }

		internal bool <AddWelcome>b__0(IData t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass50_0
	{
		public string type; //Field offset: 0x10
		public int index; //Field offset: 0x18

		public <>c__DisplayClass50_0() { }

		internal bool <AddItem>b__0(IData t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass51_0
	{
		public string type; //Field offset: 0x10
		public int index; //Field offset: 0x18

		public <>c__DisplayClass51_0() { }

		internal bool <RemoveItem>b__0(IData t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass53_0
	{
		public string type; //Field offset: 0x10
		public int index; //Field offset: 0x18

		public <>c__DisplayClass53_0() { }

		internal bool <AddExtraItem>b__0(IData t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass56_0
	{
		public int index; //Field offset: 0x10

		public <>c__DisplayClass56_0() { }

		internal bool <CheckAndAddWelcome>b__0(IData t) { }

	}

	public const string character = "character"; //Field offset: 0x0
	public const string elfin = "elfin"; //Field offset: 0x0
	public const string loading = "loading"; //Field offset: 0x0
	public const string welcome = "welcome"; //Field offset: 0x0
	[CompilerGenerated]
	private List<IData> <items>k__BackingField; //Field offset: 0x10
	private List<IData> m_RewardItems; //Field offset: 0x18
	private int m_TotalCount; //Field offset: 0x20
	[CompilerGenerated]
	private int <totalCharacterCount>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private int <totalElfinCount>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private int <totalLoadingCount>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private int <totalWelcomeCount>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private int <unlockRoleCount>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private int <unlockElfinCount>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private int <unlockLoadingCount>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private int <unlockWelcomeCount>k__BackingField; //Field offset: 0x40

	public private List<IData> items
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private int totalCharacterCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int totalElfinCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int totalLoadingCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int totalWelcomeCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int unlockElfinCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int unlockLoadingCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int unlockRoleCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int unlockWelcomeCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public ItemManager() { }

	public void AddExtraItem(string type, int index, int count, bool awardTip = true) { }

	public void AddItem(string type, int index, int count) { }

	private void AddItemToUsedList(IData it) { }

	public void AddItemToUsedList(string type, int index) { }

	private void AddLoading() { }

	private void AddSkin(string rarity) { }

	private void AddWelcome() { }

	private int CalcInsertIndex(string type, int index) { }

	public void CheckAndAddWelcome(int index, int count, bool showTips) { }

	public bool ChristmasItemLogic(string itemType) { }

	[CompilerGenerated]
	public List<IData> get_items() { }

	[CompilerGenerated]
	public int get_totalCharacterCount() { }

	[CompilerGenerated]
	public int get_totalElfinCount() { }

	[CompilerGenerated]
	public int get_totalLoadingCount() { }

	[CompilerGenerated]
	public int get_totalWelcomeCount() { }

	[CompilerGenerated]
	public int get_unlockElfinCount() { }

	[CompilerGenerated]
	public int get_unlockLoadingCount() { }

	[CompilerGenerated]
	public int get_unlockRoleCount() { }

	[CompilerGenerated]
	public int get_unlockWelcomeCount() { }

	private void Init() { }

	public bool IsAprilFoolsDay() { }

	public bool IsChirstmasCover3() { }

	public bool IsFestivalCarnival() { }

	public bool IsMay() { }

	public bool IsNanahira() { }

	public void ItemReviewHandlersSpecialLogic(bool isReview) { }

	public bool OnStateReward(string rarity, string nextRarity) { }

	public int RefreshUnlockCount() { }

	public void RemoveItem(string type, int index) { }

	public bool Reward(int count = 2) { }

	private void RewardItemsInit() { }

	[CompilerGenerated]
	private void set_items(List<IData> value) { }

	[CompilerGenerated]
	private void set_totalCharacterCount(int value) { }

	[CompilerGenerated]
	private void set_totalElfinCount(int value) { }

	[CompilerGenerated]
	private void set_totalLoadingCount(int value) { }

	[CompilerGenerated]
	private void set_totalWelcomeCount(int value) { }

	[CompilerGenerated]
	private void set_unlockElfinCount(int value) { }

	[CompilerGenerated]
	private void set_unlockLoadingCount(int value) { }

	[CompilerGenerated]
	private void set_unlockRoleCount(int value) { }

	[CompilerGenerated]
	private void set_unlockWelcomeCount(int value) { }

}


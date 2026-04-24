namespace Assets.Scripts.GameCore.Managers;

public class MessageManager : SingletonMonoBehaviour<MessageManager>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<IData, Boolean> <>9__18_0; //Field offset: 0x8
		public static Predicate<IData> <>9__22_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <get_available>b__18_0(IData m) { }

		internal bool <OnReward>b__22_0(IData m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public string type; //Field offset: 0x10

		public <>c__DisplayClass25_0() { }

		internal bool <Send>b__2(IData m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_1
	{
		public int maxAddExp; //Field offset: 0x10

		public <>c__DisplayClass25_1() { }

		internal bool <Send>b__0(IData m) { }

		internal bool <Send>b__1(IData m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public string type; //Field offset: 0x10

		public <>c__DisplayClass26_0() { }

		internal bool <Receive>b__0(IData m) { }

		internal bool <Receive>b__1(IData m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_1
	{
		public string uid; //Field offset: 0x10
		public <>c__DisplayClass26_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass26_1() { }

		internal bool <Receive>b__2(IData m) { }

	}

	public const string task = "task"; //Field offset: 0x0
	public const string achievement = "achievement"; //Field offset: 0x0
	public const string level = "level"; //Field offset: 0x0
	public const string exp = "exp"; //Field offset: 0x0
	public const string item = "item"; //Field offset: 0x0
	public const string unlockStage = "unlockStage"; //Field offset: 0x0
	public const string stageAchievement = "stage_achievement"; //Field offset: 0x0
	public const string unlockLevel = "unlockLevel"; //Field offset: 0x0
	public const string unlockRole = "unlockRole"; //Field offset: 0x0
	public const string unlockElfin = "unlockElfin"; //Field offset: 0x0
	public const string unlockLoading = "unlockLoading"; //Field offset: 0x0
	public const string unlockWelcome = "unlockWelcome"; //Field offset: 0x0
	public const string rank = "rank"; //Field offset: 0x0
	[HideInInspector]
	public static int maxExp; //Field offset: 0x0
	private List<IData> m_Messages; //Field offset: 0x18
	public GameObject pnlMessage; //Field offset: 0x20

	public bool available
	{
		 get { } //Length: 261
	}

	public List<IData> messages
	{
		 get { } //Length: 5
	}

	private static MessageManager() { }

	public MessageManager() { }

	private void CheckMessagesRef() { }

	public bool get_available() { }

	public List<IData> get_messages() { }

	private void Init() { }

	private void OnDestroy() { }

	private void OnReward(object sender, object rev, Object[] pars) { }

	public void Receive(string type, Object[] msg) { }

	public void ResetData() { }

	public void Send(string type, Object[] msg) { }

}


namespace Assets.Scripts.UI.Panels;

public class PnlMessage : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<IData, Boolean> <>9__13_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <OnEnable>b__13_0(IData m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public PnlMessage <>4__this; //Field offset: 0x10
		public List<IData> messages; //Field offset: 0x18
		public Action <>9__2; //Field offset: 0x20

		public <>c__DisplayClass13_0() { }

		internal void <OnEnable>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_1
	{
		public string type; //Field offset: 0x10
		public int index; //Field offset: 0x18
		public string uid; //Field offset: 0x20
		public <>c__DisplayClass13_0 CS$<>8__locals1; //Field offset: 0x28

		public <>c__DisplayClass13_1() { }

		internal void <OnEnable>b__1() { }

	}

	public GameObject task; //Field offset: 0x18
	public GameObject achievement; //Field offset: 0x20
	public GameObject stageAchievement; //Field offset: 0x28
	public GameObject unlockLevel; //Field offset: 0x30
	public GameObject unlockRole; //Field offset: 0x38
	public GameObject unlockElfin; //Field offset: 0x40
	public GameObject unlockLoading; //Field offset: 0x48
	public GameObject unlockWelcome; //Field offset: 0x50
	public GameObject rank; //Field offset: 0x58
	public Transform layout; //Field offset: 0x60
	public Button btnDone; //Field offset: 0x68
	public float gap; //Field offset: 0x70
	public float closeGap; //Field offset: 0x74

	public PnlMessage() { }

	public void FinishMessage() { }

	private void OnEnable() { }

}


namespace Assets.Scripts.GameCore.Managers;

public class StageManager : Singleton<StageManager>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public int i; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal bool <DataUpdate>b__1(IData s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_1
	{
		public string uid; //Field offset: 0x10

		public <>c__DisplayClass3_1() { }

		internal bool <DataUpdate>b__0(IData s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public string uid; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal bool <UnlockStage>b__0(IData d) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public string uid; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		internal bool <UnlockStage>b__0(IData d) { }

	}

	private List<IData> m_UnlockStages; //Field offset: 0x10
	private List<Int32> m_UnlockAlbums; //Field offset: 0x18

	public StageManager() { }

	private void DataUpdate() { }

	private void Init() { }

	public void UnlockAlbum(int albumIndex) { }

	public void UnlockStage(bool isNew = true) { }

	public void UnlockStage(string uid, bool isNew = true) { }

}


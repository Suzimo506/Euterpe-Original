namespace Assets.Scripts.Database;

public class DBUi : BaseDatabase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public int roleIndex; //Field offset: 0x10

		public <>c__DisplayClass12_0() { }

		internal bool <SetSkin>b__0(IData d) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public int roleIndex; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal bool <GetSkinIndex>b__0(IData d) { }

	}

	public readonly Stack<PlayPopuper> popups; //Field offset: 0x10
	public readonly List<Sequence> m_Seqs; //Field offset: 0x18
	public int troveCount; //Field offset: 0x20
	public int unlockDiffByAbility; //Field offset: 0x24
	public float ability; //Field offset: 0x28
	public bool thisFrameBtnInvoke; //Field offset: 0x2C

	public string curLanguage
	{
		 get { } //Length: 75
	}

	public int curLanguageIndex
	{
		 get { } //Length: 85
	}

	public DBUi() { }

	public virtual void AwakeInit() { }

	public string get_curLanguage() { }

	public int get_curLanguageIndex() { }

	public int GetSkinIndex(int roleIndex) { }

	public virtual void Release() { }

	public void ResetAbility() { }

	public void ResetAllSkin() { }

	public virtual void SceneChangedRelease(Scene preScene, Scene curScene) { }

	public void SetSkin(int roleIndex, int skinIndex) { }

	public bool ThisFrameInvokeButton() { }

}


namespace PeroTools2.Managers;

[ExecuteInEditMode]
public class LoopManager : SingletonMonoBehaviour<LoopManager>
{
	private class Looper
	{
		[CompilerGenerated]
		private readonly LoopType <type>k__BackingField; //Field offset: 0x10
		public bool pause; //Field offset: 0x14
		private readonly Action m_Action; //Field offset: 0x18

		public LoopType type
		{
			[CompilerGenerated]
			 get { } //Length: 4
		}

		public Looper(Action _action, LoopType _type) { }

		[CompilerGenerated]
		public LoopType get_type() { }

		public void Loop() { }

	}

	internal enum LoopType
	{
		Update = 0,
		FixedUpdate = 1,
	}

	private readonly List<Looper> m_Loopers; //Field offset: 0x58

	public LoopManager() { }

	private void FixedUpdate() { }

	private void Init() { }

	public bool IsPause(int uid) { }

	private void Loop(LoopType type) { }

	public void Pause(int uid) { }

	public int RegLoop(Action action, LoopType type = 1) { }

	public void Resume(int uid) { }

	public void UnregLoop(int uid) { }

	private void Update() { }

}


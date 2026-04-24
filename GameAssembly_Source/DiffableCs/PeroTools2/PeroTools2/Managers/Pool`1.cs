namespace PeroTools2.Managers;

public class Pool
{
	private static Pool<T> s_Pools; //Field offset: 0x0
	[CompilerGenerated]
	private readonly Stack<T> <caches>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly List<T> <actives>k__BackingField; //Field offset: 0x0
	protected readonly Func<T> m_NewFunc; //Field offset: 0x0
	protected readonly Action<T> m_PushAction; //Field offset: 0x0
	protected readonly Action<T> m_PopAction; //Field offset: 0x0

	public List<T> actives
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Stack<T> caches
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Pool`1(Func<T> newFunc, Action<T> pushAction = null, Action<T> popAction = null, int preload = 10) { }

	public void Destroy() { }

	protected override void ExpandPool(int count) { }

	public static T Get(Func<T> newFunc = null, Action<T> pushAction = null, Action<T> popAction = null, int preload = 10) { }

	[CompilerGenerated]
	public List<T> get_actives() { }

	[CompilerGenerated]
	public Stack<T> get_caches() { }

	public T Pop() { }

	public void Push(T t) { }

	public static void Release(T t) { }

}


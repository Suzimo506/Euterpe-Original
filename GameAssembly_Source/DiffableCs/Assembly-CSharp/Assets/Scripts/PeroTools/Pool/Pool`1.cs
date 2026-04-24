namespace Assets.Scripts.PeroTools.Pool;

public class Pool
{
	private static Pool<T> _pools; //Field offset: 0x0
	private readonly Stack<T> _caches; //Field offset: 0x0
	private readonly Func<T> _newFunc; //Field offset: 0x0
	private readonly Action<T> _releaseAction; //Field offset: 0x0

	public Pool`1(Func<T> newFunc, Action<T> releaseAction) { }

	public static T Get(Func<T> newFunc, Action<T> releaseAction) { }

	public T Pop() { }

	public void Push(T t) { }

	public static void Release(T t) { }

}


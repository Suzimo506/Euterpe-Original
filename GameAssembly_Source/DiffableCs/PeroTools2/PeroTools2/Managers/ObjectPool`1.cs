namespace PeroTools2.Managers;

public class ObjectPool : Pool<T>
{

	public ObjectPool`1(Func<T> newFunc = null, Action<T> pushAction = null, Action<T> popAction = null, int preload = 10) { }

	protected virtual void ExpandPool(int count) { }

}


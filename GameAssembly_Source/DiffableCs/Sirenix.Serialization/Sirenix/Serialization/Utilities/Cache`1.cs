namespace Sirenix.Serialization.Utilities;

public sealed class Cache : ICache, IDisposable
{
	private static readonly bool IsNotificationReceiver; //Field offset: 0x0
	private static Object[] FreeValues; //Field offset: 0x0
	private static int THREAD_LOCK_TOKEN; //Field offset: 0x0
	private static int maxCacheSize; //Field offset: 0x0
	private bool isFree; //Field offset: 0x0
	public T Value; //Field offset: 0x0

	public bool IsFree
	{
		 get { } //Length: 5
	}

	public static int MaxCacheSize
	{
		 get { } //Length: 252
		 set { } //Length: 337
	}

	private override object Sirenix.Serialization.Utilities.ICache.Value
	{
		private get { } //Length: 5
	}

	private static Cache`1() { }

	private Cache`1() { }

	public static Cache<T> Claim() { }

	public bool get_IsFree() { }

	public static int get_MaxCacheSize() { }

	public static T op_Implicit(Cache<T> cache) { }

	public static void Release(Cache<T> cache) { }

	public void Release() { }

	public static void set_MaxCacheSize(int value) { }

	private override object Sirenix.Serialization.Utilities.ICache.get_Value() { }

	private override void System.IDisposable.Dispose() { }

}


namespace Rewired.Utils.Classes.Utility;

[CustomClassObfuscation]
[CustomObfuscation]
internal class ObjectPool : IObjectPool<T>, IObjectPool
{
	protected readonly Queue<T> _pool; //Field offset: 0x0
	protected readonly Func<T> _createInstanceDelegate; //Field offset: 0x0
	protected readonly Action<T> _processOnReturnDelegate; //Field offset: 0x0
	private ulong FXgaaSzYQVIGCXhveEdygcvBNqgtA; //Field offset: 0x0

	protected ulong InstanceCount
	{
		 get { } //Length: 5
	}

	public ObjectPool`1(int unnamed_param_0, Func<T> unnamed_param_1, Action<T> unnamed_param_2 = null) { }

	public ObjectPool`1(Func<T> unnamed_param_0) { }

	public override void Clear(bool reduceSize = false) { }

	protected T CreateInstance() { }

	private override object FzpUglTNMLElNkLYnutHJYQlZKRP() { }

	public override T Get() { }

	protected ulong get_InstanceCount() { }

	private override bool HjrmnXDhlKushLllChUokjmloolc(object unnamed_param_0) { }

	protected ulong IncrementInstanceCount() { }

	public override bool Return(T item) { }

}


namespace Rewired.Utils.Classes.Utility;

[CustomClassObfuscation]
[CustomObfuscation]
internal interface IPoolableObject_Internal : IDisposable, IPoolableObject
{

	public IObjectPool pool
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public void Clear() { }

	public IObjectPool get_pool() { }

	public void set_pool(IObjectPool value) { }

}


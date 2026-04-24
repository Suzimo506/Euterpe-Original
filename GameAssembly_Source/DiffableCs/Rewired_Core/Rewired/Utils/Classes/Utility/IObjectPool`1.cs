namespace Rewired.Utils.Classes.Utility;

[CustomClassObfuscation]
[CustomObfuscation]
internal interface IObjectPool
{

	public void Clear(bool reduceSize = false) { }

	public T Get() { }

	public bool Return(T item) { }

}


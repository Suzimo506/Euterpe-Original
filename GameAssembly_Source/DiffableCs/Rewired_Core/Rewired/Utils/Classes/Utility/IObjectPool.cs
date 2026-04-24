namespace Rewired.Utils.Classes.Utility;

[CustomClassObfuscation]
[CustomObfuscation]
internal interface IObjectPool
{

	public void Clear(bool reduceSize = false) { }

	public object Get() { }

	public bool Return(object item) { }

}


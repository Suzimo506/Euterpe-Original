namespace Assets.Scripts.Database;

public abstract class BaseDBConfigLocalObject : BaseDBConfigObject
{
	protected Dictionary<Int32, T> m_LocalDic; //Field offset: 0x0

	protected BaseDBConfigLocalObject`2() { }

	public virtual bool DeserializeLocal(string fileName, string str, int language) { }

	public void GetAllLocal(List<T> buffer) { }

	public T GetLocal(int language = 0) { }

	protected void RemoveLocal(int language, bool removeDataBase = false) { }

}


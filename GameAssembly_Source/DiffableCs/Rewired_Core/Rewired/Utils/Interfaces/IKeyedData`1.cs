namespace Rewired.Utils.Interfaces;

public interface IKeyedData
{

	public bool TryGetValue(TKey key, out T value) { }

	public bool TrySetValue(TKey key, T value) { }

}


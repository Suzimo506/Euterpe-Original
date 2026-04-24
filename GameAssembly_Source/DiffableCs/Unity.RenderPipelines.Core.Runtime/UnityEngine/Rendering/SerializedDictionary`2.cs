namespace UnityEngine.Rendering;

public class SerializedDictionary : Dictionary<K, V>, ISerializationCallbackReceiver
{
	[SerializeField]
	private List<K> m_Keys; //Field offset: 0x0
	[SerializeField]
	private List<V> m_Values; //Field offset: 0x0

	public SerializedDictionary`2() { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

}


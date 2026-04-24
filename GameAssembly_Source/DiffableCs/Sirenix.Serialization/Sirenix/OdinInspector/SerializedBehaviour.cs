namespace Sirenix.OdinInspector;

public abstract class SerializedBehaviour : Behaviour, ISerializationCallbackReceiver, ISupportsPrefabSerialization
{
	[HideInInspector]
	[SerializeField]
	private SerializationData serializationData; //Field offset: 0x18

	private override SerializationData Sirenix.Serialization.ISupportsPrefabSerialization.SerializationData
	{
		private get { } //Length: 35
		private set { } //Length: 42
	}

	protected SerializedBehaviour() { }

	protected override void OnAfterDeserialize() { }

	protected override void OnBeforeSerialize() { }

	private override SerializationData Sirenix.Serialization.ISupportsPrefabSerialization.get_SerializationData() { }

	private override void Sirenix.Serialization.ISupportsPrefabSerialization.set_SerializationData(SerializationData value) { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}


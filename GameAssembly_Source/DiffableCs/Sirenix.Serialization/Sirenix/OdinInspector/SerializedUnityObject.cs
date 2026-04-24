namespace Sirenix.OdinInspector;

public abstract class SerializedUnityObject : object, ISerializationCallbackReceiver
{
	[HideInInspector]
	[SerializeField]
	private SerializationData serializationData; //Field offset: 0x18

	protected SerializedUnityObject() { }

	protected override void OnAfterDeserialize() { }

	protected override void OnBeforeSerialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}


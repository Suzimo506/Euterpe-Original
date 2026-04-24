namespace Sirenix.OdinInspector;

public abstract class SerializedScriptableObject : ScriptableObject, ISerializationCallbackReceiver
{
	[HideInInspector]
	[SerializeField]
	private SerializationData serializationData; //Field offset: 0x18

	protected SerializedScriptableObject() { }

	protected override void OnAfterDeserialize() { }

	protected override void OnBeforeSerialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}


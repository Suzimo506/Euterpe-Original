namespace Sirenix.Serialization;

public struct SerializationData
{
	public const string PrefabModificationsReferencedUnityObjectsFieldName = "PrefabModificationsReferencedUnityObjects"; //Field offset: 0x0
	public const string PrefabModificationsFieldName = "PrefabModifications"; //Field offset: 0x0
	public const string PrefabFieldName = "Prefab"; //Field offset: 0x0
	[SerializeField]
	public DataFormat SerializedFormat; //Field offset: 0x0
	[SerializeField]
	public Byte[] SerializedBytes; //Field offset: 0x8
	[SerializeField]
	public List<Object> ReferencedUnityObjects; //Field offset: 0x10
	[SerializeField]
	public string SerializedBytesString; //Field offset: 0x18
	[SerializeField]
	public object Prefab; //Field offset: 0x20
	[SerializeField]
	public List<Object> PrefabModificationsReferencedUnityObjects; //Field offset: 0x28
	[SerializeField]
	public List<String> PrefabModifications; //Field offset: 0x30
	[SerializeField]
	public List<SerializationNode> SerializationNodes; //Field offset: 0x38

	public bool ContainsData
	{
		 get { } //Length: 33
	}

	[Obsolete]
	public bool HasEditorData
	{
		 get { } //Length: 234
	}

	public bool get_ContainsData() { }

	public bool get_HasEditorData() { }

	public void Reset() { }

}


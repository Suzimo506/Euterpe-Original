namespace UnityEngine.ResourceManagement.Util;

public struct ObjectInitializationData
{
	[FormerlySerializedAs(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private string m_Id; //Field offset: 0x0
	[FormerlySerializedAs(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private SerializedType m_ObjectType; //Field offset: 0x8
	[FormerlySerializedAs(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private string m_Data; //Field offset: 0x28

	public string Data
	{
		 get { } //Length: 5
	}

	public string Id
	{
		 get { } //Length: 4
	}

	public SerializedType ObjectType
	{
		 get { } //Length: 19
	}

	public TObject CreateInstance(string idOverride = null) { }

	public string get_Data() { }

	public string get_Id() { }

	public SerializedType get_ObjectType() { }

	public AsyncOperationHandle GetAsyncInitHandle(ResourceManager rm, string idOverride = null) { }

	public virtual string ToString() { }

}


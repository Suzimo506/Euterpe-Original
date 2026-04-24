namespace UnityEngine.AddressableAssets;

public class AssetReference : IKeyEvaluator
{
	[FormerlySerializedAs(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private string m_AssetGUID; //Field offset: 0x10
	[SerializeField]
	private string m_SubObjectName; //Field offset: 0x18
	[SerializeField]
	private string m_SubObjectType; //Field offset: 0x20
	private AsyncOperationHandle m_Operation; //Field offset: 0x28

	public override object Asset
	{
		 get { } //Length: 150
	}

	public override string AssetGUID
	{
		 get { } //Length: 5
	}

	public bool IsDone
	{
		 get { } //Length: 11
	}

	public AsyncOperationHandle OperationHandle
	{
		 get { } //Length: 21
	}

	public override object RuntimeKey
	{
		 get { } //Length: 139
	}

	public override string SubObjectName
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	internal override Type SubOjbectType
	{
		internal get { } //Length: 143
	}

	internal AssetReference(string guid, Type type) { }

	public AssetReference(string guid) { }

	public AssetReference() { }

	private static AsyncOperationHandle<T> CreateFailedOperation() { }

	public override object get_Asset() { }

	public override string get_AssetGUID() { }

	public bool get_IsDone() { }

	public AsyncOperationHandle get_OperationHandle() { }

	public override object get_RuntimeKey() { }

	public override string get_SubObjectName() { }

	internal override Type get_SubOjbectType() { }

	[Obsolete]
	public AsyncOperationHandle<GameObject> Instantiate(Vector3 position, Quaternion rotation, Transform parent = null) { }

	[Obsolete]
	public AsyncOperationHandle<GameObject> Instantiate(Transform parent = null, bool instantiateInWorldSpace = false) { }

	public override AsyncOperationHandle<GameObject> InstantiateAsync(Vector3 position, Quaternion rotation, Transform parent = null) { }

	public override AsyncOperationHandle<GameObject> InstantiateAsync(Transform parent = null, bool instantiateInWorldSpace = false) { }

	public bool IsValid() { }

	[Obsolete]
	public AsyncOperationHandle<TObject> LoadAsset() { }

	public override AsyncOperationHandle<TObject> LoadAssetAsync() { }

	[Obsolete]
	public AsyncOperationHandle<SceneInstance> LoadScene() { }

	public override AsyncOperationHandle<SceneInstance> LoadSceneAsync(LoadSceneMode loadMode = 0, bool activateOnLoad = true, int priority = 100) { }

	public override void ReleaseAsset() { }

	public override void ReleaseInstance(GameObject obj) { }

	public override bool RuntimeKeyIsValid() { }

	public override void set_SubObjectName(string value) { }

	public virtual string ToString() { }

	public override AsyncOperationHandle<SceneInstance> UnLoadScene() { }

	public override bool ValidateAsset(object obj) { }

	public override bool ValidateAsset(string path) { }

}


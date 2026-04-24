//Type is in global namespace

public class SpineMountController : MonoBehaviour
{
	private String[] sklNames; //Field offset: 0x18
	private GameObject[] dymanicObjects; //Field offset: 0x20
	[SerializeField]
	private SkeletonMountData[] mountData; //Field offset: 0x28

	public SpineMountController() { }

	public void AddData() { }

	public int DataCount() { }

	public void DelData(int idx) { }

	public void DestoryDynamicObjects() { }

	private static bool FindBones(Bone elem, string _name) { }

	public SkeletonMountData GetData(int idx) { }

	public GameObject GetMountObjectByIdx(int index) { }

	public GameObject[] GetMountObjects() { }

	private void InitSkeletonName() { }

	public void OnControllerStart() { }

	public void SetData(int idx, SkeletonMountData d) { }

	private void Start() { }

}


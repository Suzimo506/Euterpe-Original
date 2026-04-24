//Type is in global namespace

public class EditorData : MonoBehaviour
{
	private static string PATH; //Field offset: 0x0
	private static GameObject dataObject; //Field offset: 0x8
	private static EditorData instance; //Field offset: 0x10
	[SerializeField]
	public String[] SpineActionKeys; //Field offset: 0x18
	public String[] SpineActionDes; //Field offset: 0x20
	public String[] SpineEventName; //Field offset: 0x28
	public String[] SpineEventDes; //Field offset: 0x30
	public String[] SpineModeName; //Field offset: 0x38
	public String[] SpineModeDes; //Field offset: 0x40
	public StageEvent[] StageEvents; //Field offset: 0x48

	public static EditorData Instance
	{
		 get { } //Length: 371
	}

	private static EditorData() { }

	public EditorData() { }

	public void AddGameObjectListItem(ref GameObject item, ref GameObject[] objList) { }

	public void AddIntListItem(int item, ref Int32[] intList) { }

	public void AddStageEvent(ref StageEvent item) { }

	public void AddStringListItem(ref string item, ref String[] strList) { }

	public void AfterSave() { }

	public void DelGameObjectListItem(int idx, ref GameObject[] objList) { }

	public void DelIntListItem(int idx, ref Int32[] intList) { }

	public void DelStringListItem(int idx, ref String[] strList) { }

	public static EditorData get_Instance() { }

	public static GameObject GetDataObject() { }

	public StageEvent GetStageEventDataById(int idx) { }

}


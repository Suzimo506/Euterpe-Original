//Type is in global namespace

public class AdminData : MonoBehaviour
{
	private const string PATH = "AdminData"; //Field offset: 0x0
	private static GameObject dataObject; //Field offset: 0x0
	private static AdminData instance; //Field offset: 0x8
	[SerializeField]
	public string defaultStageName; //Field offset: 0x18
	[SerializeField]
	public int defualtDifficulty; //Field offset: 0x20
	public int defaultClothUid; //Field offset: 0x24
	public int defaultElfinUid; //Field offset: 0x28
	public List<Int32> defaultSkills; //Field offset: 0x30
	public int defaultPetSkill; //Field offset: 0x38

	public static AdminData Instance
	{
		 get { } //Length: 356
	}

	private static AdminData() { }

	public AdminData() { }

	public void AfterSave() { }

	public static AdminData get_Instance() { }

	public static GameObject GetDataObject() { }

}


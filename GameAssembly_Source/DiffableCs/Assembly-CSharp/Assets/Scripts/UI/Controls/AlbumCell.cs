namespace Assets.Scripts.UI.Controls;

public class AlbumCell : MonoBehaviour
{
	public Button btn; //Field offset: 0x18
	public GameObject imgLock; //Field offset: 0x20
	public GameObject imgMy; //Field offset: 0x28
	public GameObject imgHeart; //Field offset: 0x30
	public GameObject locker; //Field offset: 0x38
	private VariableBehaviour m_VariableBehaviour; //Field offset: 0x40
	public GameObject imgFavoriteMusic; //Field offset: 0x48
	public GameObject weekFreeIcon; //Field offset: 0x50
	private bool m_Lock; //Field offset: 0x58
	[CompilerGenerated]
	private string <uid>k__BackingField; //Field offset: 0x60

	public private string uid
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public AlbumCell() { }

	private void Awake() { }

	[CompilerGenerated]
	public string get_uid() { }

	public int GetDataIndex() { }

	[CompilerGenerated]
	private void set_uid(string value) { }

	public void SetLock(bool isLock) { }

	public void SetUid(string uid) { }

	public void SetWeekFree(bool isWeekFree) { }

}


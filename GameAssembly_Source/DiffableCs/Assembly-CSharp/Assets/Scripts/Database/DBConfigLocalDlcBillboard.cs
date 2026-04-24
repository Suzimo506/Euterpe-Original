namespace Assets.Scripts.Database;

public class DBConfigLocalDlcBillboard : BaseDBConfigObject
{
	private List<LocalDlcBillboardInfo> m_Items; //Field offset: 0x38

	protected private List<LocalDlcBillboardInfo> List
	{
		 get { } //Length: 5
		private set { } //Length: 54
	}

	public DBConfigLocalDlcBillboard() { }

	public virtual void Deserialize(string str) { }

	protected List<LocalDlcBillboardInfo> get_List() { }

	public LocalDlcBillboardInfo GetLocalDlcBillboardByIndex(int index) { }

	private void set_List(List<LocalDlcBillboardInfo> value) { }

}


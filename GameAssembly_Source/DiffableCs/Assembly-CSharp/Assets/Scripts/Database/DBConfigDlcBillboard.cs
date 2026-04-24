namespace Assets.Scripts.Database;

public class DBConfigDlcBillboard : BaseDBConfigLocalObject<DBConfigLocalDlcBillboard, LocalDlcBillboardInfo>
{
	private List<DlcBillboardInfo> m_Items; //Field offset: 0x40

	protected private List<DlcBillboardInfo> list
	{
		 get { } //Length: 5
		private set { } //Length: 54
	}

	public DBConfigDlcBillboard() { }

	public virtual void Deserialize(string str) { }

	protected List<DlcBillboardInfo> get_list() { }

	public DlcBillboardInfo GetBillboardInfoByIndex(int index) { }

	public DlcBillboardInfo GetBillboardInfoByJsonIndex(int jsonIndex) { }

	private void set_list(List<DlcBillboardInfo> value) { }

}


namespace Assets.Scripts.Database;

public class UnlockAllInfo : BaseDataObject
{
	public string uid; //Field offset: 0x20
	public decimal discount; //Field offset: 0x28
	public decimal price; //Field offset: 0x38
	public int displayDiscount; //Field offset: 0x48

	public UnlockAllInfo() { }

	public UnlockAllInfo Clone() { }

}


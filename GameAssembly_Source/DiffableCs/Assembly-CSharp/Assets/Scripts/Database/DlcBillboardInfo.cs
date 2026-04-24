namespace Assets.Scripts.Database;

public class DlcBillboardInfo : BaseDataObject
{
	public int jsonIndex; //Field offset: 0x20
	public string billboardImg; //Field offset: 0x28
	public string billboardImgReview; //Field offset: 0x30
	public string billboardImg2; //Field offset: 0x38
	public string billboardImg2Review; //Field offset: 0x40
	public string billboardDemo; //Field offset: 0x48
	public string billboardDemo2; //Field offset: 0x50
	public string description; //Field offset: 0x58
	public string description2; //Field offset: 0x60

	public string billBoardImg2Name
	{
		 get { } //Length: 205
	}

	public string billBoardImgName
	{
		 get { } //Length: 205
	}

	public string localDescription
	{
		 get { } //Length: 237
	}

	public string localDescription2
	{
		 get { } //Length: 499
	}

	public int showCount
	{
		 get { } //Length: 427
	}

	public DlcBillboardInfo() { }

	public string get_billBoardImg2Name() { }

	public string get_billBoardImgName() { }

	public string get_localDescription() { }

	public string get_localDescription2() { }

	public int get_showCount() { }

}


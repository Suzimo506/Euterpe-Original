namespace GameLogic;

public class DoNothing
{
	protected int idx; //Field offset: 0x10
	protected GameObject gameObject; //Field offset: 0x18

	public int NothingObjIdx
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public GameObject NothingTarget
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public DoNothing() { }

	public override void Do(TrackEntry entry) { }

	public int get_NothingObjIdx() { }

	public GameObject get_NothingTarget() { }

	public override void Init() { }

	public void set_NothingObjIdx(int value) { }

	public void set_NothingTarget(GameObject value) { }

	public void SetGameObject(GameObject obj) { }

	public void SetIdx(int idx) { }

}


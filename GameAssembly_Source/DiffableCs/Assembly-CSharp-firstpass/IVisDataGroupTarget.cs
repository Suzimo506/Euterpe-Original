//Type is in global namespace

public interface IVisDataGroupTarget
{

	public VisDataGroup DataGroup
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string LastDataGroupName
	{
		 get { } //Length: 0
	}

	public VisDataGroup get_DataGroup() { }

	public string get_LastDataGroupName() { }

	public void set_DataGroup(VisDataGroup value) { }

}


//Type is in global namespace

public interface IVisManagerTarget
{

	public string LastManagerName
	{
		 get { } //Length: 0
	}

	public VisManager Manager
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string get_LastManagerName() { }

	public VisManager get_Manager() { }

	public void set_Manager(VisManager value) { }

}


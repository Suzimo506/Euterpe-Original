//Type is in global namespace

public interface IVisBaseControllerTarget
{

	public VisBaseController Controller
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string LastControllerName
	{
		 get { } //Length: 0
	}

	public VisBaseController get_Controller() { }

	public string get_LastControllerName() { }

	public void set_Controller(VisBaseController value) { }

}


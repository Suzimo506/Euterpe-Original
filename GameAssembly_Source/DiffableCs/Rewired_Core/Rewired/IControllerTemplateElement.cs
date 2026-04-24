namespace Rewired;

public interface IControllerTemplateElement
{

	public string descriptiveName
	{
		 get { } //Length: 0
	}

	public bool exists
	{
		 get { } //Length: 0
	}

	public int id
	{
		 get { } //Length: 0
	}

	public IControllerTemplateElementSource source
	{
		 get { } //Length: 0
	}

	public ControllerTemplateElementType type
	{
		 get { } //Length: 0
	}

	public string get_descriptiveName() { }

	public bool get_exists() { }

	public int get_id() { }

	public IControllerTemplateElementSource get_source() { }

	public ControllerTemplateElementType get_type() { }

}


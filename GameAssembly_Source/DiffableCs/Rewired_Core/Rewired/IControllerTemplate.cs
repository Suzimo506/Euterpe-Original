namespace Rewired;

public interface IControllerTemplate
{

	public Controller controller
	{
		 get { } //Length: 0
	}

	public int elementCount
	{
		 get { } //Length: 0
	}

	public IList<IControllerTemplateElement> elements
	{
		 get { } //Length: 0
	}

	public string name
	{
		 get { } //Length: 0
	}

	public Guid typeGuid
	{
		 get { } //Length: 0
	}

	public Controller get_controller() { }

	public int get_elementCount() { }

	public IList<IControllerTemplateElement> get_elements() { }

	public string get_name() { }

	public Guid get_typeGuid() { }

	public IControllerTemplateElement GetElement(int id) { }

	public T GetElement(int id) { }

	public int GetElementTargets(ControllerElementTarget target, IList<ControllerTemplateElementTarget> results) { }

}


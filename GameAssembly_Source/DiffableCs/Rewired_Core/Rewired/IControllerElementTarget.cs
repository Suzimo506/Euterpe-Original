namespace Rewired;

public interface IControllerElementTarget
{

	public AxisRange axisRange
	{
		 get { } //Length: 0
	}

	public Controller controller
	{
		 get { } //Length: 0
	}

	public string descriptiveName
	{
		 get { } //Length: 0
	}

	public Element element
	{
		 get { } //Length: 0
	}

	public int elementIdentifierId
	{
		 get { } //Length: 0
	}

	public ControllerElementType elementType
	{
		 get { } //Length: 0
	}

	public bool hasTarget
	{
		 get { } //Length: 0
	}

	public AxisRange get_axisRange() { }

	public Controller get_controller() { }

	public string get_descriptiveName() { }

	public Element get_element() { }

	public int get_elementIdentifierId() { }

	public ControllerElementType get_elementType() { }

	public bool get_hasTarget() { }

}


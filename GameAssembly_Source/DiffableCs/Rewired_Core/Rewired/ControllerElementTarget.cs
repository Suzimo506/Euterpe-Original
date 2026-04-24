namespace Rewired;

public struct ControllerElementTarget
{
	private Element AClnKByFAGiJFYhihHxblEKpjxpO; //Field offset: 0x0
	private AxisRange yQmEhNhvJlWmGQHArjFyfkyEhBBHA; //Field offset: 0x8

	public AxisRange axisRange
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public Controller controller
	{
		 get { } //Length: 14
	}

	public string descriptiveName
	{
		 get { } //Length: 115
	}

	public Element element
	{
		 get { } //Length: 4
		 set { } //Length: 8
	}

	public int elementIdentifierId
	{
		 get { } //Length: 18
	}

	public ControllerElementType elementType
	{
		 get { } //Length: 13
	}

	public bool hasTarget
	{
		 get { } //Length: 8
	}

	public ControllerElementTarget(ActionElementMap unnamed_param_0) { }

	public ControllerElementTarget(ControllerElementTarget unnamed_param_0) { }

	public ControllerElementTarget(IControllerElementTarget unnamed_param_0) { }

	public AxisRange get_axisRange() { }

	public Controller get_controller() { }

	public string get_descriptiveName() { }

	public Element get_element() { }

	public int get_elementIdentifierId() { }

	public ControllerElementType get_elementType() { }

	public bool get_hasTarget() { }

	public static ControllerElementTarget op_Implicit(ActionElementMap actionElementMap) { }

	public void set_axisRange(AxisRange value) { }

	public void set_element(Element value) { }

}


namespace Rewired;

public interface IControllerTemplateStick : IControllerTemplateElement
{

	public IControllerTemplateAxis horizontal
	{
		 get { } //Length: 0
	}

	public IControllerTemplateAxis rotation
	{
		 get { } //Length: 0
	}

	public Vector3 value
	{
		 get { } //Length: 0
	}

	public Vector3 valuePrev
	{
		 get { } //Length: 0
	}

	public IControllerTemplateAxis vertical
	{
		 get { } //Length: 0
	}

	public IControllerTemplateAxis get_horizontal() { }

	public IControllerTemplateAxis get_rotation() { }

	public Vector3 get_value() { }

	public Vector3 get_valuePrev() { }

	public IControllerTemplateAxis get_vertical() { }

}


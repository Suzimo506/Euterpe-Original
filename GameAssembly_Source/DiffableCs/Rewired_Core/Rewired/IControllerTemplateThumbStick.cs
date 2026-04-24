namespace Rewired;

public interface IControllerTemplateThumbStick : IControllerTemplateElement
{

	public IControllerTemplateAxis horizontal
	{
		 get { } //Length: 0
	}

	public IControllerTemplateButton press
	{
		 get { } //Length: 0
	}

	public Vector2 value
	{
		 get { } //Length: 0
	}

	public Vector2 valuePrev
	{
		 get { } //Length: 0
	}

	public IControllerTemplateAxis vertical
	{
		 get { } //Length: 0
	}

	public IControllerTemplateAxis get_horizontal() { }

	public IControllerTemplateButton get_press() { }

	public Vector2 get_value() { }

	public Vector2 get_valuePrev() { }

	public IControllerTemplateAxis get_vertical() { }

}


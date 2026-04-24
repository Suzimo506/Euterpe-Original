namespace Rewired;

public interface IControllerTemplateDPad : IControllerTemplateElement
{

	public IControllerTemplateButton down
	{
		 get { } //Length: 0
	}

	public IControllerTemplateButton left
	{
		 get { } //Length: 0
	}

	public IControllerTemplateButton press
	{
		 get { } //Length: 0
	}

	public IControllerTemplateButton right
	{
		 get { } //Length: 0
	}

	public IControllerTemplateButton up
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

	public IControllerTemplateButton get_down() { }

	public IControllerTemplateButton get_left() { }

	public IControllerTemplateButton get_press() { }

	public IControllerTemplateButton get_right() { }

	public IControllerTemplateButton get_up() { }

	public Vector2 get_value() { }

	public Vector2 get_valuePrev() { }

}


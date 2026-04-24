namespace Rewired;

public interface IControllerTemplateHat : IControllerTemplateElement
{

	public IControllerTemplateButton down
	{
		 get { } //Length: 0
	}

	public IControllerTemplateButton downLeft
	{
		 get { } //Length: 0
	}

	public IControllerTemplateButton downRight
	{
		 get { } //Length: 0
	}

	public IControllerTemplateButton left
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

	public IControllerTemplateButton upLeft
	{
		 get { } //Length: 0
	}

	public IControllerTemplateButton upRight
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

	public IControllerTemplateButton get_downLeft() { }

	public IControllerTemplateButton get_downRight() { }

	public IControllerTemplateButton get_left() { }

	public IControllerTemplateButton get_right() { }

	public IControllerTemplateButton get_up() { }

	public IControllerTemplateButton get_upLeft() { }

	public IControllerTemplateButton get_upRight() { }

	public Vector2 get_value() { }

	public Vector2 get_valuePrev() { }

}


namespace Rewired;

public interface IControllerTemplateYoke : IControllerTemplateElement
{

	public IControllerTemplateAxis pushPull
	{
		 get { } //Length: 0
	}

	public IControllerTemplateAxis rotation
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

	public IControllerTemplateAxis get_pushPull() { }

	public IControllerTemplateAxis get_rotation() { }

	public Vector2 get_value() { }

	public Vector2 get_valuePrev() { }

}


namespace Rewired;

public interface IControllerTemplateThrottle : IControllerTemplateElement
{

	public IControllerTemplateButton minDetent
	{
		 get { } //Length: 0
	}

	public IControllerTemplateAxis throttle
	{
		 get { } //Length: 0
	}

	public float value
	{
		 get { } //Length: 0
	}

	public float valuePrev
	{
		 get { } //Length: 0
	}

	public IControllerTemplateButton get_minDetent() { }

	public IControllerTemplateAxis get_throttle() { }

	public float get_value() { }

	public float get_valuePrev() { }

}


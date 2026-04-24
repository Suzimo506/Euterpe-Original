namespace Rewired;

public interface IControllerTemplateButton : IControllerTemplateElement
{

	public IControllerTemplateAxis AsAxis
	{
		 get { } //Length: 0
	}

	public bool justChangedState
	{
		 get { } //Length: 0
	}

	public bool justPressed
	{
		 get { } //Length: 0
	}

	public bool justReleased
	{
		 get { } //Length: 0
	}

	public float pressure
	{
		 get { } //Length: 0
	}

	public float pressurePrev
	{
		 get { } //Length: 0
	}

	public IControllerTemplateButtonSource source
	{
		 get { } //Length: 0
	}

	public bool value
	{
		 get { } //Length: 0
	}

	public bool valuePrev
	{
		 get { } //Length: 0
	}

	public IControllerTemplateAxis get_AsAxis() { }

	public bool get_justChangedState() { }

	public bool get_justPressed() { }

	public bool get_justReleased() { }

	public float get_pressure() { }

	public float get_pressurePrev() { }

	public IControllerTemplateButtonSource get_source() { }

	public bool get_value() { }

	public bool get_valuePrev() { }

}


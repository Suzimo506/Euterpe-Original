namespace Rewired;

public interface IFlightPedalsTemplate : IControllerTemplate
{

	public IControllerTemplateAxis leftPedal
	{
		 get { } //Length: 0
	}

	public IControllerTemplateAxis rightPedal
	{
		 get { } //Length: 0
	}

	public IControllerTemplateAxis slide
	{
		 get { } //Length: 0
	}

	public IControllerTemplateAxis get_leftPedal() { }

	public IControllerTemplateAxis get_rightPedal() { }

	public IControllerTemplateAxis get_slide() { }

}


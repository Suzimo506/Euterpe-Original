namespace Rewired;

public sealed class FlightPedalsTemplate : ControllerTemplate, IFlightPedalsTemplate, IControllerTemplate
{
	public static readonly Guid typeGuid; //Field offset: 0x675DC
	public const int elementId_rightPedal = 1; //Field offset: 0x675E0
	public const int elementId_slide = 2; //Field offset: 0x6761E
	public const int elementId_leftPedal = 0; //Field offset: 0x2C927B4

	private override IControllerTemplateAxis Rewired.IFlightPedalsTemplate.leftPedal
	{
		private get { } //Length: 58
	}

	private override IControllerTemplateAxis Rewired.IFlightPedalsTemplate.rightPedal
	{
		private get { } //Length: 61
	}

	private override IControllerTemplateAxis Rewired.IFlightPedalsTemplate.slide
	{
		private get { } //Length: 61
	}

	private static FlightPedalsTemplate() { }

	public FlightPedalsTemplate(object payload) { }

	private override IControllerTemplateAxis Rewired.IFlightPedalsTemplate.get_leftPedal() { }

	private override IControllerTemplateAxis Rewired.IFlightPedalsTemplate.get_rightPedal() { }

	private override IControllerTemplateAxis Rewired.IFlightPedalsTemplate.get_slide() { }

}


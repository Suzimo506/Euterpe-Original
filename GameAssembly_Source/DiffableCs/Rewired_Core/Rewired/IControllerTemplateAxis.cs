namespace Rewired;

public interface IControllerTemplateAxis : IControllerTemplateElement
{

	public IControllerTemplateButton AsButton
	{
		 get { } //Length: 0
	}

	public string negativeDescriptiveName
	{
		 get { } //Length: 0
	}

	public string positiveDescriptiveName
	{
		 get { } //Length: 0
	}

	public IControllerTemplateAxisSource source
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

	public IControllerTemplateButton get_AsButton() { }

	public string get_negativeDescriptiveName() { }

	public string get_positiveDescriptiveName() { }

	public IControllerTemplateAxisSource get_source() { }

	public float get_value() { }

	public float get_valuePrev() { }

	public string GetDescriptiveName(AxisRange axisRange) { }

}


namespace Rewired;

public interface IControllerTemplateAxisSource : IControllerTemplateElementSource
{

	public IControllerElementTarget fullTarget
	{
		 get { } //Length: 0
	}

	public IControllerElementTarget negativeTarget
	{
		 get { } //Length: 0
	}

	public IControllerElementTarget positiveTarget
	{
		 get { } //Length: 0
	}

	public bool splitAxis
	{
		 get { } //Length: 0
	}

	public IControllerElementTarget get_fullTarget() { }

	public IControllerElementTarget get_negativeTarget() { }

	public IControllerElementTarget get_positiveTarget() { }

	public bool get_splitAxis() { }

}


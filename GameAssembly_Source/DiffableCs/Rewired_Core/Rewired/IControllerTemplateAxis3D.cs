namespace Rewired;

[CustomClassObfuscation]
[CustomObfuscation]
internal interface IControllerTemplateAxis3D : IControllerTemplateElement
{

	public IControllerTemplateAxis depth
	{
		 get { } //Length: 0
	}

	public IControllerTemplateAxis horizontal
	{
		 get { } //Length: 0
	}

	public Vector3 value
	{
		 get { } //Length: 0
	}

	public Vector3 valuePrev
	{
		 get { } //Length: 0
	}

	public IControllerTemplateAxis vertical
	{
		 get { } //Length: 0
	}

	public IControllerTemplateAxis get_depth() { }

	public IControllerTemplateAxis get_horizontal() { }

	public Vector3 get_value() { }

	public Vector3 get_valuePrev() { }

	public IControllerTemplateAxis get_vertical() { }

}

